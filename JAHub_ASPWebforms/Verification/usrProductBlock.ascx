<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrProductBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrProductBlock" %>

<div>
    <asp:Label runat="server" ID="lblProduct" CssClass="text text-right col-lg-3">Product*:</asp:Label>
    <asp:TextBox runat="server" ID="txtProduct" CssClass="col-lg-3" />
    <asp:RequiredFieldValidator runat="server" ID="reqProduct" ControlToValidate="txtProduct" 
        ErrorMessage="Field is Required" CssClass="text text-danger col-lg-3"/>
</div>