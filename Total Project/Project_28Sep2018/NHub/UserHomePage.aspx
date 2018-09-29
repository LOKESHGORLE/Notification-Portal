<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserHomePage.aspx.cs" Inherits="NHub.UserHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table cellpadding="3" cellspacing="3" style="width: 100%; border: 2px solid #FFFFFF; border-color:brown" ;>
        <tr style=" background-color: #000000">
            <td class="modal-sm" style=" color:ghostwhite;  width: 154px; height: 65px">EVENT NAME</td>
            <td style=" color:ghostwhite;height: 65px; width: 129px;">SUBSCRIBED</td>
            <td style=" color:ghostwhite;height: 65px; width: 263px;">CHANNELS</td>
            <td style="height: 65px; width: 130px;"></td>
            <td style="height: 65px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style= "color:ghostwhite; width: 154px; height: 122px ;border-color:brown"></td>
            <td style="height: 122px; width: 129px;border-color:brown ">
                <asp:CheckBoxList ID="CheckBoxList3" runat="server">
                    <asp:ListItem>ON</asp:ListItem>
                    <asp:ListItem>OFF</asp:ListItem>
                </asp:CheckBoxList>
            </td>
            <td style="height: 122px; width: 263px; border-color:brown">
                <asp:CheckBoxList ID="CheckBoxList1"  runat="server">
                    <asp:ListItem>INTRANET</asp:ListItem>
                    <asp:ListItem>EMAILS</asp:ListItem>
                    <asp:ListItem>Una Bot</asp:ListItem>
                    <asp:ListItem>SMS</asp:ListItem>
                </asp:CheckBoxList>
            </td>
            <td style="height: 122px; width: 130px;">
                <asp:Button ID="Button1" runat="server" Text="UPDATE" BorderStyle="Double" BackColor="#ffffff" Font-Size="Large" />
            </td>
            <td style="height: 122px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style=" color:ghostwhite; width: 154px; height: 120px"></td>
            <td style="height: 120px; width: 129px;">
                <asp:CheckBoxList ID="CheckBoxList4" runat="server">
                    <asp:ListItem>ON</asp:ListItem>
                    <asp:ListItem>OFF</asp:ListItem>
                </asp:CheckBoxList>
            </td>
            <td style="height: 120px; width: 263px;">
                <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                    <asp:ListItem>INTRANET</asp:ListItem>
                    <asp:ListItem>EMAILS</asp:ListItem>
                    <asp:ListItem>Una Bot</asp:ListItem>
                    <asp:ListItem>SMS</asp:ListItem>
                </asp:CheckBoxList>
            </td>
            <td style="height: 120px; width: 130px;">
                <asp:Button ID="Button2" runat="server" Text="UPDATE" BorderStyle="Double" BackColor="#ffffff" Font-Size="Large" />
            </td>
            <td style="height: 120px">
                <asp:HyperLink ID="HyperLink1" runat="server" >SEEMORE</asp:HyperLink>
            </td>
        </tr>
    </table>

</asp:Content>
