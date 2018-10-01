<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditSource.aspx.cs" Inherits="NotificationHub.EditSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EditSource</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 3px solid #000000;
            background-color: #C0C0C0;
        }
        .auto-style2 {
            height: 85px;
        }
        .auto-style3 {
            height: 85px;
            width: 288px;
        }
        .auto-style4 {
            width: 288px;
            height: 79px;
        }
        .auto-style7 {
            height: 79px;
        }
        .auto-style8 {
            float: inherit;
        }
        .auto-style9 {
            height: 81px;
            width: 288px;
        }
        .auto-style10 {
            height: 81px;
        }
    </style>
</head>
<body style="background-color:burlywood">
    <form id="form1" runat="server" >

         <h3>
             <table cellpadding="5" cellspacing="5" class="auto-style1">
                 <tr>
                     <td class="auto-style3"><span style="display: inline !important; float: none; background-color: transparent; color: rgb(0, 0, 0); font-family: Times New Roman; font-size: 24px; font-style: normal; font-variant: normal; font-weight: 700; letter-spacing: normal; orphans: 2; text-align: left; text-decoration: none; text-indent: 0px; text-transform: none; -webkit-text-stroke-width: 0px; white-space: normal; word-spacing: 0px;">&nbsp; EDIT SOURCE</span></td>
                     <td class="auto-style2"></td>
                 </tr>
                 <tr>
                     <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;EDIT NAME :   </td>
                     <td class="auto-style7">&nbsp;&nbsp;&nbsp;   <asp:TextBox ID="TextBox1" runat="server" Font-Size="Large" CssClass="auto-style8" Width="152px"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="please Enter The name" ForeColor="Red" OnDataBinding="Button1_Click"></asp:RequiredFieldValidator>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style9">&nbsp;


        <asp:Button ID="Button1" runat="server"  Text="Submit" OnClick="Button1_Click" Font-Size="Large" Width="81px"  />   
        
                     </td>
                     <td class="auto-style10"></td>
                 </tr>
             </table>
        <br />
        <br />

        <br />
        <br />
        <br />


             </h3><div>
        </div>
        <div>
        </div>
    </form>
</body>
</html>
