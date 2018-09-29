using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHubDAL.Access
{
    public class DalAccess
    {
        

            public DataTable AccessTab = new DataTable();
            private SqlConnection connection = new SqlConnection();

            private SqlDataAdapter adapter;
            private string AdapterConnStr = @"Data Source=ACUPC-208;Initial Catalog=NotificationHub;Integrated Security=True";

            public DataTable GetAccessTable(string pSearchName)
            {
                connection.ConnectionString = AdapterConnStr;

                string sql1 = string.Format("select u.UserName,r.Name,u.Id from AspNetUsers u left outer join AspNetUserRoles ur on u.Id=ur.UserId left outer join AspNetRoles r on ur.RoleId = r.Id and u.Id like '%{0}%'", pSearchName);
                adapter = new SqlDataAdapter(sql1, connection);
           
            
            adapter.Fill(AccessTab);
                return AccessTab;
            }
        
    }
}
