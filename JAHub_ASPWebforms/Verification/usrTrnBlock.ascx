<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrTrnBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrTrnBlock" %>

<div class="row">
    <asp:Label ID="lblTaxRegistrationNumber" runat="server" CssClass="text col-lg-3 input-sm">TRN*: </asp:Label>
    <asp:TextBox ID="txtTaxRegistrationNumber" runat="server" CssClass="col-lg-3 input-sm"></asp:TextBox>
    <asp:CustomValidator ID="cusTaxRegistrationNumber" runat="server" controltoValidate="txtTaxRegistrationNumber"
        ErrorMessage="Value entered must be a 9 digit number" CssClass="text text-danger col-lg-3 input-sm" OnServerValidate="cusTaxRegistrationNumber_ServerValidate" />
</div>