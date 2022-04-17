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
            //udLandMeasurement.Value = landInformation.LandMeasurement;
            //tblLandBlock.Controls.Add(new usrAddressBlock(landInformation.LandAddressTown,
                //landInformation.LandAddressPoBox, landInformation.LandAddressParish));

            //var addressBlock = tblLandBlock.Controls[tblLandBlock.Controls.Count - 1];

            //tblLandBlock.SetCellPosition(addressBlock, new TableLayoutPanelCellPosition(1, 0));

            //isLandBlockValid = true;
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

        public bool IsBlockValid()
        {
            //if ((usrLandBlock)phAddressBlock.Controls[0].IsBlockValid())
            {
                if (isLandBlockValid)
                {
                    //land.LandAddressTown = usrAddressBlock1.AddressTown;
                    //land.LandAddressPoBox = usrAddressBlock1.AddressPostOffice;
                    //land.LandAddressParish = usrAddressBlock1.AddressParish;

                   // land.LandMeasurement = nudLandMeasurement.Value;

                    return true;
                }
            }

            return false;
        }

        public void SetControlFocus()
        {
            //if (!usrAddressBlock1.IsBlockValid())
            {
                //usrAddressBlock1.SetControlFocus();
            }
            //else if (!isLandBlockValid)
            {
                //nudLandMeasurement.Select();
            }
        }

        private void nudLandMeasurement_ValueChanged(object sender, EventArgs e)
        {
            // I would probably prefer to use "TextChanged" or some other event like that, but
            // this will work for the time being
           // if (nudLandMeasurement.Value <= 0)
            {
                //errLandBlock.SetIconAlignment(nudLandMeasurement, ErrorIconAlignment.MiddleRight);
                //errLandBlock.SetError(nudLandMeasurement, "Value must be greater than 0");

                //isLandBlockValid = false;
            }
            //else
            {
               // errLandBlock.SetError(nudLandMeasurement, "");


                //isLandBlockValid = true;
            }
        }
    }
}