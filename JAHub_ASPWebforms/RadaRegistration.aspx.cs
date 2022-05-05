using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;
using JAHub_ASPWebforms.Verification;

namespace JAHub_ASPWebforms
{
    public partial class RadaRegistration : System.Web.UI.Page
    {
        protected bool fullRegistration;

        usrAddressBlock addressBlock;
        usrContactBlock contactBlock;
        usrDateOfBirthBlock dateOfBirthBlock;
        usrHoldingsBlock holdingsBlock;
        usrTrnBlock trnBlock;
        usrIndustryBlock industryBlock;
        usrOrganizationsBlock organizationsBlock;
        protected void Page_Init(object sender, EventArgs e)
        {
            if (PreviousPage.FarmerRegistrationPhase == RadaRegistrationType.NotRegistered)
            {
                // Create all of the controls for entry and let them see them

            }
            else if (PreviousPage.FarmerRegistrationPhase == RadaRegistrationType.FullyConnected)
            {
                // Change the text to say view/edit information
                // hide the button to choose between the short and long forms of doing the thing
                // Either hide the submit button or choose edit or something, idk
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage.FarmerRegistrationPhase == RadaRegistrationType.NotRegistered)
            {
                if (fullRegistration)
                {
                    // Add all of the controls
                }
                else
                {
                    // Add the reduced amount of controls
                }

            }
            else if (PreviousPage.FarmerRegistrationPhase == RadaRegistrationType.FullyConnected)
            {
                lblRadaRegistrationHeading.Text = "Edit/View Information";
                btnSubmit.Visible = false;
                FindControl("divAccountCreation").Visible = false;

                // query the entire farmer thing and write it out
            }
        }

        protected void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            fullRegistration = true;
        }

        protected void btnPreexistingAccount_Click(object sender, EventArgs e)
        {
            fullRegistration = false; 
        }
    }
}