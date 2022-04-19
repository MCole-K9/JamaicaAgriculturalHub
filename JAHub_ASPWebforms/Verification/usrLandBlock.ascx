<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrLandBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrLandBlock" %>
<%@ Reference Control="~/Verification/usrAddressBlock.ascx" %>

<div>
    <asp:PlaceHolder runat="server" ID="phAddressBlock"></asp:PlaceHolder>
    <div>
        <asp:TextBox runat="server" ID="txtLandMeasurement"></asp:TextBox>
    </div>

</div>