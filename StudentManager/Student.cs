using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    internal class Student
    {
        public int Id { get; set; }
        public string NeptunCode { get; set; }
        public string SubjectCode { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Gender { get; set; }


        public DataTable GetStudents()
        {
            return ConnectionLayer.dataAccessLayer.GetDataTable("SELECT st.ID,st.NeptunCode AS[Neptun code], su.SubjectCode AS[Subject code], st.LastName AS[Lastname], " +
                "st.FirstName AS[First name], FORMAT(st.BirthDate, 'dd/MM/yyyy ') AS[BirthDate], st.City, st.Street, st.Gender FROM Student st " +
                "JOIN Subject su ON su.ID = st.SubjectCode", CommandType.Text);
        }
    }
}
