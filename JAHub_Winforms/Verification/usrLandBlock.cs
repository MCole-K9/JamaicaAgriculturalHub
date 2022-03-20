using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms.Verification
{
    public partial class usrLandBlock : UserControl
    {
        bool isLandBlockValid;

        public decimal LandMeasurement => nudLandMeasurement.Value;
        public usrLandBlock()
        {
            InitializeComponent();
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
                nudLandMeasurement.Focus();
            }
        }
    }
}
