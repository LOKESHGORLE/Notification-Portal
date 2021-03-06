﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Repository;


namespace Project_28Sep2018
{
    public partial class SLMServiceLinesEdit1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Context.User.IsInRole("ServiceLine Manager"))
            {
                Response.Redirect("Access.aspx");
            }
            string ServiceName = Request.QueryString["ServLineName"];
            ServLineName.Text = ServiceName;
            if (!IsPostBack)
            {
                string ServLineName = Request.QueryString["ServLineName"];
                //OMCheckList.Text = ServLineName;
                string ServLineId = Request.QueryString["ID"];
                int ServLineId1 = Convert.ToInt32(Request.QueryString["ID"]);
                ServiceLineRepository SLrepo = new ServiceLineRepository();

                SLMServiceLine SlMRepo = new SLMServiceLine();
                SlMRepo.getServLineOMDetails(ServLineId);
                SlMRepo.getAllOMDetails();
                SlMRepo.getAllOMDetailsOfServiceLineManagers(ServLineId);

                SelectAllUsers selectAllUsers = new SelectAllUsers();

                OMCheckList.DataSource = SlMRepo.ServLineOMTab;
                OMCheckList.DataTextField = "UserName";
                OMCheckList.DataValueField = "Id";
                OMCheckList.DataBind();
                for (int i = 0; i < OMCheckList.Items.Count; i++)
                {
                    OMCheckList.Items[i].Selected = true;
                    string OmId = OMCheckList.Items[i].Value;
                    SLrepo.EditServiceLineOMwhileload(ServLineId1, OmId);


                }

                //OMCheckList1.DataSource = SlMRepo.ServLineOMList;
                //OMCheckList1.DataTextField = "UserName";
                //OMCheckList1.DataValueField = "Id";

                //OMCheckList1.DataBind();

                //CheckBoxList2.DataSource = SlMRepo.getAllOMDetailsOfServiceLineManagers(ServLineId);
                CheckBoxList2.DataSource = SlMRepo.ServLineOMList;
                CheckBoxList2.DataTextField = "UserName";
                CheckBoxList2.DataValueField = "Id";

                CheckBoxList2.DataBind();
            }
        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SLMServiceLines.aspx");
        }

        protected void update_Click(object sender, EventArgs e)
        {
           
            
            int ServLineId = Convert.ToInt32(Request.QueryString["ID"]);
            string OMIds = "";
            ServiceLineRepository SLrepo = new ServiceLineRepository();


            for (int SLMcount = 0; SLMcount < OMCheckList.Items.Count; SLMcount++)
            {
                if (OMCheckList.Items[SLMcount].Selected)
                {
                    OMIds = OMIds + OMCheckList.Items[SLMcount].Value + ",";
                }
            }

            for (int SLMcount = 0; SLMcount < CheckBoxList2.Items.Count; SLMcount++)
            {
                if (CheckBoxList2.Items[SLMcount].Selected)
                {
                    OMIds = OMIds + CheckBoxList2.Items[SLMcount].Value + ",";
                }
            }


            if (OMIds.Length > 0)
            {
                OMIds = OMIds.Substring(0, OMIds.Length - 1);
                SLrepo.UpdateAfterDeleteServiceLine(ServLineId, OMIds);
                Response.Redirect("~/SLMServiceLines.aspx");
            }
            else
            {
                Label1.Text = "Please Select atleast one operartional manager";
            }
            //SLrepo.EditServiceLine(ServLineId, OMIds);
 
           
            
        }
    }
}
        
    
