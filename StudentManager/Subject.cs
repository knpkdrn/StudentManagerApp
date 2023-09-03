using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int Credit { get; set; }
        public string TypeOfSubjectRequirement { get; set; }
        public string TeacherId { get; set; }
        public string InstitueResponsibleForTheSubject { get; set; }

        public DataTable GetSubjects()
        {
            return ConnectionLayer.dataAccessLayer.GetDataTable("SELECT s.ID,s.SubjectCode AS[Subject code], s.SubjectName AS[Subject name], s.Credit AS Credit," +
                "s.TypeOfSubjectRequirement AS[Requirement type], t.Name AS Teacher,s.InstituteResponsibleForTheSubject AS Institute FROM Subject s " +
                "JOIN Teacher t ON t.ID = s.TeacherID", CommandType.Text);
        }
    }
}
