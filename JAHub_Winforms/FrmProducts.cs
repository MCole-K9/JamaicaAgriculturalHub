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
        public FrmProducts()
        {
            InitializeComponent();
            
        }
        public FrmProducts(FrmShop frmShop)
        {
            InitializeComponent();
            _frmShop = frmShop;
        }
        // Create Instances of product using the data that comes from Product Class
        public void LoadProducts(List<Product> products = null)
        {
            //Loop through the product list and renders it on the product form
            foreach(var product in products)
            {
                Shop_Controls.UcProduct ucProduct = new Shop_Controls.UcProduct(product, this);
                fpnlProducts.Controls.Add(ucProduct);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {

            List<Product> products = new List<Product>();

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
                        product.Image = $"{Utilities.GetFilePath()}/Images/{sqlData["Image"].ToString()}";
                        product.Farmer = new Farmer((int)sqlData["Farmer"]);

                        products.Add(product);
                        
                    }
                }
                LoadProducts(products);

            }
            

        }
    }
}
