<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcceptTemplate.aspx.cs" Inherits="NotificationHub.AcceptTemplate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CONFIRMATION</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 4px solid #000000;
            background-color: #C0C0C0;
        }
        .auto-style2 {
            height: 56px;
        }
        .auto-style3 {
            height: 106px;
        }
        .auto-style4 {
            height: 84px;
        }
    </style>
</head>
<body style="background-color:seashell">
    <form id="form1" runat="server">
        <div>
            <br />
<div align="center">
</div>
           

        </div>
        <h2>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Confirmation</td>
            </tr>
            <tr>
                <td class="auto-style4">Are you Sure You Want to Approve Template -<asp:Label ID="Label1" runat="server"></asp:Label> ?</td>
            </tr>
            <tr>
                <td class="auto-style3">
 <asp:Button ID="Button1" runat="server" Text="Yes" Font-Size="Large" OnClick="Button1_Click" /> &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp<asp:Button ID="Button2" runat="server" Text="No" Font-Size="Large" OnClick="Button2_Click" />
                </td>
            </tr>
        </table>
            </h2>
    </form>
</body>
</html>
