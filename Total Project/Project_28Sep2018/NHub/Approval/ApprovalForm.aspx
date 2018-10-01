<%@ Page Title="ApprovalForm" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ApprovalForm.aspx.cs" Inherits="NotificationHub.ApprovalForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<%--    <asp:HyperLink ID="HyperLink1" runat="server" BorderStyle="Groove" ForeColor="#009900">Approved</asp:HyperLink>
    <asp:HyperLink ID="HyperLink2" runat="server" BorderStyle="Groove" ForeColor="#cc0000">Declined</asp:HyperLink>--%>
    
    <br />
    <br />
        <h3> Pending Approvals:</h3>
    <br />
    <br />
    <div>

        <asp:PlaceHolder ID="PlaceHolder1" runat="server">
           <%-- <asp:HyperLink ID="HyperLink1" runat="server">Approved</asp:HyperLink>
            <asp:HyperLink ID="HyperLink2" runat="server">Declined</asp:HyperLink>--%>
            <asp:Label ID="Label1" runat="server"></asp:Label>

        </asp:PlaceHolder>
    </div>
    
    
    
    
    
    
    
    
    
    
    <br />
    <br />
    <h3> Approved Templates:</h3>
    <br />
    <br />
    <div>
            <asp:PlaceHolder ID="PlaceHolder2" runat="server">
                </asp:PlaceHolder>

    </div>
    <br />
    <br />
    <h3>Declined Templates:</h3>
    <br />
    <br />
    <div>
            <asp:PlaceHolder ID="PlaceHolder3" runat="server">
                </asp:PlaceHolder>

    </div>
    <br />
    <br />


  




</asp:Content>
