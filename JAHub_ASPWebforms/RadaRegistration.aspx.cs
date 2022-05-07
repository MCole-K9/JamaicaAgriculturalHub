using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;
using JAHub_ASPWebforms.Verification;
using System.Data;
using System.Data.SqlClient;

namespace JAHub_ASPWebforms
{
    public partial class RadaRegistration : System.Web.UI.Page
    {
        protected bool fullRegistration
        {
            get
            {
                return ViewState["registrationFullRegistration"] == null ? true : (bool)ViewState["registrationFullRegistration"];
            }
            set
            {
                ViewState["registrationFullRegistration"] = value;
            }
        }

        usrNameBlock nameBlock;
        //usrAddressBlock addressBlock;
        usrContactBlock contactBlock;
        usrDateOfBirthBlock dateOfBirthBlock;
        usrHoldingsBlock holdingsBlock;
        usrTrnBlock trnBlock;
        usrIndustryBlock industryBlock;
        usrOrganizationsBlock organizationsBlock;
        protected void Page_Init(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
                    btnSubmit.Text = "Update Record";
                    FindControl("divAccountCreation").Visible = false;

                    GenerateFullRegistration();

                    if (!IsPostBack)
                    {
                        Farmer farmer = new Farmer();
                        farmer.GetFullRecordFromDatabase((int)Session["UserId"]);

                        nameBlock.FirstName = farmer.FirstName;
                        nameBlock.MiddleName = farmer.MiddleName;
                        nameBlock.LastName = farmer.LastName;

                        var date = (DateTime)farmer.DateOfBirth;

                        dateOfBirthBlock.Day = date.Day;
                        dateOfBirthBlock.Month = date.Month;
                        dateOfBirthBlock.Year = date.Year;

                        trnBlock.TaxRegistrationNumber = farmer.TaxRegistrationNumber;

                        contactBlock.Email = farmer.Email;
                        contactBlock.PhoneNumbers = farmer.PhoneNumbers;

                        industryBlock.NumberOfEmployees = farmer.NumberOfEmployees;
                        industryBlock.UsesHeavyMachinery = farmer.UsesHeavyMachinery;

                        holdingsBlock.LandInformation = farmer.OwnedLand;

                        organizationsBlock.Organizations = farmer.Organizations;
                    }
                }
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
            nameBlock = (usrNameBlock)LoadControl("~/Verification/usrNameBlock.ascx");
            //addressBlock = (usrAddressBlock)LoadControl("~/Verification/usrAddressBlock.ascx");
            contactBlock = (usrContactBlock)LoadControl("~/Verification/usrContactBlock.ascx");
            dateOfBirthBlock = (usrDateOfBirthBlock)LoadControl("~/Verification/usrDateOfBirthBlock.ascx");
            holdingsBlock = (usrHoldingsBlock)LoadControl("~/Verification/usrHoldingsBlock.ascx");
            trnBlock = (usrTrnBlock)LoadControl("~/Verification/usrTrnBlock.ascx");
            industryBlock = (usrIndustryBlock)LoadControl("~/Verification/usrIndustryBlock.ascx");
            organizationsBlock = (usrOrganizationsBlock)LoadControl("~/Verification/usrOrganizationsBlock.ascx");

            phRadaRegistration.Controls.Add(nameBlock);
            phRadaRegistration.Controls.Add(dateOfBirthBlock);
            phRadaRegistration.Controls.Add(contactBlock);
            phRadaRegistration.Controls.Add(trnBlock);
            phRadaRegistration.Controls.Add(industryBlock);
            phRadaRegistration.Controls.Add(organizationsBlock);
            phRadaRegistration.Controls.Add(holdingsBlock);
        }

        protected void GeneratePartialRegistration()
        {
            nameBlock = (usrNameBlock)LoadControl("~/Verification/usrNameBlock.ascx");
            //addressBlock = (usrAddressBlock)LoadControl("~/Verification/usrAddressBlock.ascx");
            contactBlock = (usrContactBlock)LoadControl("~/Verification/usrContactBlock.ascx");
            dateOfBirthBlock = (usrDateOfBirthBlock)LoadControl("~/Verification/usrDateOfBirthBlock.ascx");
            //holdingsBlock = (usrHoldingsBlock)LoadControl("~/Verificaton/usrHoldingsBlock.ascx");
            trnBlock = (usrTrnBlock)LoadControl("~/Verification/usrTrnBlock.ascx");
            //industryBlock = (usrIndustryBlock)LoadControl("~/Verificaton/usrIndustryBlock.ascx");
            //organizationsBlock = (usrOrganizationsBlock)LoadControl("~/Verification/usrOrganizationzBlock.ascx");

            phRadaRegistration.Controls.Add(nameBlock);
            phRadaRegistration.Controls.Add(dateOfBirthBlock);
            phRadaRegistration.Controls.Add(trnBlock);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate();

            if (Page.IsValid)
            {
                // change customer to farmer if valid
                if ((UserRole)Session["UserRole"] == UserRole.Customer)
                {
                    using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                    {
                        connection.Open();

                        // First: Change the UserRole in the User Table
                        String command = $"UPDATE [User] SET UserRole = 3 WHERE ID = {Session["UserId"]}";

                        SqlCommand changeCustomerToFarmer = new SqlCommand(command, connection);

                        changeCustomerToFarmer.ExecuteNonQuery();

                        // Then: Create a new record for the Farmer-to-be using their UserID
                        changeCustomerToFarmer.CommandText = $"INSERT INTO [Farmer] (UserId) VALUES ({Session["UserId"]})";

                        changeCustomerToFarmer.ExecuteNonQuery();

                        connection.Close();
                    }
                }


                if (fullRegistration)
                {
                    Farmer newFarmer = new Farmer();

                    newFarmer.FirstName = nameBlock.FirstName;
                    newFarmer.MiddleName = nameBlock.MiddleName;
                    newFarmer.LastName = nameBlock.LastName;

                    newFarmer.TaxRegistrationNumber = trnBlock.TaxRegistrationNumber;

                    newFarmer.DateOfBirth = new System.Data.SqlTypes.SqlDateTime(dateOfBirthBlock.Year, dateOfBirthBlock.Month, dateOfBirthBlock.Day);

                    newFarmer.BusinessEmail = contactBlock.Email;
                    newFarmer.PhoneNumbers = contactBlock.PhoneNumbers;

                    newFarmer.ProductsTypicallyProduced = holdingsBlock.ProductList;
                    newFarmer.OwnedLand = holdingsBlock.LandInformation;

                    newFarmer.Organizations = organizationsBlock.Organizations;

                    newFarmer.UsesHeavyMachinery = industryBlock.UsesHeavyMachinery;
                    newFarmer.NumberOfEmployees = Decimal.ToInt32(industryBlock.NumberOfEmployees);

                    newFarmer.RadaRegistrationPhase = RadaRegistrationType.AwaitingVerification;

                    newFarmer.WriteRecordToDatabase((int)Session["UserId"]);

                    Response.Redirect("~/RadaStatus.aspx");
                }
                else
                {
                    Farmer newFarmer = new Farmer();

                    newFarmer.FirstName = nameBlock.FirstName;
                    newFarmer.MiddleName = nameBlock.MiddleName;
                    newFarmer.LastName = nameBlock.LastName;

                    newFarmer.TaxRegistrationNumber = trnBlock.TaxRegistrationNumber;

                    newFarmer.DateOfBirth = new System.Data.SqlTypes.SqlDateTime(dateOfBirthBlock.Year, dateOfBirthBlock.Month, dateOfBirthBlock.Day);

                    newFarmer.RadaRegistrationPhase = RadaRegistrationType.NotConnected;

                    newFarmer.WriteRecordToDatabase((int)Session["UserId"]);

                    Response.Redirect("~/RadaStatus.aspx");
                }
            }
            
        }
    }
}