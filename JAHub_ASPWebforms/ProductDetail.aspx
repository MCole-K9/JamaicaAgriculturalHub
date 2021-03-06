<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="JAHub_ASPWebforms.ProductDetail" EnableViewState="true" %>

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

        .tab-pane {
            padding: 20px 0;
        }

        .review-panel {
            overflow-y: scroll;
            max-height: 400px;
        }
        .rating-percentage{
            display: flex;
            width: 100%;
            justify-content: space-between;
            padding: 10px 0;
            
        }
        .star{
            
            margin: 10px 5px;
            height: 35px;
        }
        #clr-rating{
            position: absolute;
            right: 2px;
            top: 2px;
            cursor:pointer;
           
        }
        .d-none{
            display: none;
        }
    </style>

    <div class="row" style="padding: 50px 0;">
        <div class="col-lg-5 fit-content-y">
            <div class="container-fluid">
                <img src="#" class="img-responsive img-rounded" runat="server" id="imgProduct" />
            </div>
        </div>
        <div class="col-lg-4 fit-content-y">
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
        <div class="col-lg-3 fit-content-y">
            <div class="container-fluid content-container text-center" style="padding: 20px">
                <h4 id="FarmerName" runat="server">Farmer Name</h4>
                <img src="http://vtdics.com/ead22/Avatar.png" />

            </div>
        </div>

        <div class="col-lg-12 col-md-12 col-sm-12 fit-content-y " style="margin-top: 20px">
            <div class="row">
                <div class="col-lg-4 fit-content-y" >
                    <div class="">
                        <h3>Customer Reviews</h3>
                        <div class="rating-percentage">
                            <h4 style="padding:  0 5px;">5 Star</h4>
                            <div class="progress" style="flex-grow: 1;">
                                <div runat="server" id="rating5" class="progress-bar" role="progressbar" 
                                    aria-valuemin="0" aria-valuemax="100" >
                                </div>
                            </div>
                            <h4 id="lblpercentage5" runat="server" style="padding:  0 5px;">55%</h4>
                        </div>
                        <div class="rating-percentage">
                            <h4 style="padding: 0 5px;">4 Star</h4>
                            <div class="progress" style="flex-grow: 1;">
                                <div runat="server" id="rating4" class="progress-bar" role="progressbar"
                                    aria-valuemin="0" aria-valuemax="100" style="width: 70%">
                                </div>
                            </div>
                            <h4 id="lblpercentage4" runat="server" style="padding: 0 5px;">55%</h4>
                        </div>
                         <div class="rating-percentage">
                            <h4 style="padding: 0 5px;">3 Star</h4>
                            <div class="progress" style="flex-grow: 1; ">
                                <div runat="server" id="rating3" class="progress-bar" role="progressbar"
                                    aria-valuemin="0" aria-valuemax="100" style="width: 70%">
                                </div>
                            </div>
                            <h4 id="lblpercentage3" runat="server" style="padding: 0 5px;">55%</h4>
                        </div>
                        <div class="rating-percentage">
                            <h4 style="padding: 0 5px;">2 Star</h4>
                            <div class="progress" style="flex-grow: 1; ">
                                <div runat="server" id="rating2" class="progress-bar" role="progressbar"
                                    aria-valuemin="0" aria-valuemax="100" style="width: 70%">
                                </div>
                            </div>
                            <h4 id="lblpercentage2" runat="server" style="padding: 0 5px;">55%</h4>
                        </div>
                        <div class="rating-percentage">
                            <h4 style="padding: 0 5px;">1 Star</h4>
                            <div class="progress" style="flex-grow: 1;">
                                <div runat="server" id="rating1" class="progress-bar" role="progressbar"
                                    aria-valuemin="0" aria-valuemax="100" style="width: 70%">
                                </div>
                            </div>
                            <h4 id="lblpercentage1" runat="server" style="padding: 0 5px;">55%</h4>
                        </div>
                    </div>
                </div>
                <div class="col-lg-8 fit-content-y">
                    <ul class="nav nav-tabs nav-pills">
                        <li class="active"><a data-toggle="tab" href="#reviews">Reviews</a></li>
                        <li><a data-toggle="tab" href="#add-review">Add Review</a></li>
                    </ul>

                    <div class="tab-content">
                        <div id="reviews" class="tab-pane fade in active">

                            <div id="ZRMessage" runat="server">
                                <h4>No Reviews Yet</h4>
                                <p>Be the First To Review</p>
                            </div>
                            
                            <asp:Panel ID="pnlReviews" runat="server" CssClass="review-panel">
                            </asp:Panel>
                        </div>
                        <div id="add-review" class="tab-pane fade">
                            <%--<h5>Over All Rating</h5>--%>
                            <label for="">Over All Rating</label>
                            <div style="position: relative;">
                                <img class="star fit-content-y" src="https://vtdics.com/ead22/whitestar.png"/>
                                <img class="star fit-content-y" src="https://vtdics.com/ead22/whitestar.png"/>
                                <img class="star fit-content-y" src="https://vtdics.com/ead22/whitestar.png"/>
                                <img class="star fit-content-y" src="https://vtdics.com/ead22/whitestar.png"/>
                                <img class="star fit-content-y" src="https://vtdics.com/ead22/whitestar.png"/>
                                <p id="clr-rating" class="d-none" onclick="deselectStars()">Clear Rating</p>
                            </div>
                            <asp:RangeValidator ID="rvRating" runat="server" ErrorMessage="You have not Selected a Rating" Display="Dynamic" ControlToValidate="hidRating" MaximumValue="5" MinimumValue="1" CssClass="v-text" BackColor="White"></asp:RangeValidator>
                            <div class="form-group" style="width: 100%">
                                <label for="headline">Healine/Summery:</label>
                                <input style="max-width: 100%" enableviewstate="true" runat="server" type="text" class="form-control" id="headline">
                            </div>
                            <asp:RequiredFieldValidator ID="rfvHeadline" runat="server" ErrorMessage="Healine Is Required" ControlToValidate="headline" CssClass="v-text"></asp:RequiredFieldValidator>

                            <div class="form-group">
                                <label for="comment">Comment:</label>
                                <textarea runat="server" enableviewstate="true" class="form-control" rows="8" id="comment"></textarea>
                            </div>
                            <asp:RequiredFieldValidator ID="rfvComment" runat="server" ErrorMessage="Comment Is Required" ControlToValidate="comment" CssClass="v-text"></asp:RequiredFieldValidator>
                            <div style="display: flex; justify-content: end">
                                <asp:Button CssClass="btn btn-primary text-center" ID="btnReviewSubmit" runat="server" OnClick="btnReviewSubmit_Click" Text="Submit" Width="70px" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <%--Holdings the star rating--%>
    <input type="number" name="hidRating" id="hidRating" runat="server"  enableviewstate="true" value="0" style="visibility: hidden"/>

    <script type="text/javascript">

        let stars = document.querySelectorAll(".star");
        let rating = 0;

        function deselectStars() {

            for (var i = 0; i <= stars.length; i++) {

                rating = 0;
               
                document.getElementById("<%=hidRating.ClientID%>").value = rating;

                stars[i].setAttribute("src", "https://vtdics.com/ead22/whitestar.png");

            }
           
        }

        stars.forEach((star, index) => {

            
            star.addEventListener("mouseover", () => {
                

                for (var i = 0; i <= index; i++) {

                    stars[i].setAttribute("src", "https://vtdics.com/ead22/yellowstar.png");
                }
                
            });

            star.addEventListener("mouseout", deselectStars);

            star.addEventListener("click", () => {

                for (var i = 0; i <= index; i++) {

                    stars[i].setAttribute("src", "https://vtdics.com/ead22/yellowstar.png");

                }

                stars.forEach((star) => {

                    star.removeEventListener("mouseout", deselectStars);
                   
                    if (star.getAttribute("src") === "https://vtdics.com/ead22/yellowstar.png") {
                        //Doesnt really prevent edge cases
                        if (rating <= 5) {
                            rating++
                        }
                        
                    };
                });
                

                document.getElementById("<%=hidRating.ClientID%>").value = rating;
                

                
                $("#clr-rating").removeClass("d-none");

            });
        });
       

    </script>

</asp:Content>
