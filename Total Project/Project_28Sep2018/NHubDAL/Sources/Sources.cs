using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHubDAL.Model;
using System.Data;
using System.Data.SqlClient;

namespace NHubDAL.Sources
{
    public class Sources
    {
        public List<SourcesModel> SourcesList = new List<SourcesModel>();

        public List<SourcesModel> GetSources(string pSearchObj, string pQueryID)
        {
            string Search = string.IsNullOrEmpty(pSearchObj) ? "%" : pSearchObj;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=ACUPC-208;Initial Catalog=NotificationHub;Integrated Security=True";
                connection.Open();
                string sql;
                
                if (pQueryID == "0")
                {
                    sql = "select * from Sources where ID =" + pSearchObj;
                }
                else
                {
                    sql = string.Format("select * from Sources where Name like '%{0}%'", Search);
                }



                SqlCommand mycommand = new SqlCommand(sql, connection);

                using (SqlDataReader myDataReader = mycommand.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        SourcesList.Add(new SourcesModel
                        {
                            Name = myDataReader["Name"].ToString(),
                            
                        });

                    }
                }
                return SourcesList;

            }
        }
    }
    public class InventoryAdapter
    {

        public DataTable SourcesTable = new DataTable();
        private SqlConnection connection = new SqlConnection();

        private SqlDataAdapter adapter;
        private string AdapterConnStr = @"Data Source=ACUPC-208;Initial Catalog=NotificationHub;Integrated Security=True";

        public DataTable GetSourcesTable(string pSearchName)
        {
            connection.ConnectionString = AdapterConnStr;
           
            string sql = string.Format("select * from Sources where Name like '%{0}%'", pSearchName);
            adapter = new SqlDataAdapter(sql, connection);



            adapter.Fill(SourcesTable);
            return SourcesTable;
        }
    }
}
