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
        RadaRegistrationType applicationType = RadaRegistrationType.AwaitingVerification;

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

                // Information will add to DB, but will not show until verification
                applicationType = RadaRegistrationType.AwaitingVerification;
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

                // User already has an application with RADA, but is not connected to system
                applicationType = RadaRegistrationType.NotConnected;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // First step: Check to see if all controls validate correctly
            // But then, how do i know which controls to validate?
            // depends on the lists

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
