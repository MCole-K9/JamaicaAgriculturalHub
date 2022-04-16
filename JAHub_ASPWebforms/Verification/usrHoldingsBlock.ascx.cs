using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms.Verification
{
    public partial class usrHoldingsBlock : System.Web.UI.UserControl
    {
        List<String> _productsList = new List<String>();
        List<LandInformation> _landInformationList = new List<LandInformation>();

        public List<LandInformation> LandInformation => _landInformationList;
        public List<String> ProductList => _productsList;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public usrHoldingsBlock()
        {
            // Create a product block in the product block placeholder
            phProducts.Controls.Add((usrProductBlock)LoadControl("~/Verification/usrProductBlock.ascx.cs"));

            // Create a Land block in the landblock holder
            // Empty constructor, nothing worth caring about
        }

        public usrHoldingsBlock(Farmer farmer)
        {
            // Maybe need to specify a special way of initializing components, not sure

            // Will need to foreach create entries into the asp placeholder for products

            // Will need to foreach create entries for each LandInformation
            
            // the products and Landblocks will return valid on their own
        }
        
        // pretty much everything here needs a rewrite
        public bool IsBlockValid()
        {
            bool isListValid = true;

            // foreach (usrProductsBlock product in flwProductsBlock.Controls)
            {
                //if (product.IsBlockValid())
                {
                    //_productsList.Add(product.Product);
                }
                //else
                {
                    //isListValid = false;
                   // _productsList.Clear();
                   // break;
                }
            }

            //foreach (usrLandBlock land in flwLandBlockHolder.Controls)
            {
                //if (land.IsBlockValid())
                {
                    //_landInformationList.Add(land.LandInformation);
                }
                //else
                {
                    //isListValid = false;
                    //_landInformationList.Clear();
                }
            }

            //if (isListValid)
            {
                //return true;
            }
            //else
            {
                //return false;
            }
            return false;
        }

        public void SetControlFocus()
        {
            //foreach (usrLandBlock land in flwLandBlockHolder.Controls)
            {
                //if (!land.IsBlockValid())
                {
                    //land.SetControlFocus();
                    //return;
                }
            }

            //foreach (usrProductsBlock product in flwProductsBlock.Controls)
            {
                //if (!product.IsBlockValid())
                {
                    //product.SetControlFocus();
                    //return;
                }
            }
        }

        protected void btnAddLandEntry_Click(object sender, EventArgs e)
        {
            //flwLandBlockHolder.Controls.Add(new usrLandBlock());
            btnRemoveLandEntry.Visible = true;
        }

        protected void btnRemoveLandEntry_Click(object sender, EventArgs e)
        {
            //flwLandBlockHolder.Controls.RemoveAt(flwLandBlockHolder.Controls.Count - 1);

            //if (flwLandBlockHolder.Controls.Count == 1)
            {
                btnRemoveLandEntry.Visible = false;
            }
        }

    }
}