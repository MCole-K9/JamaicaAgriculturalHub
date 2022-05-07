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
        public RadaRegistrationType FarmerRegistrationPhase
        {
            get
            {
                return ViewState["RadaStatusRegistrationType"] == null ? RadaRegistrationType.NotRegistered : (RadaRegistrationType)ViewState["RadaStatusRegistrationType"];
            }
            set
            {
                ViewState["RadaStatusRegistrationType"] = value;
            }
        }
        protected String RadaExplanation;
        protected String RadaStatusHeading;
        int farmerId;

        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                String command = $"SELECT ID, RadaRegistrationStatus FROM Farmer WHERE UserID = {Session["UserId"]};";

                SqlCommand pullFarmer = new SqlCommand(command, connection);

                SqlDataReader reader = pullFarmer.ExecuteReader();

                while (reader.Read())
                {
                    if (DBNull.Value.Equals(reader["RadaRegistrationStatus"]))
                    {
                        FarmerRegistrationPhase = RadaRegistrationType.NotRegistered;
                    }
                    else
                    {
                        farmerId = (int)reader["ID"];
                        FarmerRegistrationPhase = (RadaRegistrationType)Int32.Parse(reader["RadaRegistrationStatus"].ToString());
                    }
                }

                connection.Close();
            }

            switch (FarmerRegistrationPhase)
            {
                case RadaRegistrationType.NotRegistered:
                    lblStatusHeading.Text = "Rada Status: Not Registered";
                    lblStatusExplanation.Text = "You are not currently registered with RADA. Click the button below to apply.";

                    btnRegisterOrViewInformation.Visible = true;
                    btnRegisterOrViewInformation.Text = "Click Here to Register";
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
                    btnRegisterOrViewInformation.Text = "View or Change Information";
                    break;
                default:
                    lblStatusHeading.Text = "Rada Status: Not Registered";
                    lblStatusExplanation.Text = "You are not currently registered with RADA. Click the button below to apply.";

                    btnRegisterOrViewInformation.Visible = true;
                    btnRegisterOrViewInformation.Text = "Click here to Register";
                    break;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegisterOrViewInformation_Click(object sender, EventArgs e)
        {
            if (FarmerRegistrationPhase == RadaRegistrationType.NotRegistered)
            {
                Server.Transfer("~/RadaRegistration.aspx");
            }
            else if (FarmerRegistrationPhase == RadaRegistrationType.FullyConnected)
            {
                Server.Transfer("~/RadaRegistration.aspx");
            }
        }
    }
}