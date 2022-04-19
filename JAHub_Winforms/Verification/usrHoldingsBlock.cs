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

            if(farmer.OwnedLand.Count > 0)
            {
                foreach (LandInformation land in farmer.OwnedLand)
                {
                    flwLandBlockHolder.Controls.Add(new usrLandBlock(land));
                }
            }

            btnAddAnotherProduct.Visible = false;
            btnAddLandEntry.Visible = false;

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
                    _landInformationList.Add(land.LandInformation);
                }
                else
                {
                    isListValid=false;
                    _landInformationList.Clear();
                }
            }
                
            if (isListValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetControlFocus()
        {
            foreach(usrLandBlock land in flwLandBlockHolder.Controls)
            {
                if (!land.IsBlockValid())
                {
                    land.SetControlFocus();
                    return;
                }
            }

            foreach (usrProductsBlock product in flwProductsBlock.Controls)
            {
                if (!product.IsBlockValid())
                {
                    product.SetControlFocus();
                    return;
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
