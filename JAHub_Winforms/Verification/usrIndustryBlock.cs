using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms.Verifcation
{
    public partial class usrIndustryBlock : UserControl
    {
        public usrIndustryBlock()
        {
            InitializeComponent();
        }

        // in reality this is not the space where this event should go, but
        // it doesn't actually matter because this should only get called if:
        // A. the user tabs over the control
        // B. at the end when the user tried to submit
        private void rdoIndustryYes_Validating(object sender, CancelEventArgs e)
        {
            if (!rdoIndustryNo.Checked && !rdoIndustryYes.Checked)
            {
                errIndustryBlock.SetIconAlignment(lblHeavyMachinery, ErrorIconAlignment.MiddleRight);
                errIndustryBlock.SetError(lblHeavyMachinery, "Please select 'Yes' or 'No'");
            }
            else
            {
                errIndustryBlock.SetError(lblHeavyMachinery, "");
            }
        }

        // same thing for this function
        private void rdoIndustryNo_Validating(object sender, CancelEventArgs e)
        {
            if (!rdoIndustryNo.Checked && !rdoIndustryYes.Checked)
            {
                errIndustryBlock.SetIconAlignment(lblHeavyMachinery, ErrorIconAlignment.MiddleRight);
                errIndustryBlock.SetError(lblHeavyMachinery, "Please select 'Yes' or 'No'");
            }
            else
            {
                errIndustryBlock.SetError(lblHeavyMachinery, "");
            }
        }
    }
}
