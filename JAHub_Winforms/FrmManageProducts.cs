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
    public partial class FrmManageProducts : Form
    {
        private FrmProfile _frmProfile;
        public FrmManageProducts()
        {
            InitializeComponent();
        }
        public FrmManageProducts(FrmProfile frmProfile)
        {
            InitializeComponent();
            _frmProfile = frmProfile;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _frmProfile.OpenChildForm(new FrmAddEditProduct());
        }
    }
}
