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

    // per discussion: classes are primarily data-holders, with methods to do
    // things with that data written in place/in event handlers
    public class Farmer : User
    {
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

        public DateTime DateOfBirth { get; set; }
        public String BusinessEmail { get; set; }
        public Boolean UsesHeavyMachinery { get; set; }
        public int NumberOfEmployees { get; set; }

        public List<String> ProductsTypicallyProduced { get; set; }
        public List<String> Organizations { get; set; }
        public List<String> PhoneNumbers { get; set; }
        public decimal TotalHectares { get; set; }
        public Bitmap IdPicture { get; set; }
        public String TaxRegistrationNumber { get; set; }
        public RadaRegistrationType RadaRegistrationPhase { get; set; }


        public Farmer()
        {
            // i don't think this needs anything, tbh. everything is accessible
            // from the properties
        }
    }
}
