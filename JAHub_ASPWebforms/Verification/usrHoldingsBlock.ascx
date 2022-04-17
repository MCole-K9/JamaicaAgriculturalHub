<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrHoldingsBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrHoldingsBlock" %>
<%@ Reference Control="~/Verification/usrLandBlock.ascx" %>
<%@ Reference Control="~/Verification/usrProductBlock.ascx" %>

<div>
    <div>
        <asp:PlaceHolder runat="server" ID="phProducts"></asp:PlaceHolder>
        <asp:Button runat="server" ID="btnAddProduct" Text="Add Product" />
        <asp:Button runat="server" ID="btnRemoveProduct" Text="RemoveProduct" Visible="false" />
    </div>
    <div>
        <asp:PlaceHolder runat="server" ID="phLandBlock"></asp:PlaceHolder>
        <asp:Button runat="server" ID="btnAddLandEntry" Text="Add Land Entry" />
        <asp:Button runat="server" ID="btnRemoveLandEntry"  Text="Remove Land Entry" Visible="false" />
    </div>  
</div>