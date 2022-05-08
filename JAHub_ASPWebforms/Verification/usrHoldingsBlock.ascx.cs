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

                _landInformationList = value;
                foreach (LandInformation l in _landInformationList)
                {
                    usrLandBlock landblock = (usrLandBlock)LoadControl("~/Verification/usrLandBlock.ascx");
                    landblock.LandInformation = l;

                    phLandBlock.Controls.Add(landblock);
                }

                if (_landInformationList.Count > 1)
                {
                    btnRemoveLandEntry.Visible = true;
                }
            }
        }
        
        public List<String> ProductList
        {
            get
            {
                return _productsList;
            }
            set
            {
                _productsList.Clear();
                phProducts.Controls.Clear();

                _productsList = value;
                foreach (String product in _productsList)
                {
                    usrProductBlock productblock = (usrProductBlock)LoadControl("~/Verificaton/usrProductBlock.ascx");
                    productblock.Product = product;
                    phProducts.Controls.Add(productblock);
                }

                if (_productsList.Count > 1)
                {
                    btnRemoveProduct.Visible = true;
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            usrProductBlock productBlock = (usrProductBlock)LoadControl("~/Verification/usrProductBlock.ascx");
            _productsList.Add(productBlock.Product);

            phProducts.Controls.Add(productBlock);



            usrLandBlock landblock = (usrLandBlock)LoadControl("~/Verification/usrLandBlock.ascx");
            _landInformationList.Add(landblock.LandInformation);

            phLandBlock.Controls.Add(landblock);
        }

        protected void btnAddLandEntry_Click(object sender, EventArgs e)
        {
            usrLandBlock landBlock = (usrLandBlock)LoadControl("~/Verification/usrLandBlock.ascx");

            _landInformationList.Add(landBlock.LandInformation);
            phLandBlock.Controls.Add(landBlock);
            
            btnRemoveLandEntry.Visible = true;
        }

        protected void btnRemoveLandEntry_Click(object sender, EventArgs e)
        {
            _landInformationList.RemoveAt(_landInformationList.Count - 1);
            phLandBlock.Controls.RemoveAt(phLandBlock.Controls.Count - 1);

            if (phLandBlock.Controls.Count == 1)
            {
                btnRemoveLandEntry.Visible = false;
            }
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            usrProductBlock productBlock = (usrProductBlock)LoadControl("~/Verification/usrProductBlock.ascx");
            productBlock.Controls.Add(productBlock);

            btnRemoveProduct.Visible = true;
        }

        protected void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            _productsList.RemoveAt(_productsList.Count - 1);
            phProducts.Controls.RemoveAt(phProducts.Controls.Count - 1);

            if (phProducts.Controls.Count == 1)
            {
                btnRemoveProduct.Visible = false;
            }
        }
    }
}