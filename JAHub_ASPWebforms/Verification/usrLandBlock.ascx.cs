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
        bool isLandBlockValid;
        LandInformation land = new LandInformation();

        public LandInformation LandInformation => land;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public usrLandBlock()
        {
            // Nothing really necessary here
        }

        public usrLandBlock(LandInformation landInformation)
        {
            txtLandMeasurement.Text = landInformation.LandMeasurement.ToString();
            phAddressBlock.Controls.Add((usrAddressBlock)LoadControl("~/usrAddressBlock.ascx.cs"/*, [landInformation.LandAddressTown,
                landInformation.LandAddressPoBox, landInformation.LandAddressParish]*/));

            isLandBlockValid = true;
        }

        private void nudLandMeasurement_Validating(object sender)
        {
            // I would probably prefer to use "TextChanged" or some other event like that, but
            // this will work for the time being
            //if (nudLandMeasurement.Value <= 0)
            {
               // errLandBlock.SetIconAlignment(nudLandMeasurement, ErrorIconAlignment.MiddleRight);
               // errLandBlock.SetError(nudLandMeasurement, "Value must be greater than 0");

              //  isLandBlockValid = false;
            }
          //  else
            {
                //errLandBlock.SetError(nudLandMeasurement, "");


                //isLandBlockValid = true;
            }
        }

        //public bool IsBlockValid()
        //{
        //    var addressBlock = phAddressBlock.Controls[0] as usrAddressBlock;

        //    if (addressBlock.IsBlockValid())
        //    {
        //        if (isLandBlockValid)
        //        {
        //            land.LandAddressTown = addressBlock.AddressTown;
        //            land.LandAddressPoBox = addressBlock.AddressPostOffice;
        //            land.LandAddressParish = addressBlock.AddressParish;

        //            land.LandMeasurement = Decimal.Parse(txtLandMeasurement.Text);

        //            return true;
        //        }
        //    }

        //    return false;
        //}

    }
}