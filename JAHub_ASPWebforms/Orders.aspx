<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="JAHub_ASPWebforms.Orders" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin: 40px 0">
        <div class="content-container" style="padding: 40px 40px; max-width: 90%; margin: 0 auto;">
            <h3>Orders</h3>
            <hr />
            <div class="row" style="padding: 0 20px;">
                <asp:Panel ID="pnlOrders" runat="server">
                </asp:Panel>
            </div>
        </div>
    </div>
</asp:Content>
