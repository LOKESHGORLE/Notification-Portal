using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHubDAL
{
    static class Utilities
    {
        public static string CONNECTIONSTRING = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString.ToString();

        public static string ACTION_SELECT = "SELECT";
    }
}
