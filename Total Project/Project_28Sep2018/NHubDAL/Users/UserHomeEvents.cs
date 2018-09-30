using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHubDAL.Users
{
   public  class UserHomeEvents
    {
        public DataTable UserEventsTab = new DataTable();
        private SqlConnection connection = new SqlConnection();

        private SqlDataAdapter adapter;
        private string AdapterConnStr = @"Data Source=ACUPC-208;Initial Catalog=NotificationHub;Integrated Security=True";

        public DataTable GetEventsTable(string pSearchUserId)
        {
            connection.ConnectionString = AdapterConnStr;

            string sql1 = "select ev.Id, ev.Name from Event_slm_subscribe_users evu join Event_slm_subscribe evslm on evu.Event_slm_subscribe_Id=evslm.Id join Event ev on ev.Id = evslm.EventId where evu.UserId ='"+ pSearchUserId+"'";
            adapter = new SqlDataAdapter(sql1, connection);


            adapter.Fill(UserEventsTab);
            return UserEventsTab;
        }
    }
}
