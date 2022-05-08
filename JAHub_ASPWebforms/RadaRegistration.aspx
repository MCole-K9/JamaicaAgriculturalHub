<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadaRegistration.aspx.cs" Inherits="JAHub_ASPWebforms.RadaRegistration" 
    MasterPageFile="~/UserPortal.Master"%>

<%@ PreviousPageType VirtualPath="~/RadaStatus.aspx" %>

<asp:Content runat="server" ContentPlaceholderID="MainContent" ID="RadaRegistration">
    <div>
        <div class="row">
            <h2><asp:Label runat="server" ID="lblRadaRegistrationHeading" /></h2>
        </div>

        <div class="row center-block" id="divAccountCreation">
            <asp:Button runat="server" Text="Create New Account" ID="btnCreateNewAccount" OnClick="btnCreateNewAccount_Click"
                CssClass="btn btn-default col-lg-3 input-sm" UseSubmitBehavior="False" />
            <asp:Button runat="server" Text="Connect a Pre-existing Account" ID="btnPreexistingAccount" OnClick="btnPreexistingAccount_Click"
                CssClass="btn btn-default col-lg-3 input-sm" UseSubmitBehavior="False" />
        </div>
        <div>
            <asp:UpdatePanel runat="server" ID="udpRadaRegistration">
                <ContentTemplate>
                    <asp:PlaceHolder runat="server" ID="phRadaRegistration">
                    </asp:PlaceHolder>
                </ContentTemplate>   
            </asp:UpdatePanel>
        </div>
        <div class="row">
            <asp:Button runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </div>
</asp:Content>
