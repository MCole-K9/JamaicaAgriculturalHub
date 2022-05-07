<%@ Page Title="" Language="C#" MasterPageFile="~/UserPortal.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="JAHub_ASPWebforms.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="UserPortalCss.css" rel="stylesheet" />
    <link href="Dashboard.css" rel="stylesheet" />


    <main>
        <h1>Dashboard</h1>

        <div class="date-buttons">
            <asp:Button Class="box" ID="Button1" runat="server" Text="Button" />
            <asp:Button Class="box" ID="Button2" runat="server" Text="Button" />
            <asp:Button Class="box" ID="Button3" runat="server" Text="Button" />
        </div>

        <div class="insights">
            <div class="card">
                <div class="lef">
                    <span class="material-symbols-outlined">assignment</span>
                    <i class="fa-solid fa-folder-magnifying-glass"></i>
                </div>
                <div class="middle">
                    <h1>Number of Orders</h1>
                    <asp:Label ID="lblNumberOfOrders" runat="server" Text="2000"></asp:Label>
                </div>
            </div>

            <div class="card">
                <div class="lef">
                    <span class="material-symbols-outlined">assignment</span>
                    <i class="fa-solid fa-folder-magnifying-glass"></i>
                </div>
                <div class="card">
                    <h1>Total Revenue</h1>
                    <asp:Label ID="lblTotalRevenue" runat="server" Text="2000"></asp:Label>
                </div>
            </div>

            <div class="card">
                <div class="lef">
                    <span class="material-symbols-outlined">assignment</span>
                    <i class="fa-solid fa-folder-magnifying-glass"></i>
                </div>
                <div class="middle">
                    <h1>Total Profits</h1>
                    <asp:Label ID="lblTotalProfits" runat="server" Text="2000"></asp:Label>
                </div>
            </div>
        </div>


    </main>

</asp:Content>
