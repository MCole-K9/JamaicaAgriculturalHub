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
            lblFarmerName.Text = $"{_product.Farmer.FirstName} {_product.Farmer.LastName}";
        }

        private void LoadReviews()
        {
            fpnlReviews.Controls.Clear();
            foreach (var review in _product.Reviews)
            {
                fpnlReviews.Controls.Add(new Shop_Controls.UsrRating(review));
            }
            CalculateReviews();
        }
        public void RenderProgressBars(List<float> ratings)
        {
            fpnlProgress.Controls.Clear();
            foreach (var rating in ratings)
            {
                ProgressBar progressBar = new ProgressBar();
                progressBar.Value = (int)rating;
                fpnlProgress.Controls.Add(progressBar);
            }
            
        }
        public void CalculateReviews()
        {
            try
            {
                int totalReviews = _product.Reviews.Count;

                List<Review> Rating5Reviews = _product.Reviews.Where(q => q.Rating == 5).ToList();
                List<Review> Rating4Reviews = _product.Reviews.Where(q => q.Rating == 4).ToList();
                List<Review> Rating3Reviews = _product.Reviews.Where(q => q.Rating == 3).ToList();
                List<Review> Rating2Reviews = _product.Reviews.Where(q => q.Rating == 2).ToList();
                List<Review> Rating1Reviews = _product.Reviews.Where(q => q.Rating == 1).ToList();


                float ratingCount5 = Rating5Reviews.Count();
                float ratingCount4 = Rating4Reviews.Count();
                float ratingCount3 = Rating3Reviews.Count();
                float ratingCount2 = Rating2Reviews.Count();
                float ratingCount1 = Rating1Reviews.Count();


                List<float> rating = new List<float> ();
                float star5Percentage =  (ratingCount5 / totalReviews)* 100;
                float star4Percentage = (ratingCount4 / totalReviews) * 100;
                float star3Percentage = (ratingCount3 / totalReviews) * 100;
                float star2Percentage = (ratingCount2 / totalReviews) * 100;
                float star1Percentage = (ratingCount1 / totalReviews) * 100;

                rating.Add(star5Percentage); 
                rating.Add(star4Percentage);
                rating.Add(star3Percentage);
                rating.Add(star2Percentage);
                rating.Add(star1Percentage);
    
                RenderProgressBars(rating);
                   
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Some error occured, contact the app owner " + ex.Message);
            }



        }
 

  
        private void FrmProductDetail_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateFields();
                _product.FetchReviews();
                LoadReviews();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.GetType().ToString()}" + ex.Message);
            }
            
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
                Customer customer = new Customer(true);

                Review review = new Review 
                {
                    Rating = rating,
                    Comment = txtComment.Text,
                    ProductID = _product.Id,
                    
                };
                

                if(customer.AddReview(review) > 0)
                {
                    MessageBox.Show("Review Has Been Made");

                    _product.FetchReviews();
                    LoadReviews();
                }

                

            }
        }
    }
}
