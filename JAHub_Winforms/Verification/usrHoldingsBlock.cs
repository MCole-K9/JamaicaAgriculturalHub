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

namespace JAHub_Winforms.Verification
{
    public partial class usrHoldingsBlock : UserControl
    {
        #region Variables and Properties
        List<String> _productsList = new List<String>();
        List<LandInformation> _landInformationList = new List<LandInformation>();

        public List<LandInformation> LandInformation => _landInformationList;
        public List<String> ProductList => _productsList;
        #endregion
        public usrHoldingsBlock()
        {
            InitializeComponent();
        }

        public usrHoldingsBlock(Farmer farmer)
        {
            InitializeFilledComponent(farmer);
            
            foreach (String product in farmer.ProductsTypicallyProduced)
            {
                flwProductsBlock.Controls.Add(new usrProductsBlock(product));
            }

            foreach(LandInformation land in farmer.OwnedLand)
            {
                flwLandBlockHolder.Controls.Add(new usrLandBlock(land));
            }

            // the products and Landblocks will return valid on their own
        }

        private void btnAddAnotherProduct_Click(object sender, EventArgs e)
        {
            flwProductsBlock.Controls.Add(new usrProductsBlock());
            btnRemoveLastProduct.Visible = true;
        }

        private void btnRemoveLastProduct_Click(object sender, EventArgs e)
        {
            flwProductsBlock.Controls.RemoveAt(flwProductsBlock.Controls.Count-1);
            
            if (flwProductsBlock.Controls.Count == 1)
            {
                btnRemoveLastProduct.Hide();
            }
        }

        public bool IsBlockValid()
        {
            // This needs to be rewriten in consideration of multiple land blocks, now
            if (usrLandBlock1.IsBlockValid())
            {
                bool isListValid = true;

                foreach(usrProductsBlock product in flwProductsBlock.Controls)
                {
                    if (product.IsBlockValid())
                    {
                        _productsList.Add(product.Product);
                    }
                    else
                    {
                        isListValid = false;
                        _productsList.Clear();
                        break;
                    }
                }

                foreach(usrLandBlock land in flwLandBlockHolder.Controls)
                {
                    if (land.IsBlockValid()){
                        
                    }
                    else
                    {
                        isListValid=false;
                        // clear whatever list of Landstuff here
                    }
                }
                
                if (isListValid)
                {
                    return true;
                }

            }
            
            return false;
        }

        public void SetControlFocus()
        {
            if (!usrLandBlock1.IsBlockValid())
            {
                usrLandBlock1.SetControlFocus();
            }
            else
            {
                foreach(usrProductsBlock product in flwProductsBlock.Controls)
                {
                    if (!product.IsBlockValid())
                    {
                        product.SetControlFocus();
                        break;
                    }
                }
            }
        }

        private void btnAddLandEntry_Click(object sender, EventArgs e)
        {
            flwLandBlockHolder.Controls.Add(new usrLandBlock());
            btnRemoveLandEntry.Show();
        }

        private void btnRemoveLandEntry_Click(object sender, EventArgs e)
        {
            flwLandBlockHolder.Controls.RemoveAt(flwLandBlockHolder.Controls.Count - 1);

            if (flwLandBlockHolder.Controls.Count == 1){
                btnRemoveLandEntry.Hide();
            }
        }
    }
}
