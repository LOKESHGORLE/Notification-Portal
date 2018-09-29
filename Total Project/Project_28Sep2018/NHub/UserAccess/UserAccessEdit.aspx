<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAccessEdit.aspx.cs" Inherits="NHub.UserAccess.UserAccessEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="UserNameLabel" runat="server" Text="UserName"></asp:Label>
            <br />
            <br />
        
            <asp:CheckBoxList ID="RoleCheckBoxList" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id">
            </asp:CheckBoxList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NotificationHubConnectionString %>" SelectCommand="SELECT [Id], [Name] FROM [AspNetRoles]"></asp:SqlDataSource>
        
            <br />
            <asp:Button ID="UpdateRole" runat="server" OnClick="UpdateRole_Click" Text="Update" />
        </div>
    </form>
</body>
</html>
