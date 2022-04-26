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
                Farmer farmer = new Farmer(true);
                    
                LoadProducts(farmer.GetFarmerProducts());
                
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
