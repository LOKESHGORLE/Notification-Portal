using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class SourecDal
    {
        public List<Source> Sourceslist = new List<Source>();
        public List<TemplateAccess> templateslist = new List<TemplateAccess>();

        public List<Source> GetSources()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source =.; Initial Catalog = NHUB; Integrated Security = True";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("SourceProc", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "SELECT";
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        Sourceslist.Add(new Source
                        {

                            Id = Convert.ToInt32(sqlDataReader["Id"].ToString()),
                            Name = (sqlDataReader["Name"].ToString()),
                        });

                    }
                }
            }
            return Sourceslist;





        }

   







        public void Entersource(string Name)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=.;Initial Catalog=NHUB;Integrated Security=True";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("insertproc", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "INSERT";
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = Name;

                sqlCommand.ExecuteNonQuery();

            }
        }

        public void Delete(int Id)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=.;Initial Catalog=NHUB;Integrated Security=True";
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("delproc", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "DELETE";

                sqlCommand.Parameters.Add("@Id", SqlDbType.Int, 5).Value = Id;

                sqlCommand.ExecuteNonQuery();



            }
        }

        public void Edit(int Id, string Name)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=.;Initial Catalog=NHUB;Integrated Security=True";
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("EditProc", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "EDIT";

                sqlCommand.Parameters.Add("@Id", SqlDbType.Int, 5).Value = Id;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = Name;

                sqlCommand.ExecuteNonQuery();


            }

        }


        //-------------------------------------------------------------Approval-----------------------------------
        public List<TemplateAccess> GetTemplates()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source =.; Initial Catalog = NHUB; Integrated Security = True";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("DisplayAccessproc", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "SELECT";
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        templateslist.Add(new TemplateAccess
                        { Id = Convert.ToInt32(sqlDataReader["Id"].ToString()),
                            TemplateName = (sqlDataReader["Name"].ToString()),
                            OperationManager = (sqlDataReader["UserName"].ToString()),


                            //Id = Convert.ToInt32(sqlDataReader["Id"].ToString()),
                            //Name = (sqlDataReader["Name"].ToString()),
                        });

                    }
                }
            }
            return templateslist;





        }

        //-----------------------------------------------
        public void TempUpdate(int Id)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=.;Initial Catalog=NHUB;Integrated Security=True";
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("UpdateTemp", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "Approved";

                sqlCommand.Parameters.Add("@Id", SqlDbType.Int, 5).Value = Id;
                sqlCommand.ExecuteNonQuery();


            }

        }

        //---------------------------------------------- Decline
        public void TempDecline(int Id)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=.;Initial Catalog=NHUB;Integrated Security=True";
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("UpdateTemp", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "Declined";

                sqlCommand.Parameters.Add("@Id", SqlDbType.Int, 5).Value = Id;
                sqlCommand.ExecuteNonQuery();


            }

        }

        //-----------------------------------------------------------accepted and declined

        public List<TemplateAccess> GetApproved()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source =.; Initial Catalog = NHUB; Integrated Security = True";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("DisplayApproved", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "SELECT";
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        templateslist.Add(new TemplateAccess
                        {
                            Id = Convert.ToInt32(sqlDataReader["Id"].ToString()),
                            TemplateName = (sqlDataReader["Name"].ToString()),
                            OperationManager = (sqlDataReader["UserName"].ToString()),


                            //Id = Convert.ToInt32(sqlDataReader["Id"].ToString()),
                            //Name = (sqlDataReader["Name"].ToString()),
                        });

                    }
                }
            }
            return templateslist;





        }


        //-------------------------------------------------------------------------------------------

        public List<TemplateAccess> GetDeclined()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source =.; Initial Catalog = NHUB; Integrated Security = True";
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("DisplayDeclined", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Action", SqlDbType.VarChar, 10).Value = "SELECT";
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        templateslist.Add(new TemplateAccess
                        {
                            Id = Convert.ToInt32(sqlDataReader["Id"].ToString()),
                            TemplateName = (sqlDataReader["Name"].ToString()),
                            OperationManager = (sqlDataReader["UserName"].ToString()),


                            //Id = Convert.ToInt32(sqlDataReader["Id"].ToString()),
                            //Name = (sqlDataReader["Name"].ToString()),
                        });

                    }
                }
            }
            return templateslist;





        }







    }
}
