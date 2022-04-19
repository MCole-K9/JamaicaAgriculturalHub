<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrAddressBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrAddressBlock" %>

<div class="">
    <div>
        <asp:Label runat="server" ID="lblAddressTown">Town</asp:Label>
        <asp:TextBox runat="server" ID="txtAddressTown"></asp:TextBox>
        <asp:CustomValidator runat="server" ID="cusAddressTown" ControlToValidate="txtAddressTown"
            ErrorMessage="Address Fields must either be all Filled, or All Empty" 
            onServerValidate="txtAddressTown_Validating" ForeColor="Red"></asp:CustomValidator>
    </div>
    <div>
        <asp:Label runat="server" ID="lblAddressPostOffice">PO Box</asp:Label>
        <asp:TextBox runat="server" ID="txtAddressPostOffice"></asp:TextBox>
        <asp:CustomValidator runat="server" ID="cusAddressPostOffice" ControlToValidate="txtAddressPostOffice"
            ErrorMessage="Address Fields must either be all Filled, or All Empty"
            onServerValidate="txtAddresPostOffice_Validating" ForeColor="Red"></asp:CustomValidator>
    </div>
    <div>
        <asp:Label runat="server" ID="lblAddressParish">Parish</asp:Label>
        <asp:TextBox runat="server" ID="txtAddressParish"></asp:TextBox>
        <asp:CustomValidator runat="server" ID="cusAddressParish" ControlToValidate="txtAddressParish"
            ErrorMessage="Address Fields must either be all Filled, or All Empty"
            onServerValidate="txtAddressParish_Validating" ForeColor="Red"></asp:CustomValidator>
    </div>
</div>