using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace JAHubLib
{
    public enum RadaRegistrationType
    {
        NotRegistered = 0,
        AwaitingVerification = 1,
        NotConnected = 2,
        FullyConnected = 3
    }

    public struct LandInformation
    {
        public string LandAddressTown { get; set; }
        public string LandAddressPoBox { get; set; }
        public string LandAddressParish { get; set; }
        public decimal LandMeasurement { get; set; }
    }

    // per discussion: classes are primarily data-holders, with methods to do
    // things with that data written in place/in event handlers
    public class Farmer : User
    {
        public int FarmerId { get; set; }
        public List<LandInformation> OwnedLand { get; set; }
        public SqlDateTime DateOfBirth { get; set; }
        public String BusinessEmail { get; set; }
        public Boolean UsesHeavyMachinery { get; set; }
        public int NumberOfEmployees { get; set; }

        public List<String> ProductsTypicallyProduced { get; set; }
        public List<String> Organizations { get; set; }
        public List<String> PhoneNumbers { get; set; }
        public Bitmap IdPicture { get; set; }
        public String TaxRegistrationNumber { get; set; }
        public RadaRegistrationType RadaRegistrationPhase { get; set; }

        private bool isLoggedin;

        public Farmer()
        {
            
        }

        public Farmer(bool FarmerIsLoggedIn)
        {
            this.isLoggedin = true;
            FetchFarmerData();

        }

        //M.C
        // constructor to populate farmer with user data
        public Farmer(int farmerID)
        {

            this.FarmerId = farmerID;
            isLoggedin = false;
            FetchFarmerData();
            

        }

        //M.C.. Quires farmer table with user id to retrivethe farmer data
        public void FetchFarmerData()
        {
            using(SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = isLoggedin? $"SELECT * FROM Farmer WHERE UserID = {Session.UserId}" : $"SELECT * FROM Farmer WHERE ID = {this.FarmerId}";
 
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader sqlData =  cmd.ExecuteReader();

                while (sqlData.Read())
                {
                    this.UserID = (int)sqlData["UserID"];
                    this.FarmerId = (int)sqlData["ID"];
                    this.BusinessEmail = sqlData["BusinessEmail"].ToString();
                  
                }
                sqlData.Close();

            }
            if (isLoggedin)
            {
                ReadFromDatabase(Session.UserId);
            }
            else
            {
                ReadFromDatabase(this.UserID);
            }
        }

        public int AddProduct(Product product)
        {
            FetchFarmerData();
            string productImageName = product.GetUploadedImagePath().Remove(0, Utilities.GetFilePathLength()+8);

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = $"INSERT INTO [Product] (Name, Stock, Price, Image, Category,  Farmer)" +
                    $"Values ( '{product.Name}', {product.Stock}, {product.Price}, '{productImageName}',{product.Category} , {this.FarmerId})";

                SqlCommand cmd = new SqlCommand(query, connection);
                int i = cmd.ExecuteNonQuery();

                return i;
            }
           
        }

        public int UpdateProduct(Product product)
        {
            string productImageName = product.GetUploadedImagePath().Remove(0, Utilities.GetFilePathLength() + 8);

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = $"Update [Product]" +
                    $" Set  Name = '{product.Name}', Stock = {product.Stock} , Price = {product.Price}, Category = {product.Category}, Image = '{productImageName}'" +
                    $" Where ID = {product.Id}";

                SqlCommand cmd = new SqlCommand(query, connection);
                int i = cmd.ExecuteNonQuery();

                return i;
            }
        }

        public int DeleteProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = $"Delete FROM [Product]" +
                    $" Where ID = {product.Id}";

                SqlCommand cmd = new SqlCommand(query, connection);
                int i = cmd.ExecuteNonQuery();

                return i;
            }

        }
    }
}
