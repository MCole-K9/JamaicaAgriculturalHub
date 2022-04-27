<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="JAHub_ASPWebforms.AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin: 40px 0">
        <div class="content-container row" style="padding: 40px 40px; margin: 0 auto;">
            <div class="col-lg-6">
                <img id="ProductImage" class="img-responsive img-rounded img-thumbnail" src="Resources/700x500.png"/>
                <asp:FileUpload ID="fupProductImage" runat="server" />

            </div>
            <div class="col-lg-6">
                <div class="form-group">
                    <label for="usr">Product Name:</label>
                    <input type="text" class="form-control" id="usr">
                </div>
                <div class="form-group">
                    <label for="usr">Price</label>
                    <input type="text" class="form-control" id="usr">
                </div>
                <div class="form-group">
                    <label for="usr">Stock</label>
                    <input type="text" class="form-control" id="usr">
                </div>
                <div class="form-group">
                    <label for="usr">Name:</label>
                    <input type="text" class="form-control" id="usr">
                </div>
                <div class="form-group">
                    <label for="usr">Name:</label>
                    <input type="text" class="form-control" id="usr">
                </div>
            </div>
        </div>

    </div>

    <script type="text/javascript">
        let fileSelector = document.getElementById("<%= fupProductImage.ClientID%>");
        fileSelector.addEventListener("change", () => {

            const files = event.target.files;

            if (files && files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    
                    $('#ProductImage').attr('src', e.target.result);
                }
                reader.readAsDataURL(files[0]);
            }
        });
    </script>
</asp:Content>
