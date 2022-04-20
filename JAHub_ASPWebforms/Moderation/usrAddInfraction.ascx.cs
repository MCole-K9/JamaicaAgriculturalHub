using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace JAHub_ASPWebforms.Moderation
{
    public partial class usrAddInfraction : System.Web.UI.UserControl
    {
        DataTable addedInfractions;
        SqlDateTime currentTime;
        int userId;
        int adminId;
        PlaceHolder controlParent;


        protected void Page_Load(object sender, EventArgs e)
        {
            currentTime = new SqlDateTime(DateTime.Now);
            lblTimeStamp.Text = currentTime.ToString();
        }

        

        public usrAddInfraction (DataTable addedInfractions, int userId, int adminId, PlaceHolder controlParent)
        {
            this.userId = userId;
            this.adminId = adminId;
            this.addedInfractions = addedInfractions;
            this.controlParent = controlParent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // This should add the the generated infraction information to dtbAddedInfractions
            // it should also remove this control and create a new usrInfractionItem
            //addedInfractions.Rows.Add(currentTime, userId, adminId, txtInfractionReason.Text);

            //controlParent.Controls.Add(new usrInfractionItem(controlParent, addedInfractions.Rows[addedInfractions.Rows.Count - 1]));
            //controlParent.Controls.Remove(this);
        }
    }
}