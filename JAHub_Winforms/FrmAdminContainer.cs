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

        private void FrmAdminFormContainer_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Open the form inside of panel one
            if (pnlFormHolder.Controls.Count > 0)
            {
                pnlFormHolder.Controls.Clear();
            }

            // pnlFormHolder.Controls.Add(new FrmAdminViewModeration());
        }
    }
}
