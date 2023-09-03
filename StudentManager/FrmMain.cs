using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class FrmMain : Form
    {
        private BindingSource bsStudent;
        private BindingSource bsSubject;
        private DataTable dtTblSubject;
        private DataTable dtTblStudent;
        private DataTable dtTblTeacher;
        private Subject subject;
        private Student student;
        private Teachers teacher;


        public FrmMain()
        {
            InitializeComponent();

            bsSubject = new BindingSource();
            bsStudent = new BindingSource();
            subject = new Subject();
            student = new Student();
            teacher = new Teachers();
            dtTblSubject = subject.GetSubjects();
            dtTblStudent = student.GetStudents();
            dtTblTeacher = teacher.GetTeachers();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            bttnNewSubject.Enabled = bttnNewStudent.Enabled = true;
            bttnInsertSubject.Enabled = bttnInsertStudent.Enabled = false;
            SetSubjectGrid();
            ClearDataBindingOfSubject();
            SetDataBindingOfSubject();
            SetStudentGrid();
            ClearDataBindingOfStudent();
            SetDataBindingOfStudent();
            dtGrdVwSubject.Columns["ID"].Visible = false;
            SetCmbBxView(cmbBxResponsibleTeacher, dtTblTeacher, "Name", "Name", dtGrdVwSubject.Rows[0].Cells["Teacher"].Value);
            dtGrdVwStudent.Columns["ID"].Visible = false;
            SetCmbBxView(cmbBxSubjectCodeBelongsToStudent, dtTblSubject, "Subjectcode", "Subject code", dtGrdVwSubject.Rows[0].Cells["Subject code"].Value);
            foreach (DataColumn item in dtTblSubject.Columns)
            {
                if (item.ColumnName != "ID")
                    cmbBxSubjectFilterColumn.Items.Add(item.ColumnName);
            }
            cmbBxSubjectFilterColumn.SelectedIndex = 0;
            foreach (DataColumn item in dtTblStudent.Columns)
            {
                if (item.ColumnName != "ID")
                    cmbBxStudentFilterColumn.Items.Add(item.ColumnName);
            }
            cmbBxStudentFilterColumn.SelectedIndex = 0;
            RefreshLabelSubjectRecord();
            RefreshLabelStudentRecord();
        }


        // Set up the subject grid
        private void SetSubjectGrid()
        {
            bsSubject.DataSource = dtTblSubject;
            dtGrdVwSubject.DataSource = bsSubject;
            for (int i = 1; i < dtGrdVwSubject.Columns.Count; ++i)
            {
                dtGrdVwSubject.AutoResizeColumn(i);
                dtGrdVwSubject.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.AllCells;
            }
            if (bsSubject.Position > -1)
                SetActualPositionOfSubject(bsSubject.Position);
        }

        // Set up the student grid
        private void SetStudentGrid()
        {
            if (dtGrdVwSubject.CurrentRow != null)
            {
                bsStudent.DataSource = GetFilteredDataView(dtTblStudent, "[Subject code] = '" + dtTblSubject.Rows[dtGrdVwSubject.CurrentRow.Index][1].ToString() + "'");
                dtGrdVwStudent.DataSource = bsStudent;
                for (int i = 0; i < dtGrdVwStudent.Columns.Count; ++i)
                {
                    dtGrdVwStudent.AutoResizeColumn(i);
                    dtGrdVwStudent.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.AllCells;
                }
                if (bsStudent.Position > -1)
                    SetActualPositionOfStudent(bsStudent.Position);
            }
            else
            {
                ClearDataBindingOfStudent();
                bsStudent.DataMember = "";
                bsStudent.DataSource = null;
            }
        }

        // Get a filtered DataView from a DataTable
        private DataView GetFilteredDataView(DataTable dataTable, string rowFilter)
        {
            DataView dataView = new DataView();
            dataView = dataTable.DefaultView;
            dataView.RowFilter = rowFilter;
            return dataView;
        }

        // Clear data bindings for subject-related controls
        private void ClearDataBindingOfSubject()
        {
            foreach (var textBox in grpBxSubjectInput.Controls.OfType<TextBox>())
                textBox.DataBindings.Clear();

            nmrcpDwnSubjectCredit.DataBindings.Clear();
            cmbBxResponsibleTeacher.DataBindings.Clear();
        }

        // Clear data bindings for student-related controls
        private void ClearDataBindingOfStudent()
        {
            foreach (var textBox in grpBxStudentInput.Controls.OfType<TextBox>())
                textBox.DataBindings.Clear();

            cmbBxSubjectCodeBelongsToStudent.DataBindings.Clear();
            cmbBxGender.DataBindings.Clear();
            mskdTxtBxDateOfBirth.DataBindings.Clear();
        }

        // Set data bindings for subject-related controls
        private void SetDataBindingOfSubject()
        {
            string[] columns = new string[] { "Subject code", "Subject name", "Requirement type", "Institute" };
            int i = 0;
            foreach (var textBox in grpBxSubjectInput.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex))
                textBox.DataBindings.Add(new Binding("Text", bsSubject, columns[i++]));
            nmrcpDwnSubjectCredit.DataBindings.Add(new Binding("Value", bsSubject, "Credit"));
            cmbBxResponsibleTeacher.DataBindings.Add(new Binding("Text", bsSubject, "Teacher"));
        }

        // Set data bindings for student-related controls
        private void SetDataBindingOfStudent()
        {
            string[] columns = new string[] { "Neptun code", "Lastname", "First name", "City", "Street" };
            int i = 0;
            foreach (var textBox in grpBxStudentInput.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex))
                textBox.DataBindings.Add(new Binding("Text", bsStudent, columns[i++]));
            cmbBxSubjectCodeBelongsToStudent.DataBindings.Add(new Binding("Text", bsStudent, "Subject code"));
            mskdTxtBxDateOfBirth.DataBindings.Add(new Binding("Text", bsStudent, "BirthDate"));
            cmbBxGender.DataBindings.Add(new Binding("Text", bsStudent, "Gender"));
        }

        // Set the data source and display options for a ComboBox
        private void SetCmbBxView(ComboBox comboBox, DataTable dataTable, string displayMember, string valueMember, object selectedValue)
        {
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.SelectedValue = selectedValue;
        }

        // Event handler for text changed in subject-related TextBoxes
        private void TxtBxSubject_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            switch (textBox.Name)
            {
                case "txtBxSubjectCode":
                    lblSubjectCodeMaxLength.Text = $"({txtBxSubjectCode.Text.Length}/{lblSubjectCodeMaxLength.Text.Split('/')[1]}";
                    break;
                case "txtBxSubjectName":
                    lblSubjectNameMaxLength.Text = $"({txtBxSubjectName.Text.Length}/{lblSubjectNameMaxLength.Text.Split('/')[1]}";
                    break;
                case "txtBxRequirementType":
                    lblRequirementTypeMaxLength.Text = $"({txtBxRequirementType.Text.Length}/{lblRequirementTypeMaxLength.Text.Split('/')[1]}";
                    break;
                case "txtBxResponsibleInstitute":
                    lblResponsibleInstituteMaxLength.Text = $"({txtBxResponsibleInstitute.Text.Length}/{lblResponsibleInstituteMaxLength.Text.Split('/')[1]}";
                    break;
            }
        }

        // Event handler for buttons used to navigate subject records
        private void BtnMoveToSubjectRecord_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Name)
            {
                case "bttnMoveToFirstSubjectRecord":
                    bsSubject.MoveFirst();
                    break;
                case "bttnMoveToPreviousSubjectRecord":
                    bsSubject.MovePrevious();
                    break;
                case "bttnMoveToNextSubjectRecord":
                    bsSubject.MoveNext();
                    break;
                case "bttnMoveToLastSubjectRecord":
                    bsSubject.MoveLast();
                    break;
            }
            dtGrdVwSubject.Rows[bsSubject.Position].Selected = true;
            RefreshSubjectDataView();
            SetSubjectGrid();
            SetStudentGrid();
            RefreshLabelSubjectRecord();
            RefreshLabelStudentRecord();
        }

        // Refresh labels displaying subject record information
        private void RefreshLabelSubjectRecord()
        {
            txtBxActualRecordOfSubject.Text = (bsSubject.Position + 1).ToString();
            lblTotalRecordNumberOfSubject.Text = " total " + bsSubject.Count;
        }

        // Refresh labels displaying student record information
        private void RefreshLabelStudentRecord()
        {
            txtBxActualRecordOfStudent.Text = (bsStudent.Position + 1).ToString();
            lblTotalRecordNumberOfStudent.Text = " total " + bsStudent.Count;
        }

        // Event handler for key up event in "Actual Record of Subject" TextBox
        private void TxtBxActualRecordOfSubject_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBxActualRecordOfSubject.Text != "")
                {
                    try
                    {
                        if (Convert.ToInt32(txtBxActualRecordOfSubject.Text) > bsSubject.Count)
                        {

                            SetActualRecordOfSubject(bsSubject.Count.ToString());
                            SetActualPositionOfSubject(bsSubject.Count);
                        }
                        else if (Convert.ToInt32(txtBxActualRecordOfSubject.Text) < 1)
                        {
                            SetActualRecordOfSubject("1");
                            SetActualPositionOfSubject(0);
                        }
                        else
                        {
                            SetActualRecordOfSubject(txtBxActualRecordOfSubject.Text);
                            SetActualPositionOfSubject(Convert.ToInt32(txtBxActualRecordOfSubject.Text) - 1);
                        }
                        dtGrdVwSubject.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        SetActualRecordOfSubject("1");
                        SetActualPositionOfSubject(0);
                    }
                }
            }
        }

        // Set the actual record number of the subject
        private void SetActualRecordOfSubject(string actualRecord)
        {
            txtBxActualRecordOfSubject.Text = actualRecord;
        }

        // Set the actual position of the subject in the BindingSource
        private void SetActualPositionOfSubject(int position)
        {
            bsSubject.Position = position;
            dtGrdVwSubject.ClearSelection();
            dtGrdVwSubject.Rows[bsSubject.Position].Selected = true;
            SetStudentGrid();
            dtGrdVwSubject.CurrentCell =
            dtGrdVwSubject.Rows[bsSubject.Position].Cells[1];
        }

        // Event handler for cell click event in the subject grid
        private void SubjectGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshLabelSubjectRecord();
            SetStudentGrid();
            RefreshLabelStudentRecord();
        }

        // Event handler for key up event in the subject grid
        private void DtGrdVwSubject_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.PageDown)
            {
                RefreshLabelSubjectRecord();
                SetStudentGrid();
                RefreshLabelStudentRecord();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure? After deleting there is no any undo!", "Deletion confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int numberOfDeletedRow = 0;
                    for (int i = 0; i < dtGrdVwSubject.SelectedRows.Count; ++i)
                    {
                        var subject = new Subject
                        {
                            Id = (int)dtGrdVwSubject.SelectedRows[i].Cells["ID"].Value
                        };
                        var parameters = new List<SqlParameter>();
                        parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@ID", subject.Id, DbType.Int32));
                        ConnectionLayer.dataAccessLayer.Delete("DELETE FROM Subject WHERE ID = @ID", CommandType.Text, parameters.ToArray());

                        numberOfDeletedRow++;
                    }
                    RefreshSubjectDataView();
                    ClearDataBindingOfSubject();
                    SetDataBindingOfSubject();
                    RefreshLabelSubjectRecord();
                    SetCmbBxView(cmbBxSubjectCodeBelongsToStudent, dtTblSubject, "Subject code", "Subject code", dtGrdVwSubject.Rows[0].Cells["Subject code"].Value);
                    MessageBox.Show(numberOfDeletedRow.ToString() + " row(s) has been deleted.", "Deletion result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Event handler for the "New Subject" button click
        private void BtnNewSubject_Click(object sender, EventArgs e)
        {
            ClearDataBindingOfSubject();
            foreach (var control in grpBxSubjectInput.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    textBox.Text = "";
                }
            }

            nmrcpDwnSubjectCredit.Value = 0;
            cmbBxResponsibleTeacher.Text = "";
            bttnNewSubject.Enabled = bttnUpdateSubject.Enabled = false;
            bttnInsertSubject.Enabled = true;
            dtGrdVwSubject.ClearSelection();
            dtGrdVwStudent.ClearSelection();
        }

        // Event handler for the "Insert Subject" button click
        private void BtnInsertSubject_Click(object sender, EventArgs e)
        {
            if (!IsSubjectTextBoxValuesEmpty())
            {
                Subject subject = GetSubject();
                List<SqlParameter> parameters = GetSqlParameters(subject);
                if (IsSubjectCodeExist(subject) == 0)
                {
                    errorProvider.SetError(txtBxSubjectCode, "");
                    int lastId = 0;
                    ConnectionLayer.dataAccessLayer.Insert("INSERT INTO Subject (SubjectCode, SubjectName, Credit, TypeOfSubjectRequirement, TeacherID, InstituteResponsibleForTheSubject) "
                        + "OUTPUT INSERTED.ID "
                        + "VALUES (@SubjectCode, @SubjectName, @Credit, @TypeOfSubjectRequirement, @TeacherID, @InstituteResponsibleForTheSubject)", CommandType.Text, parameters.ToArray(), out lastId);
                    RefreshSubjectDataView();
                    HighlightModifiedSubject(lastId);
                    RefreshLabelSubjectRecord();
                    SetDataBindingOfSubject();
                    SetStudentGrid();
                    RefreshLabelStudentRecord();
                    SetCmbBxView(cmbBxSubjectCodeBelongsToStudent, dtTblSubject, "Subject code", "Subject code", dtGrdVwSubject.Rows[0].Cells["Subject code"].Value);
                    bttnNewSubject.Enabled = bttnUpdateSubject.Enabled = true;
                    bttnInsertSubject.Enabled = false;
                }
                else
                {
                    errorProvider.SetError(txtBxSubjectCode, "Given subject code already exists.");
                }

            }
        }

        // Check if subject-related TextBox values are empty
        private bool IsSubjectTextBoxValuesEmpty()
        {
            Dictionary<TextBox, string> textBoxBelongsToErrorText = new Dictionary<TextBox, string>()
            {
                { txtBxSubjectCode, "Subject code has to be filled!" },
                { txtBxSubjectName, "Subject name has to be filled!" }
            };

            foreach (KeyValuePair<TextBox, string> item in textBoxBelongsToErrorText)
            {
                if (item.Key.Text == "")
                {
                    errorProvider.SetError(item.Key, item.Value);
                    return true;
                }
                else
                    errorProvider.SetError(item.Key, "");
            }
            return false;
        }

        // Check if a subject code already exists in the database
        private int IsSubjectCodeExist(Subject subject)
        {
            List<SqlParameter> parameters = GetSqlParameters(subject);
            object scalar = ConnectionLayer.dataAccessLayer.GetScalarValue("SELECT COUNT(*) FROM Subject WHERE SubjectCode = @SubjectCode", CommandType.Text, parameters.ToArray());

            return (int)scalar;
        }

        // Create a Subject object from input values
        private Subject GetSubject()
        {
            var subject = new Subject
            {
                SubjectCode = txtBxSubjectCode.Text,
                SubjectName = txtBxSubjectName.Text,
                Credit = Convert.ToInt16(nmrcpDwnSubjectCredit.Value),
                TypeOfSubjectRequirement = txtBxRequirementType.Text,
                TeacherId = GetIdOf("ID", "Teacher", "Name", cmbBxResponsibleTeacher.SelectedValue.ToString()).ToString(),
                InstitueResponsibleForTheSubject = txtBxResponsibleInstitute.Text
            };

            return subject;
        }

        // Refresh the subject data view
        private void RefreshSubjectDataView()
        {
            dtTblSubject = subject.GetSubjects();
            bsSubject.DataSource = dtTblSubject;
            dtGrdVwSubject.DataSource = bsSubject;
        }

        // Highlight the modified subject in the grid
        private void HighlightModifiedSubject(int lastId)
        {
            foreach (DataGridViewRow row in dtGrdVwSubject.Rows)
            {
                if (row.Cells["ID"].Value.Equals(lastId))
                {
                    bsSubject.Position = row.Index;
                    dtGrdVwSubject.Rows[row.Index].Selected = true;
                    break;
                }
            }
        }

        // Get the ID of a record based on a field and value
        private object GetIdOf(string field, string fromTable, string whereField, string whereValue)
        {
            object scalar = ConnectionLayer.dataAccessLayer.GetScalarValue(
            "SELECT " + field +
            " FROM " + fromTable +
            " WHERE " + whereField + "=" + "'" + whereValue + "'",
            CommandType.Text);

            return scalar;
        }

        // Get a list of SQL parameters for a Subject
        private List<SqlParameter> GetSqlParameters(Subject subject)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@SubjectCode", 12, subject.SubjectCode, DbType.String));
            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@SubjectName", 50, subject.SubjectName, DbType.String));
            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@Credit", subject.Credit, DbType.Int32));
            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@TypeOfSubjectRequirement", 30, subject.TypeOfSubjectRequirement, DbType.String));
            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@TeacherID", 6, subject.TeacherId, DbType.String));
            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@InstituteResponsibleForTheSubject", 50, subject.InstitueResponsibleForTheSubject, DbType.String));


            return parameters;
        }

        // Function to get a list of SQL parameters for a Subject with a specific ID
        private List<SqlParameter> GetSqlParameters(Subject subject, int subjectId)
        {
            List<SqlParameter> parameters = GetSqlParameters(subject);
            subject.Id = subjectId;
            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@ID", subject.Id, DbType.Int32));

            return parameters;
        }

        // Event handler for the "Update Subject" button click
        private void BtnUpdateSubject_Click(object sender, EventArgs e)
        {
            if (!IsSubjectTextBoxValuesEmpty())
            {
                Subject subject = GetSubject();
                List<SqlParameter> parameters = GetSqlParameters(subject, (int)dtGrdVwSubject.CurrentRow.Cells["ID"].Value);
                string oldSubjectCode = (string)ConnectionLayer.dataAccessLayer.GetScalarValue("SELECT SubjectCode FROM Subject WHERE ID = @ID", CommandType.Text, parameters.ToArray());

                parameters.Clear();
                parameters = GetSqlParameters(subject, (int)dtGrdVwSubject.CurrentRow.Cells["ID"].Value);
                if (IsOldSubjectCodeExist(subject, oldSubjectCode))
                {
                    errorProvider.SetError(txtBxSubjectCode, "");
                    ConnectionLayer.dataAccessLayer.Update("UPDATE Subject SET SubjectCode = @SubjectCode, SubjectName = @SubjectName, Credit = @Credit,TypeOfSubjectRequirement = @TypeOfSubjectRequirement, TeacherID = @TeacherID," +
                    "InstituteResponsibleForTheSubject = @InstituteResponsibleForTheSubject WHERE ID = @ID", CommandType.Text, parameters.ToArray());
                    SetCmbBxView(cmbBxSubjectCodeBelongsToStudent, dtTblSubject, "Subject code", "Subject code", dtGrdVwSubject.Rows[0].Cells["Subject code"].Value);
                    RefreshSubjectDataView();
                    RefreshStudentDataView();
                    HighlightModifiedSubject(subject.Id);
                    ClearDataBindingOfStudent();
                    SetDataBindingOfStudent();
                    RefreshLabelStudentRecord();
                    SetStudentGrid();
                }
                else
                    errorProvider.SetError(txtBxSubjectCode, "Given subject code already exists.");
            }

            RefreshSubjectDataView();
            SetStudentGrid();
        }

        // Check if the old subject code exists in the database
        private bool IsOldSubjectCodeExist(Subject subject, string oldSubjectCode)
        {
            if (subject.SubjectCode == oldSubjectCode)
                return true;
            else if (IsSubjectCodeExist(subject) != 0)
                return false;
            else
                return true;
        }

        // Refresh the student data view
        private void RefreshStudentDataView() //23. oldal
        {
            dtTblStudent = student.GetStudents();
            bsStudent.DataSource = dtTblStudent;
            dtGrdVwStudent.DataSource = bsStudent;
        }

        // Event handler for text changes in the subject filter TextBox
        private void TxtBxSubjectPattern_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> fieldNames = new Dictionary<string, string>()
            {
                {"Subject code", "SubjectCode"},
                {"Subject name", "SubjectName"},
                {"Credit", "Credit"},
                {"Requirement type", "TypeOfSubjectRequirement"},
                {"Teacher", "Name"},
                {"Institute", "InstituteResponsibleForTheSubject"}
            };

            dtTblSubject = ConnectionLayer.dataAccessLayer.GetDataTable("SELECT s.ID, s.SubjectCode AS[Subject code], s.SubjectName AS[Subject name], s.Credit AS Credit," +
            "s.TypeOfSubjectRequirement AS [Requirement type], t.Name AS Teacher, s.InstituteResponsibleForTheSubject AS Institute " +
            "FROM Subject s JOIN Teacher t ON t.ID = s.TeacherID " +
            "WHERE [" + fieldNames[cmbBxSubjectFilterColumn.SelectedItem.ToString()] + "] LIKE '%" + txtBxSubjectPattern.Text + "%'", CommandType.Text);
            bsSubject.DataSource = dtTblSubject;
            dtGrdVwSubject.DataSource = bsSubject;

            SetSubjectGrid();
            ClearDataBindingOfSubject();
            SetDataBindingOfSubject();
            if (dtTblSubject.Rows.Count > 0)
            {
                ClearDataBindingOfStudent();
                SetDataBindingOfStudent();
            }
            SetStudentGrid();
            RefreshLabelSubjectRecord();
            RefreshLabelStudentRecord();
        }

        // Event handler for buttons used to navigate student records
        private void BtnMoveToStudentRecord_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Name)
            {
                case "bttnMoveToFirstStudentRecord":
                    bsStudent.MoveFirst();
                    break;
                case "bttnMoveToPreviousStudentRecord":
                    bsStudent.MovePrevious();
                    break;
                case "bttnMoveToNextStudentRecord":
                    bsStudent.MoveNext();
                    break;
                case "bttnMoveToLastStudentRecord":
                    bsStudent.MoveLast();
                    break;
            }
            RefreshStudentDataView();
            SetStudentGrid();
            RefreshLabelStudentRecord();
        }

        // Event handler for the "Actual Record of Student" TextBox key up 
        private void txtBxActualRecordOfStudent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBxActualRecordOfStudent.Text != "")
                {
                    try
                    {
                        if (Convert.ToInt32(txtBxActualRecordOfStudent.Text) > bsStudent.Count)
                        {

                            SetActualRecordOfStudent(bsStudent.Count.ToString());
                            SetActualPositionOfStudent(bsStudent.Count);
                        }
                        else if (Convert.ToInt32(txtBxActualRecordOfStudent.Text) < 1)
                        {
                            SetActualRecordOfStudent("1");
                            SetActualPositionOfStudent(0);
                        }
                        else
                        {
                            SetActualRecordOfStudent(txtBxActualRecordOfStudent.Text);
                            SetActualPositionOfStudent(Convert.ToInt32(txtBxActualRecordOfStudent.Text) - 1);
                        }
                        dtGrdVwStudent.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        SetActualRecordOfStudent("1");
                        SetActualPositionOfStudent(0);
                    }
                }
            }
        }

        // Set the actual record of the student
        private void SetActualRecordOfStudent(string actualRecord)
        {
            txtBxActualRecordOfStudent.Text = actualRecord;
        }

        // Set the actual position of the student in the grid
        private void SetActualPositionOfStudent(int position)
        {
            bsStudent.Position = position;
            dtGrdVwStudent.ClearSelection();
            dtGrdVwStudent.Rows[bsStudent.Position].Selected = true;
            dtGrdVwStudent.CurrentCell =
            dtGrdVwStudent.Rows[bsStudent.Position].Cells[1];
        }

        // Event handler for the cell click event in the student DataGridView
        private void DataGrdVwStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshStudentDataView();
            SetStudentGrid();
            RefreshLabelStudentRecord();
        }

        // Event handler for key up events in the student DataGridView
        private void DataGrdVwStudent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.PageDown)
            {
                SetStudentGrid();
                RefreshLabelStudentRecord();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure? After deleting no any undo!", "Deletion confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int numberOfDeletedRow = 0;
                    for (int i = 0; i < dtGrdVwStudent.SelectedRows.Count; ++i)
                    {
                        var student = new Student
                        {
                            Id = (int)dtGrdVwStudent.SelectedRows[i].Cells["ID"].Value
                        };


                        var parameters = new List<SqlParameter>();

                        parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@ID", student.Id, DbType.Int32));
                        ConnectionLayer.dataAccessLayer.Delete("DELETE FROM Student WHERE ID = @ID", CommandType.Text, parameters.ToArray());

                        numberOfDeletedRow++;
                    }

                    RefreshStudentDataView();
                    ClearDataBindingOfStudent();
                    SetDataBindingOfStudent();
                    SetStudentGrid();
                    RefreshLabelStudentRecord();
                    MessageBox.Show(numberOfDeletedRow.ToString() + " row(s) has been deleted.", "Deletion result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        // Event handler for the "New Student" button click
        private void BtnNewStudent_Click(object sender, EventArgs e)
        {
            ClearDataBindingOfStudent();
            foreach (var control in grpBxStudentInput.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    textBox.Text = "";
                }
            }

            mskdTxtBxDateOfBirth.Text = "";
            cmbBxGender.Text = "";
            bttnNewStudent.Enabled = bttnUpdateStudent.Enabled = false;
            bttnInsertStudent.Enabled = true;
            dtGrdVwStudent.ClearSelection();
        }

        // Event handler for the "Insert Student" button click
        private void BtnInsertStudent_Click(object sender, EventArgs e)
        {
            if (!IsStudentTextBoxValuesEmpty() || !IsStudentMaskedTextBoxValuesEmpty())
            {
                Student student = GetStudent();
                List<SqlParameter> parameters = GetSqlParameters(student);
                if (IsNeptunCodeExist(student) == 0)
                {
                    errorProvider.SetError(txtBxNeptunCode, "");
                    int lastId = 0;
                    ConnectionLayer.dataAccessLayer.Insert("INSERT INTO Student (NeptunCode, SubjectCode, LastName, FirstName, BirthDate, City, Street, Gender) " +
                     "OUTPUT INSERTED.ID " +
                     "VALUES (@NeptunCode, @SubjectCode, @LastName, @FirstName, @BirthDate, @City, @Street, @Gender)", CommandType.Text, parameters.ToArray(), out lastId);
                    RefreshStudentDataView();
                    SetStudentGrid();
                    HighlightModifiedStudent(lastId);
                    SetDataBindingOfStudent();
                    RefreshLabelStudentRecord();
                    bttnNewStudent.Enabled = bttnUpdateStudent.Enabled = true;
                    bttnInsertStudent.Enabled = false;
                }
                else
                    errorProvider.SetError(txtBxNeptunCode, "Given subject code already exists.");
            }
        }

        // Check if student-related TextBox values are empty
        private bool IsStudentTextBoxValuesEmpty()
        {
            Dictionary<TextBox, string> textBoxBelongsToErrorText = new Dictionary<TextBox, string>()
            {
                { txtBxNeptunCode, "Neptun code has to be filled!" },
                { txtBxSurname, "Surname has to be filled!" },
                { txtBxFirstName, "First name has to be filled!" },
                { txtBxCity, "City has to be filled!" },
                { txtBxStreet, "Address has to be filled!" }
            };

            foreach (KeyValuePair<TextBox, string> item in textBoxBelongsToErrorText)
            {
                if (item.Key.Text == "")
                {
                    errorProvider.SetError(item.Key, item.Value);
                    return true;
                }
                else
                    errorProvider.SetError(item.Key, "");
            }
            return false;
        }

        // Check if student-related MaskedTextBox values are empty
        private bool IsStudentMaskedTextBoxValuesEmpty()
        {
            Dictionary<MaskedTextBox, string> maskedTextBoxBelongsToErrorText = new Dictionary<MaskedTextBox, string>()
            {
                { mskdTxtBxDateOfBirth, "Date has to be filled!" }
            };

            foreach (KeyValuePair<MaskedTextBox, string> item in maskedTextBoxBelongsToErrorText)
            {
                if (!item.Key.MaskCompleted)
                {
                    errorProvider.SetError(item.Key, item.Value);
                    return true;
                }
                else
                    errorProvider.SetError(item.Key, "");
            }
            return false;
        }

        // Highlight the modified student in the grid
        private void HighlightModifiedStudent(int lastId)
        {
            foreach (DataGridViewRow row in dtGrdVwStudent.Rows)
                if (row.Cells["ID"].Value.Equals(lastId))
                {
                    bsStudent.Position = row.Index;
                    dtGrdVwStudent.Rows[row.Index].Selected = true;
                    break;
                }
        }

        // Check if a Neptun code already exists in the database
        private int IsNeptunCodeExist(Student student)
        {
            List<SqlParameter> parameters = GetSqlParameters(student);
            object scalar = ConnectionLayer.dataAccessLayer.GetScalarValue("SELECT COUNT(*) FROM Student WHERE NeptunCode = @NeptunCode", CommandType.Text, parameters.ToArray());

            return (int)scalar;
        }

        // Event handler for the TypeValidationCompleted event of the Date of Birth MaskedTextBox
        private void MskdTxtBxDateOfBirth_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                errorProvider.SetError(mskdTxtBxDateOfBirth, "Use valid date!");
            else
                errorProvider.SetError(mskdTxtBxDateOfBirth, "");
        }

        // Function to create a Student object from input values
        private Student GetStudent()
        {
            var student = new Student
            {
                NeptunCode = txtBxNeptunCode.Text,
                SubjectCode = GetIdOf("ID", "Subject", "SubjectCode",
                cmbBxSubjectCodeBelongsToStudent.SelectedValue.ToString()).ToString(),
                LastName = txtBxSurname.Text,
                FirstName = txtBxFirstName.Text,
                BirthDate = DateTime.Parse(mskdTxtBxDateOfBirth.Text),
                City = txtBxCity.Text,
                Street = txtBxStreet.Text,
                Gender = cmbBxGender.Text
            };

            return student;
        }

        // Create a list of SQL parameters for inserting a student into the database
        private List<SqlParameter> GetSqlParameters(Student student)
        {
            var parameters = new List<SqlParameter>();

            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@NeptunCode", 6, student.NeptunCode, DbType.String));

            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@SubjectCode", 12, student.SubjectCode, DbType.String));

            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@LastName", 20, student.LastName, DbType.String));

            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@FirstName", 20, student.FirstName, DbType.String));

            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@BirthDate", student.BirthDate, DbType.DateTime));

            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@City", 20, student.City, DbType.String));

            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@Street", 80, student.Street, DbType.String));

            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@Gender", 6, student.Gender, DbType.String));


            return parameters;
        }

        // Event handler for the "Update Student" button click
        private void BtnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (!IsStudentTextBoxValuesEmpty())
            {
                DateTime dateTime;
                if (DateTime.TryParse(mskdTxtBxDateOfBirth.Text, out dateTime))
                {
                    Student student = GetStudent();
                    List<SqlParameter> parameters = GetSqlParameters(student, (int)dtGrdVwStudent.CurrentRow.Cells["ID"].Value);
                    string oldNeptunCode = (string)ConnectionLayer.dataAccessLayer.GetScalarValue("SELECT NeptunCode FROM Student WHERE ID = @ID", CommandType.Text, parameters.ToArray());
                   
                    parameters.Clear();
                    parameters = GetSqlParameters(student,(int)dtGrdVwStudent.CurrentRow.Cells["ID"].Value);
                    if (IsOldNeptunCodeExist(student, oldNeptunCode))
                    {
                        errorProvider.SetError(txtBxNeptunCode, "");
                        ConnectionLayer.dataAccessLayer.Update("UPDATE Student SET NeptunCode = @NeptunCode, SubjectCode = @SubjectCode, LastName = @LastName, FirstName @FirstName, BirthDate = @BirthDate, " 
                            + "City = @City, Street = @Street, Gender = @Gender WHERE ID= @ID", CommandType.Text, parameters.ToArray());
                       
                        RefreshStudentDataView();
                        SetStudentGrid();
                        RefreshLabelStudentRecord();
                    }
                    else
                        errorProvider.SetError(txtBxNeptunCode, "Given neptun code already exists.");
                }
            }
        }

        // Check if the old Neptun code exists in the database
        private bool IsOldNeptunCodeExist(Student student, string oldNeptunCode)
        {
            if (student.NeptunCode == oldNeptunCode)
                return true;
            else if (IsNeptunCodeExist(student) != 0)
                return false;
            else
                return true;
        }

        // Create a list of SQL parameters for updating a student in the database
        private List<SqlParameter> GetSqlParameters(Student student, int studentId)
        {
            List<SqlParameter> parameters = GetSqlParameters(student);
            student.Id = studentId;
            parameters.Add(ConnectionLayer.dataAccessLayer.CreateParameter("@ID", student.Id, DbType.Int32));

            return parameters;
        }

        // Event handler for TextChanged events in student-related TextBoxes
        private void TxtBxStudent_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            switch (textBox.Name)
            {
                case "txtBxNeptunCode":
                    lblNeptunCodeMaxLength.Text = $"({txtBxNeptunCode.Text.Length}/{lblNeptunCodeMaxLength.Text.Split('/')[1]}";
                    break;
                case "txtBxSurname":
                    lblSurnameMaxLength.Text = $"({txtBxSurname.Text.Length}/{lblSurnameMaxLength.Text.Split('/')[1]}";
                    break;
                case "txtBxFirstName":
                    lblFirstNameMaxLength.Text = $"({txtBxFirstName.Text.Length}/{lblFirstNameMaxLength.Text.Split('/')[1]}";
                    break;
                case "txtBxCity":
                    lblCityMaxLength.Text = $"({txtBxCity.Text.Length}/{lblCityMaxLength.Text.Split('/')[1]}";
                    break;
                case "txtBxStreet":
                    lblStreetMaxLength.Text = $"({txtBxStreet.Text.Length}/{lblStreetMaxLength.Text.Split('/')[1]}";
                    break;
            }
        }

        // Event handler for TextChanged events in the student pattern TextBox
        private void txtBxStudentPattern_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> fieldNames = new Dictionary<string, string>()
            {
                {"Neptun code", "NeptunCode"},
                {"Subject code", "SubjectCode"},
                {"Last name", "LastName"},
                {"First name", "FirstName"},
                {"Birth date", "BirthDate"},
                {"City", "City"},
                {"Street", "Street"},
                {"Gender", "Gender"}
            };
 
            dtTblStudent = ConnectionLayer.dataAccessLayer.GetDataTable("SELECT st.ID, st.NeptunCode AS[Neptun code], su.SubjectCode AS[Subject code], st.LastName AS[Last name], st.FirstName AS[First name], " +
                "st.BirthDate AS[Birth date], st.City, st.Street, st.Gender " +
            "FROM Student st " +
            "JOIN Subject su ON su.ID = st.SubjectCode " +
            "WHERE " +
            (fieldNames[cmbBxStudentFilterColumn.SelectedItem.ToString()] == "SubjectCode" ? "su.[" + fieldNames[cmbBxStudentFilterColumn.SelectedItem.ToString()] + "] " : "[" +
            fieldNames[cmbBxStudentFilterColumn.SelectedItem.ToString()] + "] ") + "LIKE '%" + txtBxStudentPattern.Text + "%'", CommandType.Text);
            bsStudent.DataSource = dtTblStudent;
            dtGrdVwStudent.DataSource = bsStudent;
            SetStudentGrid();
            RefreshLabelStudentRecord();
        }
    }
}
