using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    public static class ConnectionLayer
    {
        public static DataAccessLayer dataAccessLayer = new DataAccessLayer(ConfigurationManager.ConnectionStrings["smDB"].ConnectionString);
    }
}
