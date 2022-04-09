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

        public bool WriteRecordToDatabase()
        {
            // This depends on the radaregistrationphase

            // K.S.: Note: this doesn't write the filepath of the IdPicture, because i'm purposefully going to scrap
            // it if time starts to runs out. it's not a MS item and if it is, it's only my problem

            if (this.RadaRegistrationPhase == RadaRegistrationType.AwaitingVerification)
            {
                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {
                    connection.Open();

                    // First, change the Name (Mostly as a formality)
                    String farmerUpdateUser = $"UPDATE [User] SET FirstName = '{this.FirstName}'," +
                        $"MiddleName = '{this.MiddleName}', LastName = '{this.LastName}'" +
                        $"WHERE ID = {Session.UserId};";

                    // Then, update the farmer record with the new information
                    String farmerUpdateFarmer = $"UPDATE [Farmer] SET BusinessEmail = {this.Email}, " +
                        $"NumberOfEmployees = {this.NumberOfEmployees}, UsesHeavyMachinery = {this.UsesHeavyMachinery}" +
                        $"TRN = {this.TaxRegistrationNumber}, DateOfBirth = {this.DateOfBirth}, RadaRegistrationStatus = {this.RadaRegistrationPhase}" +
                        $"WHERE UserID = {Session.UserId};";

                    // Necessary because every other table will need FarmerID
                    String farmerSelectFarmer = $"SELECT FarmerID FROM [Farmer] " +
                        $"WHERE UserID = {Session.UserId};";

                    // Inserts all the products listed under ProductsTypicallyProduced
                    String farmerInsertTypicalProduct = $"INSERT INTO [Farmer_ProducedProduct] " +
                        " (FarmerID, ProductName) VALUES ";
                    foreach(String product in ProductsTypicallyProduced)
                    {
                        farmerInsertTypicalProduct += $"({this.FarmerId}, '{product}')";

                        // This checks to see if the product in the list is the last, and if so appends a semicolon,
                        // else a comma
                        if (ProductsTypicallyProduced.IndexOf(product) == ProductsTypicallyProduced.Count - 1)
                        {
                            farmerInsertTypicalProduct += ";";
                        }
                        else
                        {
                            farmerInsertTypicalProduct += ", ";
                        }
                    }

                    // Inserts all the associated land values under this.OwnedLand
                    String farmerInsertLandInformation = $"INSERT INTO [Farmer_land]" +
                        $" (LandMeasurement, Town, PoBox, Parish, OwnerID) VALUES";
                    foreach(LandInformation land in this.OwnedLand)
                    {
                        farmerInsertLandInformation += $"({land.LandMeasurement}, '{land.LandAddressTown}', " +
                            $"'{land.LandAddressPoBox}', '{land.LandAddressParish}', {this.FarmerId})";

                        if (OwnedLand.IndexOf(land) == OwnedLand.Count - 1)
                        {
                            farmerInsertLandInformation += ";";
                        }
                        else
                        {
                            farmerInsertLandInformation += ", ";
                        }
                    }

                    // Inserts all of the associated Organizations in this.Organizations
                    String farmerInsertOrganization = $"INSERT INTO [Farmer_Organization]" +
                        $" (FarmerID, Organization) VALUES";
                    foreach(String organization in Organizations)
                    {
                        farmerInsertOrganization += $"()";

                        if (Organizations.IndexOf(organization) == Organizations.Count - 1)
                        {
                            farmerInsertOrganization += ";";
                        }
                        else
                        {
                            farmerInsertOrganization += ", ";
                        }
                    }

                    // Inserts all of the associated phone numbers under this.PhoneNumbers
                    String farmerInsertPhoneNumber = $"INSERT INTO [Farmer_PhoneNumber]" +
                        $" (FarmerID, PhoneNumber) VALUES";
                    foreach(String phoneNumber in PhoneNumbers)
                    {
                        farmerInsertPhoneNumber += $"({this.FarmerId}, '{phoneNumber}')";

                        if(PhoneNumbers.IndexOf(phoneNumber) == PhoneNumbers.Count - 1)
                        {
                            farmerInsertPhoneNumber += ";";
                        }
                        else
                        {
                            farmerInsertPhoneNumber += ", ";
                        }
                    }

                    // activating all of the queries in a list
                    SqlCommand writeToDatabase = new SqlCommand();
                    writeToDatabase.Connection = connection;

                    writeToDatabase.CommandText = farmerUpdateUser;
                    writeToDatabase.ExecuteNonQuery();

                    writeToDatabase.CommandText = farmerUpdateFarmer;
                    writeToDatabase.ExecuteNonQuery();

                    writeToDatabase.CommandText = farmerSelectFarmer;
                    SqlDataReader reader = writeToDatabase.ExecuteReader();
                    while (reader.Read())
                    {
                        FarmerId = (int)reader["FarmerID"];
                    }

                    writeToDatabase.CommandText = farmerInsertTypicalProduct;
                    writeToDatabase.ExecuteNonQuery();

                    writeToDatabase.CommandText = farmerInsertLandInformation;
                    writeToDatabase.ExecuteNonQuery();

                    writeToDatabase.CommandText = farmerInsertOrganization;
                    writeToDatabase.ExecuteNonQuery();

                    writeToDatabase.CommandText = farmerInsertPhoneNumber;
                    writeToDatabase.ExecuteNonQuery();
                    
                    connection.Close();
                }

                return true;
            }
            else if (this.RadaRegistrationPhase == RadaRegistrationType.NotConnected)
            {
                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {
                    connection.Open();

                    // First, change the name
                    String command = $"UPDATE [User] SET FirstName = '{this.FirstName}'," +
                        $"MiddleName = '{this.MiddleName}', LastName = '{this.LastName}' " +
                        $"WHERE ID = {Session.UserId};";

                    SqlCommand addInformation = new SqlCommand(command, connection);

                    addInformation.ExecuteNonQuery();

                    // Next, add the TRN, DateOfBirth, and RadaRegistrationPhase
                    addInformation.CommandText = $"UPDATE [Farmer] SET TRN = {this.TaxRegistrationNumber}, DateOFBirth = {this.DateOfBirth}" +
                        $", RadaRegistrationPhase = {this.RadaRegistrationPhase}" +
                        $"WHERE UserID = {Session.UserId};";
                    addInformation.ExecuteNonQuery();

                    connection.Close();
                }

                return true;
            }

            return false;
        }
    }
}
