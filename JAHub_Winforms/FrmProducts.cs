using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHubLib;
using System.Data.SqlClient;

namespace JAHub_Winforms
{
    public partial class FrmProducts : Form
    {
        public FrmShop _frmShop;
        List<Product> products;
        public FrmProducts()
        {
            InitializeComponent();
            products = new List<Product>();

        }
        public FrmProducts(FrmShop frmShop)
        {
            InitializeComponent();
            _frmShop = frmShop;
            products = new List<Product>();
        }
        // Create Instances of product using the data that comes from Product Class
        public void LoadProducts(List<Product> products)
        {
            fpnlProducts.Controls.Clear();
            //Loop through the product list and renders it on the product form
            foreach(var product in products)
            {
                Shop_Controls.UcProduct ucProduct = new Shop_Controls.UcProduct(product, this);
                fpnlProducts.Controls.Add(ucProduct);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                List<Product> searchFilteredProducts = new List<Product>();

                searchFilteredProducts = products.Where(q => q.Name.Contains(txtSearch.Text) || q.Name.StartsWith(txtSearch.Text)).ToList();

                if(searchFilteredProducts.Count == 0)
                {
                    MessageBox.Show("No Results Found");
                }
                else
                {
                    LoadProducts(searchFilteredProducts);
                }
            }
            else
            {
                MessageBox.Show("You Did Enter Enter a value for the search");
                txtSearch.Focus();
            }
            

        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {

            using(SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = "Select * from Product";

                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader sqlData = cmd.ExecuteReader())
                {
                    while (sqlData.Read())
                    {
                        Product product = new Product();

                        product.Id = (int)sqlData["ID"];
                        product.Name = sqlData["Name"].ToString();
                        product.Stock = (int)sqlData["Stock"];
                        product.Price = float.Parse(sqlData["Price"].ToString());
                        product.Image = $"http://vtdics.com/ead22/"+sqlData["Image"].ToString();
                        product.Farmer = new Farmer((int)sqlData["Farmer"]);
                        product.Category = (int)sqlData["Category"];
                        products.Add(product);
                        
                    }
                }

                query = "Select * From Category";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet categoryDS = new DataSet();

                adapter.Fill(categoryDS, "Category");

                


                cboCategory.DataSource = categoryDS.Tables["Category"];


                cboCategory.DisplayMember = "CategoryName";
                cboCategory.ValueMember = "ID";

                cboCategory.SelectedIndex = -1;
                cboCategory.Text = "Select an Item";

            }

            LoadProducts(products);



        }


        private void cboCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboCategory.SelectedValue != null)
            {
                int selectedValue = (int)cboCategory.SelectedValue;

                List<Product> categoryFilteredProducts = new List<Product>();

                categoryFilteredProducts = products.Where(q => q.Category == selectedValue).ToList();

                LoadProducts(categoryFilteredProducts);
            }
        }
    }
}
