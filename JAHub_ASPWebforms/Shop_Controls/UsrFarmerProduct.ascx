<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UsrFarmerProduct.ascx.cs" Inherits="JAHub_ASPWebforms.Shop_Controls.UsrFarmerProduct" %>

<div class="row" style="margin: 10px 0">
    <div class="col-xs-3 fit-content-y">
        <img id="ProductImage" runat="server" class="img-responsive img-thumbnail" src="#" style="max-height: 200px;">
    </div>
    <div class="col-xs-3 fit-content-y">
        <h4 runat="server" id="lblProductName">Product name</h4>
        <h4 runat="server" id="lblAvStock">Stock Available</h4>
    </div>
    <div class="col-xs-6 fit-content-y">
        <div class="col-xs-4 text-right fit-content-y">
           <h5>$<span id="Price" runat="server">25.00</span> Per <asp:Label ID="lblUnit" runat="server" Text="Lbs"></asp:Label></h5>
        </div>
        <div class="col-xs-4 fit-content-y">
            <button runat="server" id="btnEdit" type="button" class="btn btn-link fit-content-x">
                <span class="glyphicon glyphicon-pencil"></span>
                Edit
            </button>
        </div>
        <div class="col-xs-4 fit-content-y">
            <button runat="server" id="btnDelete" onserverclick="btnDelete_ServerClick" type="button" class="btn btn-link fit-content-x">
                <span class="glyphicon glyphicon-trash"></span>
                Delete
            </button>
        </div>
    </div>
</div>
