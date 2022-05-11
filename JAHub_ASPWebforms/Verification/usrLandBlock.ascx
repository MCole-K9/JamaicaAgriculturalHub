<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrLandBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrLandBlock" %>

<%@ Register Src="~/Verification/usrAddressBlock.ascx" TagPrefix="uc" TagName="AddressBlock" %>

<div class="row">
    <div class="row">
        <uc:AddressBlock runat="server" ID="addressBlock" />
    </div>
    <div class="row">
        <asp:Label runat="server" ID="lblLandMeasurement" Text="Land Measurement (in Hectares)*: " CssClass="col-lg-3 input-sm"></asp:Label>
        <asp:TextBox runat="server" ID="txtLandMeasurement" CssClass="col-lg-3 input-sm"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="reqLandMeasurement" ControlToValidate="txtLandMeasurement"
            ErrorMessage="Field is Required" CssClass="text text-danger col-lg-3 input-sm" />
    </div>

</div>