<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageProducts.aspx.cs" Inherits="JAHub_ASPWebforms.ManageProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin: 40px 0 ">
        <div class="content-container" style="padding: 40px 40px">
            <button runat="server" id="btnAddProduct" type="button" class="btn btn-primary  fit-content-x" style="padding: 8px 15px">
                <span class="glyphicon glyphicon-plus"></span>
                Add Product
            </button>
            
            <h3>Your Products</h3>
            <hr />
            <div class="row">
                <asp:Panel ID="pnlFarmerProducts" runat="server">
                </asp:Panel>
            </div>
        </div>

    </div>

</asp:Content>
