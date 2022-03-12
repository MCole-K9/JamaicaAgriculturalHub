using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHubLib

namespace JAHub_Winforms.Shop_Controls
{
    public partial class UcCartItem : UserControl
    {
        private Product _product;
        public UcCartItem(Product product = null)
        {
            InitializeComponent();
            this._product = product;
        }

        private void UcCartItem_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int qtyValue;
            bool inputIsInt = int.TryParse(txtQty.Text.Trim(), out qtyValue);

            if (inputIsInt)
            {
                qtyValue++;
                txtQty.Text = qtyValue.ToString();
            }
            else
            {
                MessageBox.Show("Please Ensure that only a number is inputed");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int qtyValue;
            bool inputIsInt = int.TryParse(txtQty.Text.Trim(), out qtyValue);

            if (inputIsInt && qtyValue > 0)
            {
                qtyValue--;
                txtQty.Text = qtyValue.ToString();
            }
            else
            {
                MessageBox.Show("Please Ensure that only a postitive number is inputed");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            //To-Do: Remove Item From Cart List
        }
    }
}
