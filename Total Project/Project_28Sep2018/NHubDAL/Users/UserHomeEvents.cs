using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHubDAL.Users
{
    public class UserHomeEvents
    {
        public DataSet UserEventsTab = new DataSet();
        public DataTable EventChannelTab = new DataTable();
        private SqlConnection connection = new SqlConnection();

        private SqlDataAdapter adapter;
        private string AdapterConnStr = @"Data Source=ACUPC-208;Initial Catalog=NotificationHub;Integrated Security=True";

        public DataSet GetEventsTable(string pSearchUserId)
        {
            connection.ConnectionString = AdapterConnStr;

            DataTable Ctb = new DataTable();
            UserEventsTab.Tables.Add(Ctb);

            DataTable Etb = new DataTable();
            UserEventsTab.Tables.Add(Etb);

            string sql = "select * from channel";
            adapter = new SqlDataAdapter(sql, connection);
            adapter.Fill(UserEventsTab.Tables[0]);

            string sql1 = "select ev.Id, ev.Name,evu.Event_slm_subscribe_Id from Event_slm_subscribe_users evu join Event_slm_subscribe evslm on evu.Event_slm_subscribe_Id=evslm.Id join Event ev on ev.Id = evslm.EventId where evu.UserId ='" + pSearchUserId + "'";
            adapter = new SqlDataAdapter(sql1, connection);


            adapter.Fill(UserEventsTab.Tables[1]);
            return UserEventsTab;
        }
        public DataTable GetEventChannels(string pEventSlmId)
        {
            connection.ConnectionString = AdapterConnStr;
            string sql = "select c.Id,c.Name from Event_slm_subscribe_channel essc,channel c where essc.ChannelId=c.Id and essc.Event_slm_subscribe_Id=" + pEventSlmId;
            adapter = new SqlDataAdapter(sql, connection);


            adapter.Fill(EventChannelTab);
            return EventChannelTab;
        }
        public void InsertMyEventsChannel(string pUserId, int pEventId, string pChannelIds)
        {
            connection.ConnectionString = @"Data Source=ACUPC-208;Initial Catalog=NotificationHub;Integrated Security=True";
            connection.Open();

            using (SqlCommand command1 = new SqlCommand("PROC_DeletemyEventChannel", connection))
            {
                command1.CommandType = CommandType.StoredProcedure;
                {
                    SqlParameter parUserId = new SqlParameter
                    {
                        ParameterName = "@pUserId",
                        SqlDbType = SqlDbType.Char,
                        Value = pUserId,
                        Direction = ParameterDirection.Input
                    };
                    command1.Parameters.Add(parUserId);
                    SqlParameter parEventId = new SqlParameter
                    {
                        ParameterName = "@pEventId",
                        SqlDbType = SqlDbType.Int,
                        Value = pEventId,
                        Direction = ParameterDirection.Input
                    };
                    command1.Parameters.Add(parEventId);
                    command1.ExecuteNonQuery();
                }
            }
                string[] ChIds = pChannelIds.Split(',');
            foreach (string ch in ChIds)
            {
                int id = Convert.ToInt32(ch);
                using (SqlCommand command = new SqlCommand("PROC_InsertmyEventChannel", connection))
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
                    SqlParameter parEventId = new SqlParameter
                    {
                        ParameterName = "@pEventId",
                        SqlDbType = SqlDbType.Int,
                        Value = pEventId,
                        Direction = ParameterDirection.Input
                    };
                    command.Parameters.Add(parEventId);
                    SqlParameter parChannelIds = new SqlParameter
                    {
                        ParameterName = "@pChannelId",
                        SqlDbType = SqlDbType.Int,
                        Value = id,
                        Direction = ParameterDirection.Input
                    };
                    command.Parameters.Add(parChannelIds);
                    command.ExecuteNonQuery();

                }
            }
            connection.Close();

        }
    }
}
