using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHub_Winforms.Verification;
using JAHubLib;

namespace JAHub_Winforms
{
    public partial class FrmRadaRegister : Form
    {
        public FrmRadaRegister()
        {
            InitializeComponent();
        }

        private void btnNewRegistration_Click(object sender, EventArgs e)
        {
            if (flwFormEntryControls.Controls.Count <= 3)
            {
                flwFormEntryControls.Controls.Clear();

                flwFormEntryControls.Controls.Add(new usrNameBlock());
                flwFormEntryControls.Controls.Add(new usrDateOfBirthBlock());
                flwFormEntryControls.Controls.Add(new usrContactBlock());
                flwFormEntryControls.Controls.Add(new usrTrnBlock());
                flwFormEntryControls.Controls.Add(new usrUploadImageBlock());
                flwFormEntryControls.Controls.Add(new usrHoldingsBlock());
                flwFormEntryControls.Controls.Add(new usrProductsBlock());
                flwFormEntryControls.Controls.Add(new usrOrganizationsBlock());
            }
        }

        private void btnConnectExistingAccount_Click(object sender, EventArgs e)
        {
            if (flwFormEntryControls.Controls.Count > 3)
            {
                flwFormEntryControls.Controls.Clear();
                flwFormEntryControls.Controls.Add(new usrNameBlock());
                flwFormEntryControls.Controls.Add(new usrDateOfBirthBlock());
                flwFormEntryControls.Controls.Add(new usrTrnBlock());
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FarmerRecord record = new FarmerRecord();

            // Broadly:
            // - Check to see if all controls validate correctly
            // Every block that can validate has its own "IsBlockValid()" method
            // Run the blocks

            // use properties to expose all of the relevant data to this form


            //  - If there are *necessary* invalid controls, stop process, raise errors
            // - Write object to database (consult "old and new registration" file)
            // - Indicate process completion (probably via messagebox)
            // - Take user back to wherever they came from (tbd)
        }
    }
}
