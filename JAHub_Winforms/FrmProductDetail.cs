using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHub_Winforms.Properties;
using JAHubLib;

namespace JAHub_Winforms
{
    public partial class FrmProductDetail : Form
    {
        private Product _product;
        private int rating;
        public FrmProductDetail()
        {
            InitializeComponent();
        }
        public FrmProductDetail(Product product)
        {
            InitializeComponent();
            this._product = product;
        }
        private void PopulateFields()
        {
            pcbImage.Image = Image.FromFile(_product.Image);
            lblProductName.Text = _product.Name;
            lblPrice.Text = $"${_product.Price} Per Lbs";
            //lblFarmerName.Text = $"{_product.Farmer.Firstname} {_product.Farmer.Lastname}";
        }

        private void LoadReviews()
        {
            fpnlReviews.Controls.Clear();
            foreach (var review in _product.Reviews)
            {
                fpnlReviews.Controls.Add(new Shop_Controls.UsrRating(review));
            }
        }

 

  
        private void FrmProductDetail_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }

       

        private void pbStar1_Click(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.yellow_star;

            pbStar2.Image = Resources.white_star;
            pbStar3.Image = Resources.white_star;
            pbStar4.Image = Resources.white_star;
            pbStar5.Image = Resources.white_star;

            rating = 1;
        }

        private void pbStar2_Click(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.yellow_star;
            pbStar2.Image = Resources.yellow_star;

            pbStar3.Image = Resources.white_star;
            pbStar4.Image = Resources.white_star;
            pbStar5.Image = Resources.white_star;

            rating = 2;
        }

        private void pbStar3_Click(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.yellow_star;
            pbStar2.Image = Resources.yellow_star;
            pbStar3.Image = Resources.yellow_star;

            pbStar4.Image = Resources.white_star;
            pbStar5.Image = Resources.white_star;

            rating = 3;
        }

        private void pbStar4_Click(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.yellow_star;
            pbStar2.Image = Resources.yellow_star;
            pbStar3.Image = Resources.yellow_star;
            pbStar4.Image = Resources.yellow_star;

            pbStar5.Image = Resources.white_star;

            rating = 4;
        }

        private void pbStar5_Click(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.yellow_star;
            pbStar2.Image = Resources.yellow_star;
            pbStar3.Image = Resources.yellow_star;
            pbStar4.Image = Resources.yellow_star;
            pbStar5.Image = Resources.yellow_star;

            rating = 5;
        }

        private void btnClearRating_Click(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.white_star;
            pbStar2.Image = Resources.white_star;
            pbStar3.Image = Resources.white_star;
            pbStar4.Image = Resources.white_star;
            pbStar5.Image = Resources.white_star;

            rating = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(pbStar1.Image == Resources.white_star)
            {
                MessageBox.Show("You did not give a Rating");
            }
            else if (txtComment.Text == "")
            {
                MessageBox.Show("Please Leave a Comment");
                txtComment.Focus();
            }
            else
            {
                _product.Reviews.Add(new Review
                {
                    Rating = rating,
                    Comment = txtComment.Text,
                    Customer = new Customer { FirstName = "John", LastName = "Doe"}
                });

                LoadReviews();
            }
        }
    }
}
