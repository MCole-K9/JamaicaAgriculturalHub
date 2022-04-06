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

namespace JAHub_Winforms
{
    public partial class FrmRadaStatus : Form
    {
        int farmerId;
        RadaRegistrationType farmerRegistrationPhase;
        public FrmRadaStatus()
        {
            InitializeComponent();
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
                    if (reader["RadaRegistrationStatus"] == null)
                    {
                        farmerRegistrationPhase = RadaRegistrationType.NotRegistered;
                    }
                    else
                    {
                        farmerId = (int)reader["ID"];
                        farmerRegistrationPhase = (RadaRegistrationType)reader["RadaRegistrationStatus"];
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

                    // generate all of the controls and then write the values insidd of them
                    using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                    {
                        connection.Open();




                        connection.Close();
                    }
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
            foreach (Control control in flwInformationHolder.Controls)
            {
                control.Enabled = true;
            }
        }

        private void btnRegisterWithRada_Click(object sender, EventArgs e)
        {
            // this needs to
            // close this form and the form above it
            // open the Register With Rada form (this uses Super?)
        }
    }
}
