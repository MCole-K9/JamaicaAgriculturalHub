<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UsrOrderItem.ascx.cs" Inherits="JAHub_ASPWebforms.Shop_Controls.UsrOrderItem" %>

<div class="row ">
    <div class="col-xs-3 fit-content-y">
        <img id="ProductImage" runat="server" class="img-responsive img-thumbnail" src="#">
    </div>
    <div class="col-xs-4 fit-content-y">
        <h4 runat="server" id="lblProductName">Product name</h4>
    </div>
    <div class="col-xs-5 fit-content-y">
        <div class="col-xs-4 text-right fit-content-y">
            <h6>$<strong><span id="Price" runat="server">25.00</span> <span class="text-muted">x</span></strong></h6>
        </div>
        <div class="col-xs-6 fit-content-y">
            <div style="display: flex; justify-content: center; align-items: center">
                <asp:Label ID="lblQty" runat="server" Text="0"></asp:Label>
                <asp:Label ID="lblUnit" runat="server" Text="Lbs"></asp:Label>
            </div>
        </div>
        <div class="col-xs-2 fit-content-y">
            <asp:Label ID="lblSubtotal" runat="server" Text="Lbs"></asp:Label>
        </div>
    </div>
</div>