<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Demo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>.NET Frameworks</h1>
    
    <asp:GridView ID="FrameworkGrid" runat="server" SelectMethod="FrameworkGrid_GetData" AutoGenerateColumns="False" CssClass="table table-bordered">
        <Columns>
            <asp:BoundField DataField="Version" HeaderText="Version" SortExpression="Version"/>
            <asp:HyperLinkField DataTextField="Name" HeaderText="Name" SortExpression="Name"
                                DataNavigateUrlFields="Slug"
                                DataNavigateUrlFormatString="~/frameworkinfo?Slug={0}"/>
        </Columns>
    </asp:GridView>

</asp:Content>
