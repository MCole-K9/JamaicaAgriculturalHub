﻿using System;
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
        public FrmAddEditProduct()
        {
            InitializeComponent();
            this.product = new Product();
            inEditMode = false;
        }
        public FrmAddEditProduct(Product product)
        {
            InitializeComponent();
            this.product = product;
            inEditMode = true;
        }
        private void PopulateFields()
        {
            pbImage.ImageLocation = product.Image;
            txtProductName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();
            txtStock.Text = product.Stock.ToString();
            
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
            Farmer farmer = new Farmer();

            string productName = txtProductName.Text;
            float price;
            int stock;

            float.TryParse(txtPrice.Text, out price);
            int.TryParse(txtStock.Text, out stock);

            product.Name = productName;
            product.Price = price;
            product.Stock = stock;
            product.Category = (int)cboCategory.SelectedValue;
            MessageBox.Show($"{ product.Category}");

            if (inEditMode)
            {
                if (farmer.UpdateProduct(product) > 0)
                {
                    MessageBox.Show("Item Updated Succesfully");

                }
            }
            else
            {
                if (farmer.AddProduct(product) > 0)
                {
                    MessageBox.Show("Item Added Succesfully");
                }
            }


        }

        private void FrmAddEditProduct_Load(object sender, EventArgs e)
        {
            lblAddUpdate.Text = inEditMode ? "Update Product" : "Add Product";
            btnAddChangeImage.Text = inEditMode ? "Change Image" : "Add Image";

            if (inEditMode)
                PopulateFields();

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


                //cboCategory.Items.Insert(0, "Select Category");
            }
            //Category ctg = new Category();

            //cboCategory.DataBindings.Clear();
            //cboCategory.DataSource = ctg.GetCategoryList();
            //cboCategory.DisplayMember = "CategoryName";
            //cboCategory.ValueMember = "ID" ;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
