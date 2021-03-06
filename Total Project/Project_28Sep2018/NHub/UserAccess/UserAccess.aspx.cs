﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NHubDAL;

namespace NHub.UserAccess
{
    public partial class UserAccess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Access access = new Access();
            NHubDAL.Access.DalAccess access = new NHubDAL.Access.DalAccess();
            access.GetAccessTable("");
            //Sourcetable.SourcesTable;
            Table Tables = new Table();
            PlaceHolder1.Controls.Add(Tables);


            TableRow TR = new TableRow();
            TableCell TCone = new TableCell();
            TCone.Controls.Add(new LiteralControl("User Name"));
            TCone.ForeColor = System.Drawing.Color.PowderBlue;
            TCone.Font.Size = 10;
            TableCell TCtwo = new TableCell();
            TCtwo.Controls.Add(new LiteralControl("Role"));
            TCtwo.ForeColor = System.Drawing.Color.PowderBlue;
            TCtwo.Font.Size = 10;
            TableCell TCthree = new TableCell();
            TCthree.Controls.Add(new LiteralControl("Actions"));
            TCthree.ForeColor = System.Drawing.Color.PowderBlue;
            TCthree.Font.Size = 10;
            TR.Cells.Add(TCone);
            TR.Cells.Add(TCtwo);
            TR.Cells.Add(TCthree);
            Tables.Rows.Add(TR);


            foreach (DataRow data in access.AccessTab.Rows)
            {
                string UserId = data[2].ToString();
                TableRow Tr = new TableRow();
                TableCell Cell1 = new TableCell();
                Cell1.Controls.Add(new LiteralControl(data[0].ToString()));
                Cell1.Width = 200;
                TableCell Cell2 = new TableCell();
                Cell2.Controls.Add(new LiteralControl(data[1].ToString()));
                Cell2.Width = 200;
                TableCell Cell3 = new TableCell();
                HyperLink hyp = new HyperLink();
                Cell3.Width = 200;
                hyp.Text = "Edit";
                hyp.NavigateUrl = "~/UserAccess/UserAccessEdit?UserId="+ UserId+"&&UserName="+ data[0].ToString();
                Cell3.Controls.Add(hyp);
                Tr.Cells.Add(Cell1);
                Tr.Cells.Add(Cell2);
                Tr.Cells.Add(Cell3);
                Tables.Rows.Add(Tr);
            }
        }

        protected void Search_Click(object sender, EventArgs e)
        {

        }
    }
}