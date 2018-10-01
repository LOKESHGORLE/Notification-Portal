<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeEventsUpdate.aspx.cs" Inherits="NHub.HomeEventsUpdate" %>

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

            <asp:Label ID="HintMsg" runat="server" Text="Select Channel"></asp:Label>
            <br />

            <asp:CheckBoxList ID="ChannelCheckBoxList" runat="server"></asp:CheckBoxList>
            <%if (Request.QueryString["Act"] == "Sub")
                { %>
            <asp:Label ID="ConfirmMsg" runat="server" Text="ConfirmMsg"></asp:Label> <br /> <br /> <br /> <br />
            
            <%}
          if (Request.QueryString["Act"] == "UnSub"){%>
            <asp:Label ID="UnSubMsg" runat="server" Text="Label"></asp:Label><br /> <br /> <br /> <br />
            
            <%}%><br />
             <%if (Request.QueryString["Act"] == "Sub")
                { %><asp:Button ID="Subscribe" runat="server" OnClick="Subscribe_Click" Text="Subscribe" />
            <%}if (Request.QueryString["Act"] == "UnSub"){%>
            <asp:Button ID="Unsubscribe" runat="server" OnClick="Unsubscribe_Click" Text="Unsubscribe" /> <%}%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Cancel" runat="server" OnClick="Cancel_Click" Text="Cancel" />
        </div>
    </form>
</body>
</html>
