<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrAddressBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrAddressBlock" %>

<div class="row">
    <div class="row">
        <asp:Label runat="server" ID="lblAddressTown" CssClass="col-lg-3 text">Town</asp:Label>
        <asp:TextBox runat="server" ID="txtAddressTown" CssClass="col-lg-3"></asp:TextBox>
        <asp:CustomValidator runat="server" ID="cusAddressTown" ControlToValidate="txtAddressTown"
            ErrorMessage="Address Fields must either be all Filled, or All Empty" 
            onServerValidate="txtAddressTown_Validating" CssClass="text text-danger col-lg-3"></asp:CustomValidator>
    </div>
    <div class="row">
        <asp:Label runat="server" ID="lblAddressPostOffice">PO Box</asp:Label>
        <asp:TextBox runat="server" ID="txtAddressPostOffice"></asp:TextBox>
        <asp:CustomValidator runat="server" ID="cusAddressPostOffice" ControlToValidate="txtAddressPostOffice"
            ErrorMessage="Address Fields must either be all Filled, or All Empty"
            onServerValidate="txtAddressPostOffice_Validating" CssClass="text text-danger col-lg-3"></asp:CustomValidator>
    </div>
    <div class="row">
        <asp:Label runat="server" ID="lblAddressParish" CssClass="col-lg-3 text">Parish</asp:Label>
        <asp:TextBox runat="server" ID="txtAddressParish" CssClass="col-lg-3 text"></asp:TextBox>
        <asp:CustomValidator runat="server" ID="cusAddressParish" ControlToValidate="txtAddressParish"
            ErrorMessage="Address Fields must either be all Filled, or All Empty"
            onServerValidate="txtAddressParish_Validating" CssClass="text text-danger col-lg-3"></asp:CustomValidator>
    </div>
</div>