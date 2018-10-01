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
    public partial class HomeEventsUpdate : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string Act = Request.QueryString["Act"];
            string EvId = Request.QueryString["EventId"];

            ConfirmMsg.Text = "Do you want to Update?";
            UserHomeEvents uh = new UserHomeEvents();
            uh.GetEventChannels(EvId);

            if (!IsPostBack)
            {


                ChannelCheckBoxList.DataSource = uh.EventChannelTab;
                ChannelCheckBoxList.DataTextField = "Name";
                ChannelCheckBoxList.DataValueField = "Id";
                ChannelCheckBoxList.DataBind();
            }

        }

        

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserEvents.aspx");
        }

        protected void Subscribe_Click(object sender, EventArgs e)
        {
            string UserId = Context.User.Identity.GetUserId();
            int EvId = Convert.ToInt32(Request.QueryString["EventId"]);
            string EvCh = "";
            for (int CkbCount=0;CkbCount< ChannelCheckBoxList.Items.Count; CkbCount++)
            {
                if (ChannelCheckBoxList.Items[CkbCount].Selected)
                {
                    EvCh = EvCh + ChannelCheckBoxList.Items[CkbCount].Value + ",";
                }
            }
            EvCh = EvCh.Substring(0, EvCh.Length - 1);


            UserHomeEvents events = new UserHomeEvents();
            events.InsertMyEventsChannel(UserId, EvId, EvCh);

            Response.Redirect("~/UserEvents.aspx");

        }

        protected void Unsubscribe_Click(object sender, EventArgs e)
        {

        }
    }
}