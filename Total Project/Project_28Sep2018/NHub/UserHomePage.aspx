﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserHomePage.aspx.cs" Inherits="NHub.UserHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   

    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="2" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellSpacing="2" Height="253px" Width="770px" >
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Event" SortExpression="Name" />
<asp:TemplateField HeaderText="Subscription"><ItemTemplate>
                        <asp:CheckBox ID="SubscribedYes" runat="server" Text="Yes"/>
                        <asp:CheckBox ID="SubscribedNo" runat="server" Text="No"/>
                    
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Channels">
    <ItemTemplate>
        <asp:CheckBoxList ID="ChannelCheckBoxList" runat="server"></asp:CheckBoxList>
                        <asp:CheckBox ID="ChannelInteranet" runat="server" Text="Intranet"/>
                        <asp:CheckBox ID="ChannelEmail" runat="server" Text="Email"/>
                        <asp:CheckBox ID="ChannelUnaBot" runat="server" Text="Una bot"/>
                        <asp:CheckBox ID="ChannelSms" runat="server" Text="Sms"/>
                    
</ItemTemplate>
</asp:TemplateField>
                
<asp:TemplateField><ItemTemplate>
                       
   

    <asp:HyperLink ID="UpdateButton" NavigateUrl='<%# Eval("Id","HomeEventsUpdate.aspx?EventId={0}")%>' runat="server">Update</asp:HyperLink>
</ItemTemplate>
</asp:TemplateField>
            </Columns> 
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
    </p>
    <p>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="Event_slm_subscribe_Id" HeaderText="Event_slm_subscribe_Id" SortExpression="Event_slm_subscribe_Id" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" InsertCommand="INSERT INTO MyEventsChannel(UserId, EvenetId, Channelid) VALUES ('12953313-07ff-4464-b9cf-856a96513f1a', 1, 1)" SelectCommand="SELECT evu.Event_slm_subscribe_Id, ev.Id, ev.Name FROM Event_slm_subscribe_users AS evu INNER JOIN Event_slm_subscribe AS evslm ON evu.Event_slm_subscribe_Id = evslm.Id INNER JOIN Event AS ev ON ev.Id = evslm.EventId WHERE (evu.UserId = '12953313-07ff-4464-b9cf-856a96513f1a')" UpdateCommand="UPDATE MyEventsChannel SET Channelid = 2 WHERE (UserId = '12953313-07ff-4464-b9cf-856a96513f1a') AND (EvenetId = 2)"></asp:SqlDataSource>
    </p>
    <p>
        <asp:GridView ID="GridView3" runat="server" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField />
                <asp:CheckBoxField />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
    </p>

   

</asp:Content>
