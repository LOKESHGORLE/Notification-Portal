﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeEventsUpdate.aspx.cs" Inherits="NHub.HomeEventsUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="ConfirmMsg" runat="server" Text="ConfirmMsg"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="Confirm" runat="server" OnClick="Confirm_Click" Text="Confirm" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Cancel" runat="server" OnClick="Cancel_Click" Text="Cancel" />
        </div>
    </form>
</body>
</html>
