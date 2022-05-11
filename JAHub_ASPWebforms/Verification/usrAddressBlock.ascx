<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrAddressBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrAddressBlock" %>

<div class="row">
    <div class="row">
        <asp:Label runat="server" ID="lblAddressTown" CssClass="col-lg-1 col-md-2 col-sm-3 col-xs-3 text input-sm">Town</asp:Label>
        <asp:TextBox runat="server" ID="txtAddressTown" CssClass="form-control col-lg-3 input-sm"></asp:TextBox>
        <asp:CustomValidator runat="server" ID="cusAddressTown" ControlToValidate="txtAddressTown"
            ErrorMessage="Address Fields must either be all Filled, or All Empty" 
            onServerValidate="txtAddressTown_Validating" CssClass="text text-danger col-lg-3 input-sm"></asp:CustomValidator>
    </div>
    <div class="row">
        <asp:Label runat="server" ID="lblAddressPostOffice" CssClass="col-lg-1 col-md-2 col-sm-3 col-xs-3 text input-sm">PO Box</asp:Label>
        <asp:TextBox runat="server" ID="txtAddressPostOffice" CssClass="form-control col-lg-3 input-sm"></asp:TextBox>
        <asp:CustomValidator runat="server" ID="cusAddressPostOffice" ControlToValidate="txtAddressPostOffice"
            ErrorMessage="Address Fields must either be all Filled, or All Empty"
            onServerValidate="txtAddressPostOffice_Validating" CssClass="text text-danger col-lg-3 input-sm"></asp:CustomValidator>
    </div>
    <div class="row">
        <asp:Label runat="server" ID="lblAddressParish" CssClass="col-lg-1 col-md-2 col-sm-3 col-xs-3 text input-sm">Parish</asp:Label>
        <asp:TextBox runat="server" ID="txtAddressParish" CssClass="form-control col-lg-3 text input-sm"></asp:TextBox>
        <asp:CustomValidator runat="server" ID="cusAddressParish" ControlToValidate="txtAddressParish"
            ErrorMessage="Address Fields must either be all Filled, or All Empty"
            onServerValidate="txtAddressParish_Validating" CssClass="text text-danger col-lg-3 input-sm"></asp:CustomValidator>
    </div>
</div>