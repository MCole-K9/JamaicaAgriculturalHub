using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JAHubLib
{
    public class Order
    {

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public float TotalAmount { get; set; }
        public string ShipStreetAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipParish { get; set; }
        public string ShipFirstName { get; set; }
        public string ShipLastName { get; set; }
        public string ShipEmail { get; set; }
        public Payment PaymentDetails { get; set; }
        public List<OrderItem> Items { get; set; }

        public string ShipName
        {
            get
            {
                return ShipFirstName + " " + ShipLastName; 
            }
        }
        

        public Order()
        {
            OrderId = 0;
            OrderNumber = 0;
            TotalAmount = 0;
            ShipStreetAddress = "";
            ShipCity = "";
            ShipParish = "";
            PaymentDetails = new Payment();
            Items = new List<OrderItem>();
        }
       
        //Fetches Last Order Made by customer
        //Incomplete but in use
        public void FetchLastOrderData(int customerID)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = $"SELECT * from [Order] WHERE Customer = {customerID}";

                SqlCommand cmd = new SqlCommand(query, connection);
                using(SqlDataReader sqlData = cmd.ExecuteReader())
                {
                    while (sqlData.Read())
                    {
                        this.OrderId = (int)sqlData["ID"];
                        this.OrderDate = (DateTime)sqlData["OrderDate"];
                        this.TotalAmount = float.Parse(sqlData["Subtotal"].ToString());
                    }
                }
            }
            FetchOrderItems();
        }

        public void FetchOrderData()
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = $"SELECT * from [Order] AS O " +
                    $" Inner JOIN Payment as Pymt " +
                    $" ON O.PaymentDetails = Pymt.ID " +
                    $" WHERE O.ID = {this.OrderId}";

                SqlCommand cmd = new SqlCommand(query, connection);
                using (SqlDataReader sqlData = cmd.ExecuteReader())
                {
                    if (sqlData.Read())
                    {
                        this.OrderDate = (DateTime)sqlData["OrderDate"];
                        this.TotalAmount = float.Parse(sqlData["Subtotal"].ToString());
                        this.ShipFirstName = sqlData["ShipFirstName"].ToString();
                        this.ShipLastName = sqlData["ShipLastName"].ToString();
                        this.ShipEmail = sqlData["ShipEmail"].ToString();
                        this.ShipStreetAddress = sqlData["ShipStreetAddress"].ToString();
                        this.ShipCity = sqlData["ShipCity"].ToString();
                        this.ShipParish = sqlData["ShipParish"].ToString();
                        this.PaymentDetails.PaymentType = sqlData["PaymentType"].ToString();
                        this.PaymentDetails.BillingFirstName = sqlData["BillingFirstName"].ToString();
                        this.PaymentDetails.BillingLastName = sqlData["BillingLastName"].ToString();
                        this.PaymentDetails.BillingEmail = sqlData["BillingEmail"].ToString();
                        this.PaymentDetails.BillingStreetAddress = sqlData["BillingStreetAddress"].ToString();
                        this.PaymentDetails.BillingCity = sqlData["BillingCity"].ToString();
                        this.PaymentDetails.BIllingParish = sqlData["BillingParish"].ToString();
                    }
                }
            }
            FetchOrderItems();
        }
        
        public void FetchOrderItems()
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();


                string query = $"Select OI.ID as OrderItemID, OI.*, Prod.* " +
                    $"from [Order] as O " +
                    $"INNER JOIN OrderItem as OI " +
                    $" ON O.ID = OI.OrderID " +
                    $" INNER JOIN Product as Prod " +
                    $" On OI.Product = Prod.ID " +
                    $" Where O.ID = {this.OrderId} ";

                SqlCommand cmd = new SqlCommand(query, connection);
                using (SqlDataReader sqlData = cmd.ExecuteReader())
                {

                    while (sqlData.Read())
                    {
                        OrderItem orderItem = new OrderItem();
                        orderItem.OrderItemID = (int)sqlData["OrderItemID"];
                        orderItem.OrderProduct = new Product
                        {
                            Id = (int)sqlData["Product"],
                            Name = sqlData["Name"].ToString(),
                            Stock = (int)sqlData["Stock"],
                            Category = (int)sqlData["Category"],
                            Price = float.Parse(sqlData["Price"].ToString()),
                            Image = $"http://vtdics.com/ead22/" + sqlData["Image"].ToString(),
                        };
                        orderItem.Quantity = (int)sqlData["Quantity"];
                        Items.Add(orderItem);

                    }
                }
            }
            

        }

        //Incomplete
        public void FetchOrderItems(int orderID)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = $"SELECT * from OrderItem WHERE OrderID = {orderID}";

                SqlCommand cmd = new SqlCommand(query, connection);
                using(SqlDataReader sqlData = cmd.ExecuteReader())
                {
                    while (sqlData.Read())
                    {
                        
                    }
                }
            }

        }

        public int WriteOrderItems(Dictionary<Product, int> cart)
        {
            PopulateOrderItems(cart);
            int totalRowsAffected = 0;
            foreach (var item in this.Items)
            {
                totalRowsAffected += Utilities.executeInputQuery($"INSERT INTO OrderItem (Product, Quantity, OrderID) VALUES( {item.OrderProduct.Id}, {item.Quantity}, {this.OrderId})");
            }

            return totalRowsAffected;
        }

        private void PopulateOrderItems(Dictionary<Product, int> cart)
        {
            foreach (Product product in cart.Keys.ToList())
            {

                Items.Add(new OrderItem
                {
                    OrderProduct = product,
                    Quantity = cart[product],


                });
            }
        }

    }
}
