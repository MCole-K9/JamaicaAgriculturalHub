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
    public partial class FrmManageProducts : Form
    {
        public FrmProfile _frmProfile;
        public FrmManageProducts()
        {
            InitializeComponent();
        }
        public FrmManageProducts(FrmProfile frmProfile)
        {
            InitializeComponent();
            _frmProfile = frmProfile;
        }
        public void LoadProducts(List<Product> products = null)
        {
            //Loop through the product list and renders it on the product form
            foreach (var product in products)
            {
                Shop_Controls.UsrFarmerProduct usrFarmerProduct = new Shop_Controls.UsrFarmerProduct(product, this);
                fpnlProducts.Controls.Add(usrFarmerProduct);
            }

        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _frmProfile.OpenChildForm(new FrmAddEditProduct());
        }

        private void FrmManageProducts_Load(object sender, EventArgs e)
        {
            try
            {
                List<Product> products = new List<Product>();

                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {
                    connection.Open();

                    Farmer farmer = new Farmer(true);
                    farmer.FetchFarmerData();

                    string query = $"Select * from Product Where Farmer = {farmer.FarmerId}";

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
                            product.Image = $"http://vtdics.com/ead22/" + sqlData["Image"].ToString();
                            products.Add(product);

                        }
                    }
                    LoadProducts(products);

                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show($"Error Occured: {ex.Message}");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
