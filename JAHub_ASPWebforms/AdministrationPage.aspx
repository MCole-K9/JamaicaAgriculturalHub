<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdministrationPage.aspx.cs" Inherits="JAHub_ASPWebforms.AdministrationPage" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="AdminContent">
    <div class ="row">
        <asp:Button runat="server" ID="btnSelectUser" Text="Select User" CssClass="btn btn-default input-sm col-sm-2"/>
        <asp:Button runat="server" ID="btnCreateNewUser" Text="Create New User" CssClass="text btn btn-default input-sm col-sm-2"/>
        <!-- Options that should only become available when a user is selected-->
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Label runat="server" ID="lblCurrentUser" CssClass="input-sm col-sm-2">Current User: none selected</asp:Label>

                <asp:Button runat="server" ID="btnDeleteUser" Text="Edit User" CssClass="btn btn-default input-sm col-sm-2"/>
                <asp:Button runat="server" ID="btnEditUser" Text="Edit User" CssClass="btn btn-default input-sm col-sm-2"/>
                <asp:Button runat="server" ID="btnViewModeration" Text="View User Moderation" CssClass="btn btn-default input-sm col-sm-2" />
            </ContentTemplate>
        </asp:UpdatePanel>
        
    </div>

    <asp:PlaceHolder runat="server" ID="phAdministration">
        This is basically where all the important stuff goes
    </asp:PlaceHolder>
    
</asp:Content>