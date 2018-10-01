using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHubDAL.Roles
{
    public class DalRoles
    {
        public DataTable RolesTab = new DataTable();
        private SqlConnection connection = new SqlConnection();

        private SqlDataAdapter adapter;
        private string AdapterConnStr = @"Data Source=ACUPC-208;Initial Catalog=NotificationHub;Integrated Security=True";

        public DataTable GetRolesTable(string pSearchName)
        {
            connection.ConnectionString = AdapterConnStr;
            string sql1 = "select * from  AspNetRoles";
            //string sql1 = string.Format("select r.name from  AspNetRoles r where r.name like '%{0}%'", pSearchName);
            adapter = new SqlDataAdapter(sql1, connection);


            adapter.Fill(RolesTab);
            return RolesTab;
        }
        public void AssignRoles(string pUserId, string pRoleId)
        {
            connection.ConnectionString = @"Data Source=ACUPC-208;Initial Catalog=NotificationHub;Integrated Security=True";
            connection.Open();

            using (SqlCommand command = new SqlCommand("Proc_DeleteRoles", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                // Input param.
                SqlParameter parUserId = new SqlParameter
                {
                    ParameterName = "@pUserId",
                    SqlDbType = SqlDbType.Char,
                    Value = pUserId,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parUserId);
                command.ExecuteNonQuery();
            }

                using (SqlCommand command = new SqlCommand("Proc_AssignRoles", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                // Input param.
                SqlParameter parUserId = new SqlParameter
                {
                    ParameterName = "@pUserId",
                    SqlDbType = SqlDbType.Char,
                    Value = pUserId,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parUserId);
                SqlParameter parRoleId = new SqlParameter
                {
                    ParameterName = "@pRoleId",
                    SqlDbType = SqlDbType.Char,
                    Value = pRoleId,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parRoleId);

                command.ExecuteNonQuery();
                // OutStatus = (string)command.Parameters["@pStatus"].Value;

            }
            connection.Close();
            //return OutStatus;
        }

    }
    
}
