<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrContactBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrContactBlock" %>
<%@ Reference Control="~/Verification/usrPhoneNumberBlock.ascx"%>

<div>
    <div>
        <asp:Label runat="server" ID="lblEmail" CssClass="text col-lg-3">Email:</asp:Label>
        <asp:TextBox runat="server" ID="txtEmail" CssClass="col-lg-3"/>
        <asp:RegularExpressionValidator runat="server" ID="regEmail" ControlToValidate="txtEmail" ErrorMessage="Field Must be a valid email format, for example: &quot;example@email.com&quot;" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="text text-danger col-lg-3" />
    </div>
    <asp:PlaceHolder runat="server" ID="phPhoneNumbers" />
    <div>
        <asp:Button runat="server" ID="btnAddPhoneNumber" OnClick="btnAddPhoneNumber_Click" CssClass="btn btn-default col-lg-2 input-sm"/>
        <asp:Button runat="server" ID="btnRemovePhoneNumber" Visible="false" OnClick="btnRemovePhoneNumber_Click" CssClass="btn btn-default col-lg-2 input-sm"/>
    </div>
</div>