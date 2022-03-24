using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JAHubLib
{
    public enum RadaRegistrationType
    {
        NotRegistered = 0,
        AwaitingVerification = 1,
        NotConnected = 2,
        FullyConnected = 3
    }

    public class FarmerRecord
    {
        // only writing these for the marks lol, they're not necessary
        String addressTown;
        String addressPoBox;
        String addressParish;

        public String AddressTown { 
            get {
                return addressTown;
            } 
            set {
                addressTown = value;
            } 
        }
        public String AddressPoBox { 
            get { 
                return addressPoBox;
            } 
            set {
                addressPoBox = value;
            }
        }
        public String AddressParish {
            get {
                return addressParish;
            }
            set
            {
                addressParish = value;
            }
                
        }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String MiddleName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public String BusinessEmail { get; set; }
        public Boolean UsesHeavyMachinery { get; set; }
        public int NumberOfEmployees { get; set; }

        public List<String> Products { get; set; }
        public List<String> Organizations { get; set; }
        public List<String> PhoneNumbers { get; set; }
        public decimal TotalHectares { get; set; }
        public Bitmap IdPicture { get; set; }
        public String TaxRegistrationNumber { get; set; }

        public RadaRegistrationType RadaRegistrationPhase { get; set; }


        public FarmerRecord()
        {
            // i don't think this needs anything, tbh. everything is accessible
            // from the properties
            // what might be useful, however, is to create a parameterized constructor that
            // takes an int userId
        }

        public bool WriteRecordToDatabase()
        {
            // this is here primarily as a placeholder

            // This should probably return a boolean in case it fucks up *somehow*

            return true;
        }

        
    }
}
