using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHubLib.Verification
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
            flwHoldingBlock.Controls.Add(new usrProductsBlock());
            flwHoldingBlock.Controls.SetChildIndex(flwHoldingBlock.Controls[flwHoldingBlock.Controls.Count - 1], 2);
            btnRemoveLastProduct.Visible = true;
        }

        private void btnRemoveLastProduct_Click(object sender, EventArgs e)
        {
            flwHoldingBlock.Controls.RemoveAt(2);
            
            if (flwHoldingBlock.Controls.Count <= 6)
            {
                btnRemoveLastProduct.Hide();
            }
        }
    }
}
