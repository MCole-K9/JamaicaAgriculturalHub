<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrNavbarAccountLogout.ascx.cs" Inherits="JAHub_ASPWebforms.Account.usrNavbarAccountLogout" %>

<asp:UpdatePanel runat="server">
    <ContentTemplate>
        <div class="nav navbar-right navbar-text">
            <asp:Label ID="lblUserInformation" runat="server">Placeholder</asp:Label>
            <asp:button runat="server" ID="btnLogout" OnClick="btnLogout_Click" Text="Log Out" Width="10em"/>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>