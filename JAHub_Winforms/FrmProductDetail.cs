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

namespace JAHub_Winforms
{
    public partial class FrmProductDetail : Form
    {
        private Product _product;
        public FrmProductDetail()
        {
            InitializeComponent();
        }
        public FrmProductDetail(Product product)
        {
            InitializeComponent();
            this._product = product;
        }
        private void PopulateFields()
        {
            pcbImage.Image = Image.FromFile(_product.Image);
            lblProductName.Text = _product.Name;
            lblPrice.Text = $"${_product.Price} Per Lbs";
        }

        private void pcbFarmerImage_Click(object sender, EventArgs e)
        {

        }

        private void LblQty_Click(object sender, EventArgs e)
        {

        }

        private void FrmProductDetail_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }
    }
}
