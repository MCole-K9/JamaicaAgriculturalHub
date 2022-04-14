<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="JAHub_ASPWebforms.ProductDetail" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .content-container {
            box-shadow: 3px -4px 30px -2px rgba(171,171,171,0.75);
            -webkit-box-shadow: 3px -4px 30px -2px rgba(171,171,171,0.75);
            -moz-box-shadow: 3px -4px 30px -2px rgba(171,171,171,0.75);
            border-radius: 6px;
        }

        .btn-style {
            width: fit-content;
            /*max-width: 10px;*/
        }

        h4 {
            margin: 0 0 40px 0;
        }
        .tab-pane{
            padding: 20px 0;
        }
    </style>

    <div class="row" style="padding: 50px 0;">
        <div class="col-lg-5">
            <div class="container-fluid">
                <img src="#" class="img-responsive img-rounded" runat="server" id="imgProduct" />
            </div>
        </div>
        <div class="col-lg-4">
            <div class="container-fluid content-container" style="background-color: white; padding: 20px 30px;">
                <h4 id="lblProductName" runat="server">Product Name</h4>
                <h4 id="lblProductPrice" runat="server">Product Cost</h4>
                <div style="display: flex; align-items: baseline">
                    <h4 style="margin-right: 10px;">Qty:</h4>
                    <div class="" style="display: flex; align-items: center; justify-content: center;">
                        <asp:Button runat="server" CssClass="btn-style btn btn-primary" type="submit" ID="btnMinus" Text="-"></asp:Button>
                        <input style="margin: 5px 5px; width: 50px; text-align: center;" runat="server" type="text" class="form-control" placeholder="0" aria-describedby="Qty">
                        <asp:Button runat="server" CssClass="btn-style btn btn-primary" type="submit" ID="btnPlus" Text="+"></asp:Button>
                    </div>
                </div>
                <div style="">
                    <asp:Button runat="server" CssClass="btn-style btn btn-primary" type="submit" ID="Button1" Text="Add to Cart"></asp:Button>
                    <asp:Button runat="server" CssClass="btn-style btn btn-primary" type="submit" ID="Button2" Text="Buy Now"></asp:Button>
                </div>
            </div>
        </div>
        <div class="col-lg-3">
            <div class="container-fluid content-container text-center" style="padding: 20px">
                <h4>Farmer Name</h4>
                <img src="http://vtdics.com/ead22/Avatar.png" />

            </div>
        </div>

        <div class="col-12">
            <div class="row">
                <div class="col-lg-4">
                    <div class ="">
                        <h3>Customer Reviews</h3>
                    </div>
                </div>
                <div class="col-lg-8">
                    <ul class="nav nav-tabs nav-pills">
                        <li class="active"><a data-toggle="tab" href="#reviews">Reviews</a></li>
                        <li><a data-toggle="tab" href="#add-review">Add Review</a></li>
                    </ul>

                    <div class="tab-content">
                        <div id="reviews" class="tab-pane fade in active">
                            <h4>No Reviews Yet</h4>
                            <p>Be the First To Review</p>
                            
                        </div>
                        <div id="add-review" class="tab-pane fade" >
                            <h4>Over All Rating</h4>

                            <div class="form-group" style="width: 100%" >
                                <label for="headline">Healine/Summery:</label>
                                <input style="max-width: 100%" runat="server" type="text" class="form-control" id="headline">
                            </div>

                            <div class="form-group">
                                <label for="comment">Comment:</label>
                                <textarea class="form-control" rows="8" id="comment"></textarea>
                            </div>
                            <div style="display: flex; justify-content: end">
                                <asp:Button CssClass="btn btn-primary text-center" ID="btnReviewSubmit" runat="server" Text="Submit" Width="70px" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
