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
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace JAHub_Winforms
{
    public partial class FrmRadaRegister : Form
    {
        /* TO DO:
         * [x] Double check the submission function
         * [x] pass values into Farmer object
         * [x] activate a "write farmer to record" form
         * [x] Check to see if the user is a customer, anf if all works, make them 
         * 
         */

        FrmProfile _profile;
        RadaRegistrationType _registrationPhase = RadaRegistrationType.AwaitingVerification;

        usrNameBlock nameBlock;
        usrDateOfBirthBlock dateBlock;
        usrContactBlock contactBlock;
        usrTrnBlock trnBlock;
        usrUploadImageBlock imageBlock;
        usrIndustryBlock industryBlock;
        usrHoldingsBlock holdingsBlock;
        usrOrganizationsBlock organizationsBlock;

        public FrmRadaRegister(FrmProfile profile, RadaRegistrationType registrationPhase)
        {
            InitializeComponent();
            this._registrationPhase = registrationPhase;
            this._profile = profile;
        }

        private void btnNewRegistration_Click(object sender, EventArgs e)
        {
            if (flwFormEntryControls.Controls.Count <= 3)
            {
                flwFormEntryControls.Controls.Clear();


                nameBlock = new usrNameBlock();
                flwFormEntryControls.Controls.Add(nameBlock);

                dateBlock = new usrDateOfBirthBlock();
                flwFormEntryControls.Controls.Add(dateBlock);

                contactBlock = new usrContactBlock();
                flwFormEntryControls.Controls.Add(contactBlock);

                trnBlock = new usrTrnBlock();
                flwFormEntryControls.Controls.Add(trnBlock);

                imageBlock = new usrUploadImageBlock();
                flwFormEntryControls.Controls.Add(imageBlock);

                industryBlock = new usrIndustryBlock();
                flwFormEntryControls.Controls.Add(industryBlock);
                
                holdingsBlock = new usrHoldingsBlock();
                flwFormEntryControls.Controls.Add(holdingsBlock);

                organizationsBlock = new usrOrganizationsBlock();
                flwFormEntryControls.Controls.Add(organizationsBlock);

                // Information will add to DB, but will not show from user perspective until verification
                _registrationPhase = RadaRegistrationType.AwaitingVerification;
            }
        }

        private void btnConnectExistingAccount_Click(object sender, EventArgs e)
        {
            // Basically: Clear controls, and then create the list of sections necessary to connect an account
            
            if (flwFormEntryControls.Controls.Count > 3)
            {
                flwFormEntryControls.Controls.Clear();

                nameBlock = new usrNameBlock();
                flwFormEntryControls.Controls.Add(nameBlock);

                dateBlock = new usrDateOfBirthBlock();
                flwFormEntryControls.Controls.Add(dateBlock);

                contactBlock = null;

                trnBlock = new usrTrnBlock();
                flwFormEntryControls.Controls.Add(trnBlock);

                industryBlock = null;
                holdingsBlock = null;
                organizationsBlock = null;

                // User already has an application with RADA, but is not connected to system
                _registrationPhase = RadaRegistrationType.NotConnected;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Farmer farmer = new Farmer();
            String message;

            farmer.RadaRegistrationPhase = _registrationPhase;

            bool isBlockOkay = true;

            // note: this method doesn't need a sentinel value, because in the event of an error of some kind, 
            // the method returns early

            // Submission format for people who don't have RADA accounts already
            if (_registrationPhase == RadaRegistrationType.AwaitingVerification)
            {
                // all of the using() statements are leftovers from a method that didn't seem to work, i'll remove 
                // them later, definitely do not care enough to rn
                
                if (isBlockOkay)
                {
                    if (nameBlock.IsBlockValid())
                    {
                        farmer.FirstName = nameBlock.FirstName;
                        farmer.MiddleName = nameBlock.MiddleName;
                        farmer.LastName = nameBlock.LastName;
                    }
                    else
                    {
                        //ScrollControlIntoView(nameBlock);
                        //nameBlock.SetControlFocus();

                        message = "Errors found in Name section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        isBlockOkay = false;
                    }
                }
                
                if (isBlockOkay)
                {
                    if (dateBlock.IsBlockValid())
                    {
                        farmer.DateOfBirth = new SqlDateTime(new DateTime(dateBlock.Year, dateBlock.Month, dateBlock.Day));
                    }
                    else
                    {
                        //ScrollControlIntoView(dateBlock);
                        //dateBlock.SetControlFocus();

                        message = "Errors found in Date of Birth section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        isBlockOkay = false;
                    }
                }

                if (isBlockOkay)
                {
                    if (contactBlock.IsBlockValid())
                    {
                        farmer.BusinessEmail = contactBlock.Email;
                        farmer.PhoneNumbers = contactBlock.PhoneNumbers;
                    }
                    else
                    {
                        //ScrollControlIntoView(contactBlock);
                        //contactBlock.SetControlFocus();

                        message = "Errors found in Contact section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        return;
                    }
                }
                

                if (trnBlock.IsBlockValid())
                {
                    farmer.TaxRegistrationNumber = trnBlock.TaxRegistrationNumber;
                }
                else
                {
                    //ScrollControlIntoView(trnBlock);
                    //trnBlock.SetControlFocus();

                    message = "Errors found in Contact section. Please fix them and " +
                        "resubmit your appliication";
                    MessageBox.Show(message);
                    return;
                }


                // I'm ignoring this until i have time to fix wtvs
                if(isBlockOkay)
                {
                    if (!(imageBlock.ProfilePicture == null))
                    {
                        farmer.IdPicture = imageBlock.ProfilePicture;
                    }
                }

                if (isBlockOkay)
                {
                    if (holdingsBlock.IsBlockValid())
                    {
                        farmer.ProductsTypicallyProduced = holdingsBlock.ProductList;

                        if ((holdingsBlock.LandInformation) != null)
                        {
                            farmer.OwnedLand = holdingsBlock.LandInformation;
                        }

                    }
                    else
                    {
                        //ScrollControlIntoView(holdingsBlock);
                        //holdingsBlock.SetControlFocus();

                        message = "Errors found in Holdings section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        isBlockOkay = false;
                    }
                }

                if (isBlockOkay)
                {
                    if (industryBlock.IsBlockValid())
                    {

                    }
                    else
                    {
                        //ScrollControlIntoView(industryBlock);
                        //industryBlock.SetControlFocus();
                        
                        message = "Errors found in Holdings section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        isBlockOkay = false;
                    }
                }

                if(isBlockOkay)
                {
                    if (organizationsBlock.Organizations != null)
                    {
                        farmer.Organizations = organizationsBlock.Organizations;
                    }
                }
            }
            
            // Other submission format for People with already existing RADA Records
            else if(_registrationPhase == RadaRegistrationType.NotConnected)
            {
                farmer.RadaRegistrationPhase = _registrationPhase;

                if (isBlockOkay)
                {
                    if (nameBlock.IsBlockValid())
                    {
                        farmer.FirstName = nameBlock.FirstName;
                        farmer.MiddleName = nameBlock.MiddleName;
                        farmer.LastName = nameBlock.LastName;
                    }
                    else
                    {
                        //ScrollControlIntoView(nameBlock);
                        //nameBlock.SetControlFocus();

                        message = "Errors found in Name section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        isBlockOkay = false;
                    }
                }

                if (isBlockOkay)
                {
                    if (dateBlock.IsBlockValid())
                    {
                        farmer.DateOfBirth = new SqlDateTime(new DateTime(dateBlock.Year, dateBlock.Month, dateBlock.Day));
                    }
                    else
                    {
                        //ScrollControlIntoView(dateBlock);
                        //dateBlock.SetControlFocus();
                        
                        message = "Errors found in Date of Birth section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        isBlockOkay = false;
                    }
                }
                
                if (isBlockOkay)
                {
                    if (trnBlock.IsBlockValid())
                    {
                        farmer.TaxRegistrationNumber = trnBlock.TaxRegistrationNumber;
                    }
                    else
                    {
                        //ScrollControlIntoView(trnBlock);
                        //trnBlock.SetControlFocus();

                        message = "Errors found in TRN section. Please fix them and " +
                            "resubmit your appliication";
                        MessageBox.Show(message);
                        isBlockOkay = false;
                    }
                }
            }

            if (isBlockOkay)
            {
                // This changes a customer into a farmer, in case the customer wants to register
                if (Session.UserRole == UserRole.Customer)
                {
                    using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                    {
                        connection.Open();

                        // First: Change the UserRole in the User Table
                        String command = $"UPDATE [User] SET UserRole = 3 WHERE ID = {Session.UserId}";

                        SqlCommand changeCustomerToFarmer = new SqlCommand(command, connection);

                        changeCustomerToFarmer.ExecuteNonQuery();

                        // Then: Create a new record for the Farmer-to-be using their UserID
                        changeCustomerToFarmer.CommandText = $"INSERT INTO [Farmer] (UserId) VALUES ({Session.UserId})";

                        changeCustomerToFarmer.ExecuteNonQuery();

                        connection.Close();
                    }
                }

                if (farmer.WriteRecordToDatabase())
                {
                    if (_registrationPhase == RadaRegistrationType.AwaitingVerification)
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
                }
                else
                {
                    // tell them there was an error
                }

                _profile.OpenChildForm(new FrmDashboard());
            }
            else
            {
                // tell them this won't work
            }
        }

        private void FrmRadaRegister_Load(object sender, EventArgs e)
        {
            
            flwFormEntryControls.Controls.Clear();

            nameBlock = new usrNameBlock();
            flwFormEntryControls.Controls.Add(nameBlock);

            dateBlock = new usrDateOfBirthBlock();
            flwFormEntryControls.Controls.Add(dateBlock);

            contactBlock = new usrContactBlock();
            flwFormEntryControls.Controls.Add(contactBlock);

            trnBlock = new usrTrnBlock();
            flwFormEntryControls.Controls.Add(trnBlock);

            imageBlock = new usrUploadImageBlock();
            flwFormEntryControls.Controls.Add(imageBlock);

            industryBlock = new usrIndustryBlock();
            flwFormEntryControls.Controls.Add(industryBlock);

            holdingsBlock = new usrHoldingsBlock();
            flwFormEntryControls.Controls.Add(holdingsBlock);

            organizationsBlock = new usrOrganizationsBlock();
            flwFormEntryControls.Controls.Add(organizationsBlock);

            // Information will add to DB, but will not show from user perspective until verification
            _registrationPhase = RadaRegistrationType.AwaitingVerification;


        }
    }
}
