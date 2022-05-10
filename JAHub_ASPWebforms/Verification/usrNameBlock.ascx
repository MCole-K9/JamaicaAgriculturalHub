<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrNameBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrNameBlock" %>

<div class="row">
    <h4 class="text">Name *</h4>
    <div class="row">
        <asp:Label runat="server" ID="lblFirstName" BorderStyle="None" CssClass="text text-right col-lg-1 input-sm">First Name</asp:Label>
        <asp:TextBox runat="server" ID="txtFirstName" CssClass="col-lg-3 input-sm"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="reqFirstName" ControlToValidate="txtFirstName" 
            ErrorMessage="Field cannot be blank" ForeColor="Red" EnableClientScript="False" CssClass="text col-lg-3"></asp:RequiredFieldValidator>
    </div>
    <div class="row">
        <asp:Label runat ="server" ID="lblMiddleName" CssClass="text text-right col-lg-1 input-sm">Middle Name</asp:Label>
        <asp:TextBox runat="server" ID="txtMiddleName" CssClass="text col-lg-3 input-sm"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="reqMiddleName" ControlToValidate="txtMiddleName"
            ErrorMessage="Field Cannot be blank" ForeColor="Red" EnableClientScript="False" CssClass="text input-sm col-lg-3"></asp:RequiredFieldValidator>
    </div>
    <div class="row">
        <asp:Label runat="server" ID="lblLastName" CssClass="text text-right col-lg-1 input-sm">Last Name</asp:Label>
        <asp:TextBox runat="server" ID="txtLastName" CssClass="col-lg-3 input-sm"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="reqLastName" ControlToValidate="txtLastName"
            ErrorMessage="Field Cannot be blank" ForeColor="Red" EnableClientScript="False" CssClass="text col-lg-3 input-sm"></asp:RequiredFieldValidator>
    </div>
</div>