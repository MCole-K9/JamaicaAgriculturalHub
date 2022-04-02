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

            lblTimeStamp.Text = row[1].ToString();
            lblAddedById.Text = $"Added by ID: {row[2].ToString()}";
            lblInfractionReason.Text = $"Reason: {row[3].ToString()}";
            
            // A. Put the relevant information on a Remove List when it gets deleted
            // B. Tell the Control that owns it to remove it
            // C. Close itself.
        }

        private void btnRemoveInfraction_Click(object sender, EventArgs e)
        {
            // Add the record Id to dtbRemovedInfractions;
            // Does this even need a full datatable?
            // I'm going to pretend it does
        }
    }
}
