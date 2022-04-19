<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="JAHub_ASPWebforms.Cart" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .btn-style{
            width:100%;
        }
        .content-container {
            box-shadow: 3px -4px 30px -2px rgba(171,171,171,0.75);
            -webkit-box-shadow: 3px -4px 30px -2px rgba(171,171,171,0.75);
            -moz-box-shadow: 3px -4px 30px -2px rgba(171,171,171,0.75);
            border-radius: 6px;

            padding: 20px
        }
        .qty-input{
            flex-grow: 1;
            margin-right: 5px;

        }
        .col-height{
            height: fit-content;
        }
    </style>
    <div class="row" style="margin-top: 30px;">
        <div class="col-lg-8">
            <div class="content-container container-fluid">
                <h2>Shopping Cart</h2>
                <hr />
                <asp:Panel ID="pnlCart" runat="server">

                </asp:Panel>
             </div>  
        </div>
        <div class="col-lg-4">
            <div class="content-container">
                <h3>Subtotal(Items: <span id="itemCount" runat="server"></span> ): $<span id="subtotal" runat="server"></span></h3>
                <button class="btn btn-primary btn-style">Proceed to Checkout</button>
            </div>
            
        </div>
    </div>
</asp:Content>
