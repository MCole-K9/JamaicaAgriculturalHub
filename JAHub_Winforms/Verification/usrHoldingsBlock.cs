﻿using System;
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
        /* TO DO
         * [] Pass the farmer object to the landblock
         */

        #region Variables and Properties
        List<String> _productsList = new List<String>();

        public String LandAddressTown => usrLandBlock1.LandAddressTown;
        public String LandAddressPoBox => usrLandBlock1.LandAddresssPoBox;
        public String LandAddressParish => usrLandBlock1.LandAddressParish;
        public decimal LandMeasurement => usrLandBlock1.LandMeasurement;
        public List<String> ProductList => _productsList;
        #endregion
        public usrHoldingsBlock()
        {
            InitializeComponent();
        }

        public usrHoldingsBlock(Farmer farmer)
        {
            InitializeFilledComponent(farmer);
            
            foreach (String product in _productsList)
            {
                flwProductsBlock.Controls.Add(new usrProductsBlock(product));
            }

            // once i change LandBlock accordingly, need to foreach this
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

            if (flwLandBlockHolder.Controls.Count > 1){
                btnRemoveLandEntry.Hide();
            }
        }
    }
}
