﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="JAHub_ASPWebforms.Checkout" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .content-container {
            box-shadow: 3px -4px 30px -2px rgba(171,171,171,0.75);
            -webkit-box-shadow: 3px -4px 30px -2px rgba(171,171,171,0.75);
            -moz-box-shadow: 3px -4px 30px -2px rgba(171,171,171,0.75);
            border-radius: 6px;
            padding: 20px;
        }

        /* Style the buttons that are used to open and close the accordion panel */
        .accordion {
            /* background-color: #eee;
            color: #444;
            cursor: pointer;
            padding: 18px;
            width: 100%;
            text-align: left;
            border: none;
            outline: none;*/
            transition: 0.4s;
        }

            /* Add a background color to the button if it is clicked on (add the .active class with JS), and when you move the mouse over it (hover) */
            #payment .active, .accordion:hover {
                /*background-color: #ccc;*/
            }

        /* Style the accordion panel. Note: hidden by default */
        .acc-content {
            padding: 0 18px;
            background-color: white;
            display: none;
            overflow: hidden;
        }

        .inlineimage {
            max-width: 470px;
            margin-right: 8px;
            margin-left: 10px
        }

        .images {
            display: inline-block;
            max-width: 98%;
            height: auto;
            width: 22%;
            margin: 1%;
            left: 20px;
            text-align: center
        }
    </style>

    <ul class="nav nav-tabs nav-justified" style="margin-top: 50px">
        <li class="active"><a data-toggle="tab" href="#shipping-details">Shipping Details</a></li>
        <li><a data-toggle="tab" href="#payment-review">Payment & Review</a></li>
    </ul>

    <div class="tab-content">
        <div id="shipping-details" class="tab-pane fade in active">
            <div class="row" style="margin: 50px 0">

                <div class="col-lg-7 fit-content-y">
                    <div class="content-container">

                        <h4>Shipping Address</h4>
                        <div class="row">
                            <div class="col-lg-6 fit-content-y">
                                <div class="form-group">
                                    <label for="ShipFirstName">First Name:</label>
                                    <input type="text" class="form-control" runat="server" style="max-width: 100%" id="ShipFirstName">
                                </div>
                            </div>
                            <div class="col-lg-6 fit-content-y">
                                <div class="form-group">
                                    <label for="ShipLastName">Last Name:</label>
                                    <input type="text" class="form-control" runat="server" style="max-width: 100%" id="ShipLastName">
                                </div>
                            </div>
                            <div class="col-lg-12 fit-content-y">
                                <div class="form-group">
                                    <label for="ShipEmail">Email Address:</label>
                                    <input type="text" class="form-control" runat="server" style="max-width: 100%" id="ShipEmail">
                                </div>
                            </div>
                            <div class="col-lg-12 fit-content-y">
                                <div class="form-group">
                                    <label for="ShipStreetAdress">Street Address:</label>
                                    <input type="text" class="form-control" runat="server" style="max-width: 100%" id="ShipStreetAdress">
                                </div>
                            </div>
                            <div class="col-lg-6 fit-content-y">
                                <div class="form-group">
                                    <label for="ShipCity">City/Town:</label>
                                    <input type="text" class="form-control" runat="server" style="max-width: 100%" id="ShipCity">
                                </div>
                            </div>
                            <div class="col-lg-6 fit-content-y">
                                <div class="form-group">
                                    <label for="ShipParish">Parish:</label>
                                    <input type="text" class="form-control" runat="server" style="max-width: 100%" id="ShipParish">
                                </div>
                            </div>

                        </div>
                        <div style="display: flex; justify-content: end">
                            <button type="button" id="btnNext" class="btn btn-primary fit-content-x" style="padding: 5px 30px">Next</button>
                        </div>
                    </div>
                </div>
                <div class="col-lg-5 fit-content-y">
                    <div class="content-container">
                        <div id="so-summery">
                            <h4>Order Summary</h4>
                            <h5><span runat="server" id="CartCount">0</span> Item(s) in Cart</h5>
                            <asp:Panel ID="pnlOrderSummery" runat="server">

                            </asp:Panel>
                        </div>


                    </div>


                </div>
            </div>

        </div>
        <div id="payment-review" class="tab-pane fade">
            <div class="row" style="margin: 50px 0">

                <div class="col-lg-7 fit-content-y">
                    <div class="content-container">
                        <h4>Payment Details</h4>
                        <div id="payment">

                            <%--<button class="accordion ">Section 1</button>--%>
                            <div class="radio fit-content-x">
                                <label>
                                    <input class="accordion fit-content-x" name="paymentMethod" type="radio" value="Credit/Debit Card">Pay With Credit/Debit Card</label>
                            </div>
                            <div class="acc-content">
                                <div class="row">
                                    <div class="col-xs-12 col-md-6 col-md-offset-4">
                                        <div class="panel panel-default">
                                            <div class="panel-heading">
                                                <div class="row">
                                                    <h3 class="text-center">Payment Details</h3>
                                                    <%--<div class="inlineimage">
                                                        <img class="img-responsive images" src="https://cdn0.iconfinder.com/data/icons/credit-card-debit-card-payment-PNG/128/Mastercard-Curved.png">
                                                        <img class="img-responsive images" src="https://cdn0.iconfinder.com/data/icons/credit-card-debit-card-payment-PNG/128/Discover-Curved.png">
                                                        <img class="img-responsive images" src="https://cdn0.iconfinder.com/data/icons/credit-card-debit-card-payment-PNG/128/Paypal-Curved.png">
                                                        <img class="img-responsive images" src="https://cdn0.iconfinder.com/data/icons/credit-card-debit-card-payment-PNG/128/American-Express-Curved.png">
                                                    </div>--%>
                                                </div>
                                            </div>
                                            <div class="panel-body">
                                                <div class="row">
                                                    <div class="col-xs-12 fit-content-y">
                                                        <div class="form-group">
                                                            <label>CARD NUMBER</label>
                                                            <div class="input-group">
                                                                <input type="tel" class="form-control" placeholder="Valid Card Number" />
                                                                <span class="input-group-addon"><span class="fa fa-credit-card"></span></span>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-xs-7 col-md-7 fit-content-y">
                                                        <div class="form-group">
                                                            <label><span class="hidden-xs">EXPIRATION</span><span class="visible-xs-inline">EXP</span> DATE</label>
                                                            <input type="tel" class="form-control" placeholder="MM / YY" />
                                                        </div>
                                                    </div>
                                                    <div class="col-xs-5 col-md-5 pull-right fit-content-y">
                                                        <div class="form-group">
                                                            <label>CV CODE</label>
                                                            <input type="tel" class="form-control" placeholder="CVC" />
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="row">
                                                    <div class="col-xs-12 fit-content-y">
                                                        <div class="form-group">
                                                            <label>CARD OWNER</label>
                                                            <input type="text" class="form-control" placeholder="Card Owner Name" />
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                           <%-- <div class="panel-footer">
                                                <div class="row">
                                                    <div class="col-xs-12 fit-content-y">
                                                        <button class="btn btn-success btn-lg btn-block">Confirm Payment</button>
                                                    </div>
                                                </div>
                                            </div>--%>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="radio fit-content-x">
                                <label>
                                    <input class="accordion fit-content-x" name="paymentMethod" type="radio" value="Paypal">Pay With Paypal</label>
                            </div>
                            <div class="acc-content">
                                <p>Click Place Order and We'll send you on to PayPal so that you can complete your purchase. After the transaction has gone through, the order will be placed.Thank you for Shopping</p>
                            </div>
                        </div>


                        <div class="checkbox">
                            <label>
                                <input id="billingIsShipping" type="checkbox" class="fit-content-x" checked value="">Billing Address is the same as Shipping Address</label>
                        </div>
                        <%----Address Block--%>

                        <div id="BillingAddress" class="row" style="display: none">
                            <div class="col-lg-6 fit-content-y">
                                <div class="form-group">
                                    <label for="BillingFirstNam">First Name:</label>
                                    <input type="text" class="form-control" style="max-width: 100%" runat="server" id="BillingFirstName">
                                </div>
                            </div>
                            <div class="col-lg-6 fit-content-y">
                                <div class="form-group">
                                    <label for="BillingLastName">Last Name:</label>
                                    <input type="text" class="form-control" style="max-width: 100%" runat="server" id="BillingLastName">
                                </div>
                            </div>
                            <div class="col-lg-12 fit-content-y">
                                <div class="form-group">
                                    <label for="BillingEmail">Email Address:</label>
                                    <input type="text" class="form-control" style="max-width: 100%" runat="server" id="BillingEmail">
                                </div>
                            </div>
                            <div class="col-lg-12 fit-content-y">
                                <div class="form-group">
                                    <label for="BillingStreetAdress">Street Address:</label>
                                    <input type="text" class="form-control" style="max-width: 100%" runat="server" id="BillingStreetAdress">
                                </div>
                            </div>
                            <div class="col-lg-6 fit-content-y">
                                <div class="form-group">
                                    <label for="BillingCity">City/Town:</label>
                                    <input type="text" class="form-control" style="max-width: 100%" runat="server" id="BillingCity">
                                </div>
                            </div>
                            <div class="col-lg-6 fit-content-y">
                                <div class="form-group">
                                    <label for="BIllingParish">Parish:</label>
                                    <input type="text" class="form-control" style="max-width: 100%" runat="server" id="BIllingParish">
                                </div>
                            </div>

                        </div>
                        <%----Address Block--%>
                        <div style="display: flex; justify-content: space-between">
                            <button type="button" id="btnBack" class="btn btn-primary fit-content-x" style="padding: 5px 30px;">Back</button>
                            <button type="button" runat="server" onserverclick="btnPlaceOrder_ServerClick" id="btnPlaceOrder" class="btn btn-primary fit-content-x" style="padding: 5px 50px; visibility: hidden;">Place Order</button>
                        </div>
                    </div>
                </div>
                <div class="col-lg-5 fit-content-y">
                    <div class="content-container">
                        <div id="bo-summery">
                            <%--Cloneing Order Summery Div from Shipping address Tab here--%>
                        </div>
                        <hr />
                        <div style="display: flex; justify-content:space-between">
                            <h4>Subtotal</h4>
                            <h4 id="Subtotal" runat="server"></h4>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <input type="hidden" name="hidPaymentMethod" id="hidPaymentMethod" runat="server" enableviewstate="true" />
    <input type="hidden" name="hidBIS" id="hidBillingIsShipping" runat="server" value="true" enableviewstate="true" />


    <script type="text/javascript">

        $("#btnNext").on("click", (event) => {
            event.preventDefault();
            $('.nav-tabs > .active').next('li').find('a').trigger('click');

            //Billing is Shipping by Default 
            $("#BillingFirstName").val($("#ShipFirstName").val());
            $("#BillingLastName").val($("#ShipLastName").val());
            $("#BillingEmail").val($("#ShipEmail").val());
            $("#BillingStreetAdress").val($("#ShipStreetAdress").val());
            $("#BillingCity").val($("#ShipCity").val());
            $("#BillingParish").val($("#ShipParish").val());
        });

        $("#btnBack").on("click", (event) => {
            event.preventDefault();
            $('.nav-tabs > .active').prev('li').find('a').trigger('click');

        });

        var acc = document.getElementsByClassName("accordion");
        var i;

        // Attaching click event handlers to all radio buttons...
        $('input[type="radio"]').bind('change', function () {

            /* Toggle between adding and removing the "active" class,
                       to highlight the button that controls the panel */



            $(this).toggleClass("active");

            /* Toggle between hiding and showing the active panel */

            let container = $(this).parent().parent();

            let panel = container.next();

            if (panel.css("display") === "block") {

                panel.css("display", "none");
            } else {

                panel.css("display", "block");
            }
            // Processing only those that match the name attribute of the currently clicked button...
            $('input[name="' + $(this).attr('name') + '"]').not($(this)).trigger('deselect'); // Every member of the current radio group except the clicked one...

            //Make Place Order Btn Visible
            $("#" + "<%=btnPlaceOrder.ClientID%>").css("visibility", " visible")
            //Set Payment Method
            $("#" + "<%=hidPaymentMethod.ClientID%>").val($(this).val());
        });

        $('input[type="radio"]').bind('deselect', function () {

            let container = $(this).parent().parent();


            let panel = container.next();

            if (panel.css("display") === "block") {

                panel.css("display", "none");
            } else {

                panel.css("display", "none");
            }
        });



        let billingShippingRdb = document.getElementById("billingIsShipping");

        billingShippingRdb.addEventListener("change", () => {


            if (!billingShippingRdb.checked) {

                $("#BillingFirstName").val("");
                $("#BillingLastName").val("");
                $("#BillingEmail").val("");
                $("#BillingStreetAdress").val("");
                $("#BillingCity").val("");
                $("#BillingParish").val("");

                $("#BillingAddress").css("display", "block");

                $("#<%=hidBillingIsShipping.ClientID%>").val("true");
            } else {

                $("#BillingFirstName").val($("#ShipFirstName").val());
                $("#BillingLastName").val($("#ShipLastName").val());
                $("#BillingEmail").val($("#ShipEmail").val());
                $("#BillingStreetAdress").val($("#ShipStreetAdress").val());
                $("#BillingCity").val($("#ShipCity").val());
                $("#BillingParish").val($("#ShipParish").val());


                $("#BillingAddress").css("display", "none");

                $("#<%=hidBillingIsShipping.ClientID%>").val("false");

            }

        });

        <%--let divToClone = document.getElementById('<%=pnlOrderSummery.ClientID%>');--%>

        let divToClone = document.getElementById("so-summery");
        let clone = divToClone.cloneNode(true);
        clone.id += 1;
        document.getElementById("bo-summery").appendChild(clone);

    </script>

</asp:Content>
