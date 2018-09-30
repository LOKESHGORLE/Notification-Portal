using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHubDAL.Users;

namespace NHub
{
    public partial class HomeEventsUpdate : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string Act = Request.QueryString["Act"];
            string EvId = Request.QueryString["EventId"];

            ConfirmMsg.Text = "Do you want to Update?";
            UserHomeEvents uh = new UserHomeEvents();
            uh.GetEventChannels(EvId);

            ChannelCheckBoxList.DataSource = uh.EventChannelTab;
            ChannelCheckBoxList.DataTextField = "Name";
            ChannelCheckBoxList.DataValueField = "Id";
            ChannelCheckBoxList.DataBind();


        }

        

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(~/UHE1.aspx);
        }

        protected void Subscribe_Click(object sender, EventArgs e)
        {
            string EvId = Request.QueryString["EventId"];

        }

        protected void Unsubscribe_Click(object sender, EventArgs e)
        {

        }
    }
}