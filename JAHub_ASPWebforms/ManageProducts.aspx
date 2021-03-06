<%@ Page Title="" Language="C#" MasterPageFile="~/UserPortal.Master" AutoEventWireup="true" CodeFile="ManageProducts.aspx.cs" EnableViewState="false" Inherits="JAHub_ASPWebforms.ManageProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin: 40px 0 ">
        <div class="content-container"  style="padding: 40px 40px; margin: 0 auto; max-width: 95%;">
            <button runat="server" id="btnAddProduct" onserverclick="btnAddProduct_ServerClick" type="button" class="btn btn-primary  fit-content-x" style="padding: 8px 15px">
                <span class="glyphicon glyphicon-plus"></span>
                Add Product
            </button>
            
            <h3>Your Products</h3>
            <hr />
            <div id="NPMessage" runat="server">
                    <h4>You Current Do Not Have any Products</h4>
                    <p>Click Add Product To Get Started</p>
              </div>
            <div class="row">
                <asp:Panel ID="pnlFarmerProducts" runat="server">
                </asp:Panel>
            </div>
        </div>

    </div>
    <script type="text/javascript">
        
        function confirmDelete() {
            
            return !confirm("Are you sure you want to delete this item");
        }

        $(document).ready(() => {

            $(".active").toggleClass("active");
            $("#manageproducts").toggleClass("active");

        })
    </script>

</asp:Content>
