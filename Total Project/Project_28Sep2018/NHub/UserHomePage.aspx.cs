using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHubDAL.Users;
using Microsoft.AspNet.Identity;

namespace NHub
{
    public partial class UserHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            UserHomeEvents UserEvents = new UserHomeEvents();
            GridView1.DataSource = UserEvents.GetEventsTable(Context.User.Identity.GetUserId());
           
            GridView1.DataBind();
           
        }

        protected void UserEventsGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int ChannelId= GridView1.;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GridView1.Columns[3].
        }

    }
}