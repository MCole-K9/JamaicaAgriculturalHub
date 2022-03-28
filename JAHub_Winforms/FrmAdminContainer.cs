using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms
{
    public partial class FrmAdminContainer : Form
    {
        public FrmAdminContainer()
        {
            InitializeComponent();
        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            if (pnlFormHolder.Controls.Count > 0)
            {
                pnlFormHolder.Controls.Clear();
            }

            pnlFormHolder.Controls.Add(new FrmAdminSelectUser());
            pnlFormHolder.Controls[0].Show();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (pnlFormHolder.Controls.Count > 0)
            {
                pnlFormHolder.Controls.Clear();
            }

            pnlFormHolder.Controls.Add(new FrmAdminEditUser());
            pnlFormHolder.Controls[0].Show();
        }

        private void btnViewModeration_Click(object sender, EventArgs e)
        {
            if (pnlFormHolder.Controls.Count > 0)
            {
                pnlFormHolder.Controls.Clear();
            }

            pnlFormHolder.Controls.Add(new FrmAdminViewModeration());
            pnlFormHolder.Controls[0].Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // This needs to offer to delete the user
            // ask the user to confirm this (messagebox?) using admin password
            // if the password matches then cool
            // else say "password incorrect" popup, raise the messagebox again
        }

        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            if (pnlFormHolder.Controls.Count > 0)
            {
                pnlFormHolder.Controls.Clear();
            }

            pnlFormHolder.Controls.Add(new FrmAdminCreateNewUser());
            pnlFormHolder.Controls[0].Show();
        }

        private void pnlFormHolder_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in pnlFormHolder.Controls)
            {
                control.Width = pnlFormHolder.Width;
                control.Height = pnlFormHolder.Height;
            }
        }
    }
}
