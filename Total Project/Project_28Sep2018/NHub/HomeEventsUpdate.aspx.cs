using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NHub
{
    public partial class HomeEventsUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ConfirmMsg.Text = "Do you want to Update?";

        }

        protected void Confirm_Click(object sender, EventArgs e)
        {

        }

        protected void Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}