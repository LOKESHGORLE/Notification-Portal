<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomeEventsUpdate.aspx.cs" Inherits="NHub.HomeEventsUpdate" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
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
  </asp:Content>
