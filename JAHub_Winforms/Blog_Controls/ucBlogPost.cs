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
        User user = new User();
        public ucBlogPost()
        {
            InitializeComponent();
        }
        public ucBlogPost(Blog b)
        {
            blog = b;
            InitializeComponent();
            lblBlogTitle.Text = blog.Title;
            try
            {
                lblBlogAuthor.Text += " " + blog.GetAuthorName(blog.AuthorID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lblDatePublished.Text += " " + blog.PublishDateString;
            lblBlogDescription.Text = blog.Description;
            lblRatings.Text = blog.Rating.ToString();
        }

        private void btnViewBlog_Click(object sender, EventArgs e)
        {
            FrmBlogDetails blogDetails = new FrmBlogDetails(blog);
            blogDetails.Show();

        }
    }
}
