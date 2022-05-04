<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrInfractionItem.ascx.cs" Inherits="JAHub_ASPWebforms.Administration.usrInfractionItem" %>

<div class="row">
    <asp:Label runat="server" ID="lblDateOfEntry" CssClass="col-lg-2 input-sm">XXXX-XX-XX</asp:Label>
    <asp:Label runat="server" ID="lblReason" CssClass="col-lg-2 input-sm">Reason for whatever</asp:Label>
    <asp:Label runat="server" ID="lblAddedById" CssClass="col-lg-2 input-sm">Added by ID Whatever</asp:Label>
    <asp:Button runat="server" ID="btnClearReason" OnClick="btnClearReason_Click" CssClass="btn btn-default col-lg-2 input-sm" Text="X"/>
</div>