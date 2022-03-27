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

namespace JAHub_Winforms.Shop_Controls
{
    public partial class UsrRating : UserControl
    {
        private Review _review;
        public UsrRating()
        {
            InitializeComponent();
        }
        public UsrRating(Review review)
        {
            InitializeComponent();
            _review = review;
        }
        private void PopulateFields()
        {
            lblCustomerName.Text = $"{_review.Customer.FirstName} {_review.Customer.LastName}";
            lblComment.Text = _review.Comment;
            lblRating.Text = $"{_review.Rating} Stars";
        }

        private void UsrRating_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }
    }
}
