using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JAHubLib
{
    public class Customer : User
    {
        public int CustomerID { get; set; }
        private bool isLoggedIn;

        public Customer()
        {
            
        }
        public Customer(int customerID)
        {
            isLoggedIn = false;
            this.CustomerID = customerID;
            FetchCustomerData();
        }
        public Customer(bool userIsLoggedIn = true)
        {
            this.isLoggedIn = userIsLoggedIn;

            if (!IsCustomer())
            {
                CreateCustomer();
                FetchCustomerData();

            }
            else
            {
                FetchCustomerData();
            }

            
        }
       
        public int AddReview(Review review)
        {
            if (IsCustomer())
            {
                string query = $"INSERT INTO [Review] (Rating, Comment, Product, Customer, Headline)" +
                $" VALUES ({review.Rating}, '{review.Comment}', {review.ProductID}, {CustomerID}, '{review.Headline}')";

                return Utilities.executeInputQuery(query);
            }

            return -1;
        }

        //Checkinng If user is already inside of customer table
        private bool IsCustomer()
        {
            using(SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = $"Select * From [Customer] Where [UserID] = {Session.UserId}";

                SqlCommand cmd = new SqlCommand(query, connection);

                using(SqlDataReader sqlData = cmd.ExecuteReader())
                {
                    if (sqlData.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private void CreateCustomer()
        {

            Utilities.executeInputQuery($"INSERT INTO [Customer] (UserID) VALUES ({Session.UserId})");
        }

        private void FetchCustomerData()
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = isLoggedIn ? $"Select * From [Customer] Where [UserID] = {Session.UserId}": $"Select * From [Customer] Where ID = {CustomerID}";

                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader sqlData = cmd.ExecuteReader())
                {
                    if (sqlData.Read())
                    {
                        this.CustomerID = (int)sqlData["ID"];
                        this.UserID = (int)sqlData["UserID"];
                    }
                }
            }

            if (isLoggedIn)
            {
                ReadFromDatabase(Session.UserId);
            }
            else
            {
                ReadFromDatabase(this.UserID);
            }
        }

        public int MakeOrder(Order order)
        {
            if (isLoggedIn)
            {
                int j = Utilities.executeInputQuery($"INSERT INTO Payment (PaymentType, PaymentDate, BillingStreetAddress, BilingCity, BillingParish ) " +
                    $"VALUES ('{order.PaymentDetails.PaymentType}', GETDATE(), '{order.PaymentDetails.BillingStreetAddress}', '{order.PaymentDetails.BillingCity}', '{order.PaymentDetails.BIllingParish}')");

                if (j < 0)
                {
                    return -1;
                }
                else
                {
                    order.PaymentDetails.FetchPaymentID();


                    int i = Utilities.executeInputQuery($"INSERT INTO [Order] (Customer, OrderDate, ShipStreetAddress, ShipCity, ShipParish,PaymentDetails, Subtotal) " +
                    $"Values ({CustomerID},GETDATE(), '{order.ShipStreetAddress}', '{order.ShipCity}', '{order.ShipParish}', {order.PaymentDetails.PaymentID}, {Cart.CaluculateTotal()} )");


                    return i;
                }
                    

                 
            }
            else
            {
                return -1;
            }
            

        }


    }
}
