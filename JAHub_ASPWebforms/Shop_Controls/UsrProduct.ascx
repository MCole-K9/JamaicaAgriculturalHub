<%@ Control Language="C#"  AutoEventWireup="true" CodeBehind="UsrProduct.ascx.cs" Inherits="JAHub_ASPWebforms.Shop_Controls.UsrProduct" %>

<div class="col-lg-3 col-md-6">
    <div class="panel panel-default ">
        <div class="panel-heading">
            <img id="ProductImage" class="img-responsive img-rounded" runat="server"/>
        </div>
        <div class="panel-body text-center">
            <h4 id="ProductName" runat="server">Product Name</h4> 
            <h4 id="ProductPrice" runat="server">Product Price</h4>

            <div style="display: flex; justify-content:space-between; margin: 20px 0 0 0;">
                <button id="btnViewProduct" runat="server"  onserverclick="btnViewProduct_ServerClick"> View</button>
                <button id="btnAddToCart" runat="server">Add to Cart</button>
            </div>
        </div>
    </div>
</div>


    
 
    