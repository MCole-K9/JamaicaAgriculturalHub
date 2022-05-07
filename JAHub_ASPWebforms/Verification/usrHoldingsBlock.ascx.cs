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

        public List<LandInformation> LandInformation
        {
            get
            {
                return _landInformationList;
            }
            set
            {
                _landInformationList.Clear();
                phLandBlock.Controls.Clear();



            }

        }
        public List<String> ProductList => _productsList;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public usrHoldingsBlock()
        {
            // Create a product block in the product block placeholder
            usrProductBlock productBlock = (usrProductBlock)LoadControl("~/Verification/usrProductBlock.ascx.cs");
            _productsList.Add(productBlock.Product);

            phProducts.Controls.Add(productBlock);



            usrLandBlock landblock = (usrLandBlock)LoadControl("~/Verification/usrLandBlock.ascx.cs");
            _landInformationList.Add(landblock.LandInformation);

            phLandBlock.Controls.Add(landblock);

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

        

        protected void btnAddLandEntry_Click(object sender, EventArgs e)
        {
            phLandBlock.Controls.Add((usrLandBlock)LoadControl("~/Verification/usrLandBlock"));
            
            btnRemoveLandEntry.Visible = true;
        }

        protected void btnRemoveLandEntry_Click(object sender, EventArgs e)
        {

            phLandBlock.Controls.RemoveAt(phLandBlock.Controls.Count - 1);

            if (phLandBlock.Controls.Count == 1)
            {
                btnRemoveLandEntry.Visible = false;
            }
        }

    }
}