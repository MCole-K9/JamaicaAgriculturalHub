<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UsrCartItem.ascx.cs" Inherits="JAHub_ASPWebforms.Shop_Controls.UsrCartItem" %>

<div class="row">
    <div class="col-xs-3 col-height">
        <img id="ProductImage" runat="server" class="img-responsive img-thumbnail" src="#">
    </div>
    <div class="col-xs-4 col-height">
        <h4 runat="server" id="lblProductName">Product name</h4>
    </div>
    <div class="col-xs-5 col-height">
        <div class="col-xs-4 text-right col-height">
            <h6>$<strong><span id="Price" runat="server">25.00</span> <span class="text-muted">x</span></strong></h6>
        </div>
        <div class="col-xs-6 col-height">
            <div style="display: flex; justify-content: center; align-items: center">
                <asp:TextBox CssClass="qty-input form-control input-sm " AutoPostBack="true" OnTextChanged="txtQuantity_TextChanged" ID="txtQuantity"  runat="server" Text="1"></asp:TextBox>
                <%--<input change runat="server" style="flex-grow: 1; margin-right: 5px;" type="text" class="form-control input-sm" value="1">--%>
                <asp:Label ID="lblUnit" runat="server" Text="Lbs"></asp:Label>
            </div>
        </div>
        <div class="col-xs-2 col-height">
            <button type="button" class="btn btn-link btn-xs btn-style">
                <span class="glyphicon glyphicon-trash"></span>
            </button>
        </div>
    </div>
</div>
