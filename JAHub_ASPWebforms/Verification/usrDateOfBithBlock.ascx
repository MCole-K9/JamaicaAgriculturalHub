<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrDateOfBithBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrDateOfBithBlock" %>

<div>
    <h4>Date Of Birth*</h4>
    <div>
        <div>
            <asp:DropDownList runat="server" ID="ddlDay"></asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" ID="reqDay" ErrorMessage="Field is Required"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:DropDownList runat="server" ID="ddlMonth"></asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" ID="reqMonth" ErrorMessage="Field is Required"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:DropDownList runat="server" ID="ddlYear"></asp:DropDownList>
            <asp:RequiredFieldValidator runat="server" ID="reqYear" ErrorMessage="Field is Required"></asp:RequiredFieldValidator>
        </div>
    </div>

</div>