using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using JAHubLib;

namespace JAHub_ASPWebforms.Administration
{
    public partial class usrInfractionItem : System.Web.UI.UserControl
    {
        PlaceHolder controlParent;

        public String Reason
        {
            get { return lblReason.Text; }
            set { lblReason.Text = value; }
        }

        public String DateOfEntry
        {
            get { return lblDateOfEntry.Text; }
            set { lblDateOfEntry.Text = value; }
        }

        public String AddedBy
        {
            get { return lblAddedById.Text; }
            set { lblAddedById.Text = value; }
        }

        public int RecordId
        {
            get { return ViewState[$"{this.NamingContainer.UniqueID}RecordId"] == null ? 0 : (int)ViewState[$"{this.NamingContainer.UniqueID}RecordId"]; }
            set { ViewState[$"{this.NamingContainer.UniqueID}RecordId"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
      

        protected void btnClearReason_Click(object sender, EventArgs e)
        {
            // Okay but why is the delete not working? Or is it?
            if (RecordId != 0)
            {
                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {

                    String command = $"DELETE FROM Infraction WHERE ID = ({this.RecordId})";

                    connection.Open();

                    SqlCommand removeDeletedInfractions = new SqlCommand(command, connection);

                    removeDeletedInfractions.ExecuteNonQuery();

                    connection.Close();

                }
            }

            ClientScriptManager cs = Page.ClientScript;

            ScriptManager.RegisterStartupScript(this.Page, this.GetType(),"test", cs.GetPostBackEventReference(this, String.Empty), true);
        }
    }
}