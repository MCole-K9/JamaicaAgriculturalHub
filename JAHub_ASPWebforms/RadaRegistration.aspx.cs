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
                lblRadaRegistrationHeading.Text = "Edit Information";
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
                    GenerateFullRegistration();
                }
                else
                {
                    GeneratePartialRegistration();
                }

            }
            else if (PreviousPage.FarmerRegistrationPhase == RadaRegistrationType.FullyConnected)
            {
                lblRadaRegistrationHeading.Text = "Edit/View Information";
                btnSubmit.Visible = false;
                FindControl("divAccountCreation").Visible = false;

                GenerateFullRegistration();

                // query the entire farmer thing and write it out
                // what if a postback happens?
            }
        }

        protected void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            fullRegistration = true;

            GenerateFullRegistration();
        }

        protected void btnPreexistingAccount_Click(object sender, EventArgs e)
        {
            fullRegistration = false;

            GeneratePartialRegistration();
        }

        protected void GenerateFullRegistration()
        {
            addressBlock = (usrAddressBlock)LoadControl("~/Verification/usrAddressBlock.ascx");
            contactBlock = (usrContactBlock)LoadControl("~/Verification/usrContactBlock.ascx");
            dateOfBirthBlock = (usrDateOfBirthBlock)LoadControl("~/Verificaton/usrDateOfBirthBlock.ascx");
            holdingsBlock = (usrHoldingsBlock)LoadControl("~/Verificaton/usrHoldingsBlock.ascx");
            trnBlock = (usrTrnBlock)LoadControl("~/Verification/usrTrnBlock.ascx");
            industryBlock = (usrIndustryBlock)LoadControl("~/Verificaton/usrIndustryBlock.ascx");
            organizationsBlock = (usrOrganizationsBlock)LoadControl("~/Verification/usrOrganizationzBlock.ascx");
        }

        protected void GeneratePartialRegistration()
        {
            addressBlock = (usrAddressBlock)LoadControl("~/Verification/usrAddressBlock.ascx");
            contactBlock = (usrContactBlock)LoadControl("~/Verification/usrContactBlock.ascx");
            dateOfBirthBlock = (usrDateOfBirthBlock)LoadControl("~/Verificaton/usrDateOfBirthBlock.ascx");
            holdingsBlock = (usrHoldingsBlock)LoadControl("~/Verificaton/usrHoldingsBlock.ascx");
            trnBlock = (usrTrnBlock)LoadControl("~/Verification/usrTrnBlock.ascx");
            industryBlock = (usrIndustryBlock)LoadControl("~/Verificaton/usrIndustryBlock.ascx");
            organizationsBlock = (usrOrganizationsBlock)LoadControl("~/Verification/usrOrganizationzBlock.ascx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate();

            // change customer to farmer if they're so and so.

            if (fullRegistration)
            {
                // do the full submission for blah blah
            }
            else
            {
                // do the partial submission
            }
        }
    }
}