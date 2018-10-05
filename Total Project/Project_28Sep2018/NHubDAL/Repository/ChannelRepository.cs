using NHubDAL.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHubDAL.Repository
{
    public class ChannelRepository
    {

        SqlConnection DefaultConnection;
        public List<Channel> GetChannel()
        {
            List<Channel> ChannelList = new List<Channel>();
            using (DefaultConnection = new SqlConnection(Utilities.CONNECTIONSTRING))
            {
                string sql = "Select * From Channel"; //Avoid select stmts, instead use procs
                SqlCommand myCommand = new SqlCommand(sql, DefaultConnection);
                Channel b;

                using (SqlDataReader dr = myCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        b = new Channel
                        {
                            ChannelId = Convert.ToInt32(dr["Id"].ToString()),
                            ChannelName = dr["Name"].ToString()
                        };
                        ChannelList.Add(b);
                    }
                }
            }
            return ChannelList;
        }

    }
}
