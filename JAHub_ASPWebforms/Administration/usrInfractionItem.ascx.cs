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
            get { return ViewState[$"{this.NamingContainer}RecordID"] == null ? 0 : (int)ViewState[$"{this.NamingContainer}RecordId"]; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void btnClearReason_Click(object sender, EventArgs e)
        {
            // Add the method to delete this from the thingy
            // also add the method to force postback
        }
    }
}