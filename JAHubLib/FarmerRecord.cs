using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JAHubLib
{
    public class FarmerRecord
    {
        // As yet unclear how the application will distinguish users from each other
        // Probably will need another constructor that takes a session variable (probably the unique
        // ID of the user, which may or may not be separate from the username, idk)
        
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
        float TotalHectares { get; set; }
        
        Bitmap ProfilePicture { get; set; }
        String TaxRegistrationNumber { get; set; }

        int RadaPhase { get; set; }


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
