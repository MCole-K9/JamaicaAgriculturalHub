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
    public partial class FrmUpdateName : Form
    {
        

        public FrmUpdateName()
        {
            InitializeComponent();
        }

        

        private void FrmUpdateName_Load(object sender, EventArgs e)
        {

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            //FrmUpdateName frmUpdateName = new FrmUpdateName();
            //frmUpdateName.();
            this.Close();

        }

        private void txtUpdateFirstName_Click(object sender, EventArgs e)
        {

            btnFName.FlatAppearance.BorderColor = Color.Blue;
                
         }

        private void txtUpdateLastName_Click(object sender, EventArgs e)
        {
            btnLName.FlatAppearance.BorderColor = Color.Blue;   
        }

        
    }
}
