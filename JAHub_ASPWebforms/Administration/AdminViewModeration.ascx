<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminViewModeration.ascx.cs" Inherits="JAHub_ASPWebforms.Administration.AdminViewModeration" EnableViewState="False" %>

<div class="row">
    <asp:Label runat="server" ID="lblViewModerationFor"></asp:Label>
</div>

<div>
    <asp:PlaceHolder runat="server" ID="phUserInfractions"></asp:PlaceHolder>
</div>

<div class="row">
    <asp:Button runat="server" ID="btnAddInfraction" CssClass="btn btn-default input-sm col-lg-2" Text="Add Infraction"/>
</div>
