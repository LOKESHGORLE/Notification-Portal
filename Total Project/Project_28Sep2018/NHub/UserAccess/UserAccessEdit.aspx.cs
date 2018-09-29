using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHubDAL.Roles;
using System.Data;

namespace NHub.UserAccess
{
    public partial class UserAccessEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserNameLabel.Text= Request.QueryString["UserName"];
            string UserId = Request.QueryString["UserId"];
            DalRoles roles = new DalRoles();
            roles.GetRolesTable("");
            //BrandDropDown.Text = myDataReader["Name"].ToString();
            //             BrandDropDown.DataSource = myDataReader;
            //           BrandDropDown.DataValueField = "ID";
            //RoleCheckBoxList.DataSource = roles.RolesTab;
            //RoleCheckBoxList.DataTextField = "Name";
            
            //RoleCheckBoxList.DataValueField = "Id";
            //RoleCheckBoxList.DataBind();


        }

        protected void UpdateRole_Click(object sender, EventArgs e)
        {
            string UserId = Request.QueryString["UserId"];
            string RoleId = RoleCheckBoxList.SelectedValue;
           // string RoleId=RoleCheckBoxList.SelectedValue.ToString();
            DalRoles roles = new DalRoles();
            roles.AssignRoles(UserId, RoleId);
            Response.Redirect("~/UserAccess/UserAccess");
        }
    }
}