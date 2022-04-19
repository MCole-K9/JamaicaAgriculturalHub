<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrNavbarLoginRegister.ascx.cs" Inherits="JAHub_ASPWebforms.Account.usrNavbarLoginRegister" %>

<asp:UpdatePanel runat="server">
    <ContentTemplate>
        <div class="nav navbar-text navbar-right" style="margin:auto;">
            <button type="button" class="btn btn-default navbar-text center-block" id="btnLogin" data-toggle="modal"
        data-target="#pnlLoginModal" style="width:10em;">Login</button>
        <asp:Button runat="server" ID="btnRegister" Text="Register"
            CssClass="btn btn-default navbar-text" style="width:10em;"
            />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>