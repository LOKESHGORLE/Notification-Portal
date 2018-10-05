using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHubDAL.Users;
using Microsoft.AspNet.Identity;
using System.Data;

namespace NHub
{
    public partial class UserEvents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserHomeEvents uh = new UserHomeEvents();
            uh.GetEventsTable(Context.User.Identity.GetUserId());

            Table DisplayTable = new Table();
            PlaceHolder1.Controls.Add(DisplayTable);



            TableRow TabRow = new TableRow();
            TableCell CellH1 = new TableCell();
            CellH1.Controls.Add(new LiteralControl("Event"));
            CellH1.Width = 150;
            CellH1.ForeColor = System.Drawing.Color.DarkRed;
            TableCell Cellh2 = new TableCell();

            Cellh2.Controls.Add(new LiteralControl("SubScribe"));
            Cellh2.Width = 150;
            Cellh2.ForeColor = System.Drawing.Color.DarkRed;
            TableCell Cellh3 = new TableCell();

            Cellh3.Controls.Add(new LiteralControl("Unsubscribe"));
            Cellh3.Width = 150;
            Cellh3.ForeColor = System.Drawing.Color.DarkRed;
            TabRow.Cells.Add(CellH1);
            TabRow.Cells.Add(Cellh2);
            TabRow.Cells.Add(Cellh3);
            //Tr.Cells.Add(Cell4);
            DisplayTable.Rows.Add(TabRow);

            CheckBoxList ckl = new CheckBoxList();
            foreach (DataRow data in uh.UserEventsTab.Tables[1].Rows)
            {

                TableRow Tr = new TableRow();
                Tr.HorizontalAlign = HorizontalAlign.Justify;


                TableCell Cell1 = new TableCell();
                Cell1.Controls.Add(new LiteralControl(data[1].ToString()));
                Cell1.Width = 150;
                TableCell Cell2 = new TableCell();
                HyperLink hyp1 = new HyperLink();
                hyp1.Text = "Subscribe";
                hyp1.NavigateUrl = "~/HomeEventsUpdate?Act=Sub&&EventId=" + data[2].ToString();
                Cell2.Controls.Add(hyp1);
                Cell2.Width = 150;
                TableCell Cell3 = new TableCell();
                HyperLink hyp2 = new HyperLink();
                hyp2.Text = "UnSubscribe";
                hyp2.NavigateUrl = "~/HomeEventsUpdate?Act=UnSub&&EventId=" + data[2].ToString();
                Cell3.Controls.Add(hyp2);
                Cell3.Width = 150;

                //CheckBox ck1 = new CheckBox { Text = "Subscribe" };
                //CheckBox ck2 = new CheckBox { Text = "Unsubscribe" };
                //Cell2.Controls.Add(ck1);

                //Cell2.Controls.Add(ck2);
                //Cell2.Width = 100;
                //Cell2.VerticalAlign = VerticalAlign.Middle;
                ////RadioButtonList rb = new RadioButtonList();
                ////RadioButton rb1 = new RadioButton();
                ////rb1.Text = "Subscribe";
                //TableCell Cell3 = new TableCell();

                //ckl.DataSource = uh.UserEventsTab.Tables[0];
                //ckl.DataTextField = uh.UserEventsTab.Tables[0].Columns[1].ToString();
                //ckl.DataValueField = uh.UserEventsTab.Tables[0].Columns[0].ToString();
                //ckl.DataBind();
                ////ckl.
                //Cell3.Controls.Add(ckl);
                //Button but = new Button();
                //but.Text = "UPdate";
                //TableCell Cell4 = new TableCell();
                //Cell4.Controls.Add(but);


                Tr.Cells.Add(Cell1);
                Tr.Cells.Add(Cell2);
                Tr.Cells.Add(Cell3);
                //Tr.Cells.Add(Cell4);
                DisplayTable.Rows.Add(Tr);
            }


        }


    }
}