<%@ Page Title="" Language="C#" MasterPageFile="~/UserPortal.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="JAHub_ASPWebforms.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="UserPortalCss.css" rel="stylesheet" />
    <link href="Dashboard.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
    <script src="JavaScript.js"></script>
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>


    

    <script type="text/javascript">
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {

            var data = google.visualization.arrayToDataTable([
                ['Task', 'Hours per Day'],
                ['Work', 11],
                ['Eat', 2],
                ['Commute', 2],
                ['Watch TV', 2],
                ['Sleep', 7]
            ]);

            var options = {
                title: 'My Daily Activities'
            };

            var chart = new google.visualization.PieChart(document.getElementById('piechart'));

            chart.draw(data, options);
        }
    </script>

    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">
        google.charts.load('current', { 'packages': ['bar'] });
        google.charts.setOnLoadCallback(drawStuff);

        function drawStuff() {
            var data = new google.visualization.arrayToDataTable([
                ['Opening Move', 'Percentage'],
                ["King's pawn (e4)", 44],
                ["Queen's pawn (d4)", 31],
                ["Knight to King 3 (Nf3)", 12],
                ["Queen's bishop pawn (c4)", 10],
                ['Other', 3]
            ]);

            var options = {
                title: 'Chess opening moves',
                width: 900,
                legend: { position: 'none' },
                chart: {
                    title: 'Chess opening moves',
                    subtitle: 'popularity by percentage'
                },
                bars: 'vertical', // Required for Material Bar Charts.
                axes: {
                    x: {
                        0: { side: 'top', label: 'Percentage' } // Top x-axis.
                    }
                },
                bar: { groupWidth: "90%" }
            };

            var chart = new google.charts.Bar(document.getElementById('top_x_div'));
            chart.draw(data, options);
        };
    </script>

   





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
                </div>
                <div class="middle">
                    <h3>Number of Orders</h3>
                    <asp:Label ID="lblNumberOfOrders" runat="server" Text="2000"></asp:Label>
                </div>
            </div>

            <div class="card">
                <div class="lef">
                    <span class="material-symbols-outlined">assignment</span>
                    <i class="fa-solid fa-folder-magnifying-glass"></i>
                </div>
                <div class="middle">
                    <h3>Total Revenue</h3>
                    <asp:Label ID="lblTotalRevenue" runat="server" Text="2000"></asp:Label>
                </div>
            </div>

            <div class="card">
                <div class="lef">
                    <span class="material-symbols-outlined">assignment</span>
                    <i class="fa-solid fa-folder-magnifying-glass"></i>
                </div>
                <div class="middle">
                    <h3>Total Profits</h3>
                    <asp:Label ID="lblTotalProfits" runat="server" Text="2000"></asp:Label>
                </div>
            </div>
        </div>

        <div class="charts">
            <div class="bestSeller">
                <h3>Best Sellers</h3>
                <div class="pieChart" id="piechart" style="width: 800px; height: 400px; margin: 0; border: 1px solid #000000;"></div>
            </div>
        </div>

        <table>
            <tr>
                <td>
                    <div class="revenue">
                        <h3>Gross Revenue</h3>
                        <div id="top_x_div" style="width: 800px; height: 400px; margin: 0; border: 1px solid #000000;"></div>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="datatgridView">
                        <asp:GridView ID="GridView1" runat="server" style="width: 200px; height: 200px; margin: 0; border: 1px solid #000000;"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div class="TotalCounterPanel">
                        <asp:Panel ID="Panel1" runat="server" style="width: 200px; height: 200px; margin: 0; border: 1px solid #000000;"></asp:Panel>
                    </div>
                </td>
            </tr>

        </table>


    </main>

</asp:Content>
