using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Repository;

namespace NotificationHub
{
    public partial class AcceptTemplate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Request.QueryString["id"]);
            SourecDal repo = new SourecDal();
            List<TemplateAccess> l = repo.GetTemplates();
            ////Source so = new Source();
            ///
            foreach (TemplateAccess template in l)
            {
                if (template.Id == s)
                {
                    Label1.Text = template.TemplateName;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(Request.QueryString["id"]);
            int Aid= Convert.ToInt32(Request.QueryString["Aid"]);
            int Did=Convert.ToInt32(Request.QueryString["Did"]);
          
            SourecDal repo = new SourecDal();
            repo.TempUpdate(s);
            

            Response.Redirect("~/ApprovalForm.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ApprovalForm.aspx");
        }
    }
}