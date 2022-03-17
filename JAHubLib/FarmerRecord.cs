using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAHubLib
{
    public class FarmerRecord
    {
        // As yet unclear how the application will distinguish users from each other
        // Probably will need another constructor that takes a session variable
        String FirstName { get; set; }
        String LastName { get; set; }
        String MiddleName { get; set; }

        int radaPhase;


        public FarmerRecord()
        {
            // i don't think this needs anything, tbh.
        }

        
    }
}
