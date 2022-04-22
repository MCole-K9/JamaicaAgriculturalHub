<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdministrationPage.aspx.cs" Inherits="JAHub_ASPWebforms.AdministrationPage" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="AdminContent">
    <nav>
        Navbar content should go here. Sections would be: Select User; Create New User; Edit User Information; View User Infractions; Delete User;

    </nav>
    <asp:PlaceHolder runat="server" ID="phAdministration">
        This is basically where all the important stuff goes
    </asp:PlaceHolder>
    
</asp:Content>