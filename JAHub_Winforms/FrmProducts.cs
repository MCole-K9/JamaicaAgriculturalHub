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
            String path = Path.GetDirectoryName(Application.ExecutablePath);
            path = path.Substring(0, 65);
            Product product = new Product
            {
                Name = "Yam",
                Price = 100,
                Image = path + @"\Images\yam-g91011fb33_640.jpg",
            };
            Shop_Controls.UcProduct ucProduct = new Shop_Controls.UcProduct(product, this);
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
