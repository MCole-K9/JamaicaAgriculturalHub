using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using JAHubLib;

namespace JAHub_ASPWebforms.Administration
{
    public partial class usrAddInfraction : System.Web.UI.UserControl
    {
        // DataTable addedInfractions;
        protected SqlDateTime currentTime;
        public int UserId;
        int adminId;
        PlaceHolder controlParent;


        protected void Page_Load(object sender, EventArgs e)
        {
            currentTime = new SqlDateTime(DateTime.Now);
            lblTimeStamp.Text = currentTime.ToString();

            // need to set:
            // - userId
            // - adminID
            // - 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // First, add the record
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                if (txtReason.Text.Contains("'"))
                {
                    txtReason.Text = txtReason.Text.Replace("'", "''");
                }


                String command = "INSERT INTO Infraction (TimeStamp, Infraction.[User], Infraction.[Admin], Reason) VALUES " +
                    $"({currentTime}, {UserId}, {adminId}, {txtReason.Text}";


                SqlCommand addNewInfractions = new SqlCommand(command, connection);

                addNewInfractions.ExecuteNonQuery();

                connection.Close();
            }

            // Then, remove the field from the placeholder
                if (this.Parent != null)
            {
                var containerPlaceholder = this.Parent as PlaceHolder;

                containerPlaceholder.Controls.Remove(this);
            }
            
            // then cause a postback

        }
    }
}