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
    public partial class FrmAddEditProduct : Form
    {
        private Product product;
        public FrmAddEditProduct()
        {
            InitializeComponent();
            product = new Product();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddChangeImage_Click(object sender, EventArgs e)
        {
            if(ofdProductImage.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(ofdProductImage.FileName);
                pbImage.ImageLocation = ofdProductImage.FileName;


                product.Image = ofdProductImage.FileName;
              

                 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Farmer farmer = new Farmer();

            string productName = txtProductName.Text;
            float price;
            int stock;

            float.TryParse(txtPrice.Text, out price);
            int.TryParse(txtStock.Text, out stock);

            product.Name = productName;
            product.Price = price;
            product.Stock = stock;

            if(farmer.AddProduct(product) > 0)
            {
                MessageBox.Show("Item Added");
            }
        }
    }
}
