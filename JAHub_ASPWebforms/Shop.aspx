<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="JAHub_ASPWebforms.Shop" Title="Shop" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .category-dropdown {
            width: 250px;
        }

        .btnSearch {
            width: fit-content;
        }
    </style>
    
        <div class="container-fluid" style="display: flex; width: 100%; margin: 20px 0 0 0">
            <div style="flex-grow: 1;">
                <asp:DropDownList CssClass="category-dropdown" ID="CategoryDropDown" runat="server" Height="32px"></asp:DropDownList>
            </div>
            <div style="display: flex; justify-content: space-evenly">

                <a href="#">
                    <div style="margin: 0 70px 0  0; display: flex; align-items: center">
                        <img style="max-height: 33px; margin-right: 5px;" class="img-responsive img-rounded" src="Resources/cart-arrow-down-solid.svg" />
                        <h4 style="position: relative;" id="Cart" runat="server">$0.0</h4>
                    </div>
                </a>
                <div>
                    <div class="input-group">
                        <input runat="server" type="text" class="form-control" placeholder="Item Search" aria-describedby="item Search">
                        <%--<span  id="btnProductSearch" role="button" runat="server" class="input-group-addon">
                   <asp:Button ID="Button1" runat="server" Text="Button" Visible="False" />
               </span>--%>
                        <div class="input-group-btn">
                            <button class="btn btn-primary btnSearch" type="submit">
                                <span class="glyphicon glyphicon-search"></span>
                            </button>
                        </div>
                    </div>
                </div>
            </div>

        </div>

    <div class="row" style="margin: 100px 0;">
        <asp:Panel ID="pnlProducts" runat="server">
        </asp:Panel>
    </div>


</asp:Content>
