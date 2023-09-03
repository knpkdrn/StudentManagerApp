using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    public class Teachers
    {
        public DataTable GetTeachers()
        {
            return ConnectionLayer.dataAccessLayer.GetDataTable("SELECT NeptunCode AS[Neptun code], Name, BirthDate AS[Birth date], City, Street, Gender FROM Teacher", 
                CommandType.Text);
        }

    }
}
