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
    public partial class usrNameBlock : UserControl
    {
        public usrNameBlock()
        {
            InitializeComponent();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                errNameBlock.SetIconAlignment(txtFirstName, ErrorIconAlignment.MiddleRight);
                errNameBlock.SetError(txtFirstName, "Field Cannot be Blank");
            }
            else
            {
                errNameBlock.SetError(txtFirstName, String.Empty);
            }
        }

        private void txtMiddleName_Validating(object sender, CancelEventArgs e)
        {
            if (txtMiddleName.Text == "")
            {
                errNameBlock.SetIconAlignment(txtMiddleName, ErrorIconAlignment.MiddleRight);
                errNameBlock.SetError(txtMiddleName, "Field Cannot be Blank");
            }
            else
            {
                errNameBlock.SetError(txtMiddleName, String.Empty);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text == "")
            {
                errNameBlock.SetIconAlignment(txtLastName, ErrorIconAlignment.MiddleRight);
                errNameBlock.SetError(txtLastName, "Field Cannot be Blank");
            }
            else
            {
                errNameBlock.SetError(txtLastName, String.Empty);
            }
        }

        

        // TO DO
        // ~[~] write method to bring focus to first control to have unfilled field~
        // [ ] write method to collect everythign up into an object
        // [x] resolve compiler error regarding control and Validation problems
        // [x] write method to remove error provider when the field is filled
        // [x] change error provider to the non-blinking kind
    }
}
