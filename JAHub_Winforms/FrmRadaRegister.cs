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

                // Information will add to DB, but will not show from user perspective until verification
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
            FarmerRecord farmer = new FarmerRecord();
            
            if(applicationType == RadaRegistrationType.AwaitingVerification)
            {
                // basic structure is:
                // if(blahBlah.IsBlockValid())
                // {
                //      farmerObject.PropertyName = relevantControl.PropertyName;
                // }
                // else 
                // {
                //      blahBlah.SetControlFocus()
                //      put some messagebox that indicated where the fuckup is
                //      return;
                // }  
                // 
                // ...
                //
                // farmerRecord.WriteToDatabase();
                // Messagebox "Application Complete! Blahblahblah"
                // Return to either last opened form, or blank page
            }
            else if(applicationType == RadaRegistrationType.NotConnected)
            {
                //flwFormEntryControls.Controls[0].IsBlockValid();
                // won't work because relevant control is not identified as the usercontrol it is
                // with an IsBlockValid() method. need to find some workaround

                // potentially, could use multiple using{} blocks
                // using (var nameBlock = flwEntryBlock.Control[x] as usrNameBlock){
                //      if (nameBlock.IsBlockValid())
                //      {
                //          ...
                //      }
                // }
                //          
            }
        }
    }
}
