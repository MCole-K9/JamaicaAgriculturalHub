using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public partial class Dashboard : System.Web.UI.Page
    {
        Farmer farmer = new Farmer(true);
        private DateTime StartDate = DateTime.Today.AddDays(-7);
        private DateTime EndDate = DateTime.Now;
        private int NumOfDays;

        public int TotalProducts { get; private set; }
        public int TotalCustomers { get; set; }
        public List<KeyValuePair<string, int>> ProductsShortList { get; private set; }
        public List<KeyValuePair<string, int>> BestSellingProductList { get; private set; }
        public List<RevenueByDate> GrossRevnueList { get; private set; } //this result couuld be hundreads/thousands of rows hence wouldnt be best to show it in a chart control... So the results would be modifed and groups by the number of days in the date range using LINq
        public int NumberOfOrders { get; private set; }
        public decimal TotalRevenue { get; private set; }
        public decimal TotalProfit { get; private set; }

        
        protected void Page_Load(object sender, EventArgs e)
        {

            LoadData(StartDate, EndDate);
            lblNumberOfOrders.Text = NumberOfOrders.ToString();
            lblTotalCustomers.Text = TotalCustomers.ToString();
            lblTotalProducts.Text = TotalProducts.ToString();
            lblTotalProfits.Text = "$" +TotalProfit.ToString();
            lblTotalRevenue.Text = "$" +TotalRevenue.ToString();

            try
            {

                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {
                    connection.Open();
                    farmer.FetchFarmerData();
                    using (var cmd = new SqlCommand())
                    {
                        DataTable dt = new DataTable();
                        cmd.Connection = connection;
                        SqlDataAdapter da = new SqlDataAdapter($" Select Name, Stock from [Product] where Stock < 250 AND Farmer ={farmer.FarmerId}", connection);
                        //cmd.CommandText = $" Select Name, Stock from [Product] where Stock < 250 AND Farmer ={farmer.FarmerId}";
                        da.Fill(dt);

                        dgvProductsShort.DataSource = dt;
                        dgvProductsShort.DataBind();

                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }

                    
               
        }






        private void GetTotalNumber()
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();
                farmer.FetchFarmerData();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    //get total products in stock
                    cmd.CommandText = $"Select count(Stock) from [Product] where Farmer = {farmer.FarmerId} ";
                    TotalProducts = (int)cmd.ExecuteScalar();
                    
                    

                    //get total customers
                    cmd.CommandText = " SELECT  DISTINCT Customer from " +
                                                 " [Customer] C " +
                                                 " INNER JOIN[Order] O " +
                                                 " ON C.ID = O.Customer " +
                                                 " INNER JOIN[OrderItem] I " +
                                                 " ON O.ID = I.OrderID " +
                                                 " INNER JOIN[Product] P" +
                                                 " ON I.Product = P.ID " +
                                                 $" Where Farmer = {farmer.FarmerId} ";
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sdr);
                    TotalCustomers = dt.Rows.Count;
                    sdr.Close();

                    //Get Total Numbers of orders
                    cmd.CommandText = @"SELECT count(O.ID) orderAmount from 
                                                      [Order] O
                                                      INNER JOIN [OrderItem] I
                                                      ON O.ID = I.OrderID
                                                      INNER JOIN [Product] P
                                                      ON I.Product = P.ID " +
                                                      $"where OrderDate between @fromDate and @toDate AND Farmer ={farmer.FarmerId} ";
                    //declear and set the fromDate and toDate parameters 
                    cmd.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = StartDate;
                    cmd.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = EndDate;
                    NumberOfOrders = (int)cmd.ExecuteScalar();
                }

            }

        }

        private void GetProductStatistics()
        {
            //initillize the list properties
            ProductsShortList = new List<KeyValuePair<string, int>>();
            BestSellingProductList = new List<KeyValuePair<string, int>>();


            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();
                farmer.FetchFarmerData();
                using (var cmd = new SqlCommand())
                {
                    SqlDataReader reader;
                    cmd.Connection = connection;
                    cmd.CommandText = $" Select Name, Stock from [Product] where Stock < 250 AND Farmer ={farmer.FarmerId}";
                    reader = cmd.ExecuteReader();
                    while (reader.Read()) //read the rows of the uery and add it to products short list
                    {
                        ProductsShortList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    cmd.CommandText = @" select top 5 P.Name as Name, sum(I.Quantity) as Quantity
                                                      from [OrderItem] I
                                                      INNER JOIN [Product] P
                                                      on P.ID = I.Product
                                                      INNER JOIN [Order] O
                                                      ON  O.ID = I.OrderID 
                                                      Where OrderDate between @fromDate and @toDate " +
                                                      $"AND P.Farmer = {farmer.FarmerId} " +
                                                      @"group by P.Name
                                                      order by Quantity desc ";
                    cmd.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = StartDate;
                    cmd.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = EndDate;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        BestSellingProductList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                }

            }
        }

        private void GetOrderStatistics()
        {
            GrossRevnueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();
                farmer.FetchFarmerData();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = @"SELECT OrderDate, sum(Subtotal) from 
                                                              [Order] O
                                                              INNER JOIN [OrderItem] I
                                                              ON O.ID = I.OrderID
                                                              INNER JOIN [Product] P
                                                              ON I.Product = P.ID " +
                                                              $"where OrderDate between @fromDate and @toDate AND Farmer = {farmer.FarmerId} " +
                                                              "Group by OrderDate";
                    cmd.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = StartDate;
                    cmd.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = EndDate;
                    var reader = cmd.ExecuteReader();
                    var TableResult = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())// while continue to read this add the result from the reader to the Tableresult list
                    {
                        TableResult.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], Convert.ToDecimal(reader[1]))); ;  //Convert.ToDecimal(reader[1])));  (decimal)reader[1]))

                        TotalRevenue += Convert.ToDecimal(reader[1]);
                    }
                    TotalProfit = TotalRevenue * 0.9m; //90 the goes the the developers lol
                    reader.Close();

                    //group by days
                    if (NumOfDays <= 30)
                    {
                        foreach (var product in TableResult)
                        {
                            GrossRevnueList.Add(new RevenueByDate()
                            {
                                Date = product.Key.ToString("dd MMM"),
                                TotalAmount = product.Value
                            });
                        }
                    }
                    else if (NumOfDays <= 92) //Group by Weeks
                    {
                        GrossRevnueList = (from orderList in TableResult
                                           group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                               orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                           select new RevenueByDate
                                           {
                                               Date = "Week " + order.Key.ToString(),
                                               TotalAmount = order.Sum(amount => amount.Value)
                                           }).ToList();


                    }
                    else if (NumOfDays <= (356 * 2))// group by month
                    {
                        bool isYear = NumOfDays <= 365 ? true : false;
                        GrossRevnueList = (from orderList in TableResult
                                           group orderList by orderList.Key.ToString("MMM YYYY")
                                          into order
                                           select new RevenueByDate
                                           {
                                               Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                               TotalAmount = order.Sum(amount => amount.Value)
                                           }).ToList();
                    }
                    else
                    {
                        GrossRevnueList = (from orderList in TableResult
                                           group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                           select new RevenueByDate
                                           {
                                               Date = order.Key,
                                               TotalAmount = order.Sum(amount => amount.Value)
                                           }).ToList();
                    }

                }



            }
        }




        public void LoadData(DateTime StartDate, DateTime EndDate)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.NumOfDays = (EndDate - StartDate).Days;

            GetTotalNumber();
            GetProductStatistics();
            GetOrderStatistics();
        }










    }
}