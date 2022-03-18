﻿using System;
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
    /* TO-DO
     * [] write the validation for the trn
     * []
     */

    public partial class usrTrnBlock : UserControl
    {
        public usrTrnBlock()
        {
            InitializeComponent();
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
    }
}
