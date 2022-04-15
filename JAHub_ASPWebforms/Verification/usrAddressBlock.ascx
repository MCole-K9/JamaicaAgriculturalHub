<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrAddressBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrAddressBlock" %>

<div class="">
    <div>
        <asp:Label runat="server" ID="lblAddressTown">Town</asp:Label>
        <asp:TextBox runat="server" ID="txtAddressTown"></asp:TextBox>
        <asp:CustomValidator runat="server" ID="cusAddressTown"></asp:CustomValidator>
    </div>
    <div>
        <asp:Label runat="server" ID="lblAddressPostOffice">PO Box</asp:Label>
        <asp:TextBox runat="server" ID="txtAddressPostOffice"></asp:TextBox>
        <asp:CustomValidator runat="server" ID="cusAddressPostOffice"></asp:CustomValidator>
    </div>
    <div>
        <asp:Label runat="server" ID="lblAddressParish">Parish</asp:Label>
        <asp:TextBox runat="server" ID="txtAddressParish"></asp:TextBox>
        <asp:CustomValidator runat="server" ID="cusAddressParish"></asp:CustomValidator>
    </div>
</div>