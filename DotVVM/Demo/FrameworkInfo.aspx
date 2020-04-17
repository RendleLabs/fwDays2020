<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrameworkInfo.aspx.cs" Inherits="Demo.FrameworkInfo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>Framework Info</h1>
    
    <asp:Label ID="FrameworkNameLabel" runat="server" CssClass="h2"></asp:Label>
    
    <ul>
        <li>Version: <asp:Label ID="FrameworkVersionLabel" runat="server"></asp:Label></li>
        <li>Year: <asp:Label ID="FrameworkYearLabel" runat="server"></asp:Label></li>
    </ul>

</asp:Content>
