<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrContactBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrContactBlock" %>
<%@ Reference Control="~/Verification/usrPhoneNumberBlock.ascx"%>

<div class="row">
    <h4>Contact Information</h4>
    <div class="row">
        <asp:Label runat="server" ID="lblEmail" CssClass="text col-lg-1 col-md-2 col-sm-3 col-xs-3 input-sm">Email:</asp:Label>
        <asp:TextBox runat="server" ID="txtEmail" CssClass="col-lg-3 input-sm"/>
        <asp:RegularExpressionValidator runat="server" ID="regEmail" ControlToValidate="txtEmail" ErrorMessage="Field Must be a valid email format, for example: &quot;example@email.com&quot;" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="text text-danger col-lg-8 input-sm" />
    </div>
    <div class="row">
        <asp:PlaceHolder runat="server" ID="phPhoneNumbers"/>
    </div>
    <div class="row">
        <asp:Button runat="server" ID="btnAddPhoneNumber" OnClick="btnAddPhoneNumber_Click" 
            Text="Add Phone Number" CssClass="btn btn-default col-lg-2 input-sm"/>
        <asp:Button runat="server" ID="btnRemovePhoneNumber" Visible="false" OnClick="btnRemovePhoneNumber_Click" 
            Text="Remove Phone Number" CssClass="btn btn-default col-lg-2 input-sm"/>
    </div>
</div>