<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrNavbarLoginRegister.ascx.cs" Inherits="JAHub_ASPWebforms.Account.usrNavbarLoginRegister" %>

<asp:UpdatePanel runat="server">
    <ContentTemplate>
        <div class="nav navbar-text">
            <button type="button" class="btn btn-default navbar-text" id="btnLogin" data-toggle="modal"
        data-target="#pnlLoginModal" style="width:10em;">Login</button>
        <asp:Button runat="server" ID="btnRegister" Text="Register"
            CssClass="btn btn-default navbar-text" style="width:10em;"
            />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>