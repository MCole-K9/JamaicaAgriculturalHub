using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace JAHub_ASPWebforms.Moderation
{
    public partial class usrViewInfraction : System.Web.UI.UserControl
    {
        int recordId;
        PlaceHolder controlParent;
        DataTable removedInfractions;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public usrViewInfraction(DataRow row, PlaceHolder controlParent, DataTable removedInfractions)
        {

            this.recordId = (int)row[0];
            this.controlParent = controlParent;
            this.removedInfractions = removedInfractions;

            lblDateOfEntry.Text = row[1].ToString();
            lblAddedById.Text = $"Added by ID: {row[2].ToString()}";
            lblReason.Text = $"Reason: {row[3].ToString()}";
        }

        // This constructor is for what usrInfractionAdder should make after the admin submits
        public usrViewInfraction(PlaceHolder controlParent, DataRow infractionRecord)
        {

            this.controlParent = controlParent;

            lblDateOfEntry.Text = infractionRecord[0].ToString();
            lblAddedById.Text = $"Added by ID: {infractionRecord[2]}";
            lblReason.Text = $"Reason: {infractionRecord[3]}";
        }

        private void btnRemoveInfraction_Click(object sender, EventArgs e)
        {
            // All this does is add the recordId of the entry, which it got from dtbCurrentInfractions
            if (recordId != 0)
            {
                // because usrInfractionAdder can create new usrInfractionEntry objects,
                // this is necessary to guard against an error. it won't bother to add
                // this to the removedInfractions list if recrodId=0
                removedInfractions.Rows.Add(this.recordId);
                controlParent.Controls.Remove(this);
            }
            else
            {
                // remove the corresponding record from the addedInfractions list
                // this requires getting a reference to that list
                // also requires comparing something in common between list items and this
                // i suggest timestamps
            }

        }
    }
}