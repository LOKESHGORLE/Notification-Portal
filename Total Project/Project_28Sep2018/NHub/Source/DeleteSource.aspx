<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteSource.aspx.cs" Inherits="NotificationHub.DeleteSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DeleteSource</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 4px solid #000000;
            background-color: #C0C0C0;
        }
        .auto-style2 {
            width: 568px;
            height: 56px;
        }
        .auto-style3 {
            width: 568px;
            height: 140px;
        }
        .auto-style4 {
            height: 140px;
        }
        .auto-style5 {
            height: 56px;
        }
    </style>
</head>
<body style="background-color:tan">
    <form id="form1" runat="server">
        <div>

        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
            <asp:PlaceHolder ID="PlaceHolder1" runat="server">

                <h3>Are you sure you want to delete <asp:Label ID="Label1" runat="server" Text="this"></asp:Label></h3>
            </asp:PlaceHolder>


                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="Cancel" Font-Size="Large" OnClick="Button2_Click" />

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


            <asp:Button ID="Button1" runat="server" Text="Yes" Font-Size="Large" OnClick="Button1_Click" /> </td>
                <td class="auto-style4"></td>
            </tr>
        </table>
    </form>
</body>
</html>
