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
        public List<SourcesModel> products = new List<SourcesModel>();

        public List<SourcesModel> GetProductList(string pSearchObj, string pQueryID)
        {
            string Search = string.IsNullOrEmpty(pSearchObj) ? "%" : pSearchObj;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=ACUPC-208;Initial Catalog=Proj;Integrated Security=True";
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
                        products.Add(new SourcesModel
                        {
                            Name = myDataReader["Name"].ToString(),
                            
                        });

                    }
                }
                return products;

            }
        }
    }
    public class InventoryAdapter
    {

        public DataTable ProdTable = new DataTable();
        private SqlConnection connection = new SqlConnection();

        private SqlDataAdapter adapter;
        private string AdapterConnStr = @"Data Source=ACUPC-208;Initial Catalog=Proj;Integrated Security=True";

        public DataTable GetProductTable(string pSearchName)
        {
            connection.ConnectionString = AdapterConnStr;
           
            string sql = string.Format("select * from Sources where Name like '%{0}%'", pSearchName);
            adapter = new SqlDataAdapter(sql, connection);



            adapter.Fill(ProdTable);
            return ProdTable;
        }
    }
}
