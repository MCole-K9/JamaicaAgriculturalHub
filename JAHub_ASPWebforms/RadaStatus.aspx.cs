using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class RadaStatus : System.Web.UI.Page
    {
        protected RadaRegistrationType farmerRegistrationPhase;
        protected String RadaExplanation;
        protected String RadaStatusHeading;
        int farmerId;

        protected void Page_Init(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                String command = $"SELECT ID, RadaRegistrationStatus FROM Farmer WHERE UserID = {Session["UserId"]}";

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
                    lblStatusHeading.Text = "Rada Status: Not Registered";
                    lblStatusExplanation.Text = "You are not currently registered with RADA. Click the button below to apply.";

                    btnRegisterOrViewInformation.Visible = true;
                    break;
                case RadaRegistrationType.AwaitingVerification:
                    lblStatusHeading.Text = "Rada Status: Awaiting Verification";

                    lblStatusExplanation.Text = "You have submitted the relevant information to us, and are " +
                        "waiting for visitation by an agent of RADA. Please wait while you are verified in person.";

                    break;
                case RadaRegistrationType.NotConnected:
                    lblStatusHeading.Text = "Rada Status: Not Yet Connected";

                    lblStatusExplanation.Text = "Please wait while your account details are transferred from your previous " +
                        "RADA applicaton to this account";

                    break;
                case RadaRegistrationType.FullyConnected:
                    lblStatusHeading.Text = "Rada Status: Fully Connected";
                    lblStatusExplanation.Text = "Your Account is fully connected, and you may modify your account details " +
                        "below";

                    btnRegisterOrViewInformation.Visible = true;
                    break;
                default:
                    lblStatusHeading.Text = "Rada Status: Not Registered";
                    lblStatusExplanation.Text = "You are not currently registered with RADA. Click the button below to apply.";

                    btnRegisterOrViewInformation.Visible = true;
                    break;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}