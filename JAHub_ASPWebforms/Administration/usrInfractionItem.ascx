<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrInfractionItem.ascx.cs" Inherits="JAHub_ASPWebforms.Moderation.usrViewInfraction" %>

<div>
    <asp:Label runat="server" ID="lblDateOfEntry">XXXX-XX-XX</asp:Label>
    <asp:Label runat="server" ID="lblReason">Reason for whatever</asp:Label>
    <asp:Label runat="server" ID="lblAddedById">Added by ID Whatever</asp:Label>
    <asp:Button runat="server" ID="btnClearReason" OnClick="btnClearReason_Click" CssClass="btn btn-default col-lg-2 input-sm" Text="X"/>
</div>