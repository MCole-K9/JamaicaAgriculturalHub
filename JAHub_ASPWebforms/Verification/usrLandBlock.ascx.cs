using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms.Verification
{
    public partial class usrLandBlock : System.Web.UI.UserControl
    {
        LandInformation land = new LandInformation();

        public LandInformation LandInformation
        {
            get
            {
                return land;
            }
            set
            {
                land = value;
                txtLandMeasurement.Text = land.LandMeasurement.ToString();

                addressBlock.AddressTown = land.LandAddressTown;
                addressBlock.AddressPostOffice = land.LandAddressPoBox;
                addressBlock.AddressParish = land.LandAddressParish;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public usrLandBlock()
        {
            // Nothing really necessary here
        }

    }
}