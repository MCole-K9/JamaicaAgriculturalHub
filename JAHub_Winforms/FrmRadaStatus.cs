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
using System.Data.SqlClient;
using JAHub_Winforms.Verification;

namespace JAHub_Winforms
{
    public partial class FrmRadaStatus : Form
    {
        int farmerId;
        RadaRegistrationType farmerRegistrationPhase;
        FrmProfile _formContainer;
        public FrmRadaStatus(FrmProfile formContainer)
        {
            InitializeComponent();
            this._formContainer = formContainer;
        }

        private void FrmRadaStatus_Load(object sender, EventArgs e)
        {
            // checking to see what the user's Rada status is on load
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                String command = $"SELECT ID, RadaRegistrationStatus FROM Farmer WHERE UserID = {Session.UserId}";

                SqlCommand pullFarmer = new SqlCommand(command, connection);

                SqlDataReader reader = pullFarmer.ExecuteReader();

                while (reader.Read())
                {
                    if (DBNull.Value.Equals(reader["RadaRegistrationStatus"]))
                    {
                        farmerRegistrationPhase = RadaRegistrationType.NotRegistered;
                    }
                    else
                    {
                        farmerId = (int)reader["ID"];
                        farmerRegistrationPhase = (RadaRegistrationType)Int32.Parse(reader["RadaRegistrationStatus"].ToString());
                    }
                }

                connection.Close();
            }

            switch (farmerRegistrationPhase)
            {
                case RadaRegistrationType.NotRegistered:
                    lblStatusType.Text = "Not Registered";
                    lblStatusExplanation.Text = "You are not currently registered with RADA. Click the button below to apply.";

                    btnRegisterWithRada.Visible = true;

                    break;
                case RadaRegistrationType.AwaitingVerification:
                    lblStatusType.Text = "Awaiting Verification";

                    lblStatusExplanation.Text = "You have submitted the relevant information to us, and are " +
                        "waiting for visitation by an agent of RADA. Please wait while you are verified in person.";

                    break;
                case RadaRegistrationType.NotConnected:
                    lblStatusType.Text = "Not Yet Connected";

                    lblStatusExplanation.Text = "Please wait while your account details are transferred from your previous " +
                        "RADA applicaton to this account";

                    break;
                case RadaRegistrationType.FullyConnected:
                    lblStatusType.Text = "Fully Connected";
                    lblStatusExplanation.Text = "Your Account is fully connected, and you may modify your account details " +
                        "below";

                    lblInformation.Visible = true;
                    btnEdit.Visible = true;

                    flwInformationHolder.Visible = true;

                    Farmer farmer = new Farmer();

                    // need a method that grabs all of the farmer information using userId

                    // Generating all of the controls using values from Farmer
                    flwInformationHolder.Controls.Add(new usrNameBlock(farmer.FirstName, farmer.MiddleName, farmer.LastName));
                    flwInformationHolder.Controls.Add(new usrDateOfBirthBlock(farmer.DateOfBirth));
                    flwInformationHolder.Controls.Add(new usrContactBlock(farmer.BusinessEmail, farmer.PhoneNumbers));
                    flwInformationHolder.Controls.Add(new usrTrnBlock(farmer.TaxRegistrationNumber));
                    //flwInformationHolder.Controls.Add(new usrUploadImageBlock());
                    flwInformationHolder.Controls.Add(new usrIndustryBlock(farmer));
                    flwInformationHolder.Controls.Add(new usrHoldingsBlock(farmer));
                    flwInformationHolder.Controls.Add(new usrOrganizationsBlock(farmer.Organizations));

                    flwInformationHolder.Enabled = false;

                    break;
                default:
                    lblStatusType.Text = "Not Registered";
                    lblStatusExplanation.Text = "You are not currently registered with RADA. Click the button below to apply.";

                    btnRegisterWithRada.Visible = true;
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            flwInformationHolder.Enabled = true;
        }

        private void btnRegisterWithRada_Click(object sender, EventArgs e)
        {
            _formContainer.OpenChildForm(new FrmRadaRegister(_formContainer, farmerRegistrationPhase));
        }
    }
}
