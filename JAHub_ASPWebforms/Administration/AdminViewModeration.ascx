<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminViewModeration.ascx.cs" Inherits="JAHub_ASPWebforms.Administration.AdminViewModeration" EnableViewState="False" %>

<%@ Register Src="~/Administration/usrAddInfraction.ascx" Tagname="AddInfraction" TagPrefix="uc"%>

<div class="row">
    <asp:Label runat="server" ID="lblViewModerationFor"></asp:Label>
</div>

<div>
    <asp:Repeater runat="server" ID="rptUserInfractions">
        <ItemTemplate>
            <uc:AddInfraction runat="server" ID="admUserInfraction"></uc:AddInfraction>
        </ItemTemplate>
    </asp:Repeater>
    <asp:PlaceHolder runat="server" ID="phUserInfractions" />
</div>

<div class="row">
    <asp:Button runat="server" ID="btnAddInfraction" CssClass="btn btn-default input-sm col-lg-2" Text="Add Infraction" OnClick="btnAddInfraction_Click"/>
</div>
