using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms.Verification
{
    public partial class usrHoldingsBlock : UserControl
    {
        public usrHoldingsBlock()
        {
            InitializeComponent();
        }

        private void usrLandBlock1_Load(object sender, EventArgs e)
        {
            // i don't know why this is here, but i don't really care atm. check later
        }

        private void btnAddAnotherProduct_Click(object sender, EventArgs e)
        {
            flwProductsBlock.Controls.Add(new usrProductsBlock());
            btnRemoveLastProduct.Visible = true;
        }

        private void btnRemoveLastProduct_Click(object sender, EventArgs e)
        {
            flwProductsBlock.Controls.RemoveAt(flwProductsBlock.Controls.Count-1);
            
            if (flwProductsBlock.Controls.Count == 1)
            {
                btnRemoveLastProduct.Hide();
            }
        }
    }
}
