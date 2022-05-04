<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrAddInfraction.ascx.cs" Inherits="JAHub_ASPWebforms.Administration.usrAddInfraction" %>

<div class="row">
    <asp:Label runat="server" ID="lblTimeStamp" CssClass="text col-lg-3 input-sm"></asp:Label>
    <asp:TextBox runat="server" ID="txtReason" CssClass="col-lg-3 input-sm"></asp:TextBox>
    <asp:Button runat="server" ID="btnSubmit" Text="Submit New Infraction" CssClass="btn btn-default col-lg-3 input-sm" OnClick="btnSubmit_Click" />
</div>