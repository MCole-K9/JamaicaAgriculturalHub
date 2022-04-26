<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UsrOrderSumItem.ascx.cs" Inherits="JAHub_ASPWebforms.Shop_Controls.UsrOrderSumItem" %>

<div style="display: flex; align-items: center">
    <img  id="ProductImage" runat="server" src="#" class="img-responsive img-rounded" style="max-height: 50px; padding: 0 10px;" />
    <div style="flex-grow: 1">
        <div style="display: flex; justify-content:space-between">
            <h5 id="ProductName" runat="server">Item Name</h5>
            <h5 id="ProductPrice" runat="server">Price</h5>
        </div>
        <h5 id="Quantity" runat="server">Quantity</h5>
    </div>

</div>