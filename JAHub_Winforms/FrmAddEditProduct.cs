using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using JAHubLib;

namespace JAHub_Winforms
{
    public partial class FrmAddEditProduct : Form
    {
        private Product product;
        bool inEditMode;
        FrmProfile frmProfile;
        public FrmAddEditProduct(FrmProfile frmProfile)
        {
            InitializeComponent();
            this.product = new Product();
            inEditMode = false;
            this.frmProfile = frmProfile;
        }
        public FrmAddEditProduct(Product product, FrmProfile frmProfile)
        {
            InitializeComponent();
            this.product = product;
            inEditMode = true;
            this.frmProfile = frmProfile;
        }
        private void PopulateFields()
        {
            pbImage.ImageLocation = product.Image;
            txtProductName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();
            txtStock.Text = product.Stock.ToString();
            cboCategory.SelectedValue = product.Category;
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddChangeImage_Click(object sender, EventArgs e)
        {
            if(ofdProductImage.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = ofdProductImage.FileName;

                product.Image = ofdProductImage.FileName;
                 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Farmer farmer = new Farmer(true);

            string productName = txtProductName.Text;
            float price;
            int stock;

            float.TryParse(txtPrice.Text, out price);
            int.TryParse(txtStock.Text, out stock);

            if(txtProductName.Text == "")
            {
                MessageBox.Show("Enter Product Name");
                txtProductName.Focus();

            }else if (txtPrice.Text == "" || price == 0)
            {
                MessageBox.Show("Enter a Value / an Appropriate Value in Price");
                txtPrice.Focus();

            }else if(txtStock.Text == "" || stock == 0)
            {
                MessageBox.Show("Enter a Value / an Appropriate Value in Stock");
                txtStock.Focus();

            }else if(cboCategory.SelectedValue == null)
            {
                MessageBox.Show("Select Category");
                cboCategory.Focus();

            }else if(product.Image == "")
            {
                MessageBox.Show(" Ensure to Select An Image");
                pbImage.Focus();
            }
            else
            {
                product.Name = productName;
                product.Price = price;
                product.Stock = stock;
                product.Category = (int)cboCategory.SelectedValue;


                if (inEditMode)
                {
                    if (farmer.UpdateProduct(product) > 0)
                    {
                        MessageBox.Show("Item Updated Succesfully");
                        frmProfile.ClickManageProduct();
                    }
                }
                else
                {
                    if (farmer.AddProduct(product) > 0)
                    {
                        MessageBox.Show("Item Added Succesfully");
                        frmProfile.ClickManageProduct();
                    }
                }
            }
           


        }

        private void FrmAddEditProduct_Load(object sender, EventArgs e)
        {
            lblAddUpdate.Text = inEditMode ? "Update Product" : "Add Product";
            btnAddChangeImage.Text = inEditMode ? "Change Image" : "Add Image";

            

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = "Select * From Category";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataSet categoryDS = new DataSet();

                sqlDataAdapter.Fill(categoryDS, "Category");


                cboCategory.DataSource = categoryDS.Tables["Category"];

                cboCategory.DisplayMember = "CategoryName";
                cboCategory.ValueMember = "ID";

                cboCategory.SelectedIndex = -1;
                cboCategory.Text = "Select an Item";
            }
            if (inEditMode)
                PopulateFields();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
