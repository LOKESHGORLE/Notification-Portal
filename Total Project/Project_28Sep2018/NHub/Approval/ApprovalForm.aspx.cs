using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Repository;

namespace NotificationHub
{
    public partial class ApprovalForm : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            bool flag = true;
            SourecDal repo1 = new SourecDal();
                
                  
                    Table table1 = new Table();
                    
                    table1.ID = "1";
                    PlaceHolder2.Controls.Add(table1);

                    
                    repo1.GetApproved();
                    //HyperLink1.NavigateUrl = ("~/ApprovedTemplates.aspx");
                    //HyperLink2.NavigateUrl = ("~/DeclinedForm.aspx");

                    for (int count = 0; count < repo1.Approvedlist.Count; count++)
                    {
                        TableRow tableRow = new TableRow();
                        table1.Rows.Add(tableRow);
                        TableCell tableCell = new TableCell();
                        tableRow.Cells.Add(tableCell);
                        Label label = new Label();
                        label.Text = "TEMPLATE--";
                        label.Width = 150;
                        PlaceHolder2.Controls.Add(label);

                        Label label1 = new Label();
                        label1.Text = repo1.Approvedlist[count].TemplateName;
                        label1.Width = 250;
                        PlaceHolder2.Controls.Add(label1);

                        Label label2 = new Label();
                        label2.Text = repo1.Approvedlist[count].OperationManager;
                        label2.Width = 150;
                        PlaceHolder2.Controls.Add(label2);

                        Label label3 = new Label();
                        label3.Text = "Accepted";
                        label3.Width = 400;
                        PlaceHolder2.Controls.Add(label3);
                        flag = false;
                    }

                   Table table2 = new Table();
                    table2.ID = "1";
                    PlaceHolder3.Controls.Add(table2);

                  
                    repo1.GetDeclined();
                  

                    for (int count = 0; count < repo1.rejectedlist.Count; count++)
                    {
                        TableRow tableRow = new TableRow();
                        table2.Rows.Add(tableRow);
                        TableCell tableCell = new TableCell();
                        tableRow.Cells.Add(tableCell);
                        Label label = new Label();
                        label.Text = "TEMPLATE--";
                        label.Width = 150;
                        PlaceHolder3.Controls.Add(label);

                        Label label1 = new Label();
                        label1.Text = repo1.rejectedlist[count].TemplateName;
                        label1.Width = 250;
                        PlaceHolder3.Controls.Add(label1);

                        Label label2 = new Label();
                        label2.Text = repo1.rejectedlist[count].OperationManager;
                        label2.Width = 150;
                        PlaceHolder3.Controls.Add(label2);

                        Label label3 = new Label();
                        label3.Text = "Declined";
                        label3.Width = 400;
                        PlaceHolder3.Controls.Add(label3);
                        flag = false;
                    }
                
            

            Table table3 = new Table();
            table3.ID = "1";
            PlaceHolder1.Controls.Add(table3);

         /*   SourecDal repo = new SourecDal()*/;
            SourecDal repo = new SourecDal();
            repo.GetTemplates();
            //HyperLink1.NavigateUrl = ("~/ApprovedTemplates.aspx");
            //HyperLink2.NavigateUrl = ("~/DeclinedForm.aspx");

            for(int count=0;count< repo.templateslist.Count; count++)
            {
                TableRow tableRow = new TableRow();
                table3.Rows.Add(tableRow);
                TableCell tableCell = new TableCell();
                tableRow.Cells.Add(tableCell);
                Label label = new Label();
                label.Text = " NEW_TEMPLATE-";
                label.Width = 130;
                PlaceHolder1.Controls.Add(label);

                Label label1 = new Label();
                label1.Text = repo.templateslist[count].TemplateName;
                label1.Width = 150;
                PlaceHolder1.Controls.Add(label1);

                Label label2 = new Label();
                label2.Text = repo.templateslist[count].OperationManager;
                label2.Width = 200;
                PlaceHolder1.Controls.Add(label2);

               HyperLink hyper = new HyperLink();
                hyper.Text = "Approve";
                hyper.Width = 80;
                hyper.NavigateUrl = ("~/Approval/AcceptTemplate.aspx?id=" + Convert.ToString(repo.templateslist[count].Id));
                PlaceHolder1.Controls.Add(hyper);

                HyperLink hyper1 = new HyperLink();
                hyper1.Text = "Decline";
                hyper1.Width = 400;
                hyper1.NavigateUrl = ("~/Approval/DeclineTemplate.aspx?id=" + Convert.ToString(repo.templateslist[count].Id));
                PlaceHolder1.Controls.Add(hyper1);



               
                
            }
        }
    }
}