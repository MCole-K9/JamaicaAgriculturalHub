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
using System.Data.SqlClient;
namespace JAHub_Winforms
{
    public partial class FrmBlogDetails : Form
    {
        Blog displayedBlog = new Blog();
        public FrmBlogDetails()
        {
            InitializeComponent();
        }
        public FrmBlogDetails(Blog blog)
        {
            displayedBlog = blog;
            InitializeComponent();
            lblTitle.Text = displayedBlog.Title;
            lblAuthor.Text = displayedBlog.Author;
            lblPublishDate.Text = displayedBlog.PublishDateString;
            lblDescription.Text = displayedBlog.Description;
            rtbBlogBody.Text = displayedBlog.BlogBody;

            
        }
        private void btnCreateBlog_Click(object sender, EventArgs e)
        {
            //displayedBlog.Rating++;
            
            if (!Utils.IsFormOpen("FrmCreateBlog"))
            {

                FrmCreateBlog createBlog = new FrmCreateBlog();
                createBlog.MdiParent = this.MdiParent;
                createBlog.Show();
            }
            else
            {
                MessageBox.Show("An Instance is Already Running");
            }

        }

        private void btnMyBlogs_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen("FrmUserBlogs"))
            {

                FrmUserBlogs userBlogs = new FrmUserBlogs();
                userBlogs.MdiParent = this.MdiParent;
                userBlogs.Show();
            }
            else
            {
                MessageBox.Show("An Instance is Already Running");
            }
        }

        private void btnBlogs_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen("FrmBlog"))
            {
                FrmBlog blogs = new FrmBlog();
                blogs.MdiParent = this.MdiParent;
                blogs.Show();
            }
            else
            {
                MessageBox.Show("An Instance is Already Running");
            }
        }

        private void btnRatingUp_Click(object sender, EventArgs e)
        {
            //displayedBlog.Rating++;
            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DQRLF1VA;Initial Catalog=BlogDetailsDB;Integrated Security=True");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("UPDATE BlogDetailsTable SET Rating = " + displayedBlog.Rating + " WHERE Title = '" + displayedBlog.Title + "'");
            //cmd.Connection = connection;
            //cmd.ExecuteNonQuery();
        }

        private void btnRatingDown_Click(object sender, EventArgs e)
        {
            //if(displayedBlog.Rating > 0)
            //{
            //    displayedBlog.Rating--;
            //    SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DQRLF1VA;Initial Catalog=BlogDetailsDB;Integrated Security=True");
            //    connection.Open();
            //    SqlCommand cmd = new SqlCommand("UPDATE BlogDetailsTable SET Rating = " + displayedBlog.Rating + " WHERE Title = '" + displayedBlog.Title + "'");
            //    cmd.Connection = connection;
            //    cmd.ExecuteNonQuery();
            //}
        }
    }

}
