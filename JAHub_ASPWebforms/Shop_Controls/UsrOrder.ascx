<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UsrOrder.ascx.cs" Inherits="JAHub_ASPWebforms.Shop_Controls.UsrOrder" %>

<div class="panel">
    <div class="page-header" style="display: flex; justify-content: space-between;">
        <div>
            <h5 class="text-muted"><strong>Shipping To</strong> </h5>
            <h5>Street Adrees: <span id="ShipStreetAdress" runat="server"></span></h5>
            <h5>City: <span id="ShipCity" runat="server"></span></h5>
            <h5>Parish: <span id="ShipParish" runat="server"></span></h5>
        </div>
        <div>
            <h5 class="text-muted"><strong>Ordered On</strong> </h5>
             <h5 id="OrderDate" runat="server">Date</h5>
        </div>
        <div>
            <h5 class="text-muted"><strong>Subtotal</strong> </h5>
             <h5 id="Subtotal" runat="server">Date</h5>
        </div>
        <button class="btn btn-default btn-link fit-content-x">View Order Details</button>
    </div>
</div>
