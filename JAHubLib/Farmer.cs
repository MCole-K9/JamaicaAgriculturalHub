using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlTypes;

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
    }
}
