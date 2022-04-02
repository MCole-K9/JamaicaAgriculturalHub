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


        public Farmer()
        {
            // i don't think this needs anything, tbh. everything is accessible
            // from the properties
        }


        //M.C
        // constructor to populate farmer with user data
        public Farmer(User user)
        {
            this.UserID = user.UserID;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.MiddleName = user.MiddleName;
            this.Email = user.Email;
            this.UserRole = user.UserRole;
            PopulateFarmerObject();
        }

        //M.C.. Quires farmer table with user id to retrive the rest of the farmer data
        private void PopulateFarmerObject()
        {
            using(SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = $"SELECT * FROM Farmer WHERE UserID = {this.UserID}";
 
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader sqlData =  cmd.ExecuteReader();

                while (sqlData.Read())
                {
                    this.FarmerId = (int)sqlData["ID"];
                    this.BusinessEmail = sqlData["BusinessEmail"].ToString();
                  
                }
                sqlData.Close();

            }
        }

        public int AddProduct(Product product)
        {
            using(SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = $"INSERT INTO [Product] (Name, Stock, Price, Image, Farmer)" +
                    $"Values ( '{product.Name}', {product.Stock}, {product.Price}, '{product.GetUploadedImagePath()}', {1})";

                SqlCommand cmd = new SqlCommand(query, connection);
                int i = cmd.ExecuteNonQuery();

                return i;
            }
        }
    }
}
