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

        String AddressTown { 
            get {
                return addressTown;
            } 
            set {
                addressTown = value;
            } 
        }
        String AddressPoBox { 
            get { 
                return addressPoBox;
            } 
            set {
                addressPoBox = value;
            }
        }
        String AddressParish {
            get {
                return addressParish;
            }
            set
            {
                addressParish = value;
            }
                
        }

        String FirstName { get; set; }
        String LastName { get; set; }
        String MiddleName { get; set; }

        DateTime dateOfBirth;

        String BusinessEmail { get; set; }
        Boolean UsesHeavyMachinery { get; set; }
        int NumberOfEmployees { get; set; }

        List<String> Products;
        List<String> Organizations;
        List<String> PhoneNumbers;
        decimal TotalHectares { get; set; }
        
        Bitmap IdPicture { get; set; }
        String TaxRegistrationNumber { get; set; }

        RadaRegistrationType RadaRegistrationPhase { get; set; }


        public FarmerRecord()
        {
            // i don't think this needs anything, tbh. everything is accessible
            // from the properties
        }

        public void WriteRecordToDatabase()
        {
            // this is here primarily as a placeholder
        }

        
    }
}
