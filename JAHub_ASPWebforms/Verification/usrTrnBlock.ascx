<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrTrnBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrTrnBlock" %>

<div>
    <asp:Label ID="lblTaxRegistrationNumber" runat="server">TRN*: </asp:Label>
    <asp:TextBox ID="txtTaxRegistrationNumber" runat="server"></asp:TextBox>
    <asp:CustomValidator ID="cusTaxRegistrationNumber" runat="server" controltoValidate="#txtTaxRegistrationNumber"
        ErrorMessage="Value entered must be a 9 digit number" CssClass="text-danger" OnServerValidate="cusTaxRegistrationNumber_ServerValidate"
        ></asp:CustomValidator>
</div>