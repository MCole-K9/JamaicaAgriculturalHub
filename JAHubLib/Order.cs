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
        public Customer Customer { get; set; }
        public string ShipStreetAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipParish { get; set; }
        public Payment PaymentDetails { get; set; }
        public List<OrderItem> Items { get; set; }

        public Order()
        {
            OrderId = 0;
            OrderNumber = 0;
            TotalAmount = 0;
            Customer = new Customer();
            ShipStreetAddress = "";
            ShipCity = "";
            ShipParish = "";
            PaymentDetails = new Payment();
            Items = new List<OrderItem>();
        }
        //Incomplete 
        public void FetchOrderData()
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = $"SELECT * from [Order] WHERE Customer = {Customer.CustomerID}";
            }
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
                        
                    }
                }
            }
        }

        
        private void FetchOrderItems()
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
            FetchOrderItems();

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
