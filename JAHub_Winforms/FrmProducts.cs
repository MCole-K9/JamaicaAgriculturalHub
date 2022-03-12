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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }
        // Create Instances of product using the data that comes from Product Class
        public void LoadProducts(List<Product> products = null)
        {
            Product product = new Product
            {
                Name = "Yam",
                Price = 100,
                Image = "C:/Users/Matthew Cole/source/repos/JamaicaAgricultualHub/JAHub_Winforms/Images/yam-g91011fb33_640.jpg",
            };
            Shop_Controls.UcProduct ucProduct = new Shop_Controls.UcProduct(product);
            fpnlProducts.Controls.Add(ucProduct);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                LoadProducts();
            }
        }
    }
}
