using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHubLib;

namespace JAHub_Winforms.Verification
{
    /* TO DO
     * [] find a way to pass the farmer object to the address block
     */

    public partial class usrLandBlock : UserControl
    {
        bool isLandBlockValid;
        LandInformation land = new LandInformation();

        public LandInformation LandInformation => land;

        public usrLandBlock()
        {
            InitializeComponent();
        }

        public usrLandBlock(LandInformation landInformation)
        {
            InitializeFilledComponent();
            nudLandMeasurement.Value = landInformation.LandMeasurement;
            tblLandBlock.Controls.Add(new usrAddressBlock(landInformation.LandAddressTown,
                landInformation.LandAddressPoBox, landInformation.LandAddressParish));
            
            var addressBlock = tblLandBlock.Controls[tblLandBlock.Controls.Count - 1];

            tblLandBlock.SetCellPosition(addressBlock, new TableLayoutPanelCellPosition(1, 0));

            isLandBlockValid = true;
        }

        private void nudLandMeasurement_Validating(object sender, CancelEventArgs e)
        {
            // I would probably prefer to use "TextChanged" or some other event like that, but
            // this will work for the time being
            if (nudLandMeasurement.Value <= 0)
            {
                errLandBlock.SetIconAlignment(nudLandMeasurement, ErrorIconAlignment.MiddleRight);
                errLandBlock.SetError(nudLandMeasurement, "Value must be greater than 0");

                isLandBlockValid = false;
            }
            else
            {
                errLandBlock.SetError(nudLandMeasurement, "");

                isLandBlockValid = true;
            }
        }

        public bool IsBlockValid()
        {
            if (usrAddressBlock1.IsBlockValid())
            {
                if (isLandBlockValid)
                {
                    land.LandAddressTown = usrAddressBlock1.AddressTown;
                    land.LandAddressPoBox = usrAddressBlock1.AddressPostOffice;
                    land.LandAddressParish = usrAddressBlock1.AddressParish;

                    return true;
                }
            }

            return false;
        }

        public void SetControlFocus()
        {
            if (!usrAddressBlock1.IsBlockValid())
            {
                usrAddressBlock1.SetControlFocus();
            }
            else if (!isLandBlockValid)
            {
                nudLandMeasurement.Select();
            }
        }
    }
}
