<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSource.aspx.cs" Inherits="NotificationHub.AddSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>ADD SOURCE</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 4px solid #000000;
            background-color: #C0C0C0;
        }
        .auto-style5 {
            width: 443px;
            height: 67px;
        }
        .auto-style6 {
            height: 67px;
        }
        .auto-style7 {
            width: 443px;
            height: 91px;
        }
        .auto-style8 {
            height: 91px;
        }
        .auto-style9 {
            width: 443px;
            height: 95px;
        }
        .auto-style10 {
            height: 95px;
        }
    </style>
</head>
<body style="background-color:lightgoldenrodyellow">
    <h2 style="align-content:center">&nbsp;</h2>
    <form id="form1" runat="server">
        
         <h3>
             <table class="auto-style1">
                 <tr>
                     <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ADD SOURCE</td>
                     <td class="auto-style10"></td>
                 </tr>
                 <tr>
                     <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NAME :&nbsp;</td>
                     <td class="auto-style6">   <asp:TextBox ID="TextBox1" runat="server" Style="float:inherit" Font-Size="Large"></asp:TextBox>
             <asp:Label ID="Label1" runat="server" Visible="False" ForeColor="#ff0000"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style7">


        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


        <asp:Button ID="Button1" runat="server" Text="Cancel" OnClick="Button1_Click" Font-Size="Large" OnDataBinding="Page_Load" />    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    </td>
                     <td class="auto-style8">    <asp:Button ID="Button2" runat="server" Text="Create" OnClick="Button2_Click" Font-Size="Large" OnDataBinding="Button2_Click"/>
        
                     </td>
                 </tr>
             </table>
&nbsp;<br />
        <br />
        <br />


             </h3><div>
        </div>
       
    </form>
         
</body>
</html>
