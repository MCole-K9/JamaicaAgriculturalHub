<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="JAHub_ASPWebforms.AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .mt-4{
            margin-top: 16px;
        }
        .d-block{
            display: block;
        }
        .mw-input{
            max-width: 100%;
        }
    </style>

    <div style="margin: 40px 0">
        <div class="content-container row" style="padding: 40px 40px; margin: 0 auto; max-width: 80%">
            <div class="col-lg-6 fit-content-y">
                <img id="ProductImage" runat="server" class="img-responsive img-rounded img-thumbnail" src="Resources/700x500.png"/>
                <asp:FileUpload ID="fupProductImage" CssClass="mt-4" runat="server" />

            </div>
            <div class="col-lg-6 fit-content-y">
                <div class="form-group">
                    <label for="usr">Product Name:</label>
                    <input type="text" class="form-control" runat="server" id="ProductName" style="max-width: 100%">
                </div>
                <div class="form-group">
                    <label for="usr">Price</label>
                    <input type="text" class="form-control mw-input" runat="server" id="Price" style="max-width: 100%">
                </div>
                <div class="form-group">
                    <label for="usr">Stock</label>
                    <input type="text" class="form-control" runat="server" id="Stock" style="max-width: 100%">
                </div>
                <div class="form-group">
                    <label for="usr">Name:</label>
                    <input type="text" class="form-control" id="usr" style="max-width: 100%">
                </div>
                <div class="form-group">
                    <label for="usr">Category:</label>
                    <asp:DropDownList ID="CategoryDropDown" CssClass="d-block mw-input" runat="server" Height="35px"></asp:DropDownList>
                </div>

                <div style="display: flex; justify-content: end; ">
                    <button id="btnSave" runat="server" onserverclick="btnSave_ServerClick" class="btn btn-default fit-content-x" style="padding: 8px 30px;">Save</button>
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
                    
                    $('#'+'<%=ProductImage.ClientID%>').attr('src', e.target.result);
                }
                reader.readAsDataURL(files[0]);
            }
        });
    </script>
</asp:Content>
