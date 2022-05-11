<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrPhoneNumberBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrPhoneNumberBlock" %>

<div class="row">
    <asp:Label runat="server" ID="lblPhoneNumber" CssClass="text text-right col-lg-3 input-sm" Text="Phone Number: "/>
    <asp:TextBox runat="server" ID="txtPhoneNumber" CssClass="col-lg-3 input-sm"></asp:TextBox>
    <asp:RegularExpressionValidator runat="server" ID="regPhoneNumber" ControlToValidate="txtPhoneNumber"
        ErrorMessage="Value must be a Phone Number in the format '1##########'" CssClass="txt txt-danger col-lg-3 input-sm" ValidationExpression="1((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" />
    <asp:RequiredFieldValidator runat="server" ID="reqPhoneNumber" ErrorMessage="Field Is Required" 
        ControlToValidate="txtPhoneNumber" CssClass="text text-danger col-lg-3 input-sm"/>
</div>