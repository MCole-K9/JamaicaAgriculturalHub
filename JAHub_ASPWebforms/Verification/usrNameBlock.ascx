<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrNameBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrNameBlock" %>

<div class="">
    <h4>Name *</h4>
    <div>
        <asp:Label runat="server" ID="lblFirstName" BorderStyle="None" Width="140px" CssClass="text-right">First Name</asp:Label>
        <asp:TextBox runat="server" ID="txtFirstName"></asp:TextBox>
    </div>
    <div>
        <asp:Label runat ="server" ID="lblMiddleName" Width="140px" CssClass="text-right">Middle Name</asp:Label>
        <asp:TextBox runat="server" ID="txtMiddleName"></asp:TextBox>
    </div>
    <div>
        <asp:Label runat="server" ID="lblLastName" Width="140px" CssClass="text-right">Last Name</asp:Label>
        <asp:TextBox runat="server" ID="txtLastName"></asp:TextBox>
    </div>
</div>