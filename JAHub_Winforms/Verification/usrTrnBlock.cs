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
    /* TO-DO
     * [x] write the validation for the trn
     * [x] write IsBlockValid() method for TRN Block
     * [x] expose value inside of mskTrn for submission
     * [x] add the value of farmer.TRN to this
     */

    public partial class usrTrnBlock : UserControl
    {
        public String TaxRegistrationNumber => mskTrn.Text;

        public usrTrnBlock()
        {
            InitializeComponent();
        }

        public usrTrnBlock(String trn)
        {
            InitializeComponent();
            mskTrn.Text = trn;
            lblTrn.Text = "TRN: ";
            mskTrn.Enabled = false;
        }

        private void mskTrn_Validating(object sender, CancelEventArgs e)
        {
            if (!mskTrn.MaskCompleted)
            {
                errTrnBlock.SetIconAlignment(mskTrn, ErrorIconAlignment.MiddleRight);
                errTrnBlock.SetError(mskTrn, "Please Enter a Valid TRN");

            }
            else
            {
                errTrnBlock.SetError(mskTrn, "");
            }
        }

        public bool IsBlockValid()
        {
            if (mskTrn.MaskCompleted)
            {
                return true;
            }

            return false;
        }

        public void SetControlFocus()
        {
            mskTrn.Select();
        }
    }
}
