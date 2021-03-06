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

namespace JAHub_Winforms.Shop_Controls
{
    public partial class UsrFarmerProduct : UserControl
    {
        private Product _product;
        private FrmManageProducts _frmManageProducts;
        public UsrFarmerProduct()
        {
            InitializeComponent();
        }
        public UsrFarmerProduct(Product product, FrmManageProducts frmManageProducts)
        {
            InitializeComponent();
            _product = product;
            _frmManageProducts = frmManageProducts;
        }
        public void PopulateFields()
        {
            lblItemName.Text = _product.Name;
            lblPrice.Text = $"${_product.Price} Per Lbs";
            pcbImage.ImageLocation = _product.Image;
        }

        private void UsrFarmerProduct_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _frmManageProducts._frmProfile.OpenChildForm(new FrmAddEditProduct(_product, _frmManageProducts._frmProfile));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure You Want To Delete This Item", "Confirmation",  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Farmer farmer = new Farmer();

                if (farmer.DeleteProduct(_product) > 0)
                {
                    MessageBox.Show("Item Sucessfully Deleted");
                    _frmManageProducts._frmProfile.ClickManageProduct();
                }
            }
            
        }
    }
}
