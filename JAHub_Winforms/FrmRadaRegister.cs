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
                flwFormEntryControls.Controls.Add(new usrIndustryBlock());
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
            Farmer farmer = new Farmer();
            String message;
            
            // Submission format for people who don't have RADA accounts already
            if(applicationType == RadaRegistrationType.AwaitingVerification)
            {
                using (var nameBlock = flwFormEntryControls.Controls[0] as usrNameBlock)
                {
                    if (nameBlock.IsBlockValid())
                    {
                        farmer.FirstName = nameBlock.FirstName;
                        farmer.MiddleName = nameBlock.MiddleName;
                        farmer.LastName = nameBlock.LastName;
                    }
                    else
                    {
                        nameBlock.SetControlFocus();

                        message = "Errors found in Name section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);

                        return;
                    }
                }

                using (var dateBlock = flwFormEntryControls.Controls[1] as usrDateOfBirthBlock)
                {
                    if (dateBlock.IsBlockValid())
                    {
                        farmer.DateOfBirth = new DateTime(Int32.Parse(dateBlock.Year),
                            Int32.Parse(dateBlock.Month), Int32.Parse(dateBlock.Day));
                    }
                    else
                    {
                        dateBlock.SetControlFocus();

                        message = "Errors found in Date of Birth section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        return;
                    }

                }

                using (var contactBlock = flwFormEntryControls.Controls[2] as usrContactBlock)
                {
                    if (contactBlock.IsBlockValid())
                    {
                        farmer.BusinessEmail = contactBlock.Email;
                        farmer.PhoneNumbers = contactBlock.PhoneNumbers;
                    }
                    else
                    {
                        contactBlock.SetControlFocus();

                        message = "Errors found in Contact section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        return;
                    }
                }

                using (var trnBlock = flwFormEntryControls.Controls[3] as usrTrnBlock)
                {
                    if (trnBlock.IsBlockValid())
                    {
                        farmer.TaxRegistrationNumber = trnBlock.Trn;
                    }
                    else
                    {
                        trnBlock.SetControlFocus();

                        message = "Errors found in Contact section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        return;
                    }
                }

                using (var imageBlock = flwFormEntryControls.Controls[4] as usrUploadImageBlock)
                {
                    if (!(imageBlock.ProfilePicture == null))
                    {
                        farmer.IdPicture = imageBlock.ProfilePicture;
                    }
                }

                 using (var holdingsBlock = flwFormEntryControls.Controls[5] as usrHoldingsBlock)
                {
                    if (holdingsBlock.IsBlockValid())
                    {
                        farmer.ProductsTypicallyProduced = holdingsBlock.ProductList;

                        if (!String.IsNullOrEmpty(holdingsBlock.LandAddressParish))
                        {
                            farmer.AddressTown = holdingsBlock.LandAddressTown;
                            farmer.AddressPoBox = holdingsBlock.LandAddressPoBox;
                            farmer.AddressParish = holdingsBlock.LandAddressPoBox;
                        }

                        farmer.TotalHectares = holdingsBlock.LandMeasurement;
                    }
                    else
                    {
                        holdingsBlock.SetControlFocus();

                        message = "Errors found in Holdings section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        return;
                    }
                }

                using (var industryBlock = flwFormEntryControls.Controls[6] as usrIndustryBlock)
                {
                    if (industryBlock.IsBlockValid())
                    {

                    }
                    else
                    {
                        industryBlock.SetControlFocus();
                        
                        message = "Errors found in Holdings section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        return;
                    }
                }

                using (var organizationsBlock = flwFormEntryControls.Controls[7] as usrOrganizationsBlock)
                {
                    if (organizationsBlock.Organizations != null)
                    {
                        farmer.Organizations = organizationsBlock.Organizations;
                    }
                }
            }
            
            // Other submission format for People with already existing RADA Records
            else if(applicationType == RadaRegistrationType.NotConnected)
            {
                farmer.RadaRegistrationPhase = applicationType;

                using (var nameBlock = flwFormEntryControls.Controls[0] as usrNameBlock)
                {
                    if (nameBlock.IsBlockValid())
                    {
                        farmer.FirstName = nameBlock.FirstName;
                        farmer.MiddleName = nameBlock.MiddleName;
                        farmer.LastName = nameBlock.LastName;
                    }
                    else
                    {
                        nameBlock.SetControlFocus();

                        message = "Errors found in Name section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        return;
                    }
                }

                using (var dateBlock = flwFormEntryControls.Controls[1] as usrDateOfBirthBlock)
                {
                    if (dateBlock.IsBlockValid())
                    {
                        farmer.DateOfBirth = new DateTime(Int32.Parse(dateBlock.Year),
                            Int32.Parse(dateBlock.Month), Int32.Parse(dateBlock.Day));
                    }
                    else
                    {
                        dateBlock.SetControlFocus();
                        
                        message = "Errors found in Date of Birth section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        return;
                    }

                }
                
                using (var trnBlock = flwFormEntryControls.Controls[2] as usrTrnBlock)
                {
                    if (trnBlock.IsBlockValid())
                    {
                        farmer.TaxRegistrationNumber = trnBlock.Trn;
                    }
                    else
                    {
                        trnBlock.SetControlFocus();

                        message = "Errors found in TRN section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        return;
                    }
                }
            }

            //if (farmer.WriteRecordToDatabase())
            //{
                if (applicationType == RadaRegistrationType.AwaitingVerification)
                {
                    message = "Successfully created record for " + farmer.FirstName +
                        " " + farmer.LastName + "! \n Please wait to be verified.";
                    MessageBox.Show(message);
                }
                else
                {
                    message = "Successfully entered request to connect account for " + farmer.FirstName +
                        " " + farmer.LastName + "! \n Please wait to be connected.";
                    MessageBox.Show(message);
                }

                // end the form and return to wherever you were before

            //}
            //else
            //{
                message = "Could not write to database";
                MessageBox.Show(message);

                // end the form and return to wherever
            //}

        }
    }
}
