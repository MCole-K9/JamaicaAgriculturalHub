using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms.Moderation
{
    public partial class usrInfractionItem : UserControl
    {
        int recordId;
        FlowLayoutPanel controlParent;
        DataTable removedInfractions;

        public usrInfractionItem(DataRow row, FlowLayoutPanel controlParent, DataTable removedInfractions)
        {
            InitializeComponent();

            this.recordId = (int)row[0];
            this.controlParent = controlParent;
            this.removedInfractions = removedInfractions;

            lblTimeStamp.Text = row[1].ToString();
            lblAddedById.Text = $"Added by ID: {row[2].ToString()}";
            lblInfractionReason.Text = $"Reason: {row[3].ToString()}";
        }
        
        // This constructor is for what usrInfractionAdder should make after the admin submits
        public usrInfractionItem(FlowLayoutPanel controlParent, DataRow infractionRecord)
        {
            InitializeComponent();

            this.controlParent = controlParent;

            lblTimeStamp.Text = infractionRecord[0].ToString();
            lblAddedById.Text = $"Added by ID: {infractionRecord[2]}";
            lblInfractionReason.Text = $"Reason: {infractionRecord[3]}";
        }

        private void btnRemoveInfraction_Click(object sender, EventArgs e)
        {
            // All this does is add the recordId of the entry, which it got from dtbCurrentInfractions
            if(recordId != 0)
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
