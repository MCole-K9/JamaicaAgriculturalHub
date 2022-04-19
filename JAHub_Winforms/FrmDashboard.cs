using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using JAHubLib;

namespace JAHub_Winforms
{
    public partial class FrmDashboard : Form
    {
        private Dashboard dashboard;
        public FrmDashboard()
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();
            dashboard = new Dashboard();
            LoadData();
        }

        private void LoadData()
        {
            dashboard.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            lblTotalNumberofOrders.Text = dashboard.NumberOfOrders.ToString();
            lblTotalRevenue.Text = "$" + dashboard.TotalRevenue.ToString();
            lblTotalProfits.Text = "$" + dashboard.TotalProfit.ToString();

            lblTotalNumCustomers.Text = dashboard.TotalCustomers.ToString();
            lblTotalNumProducts.Text = dashboard.TotalProducts.ToString();


            chartGrossRevenue.DataSource = dashboard.GrossRevnueList;
            chartGrossRevenue.Series[0].XValueMember = "Date"; // sets date on the x axis from the datasource "RevenueByDate struct" which has a Date and TotalAmount
            chartGrossRevenue.Series[0].YValueMembers = "TotalAmount"; // sets TotalAmount on the y axis "RevenueByDate struct" which has a Date and TotalAmount
            chartGrossRevenue.DataBind(); // call the databind() to force the chart to refresh when date range is selected

            chartBestSellers.DataSource = dashboard.BestSellingProductList;
            chartBestSellers.Series[0].XValueMember = "Key";
            chartBestSellers.Series[0].YValueMembers = "Value";
            chartBestSellers.DataBind();

            dgvProductsShort.DataSource = dashboard.ProductsShortList;
            dgvProductsShort.Columns[0].HeaderText = "Product";
            dgvProductsShort.Columns[1].HeaderText = "Units";
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
        }
    }
}
