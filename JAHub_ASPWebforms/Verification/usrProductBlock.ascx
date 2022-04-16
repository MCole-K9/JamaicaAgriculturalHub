<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrProductBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrProductBlock" %>

<div>
    <asp:Label runat="server" ID="lblProduct">Product*:</asp:Label>
    <asp:TextBox runat="server" ID="txtProduct"></asp:TextBox>
    <asp:RequiredFieldValidator runat="server" ID="reqProduct" ControlToValidate="txtProduct" 
        ErrorMessage="Field is Required"></asp:RequiredFieldValidator>
</div>