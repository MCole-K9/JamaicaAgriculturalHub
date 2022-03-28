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

namespace JAHub_Winforms.Blog_Controls
{
    public partial class ucBlogPost : UserControl
    {
        Blog blog = new Blog();
        public ucBlogPost()
        {
            InitializeComponent();
        }
        public ucBlogPost(Blog b)
        {
            blog = b;
            InitializeComponent();
            lblBlogTitle.Text = blog.Title;
            lblBlogAuthor.Text = blog.GetAuthorName();
            lblDatePublished.Text = blog.PublishDateString;
            lblBlogDescription.Text = blog.Description;
            lblRatings.Text = blog.Rating + " " + lblRatings.Text;
        }

        private void btnViewBlog_Click(object sender, EventArgs e)
        {
            FrmBlogDetails blogDetails = new FrmBlogDetails(blog);
            blogDetails.Show();

        }
    }
}
