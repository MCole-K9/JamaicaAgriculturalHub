using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace JAHub_Winforms.Moderation
{
    public partial class usrInfractionAdder : UserControl
    {
        DataTable addedInfractions;
        SqlDateTime currentTime;
        int userId;
        int adminId;
        FlowLayoutPanel controlParent;

        public usrInfractionAdder(DataTable addedInfractions, int userId, int adminId, FlowLayoutPanel controlParent)
        {
            InitializeComponent();

            this.userId = userId;
            this.adminId = adminId;
            this.addedInfractions = addedInfractions;
            this.controlParent = controlParent;
        }

        private void usrInfractionAdder_Load(object sender, EventArgs e)
        {
            currentTime = new SqlDateTime(DateTime.Now);
            lblTimeStamp.Text = currentTime.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // This should add the the generated infraction information to dtbAddedInfractions
            // it should also remove this control and create a new usrInfractionItem
            addedInfractions.Rows.Add(currentTime, userId, adminId, txtInfractionReason.Text);

            controlParent.Controls.Add(new usrInfractionItem(controlParent, addedInfractions.Rows[addedInfractions.Rows.Count - 1]));
            controlParent.Controls.Remove(this);
        }
    }
}
