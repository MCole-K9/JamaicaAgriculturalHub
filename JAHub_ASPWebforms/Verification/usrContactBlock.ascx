<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrContactBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrContactBlock" %>
<%@ Reference Control="~/Verification/usrPhoneNumberBlock.ascx"%>

<div>
    <div>
        <asp:Label runat="server" ID="lblEmail">Email:</asp:Label>
        <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
        <asp:RegularExpressionValidator runat="server" ID="regEmail" ControlToValidate="txtEmail" ErrorMessage="Field Must be a valid email format, for example: &quot;example@email.com&quot;" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    </div>
    <asp:PlaceHolder runat="server" ID="phPhoneNumbers"></asp:PlaceHolder>
    <div>
        <asp:Button runat="server" ID="btnAddPhoneNumber" OnClick="btnAddPhoneNumber_Click" />
        <asp:Button runat="server" ID="btnRemovePhoneNumber" Visible="false" OnClick="btnRemovePhoneNumber_Click"/>
    </div>
</div>