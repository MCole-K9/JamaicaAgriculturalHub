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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }
        public void LoadProducts()
        {
            Shop_Controls.ucProduct ucProduct = new Shop_Controls.ucProduct();
            fpnlProducts.Controls.Add(ucProduct);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                LoadProducts();
            }
        }
    }
}
