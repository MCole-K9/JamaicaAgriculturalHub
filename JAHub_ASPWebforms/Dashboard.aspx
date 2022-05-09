<%@ Page Title="" Language="C#" MasterPageFile="~/UserPortal.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="JAHub_ASPWebforms.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
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
                title: 'Top 5 Best Sellers',
                height: 400,
                width: 400,
               
                
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
                ["Queedden's bishop pawn (c4)", 10],
                ['Other', 3]
            ]);

            var options = {
                title: 'Gross revenue grouped by selected date range',
                path: 30,
                legend: { position: 'none' },
                chart: {
                    title: 'Gross revenue grouped by selected date range',
                },
                bars: 'vertical', // Required for Material Bar Charts.
                axes: {
                    x: {
                        0: { side: 'top', label: 'Percentage' } // Top x-axis.
                    }
                },
                bar: { groupWidth: "50%" },
            };

            var chart = new google.charts.Bar(document.getElementById('top_x_div'));
            chart.draw(data, options);
        };
    </script>

   





    <div class="container-fluid">
       <h1>Dashboard</h1>
        <div class="date-buttons">

            <asp:Button Class="box" ID="btnToday" runat="server" Text="Today" />
            <asp:Button Class="box" ID="btnLast7Days" runat="server" Text="Last 7 Days" />
            <asp:Button Class="box" ID="btnThisMonth" runat="server" Text="This Month" />
        </div>

        <div class="insights">
            <div class="card">
                <div class="lef">
                    <%--add image icon here--%>
                    <img src="Resources/order-delivery.png" style="width:50px;height:50px; position:absolute;"/>
                </div>
                <div class="middle">
                    <h4>Number of Orders</h4>
                    <asp:Label ID="lblNumberOfOrders" runat="server" Text="2000"></asp:Label>
                </div>
            </div>

            <div class="card">
                <div class="lef">
                    <%--add image icon here--%>
                    <img src="Resources/revenue.png" style="width:50px;height:50px; position:absolute;"/>
                </div>
                <div class="middle">
                    <h4>Total Revenue</h4>
                    <asp:Label ID="lblTotalRevenue" runat="server" Text="2000"></asp:Label>
                </div>
            </div>

            <div class="card">
                <div class="lef">
                    <%--add image icon here--%>
                    <img src="Resources/profit.png" style="width:50px;height:50px; position:absolute;"/>
                </div>
                <div class="middle">
                    <h4>Total Profits</h4>
                    <asp:Label ID="lblTotalProfits" runat="server" Text="2000"></asp:Label>
                </div>
            </div>
        </div>

        <div class="charts">
            <div class="bestSeller">
                <h3>Best Sellers</h3>
                <div class="pieChart" id="piechart" style="border: 1px solid #000000"></div>
            </div>

            <div class="revenue">
                <h3>Gross Revenue</h3>
                <div id="top_x_div" style="width: 800px; height: 400px; margin: 0; border: 1px solid #000000;"></div>
            </div>
        </div>

        <div class="countercharts">
            <div class="Understock">
                <h3>Products Understock</h3>
                <asp:GridView ID="dgvProductsShort" class="dgvprodshort" AutoGenerateColumns="false" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="165px" Width="524px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Product" />
                        <asp:BoundField DataField="Stock" HeaderText="Stock" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>

            <div class="totalcounter">
                <h3>Total Counter</h3>
                <asp:Panel ID="Panel1" class="pnlTotalCounter" runat="server">
                    <div class="content">
                        <h4>Total Number of Customers</h4>
                        <asp:Label ID="lblTotalCustomers" runat="server" Text="2000"></asp:Label>
                    </div>
                    <div class="content">
                        <h4>Total Number of Products</h4>
                        <asp:Label ID="lblTotalProducts" runat="server" Text="2000"></asp:Label>
                    </div>
                </asp:Panel>
              
            </div>
        </div>
              
        

    </div>

</asp:Content>
