namespace StudentManager
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtGrdVwSubject = new System.Windows.Forms.DataGridView();
            this.lblTotalRecordNumberOfSubject = new System.Windows.Forms.Label();
            this.txtBxActualRecordOfSubject = new System.Windows.Forms.TextBox();
            this.bttnMoveToLastSubjectRecord = new System.Windows.Forms.Button();
            this.bttnMoveToNextSubjectRecord = new System.Windows.Forms.Button();
            this.bttnMoveToPreviousSubjectRecord = new System.Windows.Forms.Button();
            this.bttnMoveToFirstSubjectRecord = new System.Windows.Forms.Button();
            this.lblRowSubject = new System.Windows.Forms.Label();
            this.grpBxSubjectInput = new System.Windows.Forms.GroupBox();
            this.bttnUpdateSubject = new System.Windows.Forms.Button();
            this.bttnNewSubject = new System.Windows.Forms.Button();
            this.bttnInsertSubject = new System.Windows.Forms.Button();
            this.lblResponsibleInstituteMaxLength = new System.Windows.Forms.Label();
            this.lblRequirementTypeMaxLength = new System.Windows.Forms.Label();
            this.lblCreditInformation = new System.Windows.Forms.Label();
            this.lblSubjectNameMaxLength = new System.Windows.Forms.Label();
            this.lblSubjectCodeMaxLength = new System.Windows.Forms.Label();
            this.txtBxResponsibleInstitute = new System.Windows.Forms.TextBox();
            this.cmbBxResponsibleTeacher = new System.Windows.Forms.ComboBox();
            this.txtBxRequirementType = new System.Windows.Forms.TextBox();
            this.nmrcpDwnSubjectCredit = new System.Windows.Forms.NumericUpDown();
            this.txtBxSubjectName = new System.Windows.Forms.TextBox();
            this.txtBxSubjectCode = new System.Windows.Forms.TextBox();
            this.lblResponsibleInstitute = new System.Windows.Forms.Label();
            this.lblResponsibleTeacher = new System.Windows.Forms.Label();
            this.lblRequirementType = new System.Windows.Forms.Label();
            this.lblSubjectCredit = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.lblSubjectCode = new System.Windows.Forms.Label();
            this.lblSubjectTotalRecordNumber = new System.Windows.Forms.Label();
            this.txtBxActualRecordOfStudent = new System.Windows.Forms.TextBox();
            this.bttnMoveToLastStudentRecord = new System.Windows.Forms.Button();
            this.bttnMoveToNextStudentRecord = new System.Windows.Forms.Button();
            this.bttnMoveToPreviousStudentRecord = new System.Windows.Forms.Button();
            this.bttnMoveToFirstStudentRecord = new System.Windows.Forms.Button();
            this.lblRowStudent = new System.Windows.Forms.Label();
            this.dtGrdVwStudent = new System.Windows.Forms.DataGridView();
            this.grpBxSubjectFilter = new System.Windows.Forms.GroupBox();
            this.txtBxSubjectPattern = new System.Windows.Forms.TextBox();
            this.cmbBxSubjectFilterColumn = new System.Windows.Forms.ComboBox();
            this.lblSubjectPattern = new System.Windows.Forms.Label();
            this.lblSubjectFilterColumn = new System.Windows.Forms.Label();
            this.grpBxStudentFilter = new System.Windows.Forms.GroupBox();
            this.txtBxStudentPattern = new System.Windows.Forms.TextBox();
            this.cmbBxStudentFilterColumn = new System.Windows.Forms.ComboBox();
            this.lblStudentPattern = new System.Windows.Forms.Label();
            this.lblStudentFilterColumn = new System.Windows.Forms.Label();
            this.grpBxStudentInput = new System.Windows.Forms.GroupBox();
            this.cmbBxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblStreetMaxLength = new System.Windows.Forms.Label();
            this.txtBxStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.mskdTxtBxDateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.lblSurnameMaxLength = new System.Windows.Forms.Label();
            this.txtBxSurname = new System.Windows.Forms.TextBox();
            this.cmbBxSubjectCodeBelongsToStudent = new System.Windows.Forms.ComboBox();
            this.bttnUpdateStudent = new System.Windows.Forms.Button();
            this.bttnNewStudent = new System.Windows.Forms.Button();
            this.bttnInsertStudent = new System.Windows.Forms.Button();
            this.lblCityMaxLength = new System.Windows.Forms.Label();
            this.lblFirstNameMaxLength = new System.Windows.Forms.Label();
            this.lblNeptunCodeMaxLength = new System.Windows.Forms.Label();
            this.txtBxCity = new System.Windows.Forms.TextBox();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxNeptunCode = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblSubjectCodeBelongsToStudent = new System.Windows.Forms.Label();
            this.lblNeptunCode = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTotalRecordNumberOfStudent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwSubject)).BeginInit();
            this.grpBxSubjectInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpDwnSubjectCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwStudent)).BeginInit();
            this.grpBxSubjectFilter.SuspendLayout();
            this.grpBxStudentFilter.SuspendLayout();
            this.grpBxStudentInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdVwSubject
            // 
            this.dtGrdVwSubject.AllowUserToAddRows = false;
            this.dtGrdVwSubject.AllowUserToDeleteRows = false;
            this.dtGrdVwSubject.AllowUserToOrderColumns = true;
            this.dtGrdVwSubject.AllowUserToResizeColumns = false;
            this.dtGrdVwSubject.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdVwSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrdVwSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwSubject.Location = new System.Drawing.Point(16, 15);
            this.dtGrdVwSubject.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrdVwSubject.Name = "dtGrdVwSubject";
            this.dtGrdVwSubject.ReadOnly = true;
            this.dtGrdVwSubject.RowHeadersWidth = 51;
            this.dtGrdVwSubject.ShowCellErrors = false;
            this.dtGrdVwSubject.ShowCellToolTips = false;
            this.dtGrdVwSubject.ShowEditingIcon = false;
            this.dtGrdVwSubject.ShowRowErrors = false;
            this.dtGrdVwSubject.Size = new System.Drawing.Size(708, 292);
            this.dtGrdVwSubject.TabIndex = 0;
            this.dtGrdVwSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectGrid_CellClick);
            this.dtGrdVwSubject.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DtGrdVwSubject_KeyUp);
            // 
            // lblTotalRecordNumberOfSubject
            // 
            this.lblTotalRecordNumberOfSubject.AutoSize = true;
            this.lblTotalRecordNumberOfSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalRecordNumberOfSubject.Location = new System.Drawing.Point(529, 326);
            this.lblTotalRecordNumberOfSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRecordNumberOfSubject.Name = "lblTotalRecordNumberOfSubject";
            this.lblTotalRecordNumberOfSubject.Size = new System.Drawing.Size(0, 17);
            this.lblTotalRecordNumberOfSubject.TabIndex = 28;
            // 
            // txtBxActualRecordOfSubject
            // 
            this.txtBxActualRecordOfSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxActualRecordOfSubject.Location = new System.Drawing.Point(308, 321);
            this.txtBxActualRecordOfSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxActualRecordOfSubject.Name = "txtBxActualRecordOfSubject";
            this.txtBxActualRecordOfSubject.Size = new System.Drawing.Size(132, 23);
            this.txtBxActualRecordOfSubject.TabIndex = 27;
            this.txtBxActualRecordOfSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxActualRecordOfSubject.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBxActualRecordOfSubject_KeyUp);
            // 
            // bttnMoveToLastSubjectRecord
            // 
            this.bttnMoveToLastSubjectRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnMoveToLastSubjectRecord.Location = new System.Drawing.Point(485, 320);
            this.bttnMoveToLastSubjectRecord.Margin = new System.Windows.Forms.Padding(4);
            this.bttnMoveToLastSubjectRecord.Name = "bttnMoveToLastSubjectRecord";
            this.bttnMoveToLastSubjectRecord.Size = new System.Drawing.Size(37, 28);
            this.bttnMoveToLastSubjectRecord.TabIndex = 26;
            this.bttnMoveToLastSubjectRecord.Text = ">|";
            this.bttnMoveToLastSubjectRecord.UseVisualStyleBackColor = true;
            this.bttnMoveToLastSubjectRecord.Click += new System.EventHandler(this.BtnMoveToSubjectRecord_Click);
            // 
            // bttnMoveToNextSubjectRecord
            // 
            this.bttnMoveToNextSubjectRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnMoveToNextSubjectRecord.Location = new System.Drawing.Point(449, 320);
            this.bttnMoveToNextSubjectRecord.Margin = new System.Windows.Forms.Padding(4);
            this.bttnMoveToNextSubjectRecord.Name = "bttnMoveToNextSubjectRecord";
            this.bttnMoveToNextSubjectRecord.Size = new System.Drawing.Size(37, 28);
            this.bttnMoveToNextSubjectRecord.TabIndex = 25;
            this.bttnMoveToNextSubjectRecord.Text = ">";
            this.bttnMoveToNextSubjectRecord.UseVisualStyleBackColor = true;
            this.bttnMoveToNextSubjectRecord.Click += new System.EventHandler(this.BtnMoveToSubjectRecord_Click);
            // 
            // bttnMoveToPreviousSubjectRecord
            // 
            this.bttnMoveToPreviousSubjectRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnMoveToPreviousSubjectRecord.Location = new System.Drawing.Point(263, 320);
            this.bttnMoveToPreviousSubjectRecord.Margin = new System.Windows.Forms.Padding(4);
            this.bttnMoveToPreviousSubjectRecord.Name = "bttnMoveToPreviousSubjectRecord";
            this.bttnMoveToPreviousSubjectRecord.Size = new System.Drawing.Size(37, 28);
            this.bttnMoveToPreviousSubjectRecord.TabIndex = 24;
            this.bttnMoveToPreviousSubjectRecord.Text = "<";
            this.bttnMoveToPreviousSubjectRecord.UseVisualStyleBackColor = true;
            this.bttnMoveToPreviousSubjectRecord.Click += new System.EventHandler(this.BtnMoveToSubjectRecord_Click);
            // 
            // bttnMoveToFirstSubjectRecord
            // 
            this.bttnMoveToFirstSubjectRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnMoveToFirstSubjectRecord.Location = new System.Drawing.Point(227, 320);
            this.bttnMoveToFirstSubjectRecord.Margin = new System.Windows.Forms.Padding(4);
            this.bttnMoveToFirstSubjectRecord.Name = "bttnMoveToFirstSubjectRecord";
            this.bttnMoveToFirstSubjectRecord.Size = new System.Drawing.Size(37, 28);
            this.bttnMoveToFirstSubjectRecord.TabIndex = 23;
            this.bttnMoveToFirstSubjectRecord.Text = "|<";
            this.bttnMoveToFirstSubjectRecord.UseVisualStyleBackColor = true;
            this.bttnMoveToFirstSubjectRecord.Click += new System.EventHandler(this.BtnMoveToSubjectRecord_Click);
            // 
            // lblRowSubject
            // 
            this.lblRowSubject.AutoSize = true;
            this.lblRowSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRowSubject.Location = new System.Drawing.Point(184, 325);
            this.lblRowSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRowSubject.Name = "lblRowSubject";
            this.lblRowSubject.Size = new System.Drawing.Size(39, 17);
            this.lblRowSubject.TabIndex = 22;
            this.lblRowSubject.Text = "Row:";
            // 
            // grpBxSubjectInput
            // 
            this.grpBxSubjectInput.Controls.Add(this.bttnUpdateSubject);
            this.grpBxSubjectInput.Controls.Add(this.bttnNewSubject);
            this.grpBxSubjectInput.Controls.Add(this.bttnInsertSubject);
            this.grpBxSubjectInput.Controls.Add(this.lblResponsibleInstituteMaxLength);
            this.grpBxSubjectInput.Controls.Add(this.lblRequirementTypeMaxLength);
            this.grpBxSubjectInput.Controls.Add(this.lblCreditInformation);
            this.grpBxSubjectInput.Controls.Add(this.lblSubjectNameMaxLength);
            this.grpBxSubjectInput.Controls.Add(this.lblSubjectCodeMaxLength);
            this.grpBxSubjectInput.Controls.Add(this.txtBxResponsibleInstitute);
            this.grpBxSubjectInput.Controls.Add(this.cmbBxResponsibleTeacher);
            this.grpBxSubjectInput.Controls.Add(this.txtBxRequirementType);
            this.grpBxSubjectInput.Controls.Add(this.nmrcpDwnSubjectCredit);
            this.grpBxSubjectInput.Controls.Add(this.txtBxSubjectName);
            this.grpBxSubjectInput.Controls.Add(this.txtBxSubjectCode);
            this.grpBxSubjectInput.Controls.Add(this.lblResponsibleInstitute);
            this.grpBxSubjectInput.Controls.Add(this.lblResponsibleTeacher);
            this.grpBxSubjectInput.Controls.Add(this.lblRequirementType);
            this.grpBxSubjectInput.Controls.Add(this.lblSubjectCredit);
            this.grpBxSubjectInput.Controls.Add(this.lblSubjectName);
            this.grpBxSubjectInput.Controls.Add(this.lblSubjectCode);
            this.grpBxSubjectInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBxSubjectInput.Location = new System.Drawing.Point(741, 11);
            this.grpBxSubjectInput.Margin = new System.Windows.Forms.Padding(4);
            this.grpBxSubjectInput.Name = "grpBxSubjectInput";
            this.grpBxSubjectInput.Padding = new System.Windows.Forms.Padding(4);
            this.grpBxSubjectInput.Size = new System.Drawing.Size(564, 247);
            this.grpBxSubjectInput.TabIndex = 29;
            this.grpBxSubjectInput.TabStop = false;
            this.grpBxSubjectInput.Text = "Enter Subject";
            // 
            // bttnUpdateSubject
            // 
            this.bttnUpdateSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnUpdateSubject.Location = new System.Drawing.Point(203, 199);
            this.bttnUpdateSubject.Margin = new System.Windows.Forms.Padding(4);
            this.bttnUpdateSubject.Name = "bttnUpdateSubject";
            this.bttnUpdateSubject.Size = new System.Drawing.Size(87, 28);
            this.bttnUpdateSubject.TabIndex = 19;
            this.bttnUpdateSubject.Text = "Update";
            this.bttnUpdateSubject.UseVisualStyleBackColor = true;
            this.bttnUpdateSubject.Click += new System.EventHandler(this.BtnUpdateSubject_Click);
            // 
            // bttnNewSubject
            // 
            this.bttnNewSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnNewSubject.Location = new System.Drawing.Point(292, 199);
            this.bttnNewSubject.Margin = new System.Windows.Forms.Padding(4);
            this.bttnNewSubject.Name = "bttnNewSubject";
            this.bttnNewSubject.Size = new System.Drawing.Size(87, 28);
            this.bttnNewSubject.TabIndex = 18;
            this.bttnNewSubject.Text = "New";
            this.bttnNewSubject.UseVisualStyleBackColor = true;
            this.bttnNewSubject.Click += new System.EventHandler(this.BtnNewSubject_Click);
            // 
            // bttnInsertSubject
            // 
            this.bttnInsertSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnInsertSubject.Location = new System.Drawing.Point(381, 199);
            this.bttnInsertSubject.Margin = new System.Windows.Forms.Padding(4);
            this.bttnInsertSubject.Name = "bttnInsertSubject";
            this.bttnInsertSubject.Size = new System.Drawing.Size(87, 28);
            this.bttnInsertSubject.TabIndex = 17;
            this.bttnInsertSubject.Text = "Insert";
            this.bttnInsertSubject.UseVisualStyleBackColor = true;
            this.bttnInsertSubject.Click += new System.EventHandler(this.BtnInsertSubject_Click);
            // 
            // lblResponsibleInstituteMaxLength
            // 
            this.lblResponsibleInstituteMaxLength.AutoSize = true;
            this.lblResponsibleInstituteMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResponsibleInstituteMaxLength.Location = new System.Drawing.Point(500, 164);
            this.lblResponsibleInstituteMaxLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponsibleInstituteMaxLength.Name = "lblResponsibleInstituteMaxLength";
            this.lblResponsibleInstituteMaxLength.Size = new System.Drawing.Size(46, 17);
            this.lblResponsibleInstituteMaxLength.TabIndex = 16;
            this.lblResponsibleInstituteMaxLength.Text = "(0/50)";
            // 
            // lblRequirementTypeMaxLength
            // 
            this.lblRequirementTypeMaxLength.AutoSize = true;
            this.lblRequirementTypeMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRequirementTypeMaxLength.Location = new System.Drawing.Point(500, 111);
            this.lblRequirementTypeMaxLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequirementTypeMaxLength.Name = "lblRequirementTypeMaxLength";
            this.lblRequirementTypeMaxLength.Size = new System.Drawing.Size(46, 17);
            this.lblRequirementTypeMaxLength.TabIndex = 15;
            this.lblRequirementTypeMaxLength.Text = "(0/30)";
            // 
            // lblCreditInformation
            // 
            this.lblCreditInformation.AutoSize = true;
            this.lblCreditInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCreditInformation.Location = new System.Drawing.Point(267, 86);
            this.lblCreditInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditInformation.Name = "lblCreditInformation";
            this.lblCreditInformation.Size = new System.Drawing.Size(184, 17);
            this.lblCreditInformation.TabIndex = 14;
            this.lblCreditInformation.Text = "(Maximum value can be 10!)";
            // 
            // lblSubjectNameMaxLength
            // 
            this.lblSubjectNameMaxLength.AutoSize = true;
            this.lblSubjectNameMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSubjectNameMaxLength.Location = new System.Drawing.Point(500, 60);
            this.lblSubjectNameMaxLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectNameMaxLength.Name = "lblSubjectNameMaxLength";
            this.lblSubjectNameMaxLength.Size = new System.Drawing.Size(46, 17);
            this.lblSubjectNameMaxLength.TabIndex = 13;
            this.lblSubjectNameMaxLength.Text = "(0/50)";
            // 
            // lblSubjectCodeMaxLength
            // 
            this.lblSubjectCodeMaxLength.AutoSize = true;
            this.lblSubjectCodeMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSubjectCodeMaxLength.Location = new System.Drawing.Point(500, 33);
            this.lblSubjectCodeMaxLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectCodeMaxLength.Name = "lblSubjectCodeMaxLength";
            this.lblSubjectCodeMaxLength.Size = new System.Drawing.Size(46, 17);
            this.lblSubjectCodeMaxLength.TabIndex = 12;
            this.lblSubjectCodeMaxLength.Text = "(0/12)";
            // 
            // txtBxResponsibleInstitute
            // 
            this.txtBxResponsibleInstitute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxResponsibleInstitute.Location = new System.Drawing.Point(203, 160);
            this.txtBxResponsibleInstitute.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxResponsibleInstitute.MaxLength = 50;
            this.txtBxResponsibleInstitute.Name = "txtBxResponsibleInstitute";
            this.txtBxResponsibleInstitute.Size = new System.Drawing.Size(265, 23);
            this.txtBxResponsibleInstitute.TabIndex = 11;
            this.txtBxResponsibleInstitute.TextChanged += new System.EventHandler(this.TxtBxSubject_TextChanged);
            // 
            // cmbBxResponsibleTeacher
            // 
            this.cmbBxResponsibleTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxResponsibleTeacher.DropDownWidth = 200;
            this.cmbBxResponsibleTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBxResponsibleTeacher.FormattingEnabled = true;
            this.cmbBxResponsibleTeacher.Location = new System.Drawing.Point(203, 133);
            this.cmbBxResponsibleTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxResponsibleTeacher.Name = "cmbBxResponsibleTeacher";
            this.cmbBxResponsibleTeacher.Size = new System.Drawing.Size(265, 25);
            this.cmbBxResponsibleTeacher.TabIndex = 10;
            // 
            // txtBxRequirementType
            // 
            this.txtBxRequirementType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxRequirementType.Location = new System.Drawing.Point(203, 107);
            this.txtBxRequirementType.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxRequirementType.MaxLength = 30;
            this.txtBxRequirementType.Name = "txtBxRequirementType";
            this.txtBxRequirementType.Size = new System.Drawing.Size(265, 23);
            this.txtBxRequirementType.TabIndex = 9;
            this.txtBxRequirementType.TextChanged += new System.EventHandler(this.TxtBxSubject_TextChanged);
            // 
            // nmrcpDwnSubjectCredit
            // 
            this.nmrcpDwnSubjectCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmrcpDwnSubjectCredit.Location = new System.Drawing.Point(203, 81);
            this.nmrcpDwnSubjectCredit.Margin = new System.Windows.Forms.Padding(4);
            this.nmrcpDwnSubjectCredit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrcpDwnSubjectCredit.Name = "nmrcpDwnSubjectCredit";
            this.nmrcpDwnSubjectCredit.Size = new System.Drawing.Size(56, 23);
            this.nmrcpDwnSubjectCredit.TabIndex = 8;
            this.nmrcpDwnSubjectCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxSubjectName
            // 
            this.txtBxSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxSubjectName.Location = new System.Drawing.Point(203, 55);
            this.txtBxSubjectName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxSubjectName.MaxLength = 50;
            this.txtBxSubjectName.Name = "txtBxSubjectName";
            this.txtBxSubjectName.Size = new System.Drawing.Size(265, 23);
            this.txtBxSubjectName.TabIndex = 7;
            this.txtBxSubjectName.TextChanged += new System.EventHandler(this.TxtBxSubject_TextChanged);
            // 
            // txtBxSubjectCode
            // 
            this.txtBxSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxSubjectCode.Location = new System.Drawing.Point(203, 30);
            this.txtBxSubjectCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxSubjectCode.MaxLength = 12;
            this.txtBxSubjectCode.Name = "txtBxSubjectCode";
            this.txtBxSubjectCode.Size = new System.Drawing.Size(265, 23);
            this.txtBxSubjectCode.TabIndex = 6;
            this.txtBxSubjectCode.TextChanged += new System.EventHandler(this.TxtBxSubject_TextChanged);
            // 
            // lblResponsibleInstitute
            // 
            this.lblResponsibleInstitute.AutoSize = true;
            this.lblResponsibleInstitute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResponsibleInstitute.Location = new System.Drawing.Point(12, 169);
            this.lblResponsibleInstitute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponsibleInstitute.Name = "lblResponsibleInstitute";
            this.lblResponsibleInstitute.Size = new System.Drawing.Size(143, 17);
            this.lblResponsibleInstitute.TabIndex = 5;
            this.lblResponsibleInstitute.Text = "Responsible institute:";
            // 
            // lblResponsibleTeacher
            // 
            this.lblResponsibleTeacher.AutoSize = true;
            this.lblResponsibleTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResponsibleTeacher.Location = new System.Drawing.Point(12, 142);
            this.lblResponsibleTeacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponsibleTeacher.Name = "lblResponsibleTeacher";
            this.lblResponsibleTeacher.Size = new System.Drawing.Size(142, 17);
            this.lblResponsibleTeacher.TabIndex = 4;
            this.lblResponsibleTeacher.Text = "Responsible teacher:";
            // 
            // lblRequirementType
            // 
            this.lblRequirementType.AutoSize = true;
            this.lblRequirementType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRequirementType.Location = new System.Drawing.Point(12, 114);
            this.lblRequirementType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequirementType.Name = "lblRequirementType";
            this.lblRequirementType.Size = new System.Drawing.Size(124, 17);
            this.lblRequirementType.TabIndex = 3;
            this.lblRequirementType.Text = "Requirement type:";
            // 
            // lblSubjectCredit
            // 
            this.lblSubjectCredit.AutoSize = true;
            this.lblSubjectCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSubjectCredit.Location = new System.Drawing.Point(12, 87);
            this.lblSubjectCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectCredit.Name = "lblSubjectCredit";
            this.lblSubjectCredit.Size = new System.Drawing.Size(98, 17);
            this.lblSubjectCredit.TabIndex = 2;
            this.lblSubjectCredit.Text = "Subject credit:";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSubjectName.Location = new System.Drawing.Point(12, 60);
            this.lblSubjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(98, 17);
            this.lblSubjectName.TabIndex = 1;
            this.lblSubjectName.Text = "Subject name:";
            // 
            // lblSubjectCode
            // 
            this.lblSubjectCode.AutoSize = true;
            this.lblSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSubjectCode.Location = new System.Drawing.Point(12, 33);
            this.lblSubjectCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectCode.Name = "lblSubjectCode";
            this.lblSubjectCode.Size = new System.Drawing.Size(94, 17);
            this.lblSubjectCode.TabIndex = 0;
            this.lblSubjectCode.Text = "Subject code:";
            // 
            // lblSubjectTotalRecordNumber
            // 
            this.lblSubjectTotalRecordNumber.AutoSize = true;
            this.lblSubjectTotalRecordNumber.Location = new System.Drawing.Point(527, 326);
            this.lblSubjectTotalRecordNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectTotalRecordNumber.Name = "lblSubjectTotalRecordNumber";
            this.lblSubjectTotalRecordNumber.Size = new System.Drawing.Size(0, 16);
            this.lblSubjectTotalRecordNumber.TabIndex = 30;
            // 
            // txtBxActualRecordOfStudent
            // 
            this.txtBxActualRecordOfStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxActualRecordOfStudent.Location = new System.Drawing.Point(308, 688);
            this.txtBxActualRecordOfStudent.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxActualRecordOfStudent.Name = "txtBxActualRecordOfStudent";
            this.txtBxActualRecordOfStudent.Size = new System.Drawing.Size(132, 23);
            this.txtBxActualRecordOfStudent.TabIndex = 37;
            this.txtBxActualRecordOfStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxActualRecordOfStudent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBxActualRecordOfStudent_KeyUp);
            // 
            // bttnMoveToLastStudentRecord
            // 
            this.bttnMoveToLastStudentRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnMoveToLastStudentRecord.Location = new System.Drawing.Point(485, 687);
            this.bttnMoveToLastStudentRecord.Margin = new System.Windows.Forms.Padding(4);
            this.bttnMoveToLastStudentRecord.Name = "bttnMoveToLastStudentRecord";
            this.bttnMoveToLastStudentRecord.Size = new System.Drawing.Size(37, 28);
            this.bttnMoveToLastStudentRecord.TabIndex = 36;
            this.bttnMoveToLastStudentRecord.Text = ">|";
            this.bttnMoveToLastStudentRecord.UseVisualStyleBackColor = true;
            this.bttnMoveToLastStudentRecord.Click += new System.EventHandler(this.BtnMoveToStudentRecord_Click);
            // 
            // bttnMoveToNextStudentRecord
            // 
            this.bttnMoveToNextStudentRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnMoveToNextStudentRecord.Location = new System.Drawing.Point(449, 687);
            this.bttnMoveToNextStudentRecord.Margin = new System.Windows.Forms.Padding(4);
            this.bttnMoveToNextStudentRecord.Name = "bttnMoveToNextStudentRecord";
            this.bttnMoveToNextStudentRecord.Size = new System.Drawing.Size(37, 28);
            this.bttnMoveToNextStudentRecord.TabIndex = 35;
            this.bttnMoveToNextStudentRecord.Text = ">";
            this.bttnMoveToNextStudentRecord.UseVisualStyleBackColor = true;
            this.bttnMoveToNextStudentRecord.Click += new System.EventHandler(this.BtnMoveToStudentRecord_Click);
            // 
            // bttnMoveToPreviousStudentRecord
            // 
            this.bttnMoveToPreviousStudentRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnMoveToPreviousStudentRecord.Location = new System.Drawing.Point(263, 687);
            this.bttnMoveToPreviousStudentRecord.Margin = new System.Windows.Forms.Padding(4);
            this.bttnMoveToPreviousStudentRecord.Name = "bttnMoveToPreviousStudentRecord";
            this.bttnMoveToPreviousStudentRecord.Size = new System.Drawing.Size(37, 28);
            this.bttnMoveToPreviousStudentRecord.TabIndex = 34;
            this.bttnMoveToPreviousStudentRecord.Text = "<";
            this.bttnMoveToPreviousStudentRecord.UseVisualStyleBackColor = true;
            this.bttnMoveToPreviousStudentRecord.Click += new System.EventHandler(this.BtnMoveToStudentRecord_Click);
            // 
            // bttnMoveToFirstStudentRecord
            // 
            this.bttnMoveToFirstStudentRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnMoveToFirstStudentRecord.Location = new System.Drawing.Point(227, 687);
            this.bttnMoveToFirstStudentRecord.Margin = new System.Windows.Forms.Padding(4);
            this.bttnMoveToFirstStudentRecord.Name = "bttnMoveToFirstStudentRecord";
            this.bttnMoveToFirstStudentRecord.Size = new System.Drawing.Size(37, 28);
            this.bttnMoveToFirstStudentRecord.TabIndex = 33;
            this.bttnMoveToFirstStudentRecord.Text = "|<";
            this.bttnMoveToFirstStudentRecord.UseVisualStyleBackColor = true;
            this.bttnMoveToFirstStudentRecord.Click += new System.EventHandler(this.BtnMoveToStudentRecord_Click);
            // 
            // lblRowStudent
            // 
            this.lblRowStudent.AutoSize = true;
            this.lblRowStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRowStudent.Location = new System.Drawing.Point(184, 692);
            this.lblRowStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRowStudent.Name = "lblRowStudent";
            this.lblRowStudent.Size = new System.Drawing.Size(39, 17);
            this.lblRowStudent.TabIndex = 32;
            this.lblRowStudent.Text = "Row:";
            // 
            // dtGrdVwStudent
            // 
            this.dtGrdVwStudent.AllowUserToAddRows = false;
            this.dtGrdVwStudent.AllowUserToDeleteRows = false;
            this.dtGrdVwStudent.AllowUserToOrderColumns = true;
            this.dtGrdVwStudent.AllowUserToResizeColumns = false;
            this.dtGrdVwStudent.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdVwStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrdVwStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwStudent.Location = new System.Drawing.Point(16, 382);
            this.dtGrdVwStudent.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrdVwStudent.Name = "dtGrdVwStudent";
            this.dtGrdVwStudent.ReadOnly = true;
            this.dtGrdVwStudent.RowHeadersWidth = 51;
            this.dtGrdVwStudent.ShowCellErrors = false;
            this.dtGrdVwStudent.ShowCellToolTips = false;
            this.dtGrdVwStudent.ShowEditingIcon = false;
            this.dtGrdVwStudent.ShowRowErrors = false;
            this.dtGrdVwStudent.Size = new System.Drawing.Size(708, 292);
            this.dtGrdVwStudent.TabIndex = 31;
            this.dtGrdVwStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrdVwStudent_CellClick);
            this.dtGrdVwStudent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataGrdVwStudent_KeyUp);
            // 
            // grpBxSubjectFilter
            // 
            this.grpBxSubjectFilter.Controls.Add(this.txtBxSubjectPattern);
            this.grpBxSubjectFilter.Controls.Add(this.cmbBxSubjectFilterColumn);
            this.grpBxSubjectFilter.Controls.Add(this.lblSubjectPattern);
            this.grpBxSubjectFilter.Controls.Add(this.lblSubjectFilterColumn);
            this.grpBxSubjectFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBxSubjectFilter.Location = new System.Drawing.Point(741, 272);
            this.grpBxSubjectFilter.Margin = new System.Windows.Forms.Padding(4);
            this.grpBxSubjectFilter.Name = "grpBxSubjectFilter";
            this.grpBxSubjectFilter.Padding = new System.Windows.Forms.Padding(4);
            this.grpBxSubjectFilter.Size = new System.Drawing.Size(564, 79);
            this.grpBxSubjectFilter.TabIndex = 40;
            this.grpBxSubjectFilter.TabStop = false;
            this.grpBxSubjectFilter.Text = "Filter";
            // 
            // txtBxSubjectPattern
            // 
            this.txtBxSubjectPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxSubjectPattern.Location = new System.Drawing.Point(203, 44);
            this.txtBxSubjectPattern.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxSubjectPattern.MaxLength = 50;
            this.txtBxSubjectPattern.Name = "txtBxSubjectPattern";
            this.txtBxSubjectPattern.Size = new System.Drawing.Size(265, 23);
            this.txtBxSubjectPattern.TabIndex = 20;
            this.txtBxSubjectPattern.TextChanged += new System.EventHandler(this.TxtBxSubjectPattern_TextChanged);
            // 
            // cmbBxSubjectFilterColumn
            // 
            this.cmbBxSubjectFilterColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxSubjectFilterColumn.DropDownWidth = 200;
            this.cmbBxSubjectFilterColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBxSubjectFilterColumn.FormattingEnabled = true;
            this.cmbBxSubjectFilterColumn.Location = new System.Drawing.Point(203, 16);
            this.cmbBxSubjectFilterColumn.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxSubjectFilterColumn.Name = "cmbBxSubjectFilterColumn";
            this.cmbBxSubjectFilterColumn.Size = new System.Drawing.Size(265, 25);
            this.cmbBxSubjectFilterColumn.TabIndex = 20;
            // 
            // lblSubjectPattern
            // 
            this.lblSubjectPattern.AutoSize = true;
            this.lblSubjectPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSubjectPattern.Location = new System.Drawing.Point(12, 48);
            this.lblSubjectPattern.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectPattern.Name = "lblSubjectPattern";
            this.lblSubjectPattern.Size = new System.Drawing.Size(58, 17);
            this.lblSubjectPattern.TabIndex = 21;
            this.lblSubjectPattern.Text = "Pattern:";
            // 
            // lblSubjectFilterColumn
            // 
            this.lblSubjectFilterColumn.AutoSize = true;
            this.lblSubjectFilterColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSubjectFilterColumn.Location = new System.Drawing.Point(12, 20);
            this.lblSubjectFilterColumn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectFilterColumn.Name = "lblSubjectFilterColumn";
            this.lblSubjectFilterColumn.Size = new System.Drawing.Size(92, 17);
            this.lblSubjectFilterColumn.TabIndex = 20;
            this.lblSubjectFilterColumn.Text = "Filter column:";
            // 
            // grpBxStudentFilter
            // 
            this.grpBxStudentFilter.Controls.Add(this.txtBxStudentPattern);
            this.grpBxStudentFilter.Controls.Add(this.cmbBxStudentFilterColumn);
            this.grpBxStudentFilter.Controls.Add(this.lblStudentPattern);
            this.grpBxStudentFilter.Controls.Add(this.lblStudentFilterColumn);
            this.grpBxStudentFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBxStudentFilter.Location = new System.Drawing.Point(741, 693);
            this.grpBxStudentFilter.Margin = new System.Windows.Forms.Padding(4);
            this.grpBxStudentFilter.Name = "grpBxStudentFilter";
            this.grpBxStudentFilter.Padding = new System.Windows.Forms.Padding(4);
            this.grpBxStudentFilter.Size = new System.Drawing.Size(564, 79);
            this.grpBxStudentFilter.TabIndex = 42;
            this.grpBxStudentFilter.TabStop = false;
            this.grpBxStudentFilter.Text = "Filter";
            // 
            // txtBxStudentPattern
            // 
            this.txtBxStudentPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxStudentPattern.Location = new System.Drawing.Point(203, 44);
            this.txtBxStudentPattern.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxStudentPattern.MaxLength = 50;
            this.txtBxStudentPattern.Name = "txtBxStudentPattern";
            this.txtBxStudentPattern.Size = new System.Drawing.Size(265, 23);
            this.txtBxStudentPattern.TabIndex = 20;
            this.txtBxStudentPattern.TextChanged += new System.EventHandler(this.txtBxStudentPattern_TextChanged);
            // 
            // cmbBxStudentFilterColumn
            // 
            this.cmbBxStudentFilterColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxStudentFilterColumn.DropDownWidth = 200;
            this.cmbBxStudentFilterColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBxStudentFilterColumn.FormattingEnabled = true;
            this.cmbBxStudentFilterColumn.Location = new System.Drawing.Point(203, 16);
            this.cmbBxStudentFilterColumn.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxStudentFilterColumn.Name = "cmbBxStudentFilterColumn";
            this.cmbBxStudentFilterColumn.Size = new System.Drawing.Size(265, 25);
            this.cmbBxStudentFilterColumn.TabIndex = 20;
            // 
            // lblStudentPattern
            // 
            this.lblStudentPattern.AutoSize = true;
            this.lblStudentPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStudentPattern.Location = new System.Drawing.Point(12, 48);
            this.lblStudentPattern.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentPattern.Name = "lblStudentPattern";
            this.lblStudentPattern.Size = new System.Drawing.Size(58, 17);
            this.lblStudentPattern.TabIndex = 21;
            this.lblStudentPattern.Text = "Pattern:";
            // 
            // lblStudentFilterColumn
            // 
            this.lblStudentFilterColumn.AutoSize = true;
            this.lblStudentFilterColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStudentFilterColumn.Location = new System.Drawing.Point(12, 20);
            this.lblStudentFilterColumn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentFilterColumn.Name = "lblStudentFilterColumn";
            this.lblStudentFilterColumn.Size = new System.Drawing.Size(92, 17);
            this.lblStudentFilterColumn.TabIndex = 20;
            this.lblStudentFilterColumn.Text = "Filter column:";
            // 
            // grpBxStudentInput
            // 
            this.grpBxStudentInput.Controls.Add(this.cmbBxGender);
            this.grpBxStudentInput.Controls.Add(this.lblGender);
            this.grpBxStudentInput.Controls.Add(this.lblStreetMaxLength);
            this.grpBxStudentInput.Controls.Add(this.txtBxStreet);
            this.grpBxStudentInput.Controls.Add(this.lblStreet);
            this.grpBxStudentInput.Controls.Add(this.mskdTxtBxDateOfBirth);
            this.grpBxStudentInput.Controls.Add(this.lblSurnameMaxLength);
            this.grpBxStudentInput.Controls.Add(this.txtBxSurname);
            this.grpBxStudentInput.Controls.Add(this.cmbBxSubjectCodeBelongsToStudent);
            this.grpBxStudentInput.Controls.Add(this.bttnUpdateStudent);
            this.grpBxStudentInput.Controls.Add(this.bttnNewStudent);
            this.grpBxStudentInput.Controls.Add(this.bttnInsertStudent);
            this.grpBxStudentInput.Controls.Add(this.lblCityMaxLength);
            this.grpBxStudentInput.Controls.Add(this.lblFirstNameMaxLength);
            this.grpBxStudentInput.Controls.Add(this.lblNeptunCodeMaxLength);
            this.grpBxStudentInput.Controls.Add(this.txtBxCity);
            this.grpBxStudentInput.Controls.Add(this.txtBxFirstName);
            this.grpBxStudentInput.Controls.Add(this.txtBxNeptunCode);
            this.grpBxStudentInput.Controls.Add(this.lblCity);
            this.grpBxStudentInput.Controls.Add(this.lblDateOfBirth);
            this.grpBxStudentInput.Controls.Add(this.lblFirstName);
            this.grpBxStudentInput.Controls.Add(this.lblSurname);
            this.grpBxStudentInput.Controls.Add(this.lblSubjectCodeBelongsToStudent);
            this.grpBxStudentInput.Controls.Add(this.lblNeptunCode);
            this.grpBxStudentInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBxStudentInput.Location = new System.Drawing.Point(741, 382);
            this.grpBxStudentInput.Margin = new System.Windows.Forms.Padding(4);
            this.grpBxStudentInput.Name = "grpBxStudentInput";
            this.grpBxStudentInput.Padding = new System.Windows.Forms.Padding(4);
            this.grpBxStudentInput.Size = new System.Drawing.Size(564, 304);
            this.grpBxStudentInput.TabIndex = 41;
            this.grpBxStudentInput.TabStop = false;
            this.grpBxStudentInput.Text = "Enter Student";
            // 
            // cmbBxGender
            // 
            this.cmbBxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBxGender.FormattingEnabled = true;
            this.cmbBxGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbBxGender.Location = new System.Drawing.Point(203, 220);
            this.cmbBxGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxGender.MaxDropDownItems = 3;
            this.cmbBxGender.Name = "cmbBxGender";
            this.cmbBxGender.Size = new System.Drawing.Size(132, 25);
            this.cmbBxGender.TabIndex = 15;
            this.cmbBxGender.Text = "Female";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGender.Location = new System.Drawing.Point(12, 223);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender:";
            // 
            // lblStreetMaxLength
            // 
            this.lblStreetMaxLength.AutoSize = true;
            this.lblStreetMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStreetMaxLength.Location = new System.Drawing.Point(500, 197);
            this.lblStreetMaxLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreetMaxLength.Name = "lblStreetMaxLength";
            this.lblStreetMaxLength.Size = new System.Drawing.Size(46, 17);
            this.lblStreetMaxLength.TabIndex = 20;
            this.lblStreetMaxLength.Text = "(0/80)";
            // 
            // txtBxStreet
            // 
            this.txtBxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxStreet.Location = new System.Drawing.Point(203, 193);
            this.txtBxStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxStreet.MaxLength = 80;
            this.txtBxStreet.Name = "txtBxStreet";
            this.txtBxStreet.Size = new System.Drawing.Size(265, 23);
            this.txtBxStreet.TabIndex = 14;
            this.txtBxStreet.TextChanged += new System.EventHandler(this.TxtBxStudent_TextChanged);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStreet.Location = new System.Drawing.Point(12, 196);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(50, 17);
            this.lblStreet.TabIndex = 6;
            this.lblStreet.Text = "Street:";
            // 
            // mskdTxtBxDateOfBirth
            // 
            this.mskdTxtBxDateOfBirth.Culture = new System.Globalization.CultureInfo("en-GB");
            this.mskdTxtBxDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mskdTxtBxDateOfBirth.Location = new System.Drawing.Point(203, 139);
            this.mskdTxtBxDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.mskdTxtBxDateOfBirth.Mask = "00/00/0000";
            this.mskdTxtBxDateOfBirth.Name = "mskdTxtBxDateOfBirth";
            this.mskdTxtBxDateOfBirth.Size = new System.Drawing.Size(132, 23);
            this.mskdTxtBxDateOfBirth.TabIndex = 12;
            this.mskdTxtBxDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskdTxtBxDateOfBirth.ValidatingType = typeof(System.DateTime);
            this.mskdTxtBxDateOfBirth.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.MskdTxtBxDateOfBirth_TypeValidationCompleted);
            // 
            // lblSurnameMaxLength
            // 
            this.lblSurnameMaxLength.AutoSize = true;
            this.lblSurnameMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSurnameMaxLength.Location = new System.Drawing.Point(500, 87);
            this.lblSurnameMaxLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurnameMaxLength.Name = "lblSurnameMaxLength";
            this.lblSurnameMaxLength.Size = new System.Drawing.Size(46, 17);
            this.lblSurnameMaxLength.TabIndex = 17;
            this.lblSurnameMaxLength.Text = "(0/20)";
            // 
            // txtBxSurname
            // 
            this.txtBxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxSurname.Location = new System.Drawing.Point(203, 85);
            this.txtBxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxSurname.MaxLength = 20;
            this.txtBxSurname.Name = "txtBxSurname";
            this.txtBxSurname.Size = new System.Drawing.Size(265, 23);
            this.txtBxSurname.TabIndex = 10;
            this.txtBxSurname.TextChanged += new System.EventHandler(this.TxtBxStudent_TextChanged);
            // 
            // cmbBxSubjectCodeBelongsToStudent
            // 
            this.cmbBxSubjectCodeBelongsToStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxSubjectCodeBelongsToStudent.DropDownWidth = 200;
            this.cmbBxSubjectCodeBelongsToStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBxSubjectCodeBelongsToStudent.FormattingEnabled = true;
            this.cmbBxSubjectCodeBelongsToStudent.Location = new System.Drawing.Point(203, 57);
            this.cmbBxSubjectCodeBelongsToStudent.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxSubjectCodeBelongsToStudent.Name = "cmbBxSubjectCodeBelongsToStudent";
            this.cmbBxSubjectCodeBelongsToStudent.Size = new System.Drawing.Size(265, 25);
            this.cmbBxSubjectCodeBelongsToStudent.TabIndex = 9;
            // 
            // bttnUpdateStudent
            // 
            this.bttnUpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnUpdateStudent.Location = new System.Drawing.Point(203, 263);
            this.bttnUpdateStudent.Margin = new System.Windows.Forms.Padding(4);
            this.bttnUpdateStudent.Name = "bttnUpdateStudent";
            this.bttnUpdateStudent.Size = new System.Drawing.Size(87, 28);
            this.bttnUpdateStudent.TabIndex = 23;
            this.bttnUpdateStudent.Text = "Update";
            this.bttnUpdateStudent.UseVisualStyleBackColor = true;
            this.bttnUpdateStudent.Click += new System.EventHandler(this.BtnUpdateStudent_Click);
            // 
            // bttnNewStudent
            // 
            this.bttnNewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnNewStudent.Location = new System.Drawing.Point(292, 263);
            this.bttnNewStudent.Margin = new System.Windows.Forms.Padding(4);
            this.bttnNewStudent.Name = "bttnNewStudent";
            this.bttnNewStudent.Size = new System.Drawing.Size(87, 28);
            this.bttnNewStudent.TabIndex = 22;
            this.bttnNewStudent.Text = "New";
            this.bttnNewStudent.UseVisualStyleBackColor = true;
            this.bttnNewStudent.Click += new System.EventHandler(this.BtnNewStudent_Click);
            // 
            // bttnInsertStudent
            // 
            this.bttnInsertStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnInsertStudent.Location = new System.Drawing.Point(381, 263);
            this.bttnInsertStudent.Margin = new System.Windows.Forms.Padding(4);
            this.bttnInsertStudent.Name = "bttnInsertStudent";
            this.bttnInsertStudent.Size = new System.Drawing.Size(87, 28);
            this.bttnInsertStudent.TabIndex = 21;
            this.bttnInsertStudent.Text = "Insert";
            this.bttnInsertStudent.UseVisualStyleBackColor = true;
            this.bttnInsertStudent.Click += new System.EventHandler(this.BtnInsertStudent_Click);
            // 
            // lblCityMaxLength
            // 
            this.lblCityMaxLength.AutoSize = true;
            this.lblCityMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCityMaxLength.Location = new System.Drawing.Point(500, 170);
            this.lblCityMaxLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCityMaxLength.Name = "lblCityMaxLength";
            this.lblCityMaxLength.Size = new System.Drawing.Size(46, 17);
            this.lblCityMaxLength.TabIndex = 19;
            this.lblCityMaxLength.Text = "(0/20)";
            // 
            // lblFirstNameMaxLength
            // 
            this.lblFirstNameMaxLength.AutoSize = true;
            this.lblFirstNameMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstNameMaxLength.Location = new System.Drawing.Point(500, 116);
            this.lblFirstNameMaxLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstNameMaxLength.Name = "lblFirstNameMaxLength";
            this.lblFirstNameMaxLength.Size = new System.Drawing.Size(46, 17);
            this.lblFirstNameMaxLength.TabIndex = 18;
            this.lblFirstNameMaxLength.Text = "(0/20)";
            // 
            // lblNeptunCodeMaxLength
            // 
            this.lblNeptunCodeMaxLength.AutoSize = true;
            this.lblNeptunCodeMaxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNeptunCodeMaxLength.Location = new System.Drawing.Point(500, 33);
            this.lblNeptunCodeMaxLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNeptunCodeMaxLength.Name = "lblNeptunCodeMaxLength";
            this.lblNeptunCodeMaxLength.Size = new System.Drawing.Size(38, 17);
            this.lblNeptunCodeMaxLength.TabIndex = 16;
            this.lblNeptunCodeMaxLength.Text = "(0/6)";
            // 
            // txtBxCity
            // 
            this.txtBxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxCity.Location = new System.Drawing.Point(203, 166);
            this.txtBxCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxCity.MaxLength = 20;
            this.txtBxCity.Name = "txtBxCity";
            this.txtBxCity.Size = new System.Drawing.Size(265, 23);
            this.txtBxCity.TabIndex = 13;
            this.txtBxCity.TextChanged += new System.EventHandler(this.TxtBxStudent_TextChanged);
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxFirstName.Location = new System.Drawing.Point(203, 112);
            this.txtBxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxFirstName.MaxLength = 20;
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(265, 23);
            this.txtBxFirstName.TabIndex = 11;
            this.txtBxFirstName.TextChanged += new System.EventHandler(this.TxtBxStudent_TextChanged);
            // 
            // txtBxNeptunCode
            // 
            this.txtBxNeptunCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBxNeptunCode.Location = new System.Drawing.Point(203, 30);
            this.txtBxNeptunCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxNeptunCode.MaxLength = 6;
            this.txtBxNeptunCode.Name = "txtBxNeptunCode";
            this.txtBxNeptunCode.Size = new System.Drawing.Size(265, 23);
            this.txtBxNeptunCode.TabIndex = 8;
            this.txtBxNeptunCode.TextChanged += new System.EventHandler(this.TxtBxStudent_TextChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCity.Location = new System.Drawing.Point(12, 169);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 17);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(12, 142);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(91, 17);
            this.lblDateOfBirth.TabIndex = 4;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstName.Location = new System.Drawing.Point(12, 114);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 17);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSurname.Location = new System.Drawing.Point(12, 87);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 17);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // lblSubjectCodeBelongsToStudent
            // 
            this.lblSubjectCodeBelongsToStudent.AutoSize = true;
            this.lblSubjectCodeBelongsToStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSubjectCodeBelongsToStudent.Location = new System.Drawing.Point(12, 60);
            this.lblSubjectCodeBelongsToStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectCodeBelongsToStudent.Name = "lblSubjectCodeBelongsToStudent";
            this.lblSubjectCodeBelongsToStudent.Size = new System.Drawing.Size(94, 17);
            this.lblSubjectCodeBelongsToStudent.TabIndex = 1;
            this.lblSubjectCodeBelongsToStudent.Text = "Subject code:";
            // 
            // lblNeptunCode
            // 
            this.lblNeptunCode.AutoSize = true;
            this.lblNeptunCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNeptunCode.Location = new System.Drawing.Point(12, 33);
            this.lblNeptunCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNeptunCode.Name = "lblNeptunCode";
            this.lblNeptunCode.Size = new System.Drawing.Size(93, 17);
            this.lblNeptunCode.TabIndex = 0;
            this.lblNeptunCode.Text = "Neptun code:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblTotalRecordNumberOfStudent
            // 
            this.lblTotalRecordNumberOfStudent.AutoSize = true;
            this.lblTotalRecordNumberOfStudent.Location = new System.Drawing.Point(528, 693);
            this.lblTotalRecordNumberOfStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRecordNumberOfStudent.Name = "lblTotalRecordNumberOfStudent";
            this.lblTotalRecordNumberOfStudent.Size = new System.Drawing.Size(0, 16);
            this.lblTotalRecordNumberOfStudent.TabIndex = 44;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 784);
            this.Controls.Add(this.lblTotalRecordNumberOfStudent);
            this.Controls.Add(this.grpBxStudentFilter);
            this.Controls.Add(this.grpBxSubjectFilter);
            this.Controls.Add(this.grpBxStudentInput);
            this.Controls.Add(this.txtBxActualRecordOfStudent);
            this.Controls.Add(this.bttnMoveToLastStudentRecord);
            this.Controls.Add(this.bttnMoveToNextStudentRecord);
            this.Controls.Add(this.bttnMoveToPreviousStudentRecord);
            this.Controls.Add(this.bttnMoveToFirstStudentRecord);
            this.Controls.Add(this.lblRowStudent);
            this.Controls.Add(this.dtGrdVwStudent);
            this.Controls.Add(this.lblSubjectTotalRecordNumber);
            this.Controls.Add(this.grpBxSubjectInput);
            this.Controls.Add(this.lblTotalRecordNumberOfSubject);
            this.Controls.Add(this.txtBxActualRecordOfSubject);
            this.Controls.Add(this.bttnMoveToLastSubjectRecord);
            this.Controls.Add(this.bttnMoveToNextSubjectRecord);
            this.Controls.Add(this.bttnMoveToPreviousSubjectRecord);
            this.Controls.Add(this.bttnMoveToFirstSubjectRecord);
            this.Controls.Add(this.lblRowSubject);
            this.Controls.Add(this.dtGrdVwSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Manager";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwSubject)).EndInit();
            this.grpBxSubjectInput.ResumeLayout(false);
            this.grpBxSubjectInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcpDwnSubjectCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwStudent)).EndInit();
            this.grpBxSubjectFilter.ResumeLayout(false);
            this.grpBxSubjectFilter.PerformLayout();
            this.grpBxStudentFilter.ResumeLayout(false);
            this.grpBxStudentFilter.PerformLayout();
            this.grpBxStudentInput.ResumeLayout(false);
            this.grpBxStudentInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdVwSubject;
        private System.Windows.Forms.Label lblTotalRecordNumberOfSubject;
        private System.Windows.Forms.TextBox txtBxActualRecordOfSubject;
        private System.Windows.Forms.Button bttnMoveToLastSubjectRecord;
        private System.Windows.Forms.Button bttnMoveToNextSubjectRecord;
        private System.Windows.Forms.Button bttnMoveToPreviousSubjectRecord;
        private System.Windows.Forms.Button bttnMoveToFirstSubjectRecord;
        private System.Windows.Forms.Label lblRowSubject;
        private System.Windows.Forms.GroupBox grpBxSubjectInput;
        private System.Windows.Forms.Label lblResponsibleInstitute;
        private System.Windows.Forms.Label lblResponsibleTeacher;
        private System.Windows.Forms.Label lblRequirementType;
        private System.Windows.Forms.Label lblSubjectCredit;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label lblSubjectCode;
        private System.Windows.Forms.TextBox txtBxSubjectCode;
        private System.Windows.Forms.TextBox txtBxSubjectName;
        private System.Windows.Forms.NumericUpDown nmrcpDwnSubjectCredit;
        private System.Windows.Forms.TextBox txtBxRequirementType;
        private System.Windows.Forms.ComboBox cmbBxResponsibleTeacher;
        private System.Windows.Forms.TextBox txtBxResponsibleInstitute;
        private System.Windows.Forms.Label lblSubjectCodeMaxLength;
        private System.Windows.Forms.Label lblSubjectNameMaxLength;
        private System.Windows.Forms.Label lblCreditInformation;
        private System.Windows.Forms.Label lblRequirementTypeMaxLength;
        private System.Windows.Forms.Label lblResponsibleInstituteMaxLength;
        private System.Windows.Forms.Button bttnInsertSubject;
        private System.Windows.Forms.Button bttnNewSubject;
        private System.Windows.Forms.Button bttnUpdateSubject;
        private System.Windows.Forms.Label lblSubjectTotalRecordNumber;
        private System.Windows.Forms.TextBox txtBxActualRecordOfStudent;
        private System.Windows.Forms.Button bttnMoveToLastStudentRecord;
        private System.Windows.Forms.Button bttnMoveToNextStudentRecord;
        private System.Windows.Forms.Button bttnMoveToPreviousStudentRecord;
        private System.Windows.Forms.Button bttnMoveToFirstStudentRecord;
        private System.Windows.Forms.Label lblRowStudent;
        private System.Windows.Forms.DataGridView dtGrdVwStudent;
        private System.Windows.Forms.GroupBox grpBxSubjectFilter;
        private System.Windows.Forms.Label lblSubjectPattern;
        private System.Windows.Forms.Label lblSubjectFilterColumn;
        private System.Windows.Forms.TextBox txtBxSubjectPattern;
        private System.Windows.Forms.ComboBox cmbBxSubjectFilterColumn;
        private System.Windows.Forms.GroupBox grpBxStudentFilter;
        private System.Windows.Forms.TextBox txtBxStudentPattern;
        private System.Windows.Forms.ComboBox cmbBxStudentFilterColumn;
        private System.Windows.Forms.Label lblStudentPattern;
        private System.Windows.Forms.Label lblStudentFilterColumn;
        private System.Windows.Forms.GroupBox grpBxStudentInput;
        private System.Windows.Forms.Button bttnUpdateStudent;
        private System.Windows.Forms.Button bttnNewStudent;
        private System.Windows.Forms.Button bttnInsertStudent;
        private System.Windows.Forms.Label lblCityMaxLength;
        private System.Windows.Forms.Label lblFirstNameMaxLength;
        private System.Windows.Forms.Label lblNeptunCodeMaxLength;
        private System.Windows.Forms.TextBox txtBxCity;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.TextBox txtBxNeptunCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblSubjectCodeBelongsToStudent;
        private System.Windows.Forms.Label lblNeptunCode;
        private System.Windows.Forms.ComboBox cmbBxSubjectCodeBelongsToStudent;
        private System.Windows.Forms.TextBox txtBxSurname;
        private System.Windows.Forms.Label lblSurnameMaxLength;
        private System.Windows.Forms.MaskedTextBox mskdTxtBxDateOfBirth;
        private System.Windows.Forms.Label lblStreetMaxLength;
        private System.Windows.Forms.TextBox txtBxStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbBxGender;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblTotalRecordNumberOfStudent;
    }
}

