<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderDetails.aspx.cs" Inherits="JAHub_ASPWebforms.OrderDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin: 40px 0">
        <div class="content-container" style="padding: 40px 40px; max-width: 70%; margin: 0 auto;">
            <h3>Order Details</h3>
            
            <hr />
            <div style="display: flex; justify-content: space-between; margin:20px 0;" >
                <h4>Items Ordered</h4>
                <h4 id="OrderDate" runat="server">Date</h4>
            </div>
            <div class="row">
                <asp:Panel ID="pnlOrderItems" runat="server" ScrollBars="Vertical" Height="300px">
                </asp:Panel>
            </div>
            <div class="row" style="margin-top: 30px;">
                <div class="col-lg-6 fit-content-y">
                    <h4>Shipping Details</h4>
                    <h5>Name: <span id="ShipName" runat="server"></span> Matthew Cole</h5>
                    <h5>Email: <span id="ShipEmail" runat="server"></span> Email</h5>

                    <h5> <strong> Shipping Adress</strong> </h5>

                     <h5>Street Adrees: <span id="ShipStreetAdress" runat="server"></span> </h5>
                    <h5>City: <span id="ShipCity" runat="server"></span></h5>
                    <h5>Parish: <span id="ShipParish" runat="server"></span>  </h5>


                </div>
                <div class="col-lg-6 fit-content-y text-right">
                    <h4>Payment Details</h4>
                    <h5>Name: <span id="BillingName" runat="server"></span> Matthew Cole</h5>
                    <h5>Email: <span id="BillingEmail" runat="server"></span> Email</h5>
                    <h5> <strong> Billing Adress</strong> </h5>

                     <h5>Street Adrees: <span id="BillingStreetAddress" runat="server"></span> </h5>
                    <h5>City: <span id="BillingCity" runat="server"></span></h5>
                    <h5>Parish: <span id="BillingParish" runat="server"></span>  </h5>
                   
                    

                </div>
            </div>

        </div>

    </div>
</asp:Content>
