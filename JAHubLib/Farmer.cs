using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.IO;
using System.Data;

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

        public LandInformation(String town, String poBox, String parish, decimal measurement)
        {
            LandAddressTown = town;
            LandAddressPoBox = poBox;
            LandMeasurement = measurement;
            LandAddressParish = parish;
        }
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
            string productImageName = Path.GetFileName(product.GetUploadedImagePath());
            

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = $"INSERT INTO [Product] (Name, Stock, Price, Image, Category,  Farmer)" +
                    $"Values ( '{product.Name}', {product.Stock}, {product.Price}, '{productImageName}',{product.Category} , {this.FarmerId})";

                SqlCommand cmd = new SqlCommand(query, connection);
                int i = cmd.ExecuteNonQuery();

                Utilities.FTPFileUpload(product.GetUploadedImagePath(), productImageName);

                return i;
            }
           
        }

        public List<Product> GetFarmerProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                FetchFarmerData();

                string query = $"Select * from Product Where Farmer = {FarmerId}";

                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader sqlData = cmd.ExecuteReader())
                {
                    while (sqlData.Read())
                    {
                        Product product = new Product();

                        product.Id = (int)sqlData["ID"];
                        product.Name = sqlData["Name"].ToString();
                        product.Stock = (int)sqlData["Stock"];
                        product.Price = float.Parse(sqlData["Price"].ToString());
                        product.Image = $"http://vtdics.com/ead22/" + sqlData["Image"].ToString();
                        products.Add(product);

                    }
                }

                
            }
            return products;
        }
        public int UpdateProduct(Product product)
        {
            string productImageName = Path.GetFileName(product.GetUploadedImagePath());
            

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = $"Update [Product]" +
                    $" Set  Name = '{product.Name}', Stock = {product.Stock} , Price = {product.Price}, Category = {product.Category}, Image = '{productImageName}'" +
                    $" Where ID = {product.Id}";

                SqlCommand cmd = new SqlCommand(query, connection);
                int i = cmd.ExecuteNonQuery();

                Utilities.FTPFileUpload(product.GetUploadedImagePath(), productImageName);

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

        public bool WriteRecordToDatabase(int farmerUserId)
        {
            // This depends on the radaregistrationphase

            // K.S.: Note: this doesn't write the filepath of the IdPicture, because i'm purposefully going to scrap
            // it if time starts to runs out. it's not a MS item and if it is, it's only my problem

            if (this.RadaRegistrationPhase == RadaRegistrationType.AwaitingVerification)
            {
                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {
                    connection.Open();

                    // activating all of the queries in a list
                    SqlCommand writeToDatabase = new SqlCommand();
                    writeToDatabase.Connection = connection;

                    // First, change the Name (Mostly as a formality)
                    String farmerUpdateUser = $"UPDATE [User] SET FirstName = '{this.FirstName}'," +
                        $"MiddleName = '{this.MiddleName}', LastName = '{this.LastName}'" +
                        $"WHERE ID = {Session.UserId};";

                    writeToDatabase.CommandText = farmerUpdateUser;
                    writeToDatabase.ExecuteNonQuery();

                    // Then, update the farmer record with the new information
                    String farmerUpdateFarmer = $"UPDATE [Farmer] SET BusinessEmail = '{this.BusinessEmail}', " +
                        $"NumberOfEmployees = {this.NumberOfEmployees}, UsesHeavyMachinery = {Convert.ToInt32(this.UsesHeavyMachinery)}, " +
                        $"TRN = {this.TaxRegistrationNumber}, DateOfBirth = '{this.DateOfBirth}', RadaRegistrationStatus = {(int)this.RadaRegistrationPhase}" +
                        $" WHERE UserID = {farmerUserId};";

                    writeToDatabase.CommandText = farmerUpdateFarmer;
                    writeToDatabase.ExecuteNonQuery();

                    // Necessary because every other table will need FarmerID
                    String farmerSelectFarmer = $"SELECT ID FROM [Farmer] " +
                        $"WHERE UserID = {Session.UserId};";

                    writeToDatabase.CommandText = farmerSelectFarmer;
                    SqlDataReader reader = writeToDatabase.ExecuteReader();

                    while (reader.Read())
                    {
                        FarmerId = (int)reader["ID"];
                    }

                    reader.Close();

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

                    writeToDatabase.CommandText = farmerInsertTypicalProduct;
                    writeToDatabase.ExecuteNonQuery();

                    // Inserts all the associated land values under this.OwnedLand
                    String farmerInsertLandInformation = $"INSERT INTO [Farmer_land]" +
                        $" (LandMeasurement, Town, PoBox, Parish, OwnerID) VALUES ";
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

                    writeToDatabase.CommandText = farmerInsertLandInformation;
                    writeToDatabase.ExecuteNonQuery();

                    // Inserts all of the associated Organizations in this.Organizations
                    String farmerInsertOrganization = $"INSERT INTO [Farmer_Organization]" +
                        $" (FarmerID, Organization) VALUES ";
                    foreach(String organization in Organizations)
                    {
                        farmerInsertOrganization += $"({this.FarmerId}, '{organization})'";

                        if (Organizations.IndexOf(organization) == Organizations.Count - 1)
                        {
                            farmerInsertOrganization += ";";
                        }
                        else
                        {
                            farmerInsertOrganization += ", ";
                        }
                    }

                    if (this.Organizations.Count != 0)
                    {
                        writeToDatabase.CommandText = farmerInsertOrganization;
                        writeToDatabase.ExecuteNonQuery();
                    }
                    

                    // Inserts all of the associated phone numbers under this.PhoneNumbers
                    String farmerInsertPhoneNumber = $"INSERT INTO [Farmer_PhoneNumber]" +
                        $" (FarmerID, PhoneNumber) VALUES ";
                    foreach(String phoneNumber in PhoneNumbers)
                    {
                        farmerInsertPhoneNumber += $"({this.FarmerId}, '{Int64.Parse(phoneNumber)}')";

                        if(PhoneNumbers.IndexOf(phoneNumber) == PhoneNumbers.Count - 1)
                        {
                            farmerInsertPhoneNumber += ";";
                        }
                        else
                        {
                            farmerInsertPhoneNumber += ", ";
                        }
                    }
                    
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
                    String farmerUpdateUser = $"UPDATE [User] SET FirstName = '{this.FirstName}'," +
                        $"MiddleName = '{this.MiddleName}', LastName = '{this.LastName}' " +
                        $"WHERE ID = {farmerUserId};";

                    SqlCommand addInformation = new SqlCommand(farmerUpdateUser, connection);

                    addInformation.ExecuteNonQuery();

                // This creates a new farmer record using the UserID from User
                // This isn't necessary, because FrmRadaRegister (or FrmRadaStatus, idr which) handles this for you
                    /* String farmerInsertFarmer = $"INSERT INTO [Farmer] (UserID) VALUES ({Session.UserId});";
                     * addInformation.CommandText = farmerInsertFarmer;
                     * addInformation.ExecuteNonQuery();
                     */

                // Next, add the TRN, DateOfBirth, and RadaRegistrationPhase
                    addInformation.CommandText = $"UPDATE [Farmer] SET TRN = {this.TaxRegistrationNumber}, DateOFBirth = '{this.DateOfBirth}'" +
                        $", RadaRegistrationStatus = {(int) this.RadaRegistrationPhase} " +
                        $"WHERE UserID = {farmerUserId};";
                    addInformation.ExecuteNonQuery();

                    connection.Close();
                }

                return true;
            }

            return false;
        }

        public void GetFullRecordFromDatabase(int farmerUserId)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                SqlCommand pullRecord = new SqlCommand();
                pullRecord.Connection = connection;

                SqlDataReader reader;

            // Gathering: FirstName, MiddleName, LastName from User
                String farmerSelectUser = $"SELECT FirstName, MiddleName, LastName FROM [User] WHERE ID = {farmerUserId};";
                pullRecord.CommandText = farmerSelectUser;

                reader = pullRecord.ExecuteReader();
                if (reader.Read())
                {
                    this.FirstName = (String)reader["FirstName"];
                    this.MiddleName = (String)reader["MiddleName"];
                    this.LastName = (String)reader["LastName"];
                }

                reader.Close();

            // Gathering: Everything from farmer except RadaRegistrationStatus and UserID from Farmer
                String farmerSelectFarmer = $"SELECT * FROM [Farmer] WHERE UserID = {farmerUserId};";
                pullRecord.CommandText = farmerSelectFarmer;

                reader = pullRecord.ExecuteReader();
                if (reader.Read())
                {
                    this.FarmerId = (int)reader["ID"];
                    this.BusinessEmail = (String)reader["BusinessEmail"];
                    // leaving space for IdPicture, which should have a corresponding filepath like IdPicturePath
                    // IdPicture in DB is a string field
                    this.NumberOfEmployees = (byte)reader["NumberOfEmployees"];
                    this.UsesHeavyMachinery = (bool)reader["UsesHeavyMachinery"];
                    this.TaxRegistrationNumber = ((int)reader["TRN"]).ToString();
                    this.DateOfBirth = SqlDateTime.Parse((reader["DateOfBirth"]).ToString());

                }
                reader.Close();

            // Gathering: ProductName from Farmer_ProducedProduct
                String farmerSelectTypicalProduct = $"SELECT ProductName FROM [Farmer_ProducedProduct] WHERE FarmerID = {FarmerId};";
                pullRecord.CommandText = farmerSelectTypicalProduct;
                
                this.ProductsTypicallyProduced = new List<string>();

                reader = pullRecord.ExecuteReader();
                while (reader.Read())
                {
                    this.ProductsTypicallyProduced.Add(reader["ProductName"].ToString());
                }
                reader.Close();

            // Gathering: 
                String farmerSelectLand = $"SELECT * FROM [Farmer_Land] WHERE OwnerID = {FarmerId};";
                pullRecord.CommandText = farmerSelectLand;

                this.OwnedLand = new List<LandInformation>();

                reader = pullRecord.ExecuteReader();
                while (reader.Read())
                {
                    OwnedLand.Add(new LandInformation((String)reader["Town"], (String)reader["PoBox"],
                        (String)reader["Parish"], Decimal.Parse(reader["LandMeasurement"].ToString())));
                }
                reader.Close();

            // Gathering: PhoneNumber from Farmer_PhoneNumber
                String farmerSelectPhoneNumber = $"SELECT PhoneNumber FROM [Farmer_PhoneNumber] WHERE FarmerID = {FarmerId};";
                pullRecord.CommandText = farmerSelectPhoneNumber;

                this.PhoneNumbers = new List<String>();

                reader = pullRecord.ExecuteReader();
                while (reader.Read())
                {
                    PhoneNumbers.Add(reader["PhoneNumber"].ToString());
                }
                reader.Close();

            // Gathering: Organization from Farmer_Organization
                String farmerSelectOrganization = $"SELECT Organization FROM [Farmer_Organization] WHERE FarmerID = {FarmerId};";
                pullRecord.CommandText = farmerSelectOrganization;

                this.Organizations = new List<string>();

                reader = pullRecord.ExecuteReader();
                while (reader.Read())
                {
                    Organizations.Add((String)reader["Organization"]);
                }
                reader.Close();

                connection.Close();
            }
        }

        public void UpdateFarmerDatabase(int farmerUserId, DataColumn dclUpdate, DataColumn dclAdd, DataColumn dclRemove)
        {
            // I'm not sure if this is worth the time to write, tbh
            // DELETE statements may cause issues if more than one person tries to act on them, but this
            // isn't project-relevant
            
            /* Requires:
             * - Knowledge of which parts of the farmer record have their own tables
             *      (ProducedProduct, PhoneNumber, Organization, Land)
             * - an add, remove, and modify table/column for each table
             *      - what information?
             * - may require creating an object to contain all of the columns/tables as one very large parameter holder
             */
        }
    }
}
