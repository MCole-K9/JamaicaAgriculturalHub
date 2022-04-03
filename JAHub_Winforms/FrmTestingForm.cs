using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHubLib;
using System.Data.SqlClient;

namespace JAHub_Winforms
{
    public partial class FrmTestingForm : Form
    {
        public FrmTestingForm()
        {
            InitializeComponent();
        }

        private void FrmTestingForm_Load(object sender, EventArgs e)
        {
            User user = new User { UserID = 4};
            Farmer farmer = new Farmer(user);

            lblFarmerID.Text = farmer.FarmerId.ToString();
            lblBusinessEmail.Text = farmer.BusinessEmail;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilities.DeleteImages();
        }
    }
}
