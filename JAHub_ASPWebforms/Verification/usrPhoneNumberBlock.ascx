<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrPhoneNumberBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrPhoneNumberBlock" %>

<div>
    <asp:Label runat="server" ID="lblPhoneNumber">Phone Number:</asp:Label>
    <asp:TextBox runat="server" ID="txtPhoneNumber"></asp:TextBox>
    <asp:RegularExpressionValidator runat="server" ID="reqPhoneNumber" ControlToValidate="txtPhoneNumber"
        ErrorMessage="Value must be a Phone Number in the format '1-(###)-###-####' or '1##########'" ForeColor="Red"></asp:RegularExpressionValidator>
</div>