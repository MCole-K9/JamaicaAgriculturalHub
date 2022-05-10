<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrHoldingsBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrHoldingsBlock" %>
<%@ Reference Control="~/Verification/usrLandBlock.ascx" %>
<%@ Reference Control="~/Verification/usrProductBlock.ascx" %>

<div class="row col-1g-5">
    <h4>Holdings</h4>
    <div class="row">
        <asp:PlaceHolder runat="server" ID="phProducts"></asp:PlaceHolder>
        <asp:Button runat="server" ID="btnAddProduct" Text="Add Product" CssClass="btn btn-default col-lg-1 input-sm" OnClick="btnAddProduct_Click" />
        <asp:Button runat="server" ID="btnRemoveProduct" Text="RemoveProduct" Visible="false" CssClass="btn btn-default col-lg-1 input-sm" OnClick="btnRemoveProduct_Click" 
            />
    </div>
    <div class="row">
        <asp:PlaceHolder runat="server" ID="phLandBlock"></asp:PlaceHolder>
        <asp:Button runat="server" ID="btnAddLandEntry" Text="Add Land Entry" CssClass="btn btn-default col-lg-2 input-sm" OnClick="btnAddLandEntry_Click" />
        <asp:Button runat="server" ID="btnRemoveLandEntry"  Text="Remove Land Entry" Visible="false" CssClass="btn btn-default col-lg-2 input-sm" OnClick="btnRemoveLandEntry_Click" />
    </div>  
</div>