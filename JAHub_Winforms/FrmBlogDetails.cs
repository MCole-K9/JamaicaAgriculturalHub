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
            try
            {
                lblAuthor.Text = displayedBlog.GetAuthorName(blog.AuthorID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lblPublishDate.Text = displayedBlog.PublishDateString;
            lblDescription.Text = displayedBlog.Description;
            rtbBlogBody.Text = displayedBlog.BlogBody;

            
        }
        private void btnCreateBlog_Click(object sender, EventArgs e)
        {
            
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
            displayedBlog.Rating++;
            SqlConnection connection = new SqlConnection("Data Source = jamaicaagriculturalhub.mssql.somee.com; Initial Catalog = jamaicaagriculturalhub; Persist Security Info = True; User ID = Ethan_Hughs_SQLLogin_1; Password = yq8mavdef8");
            connection.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE Blog SET Rating = {displayedBlog.Rating} WHERE ID = {displayedBlog.BlogID}",connection);
            cmd.ExecuteNonQuery();
        }

        private void btnRatingDown_Click(object sender, EventArgs e)
        {
            if (displayedBlog.Rating > 0)
            {
                displayedBlog.Rating--;
                SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
                connection.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE Blog SET Rating = {displayedBlog.Rating} WHERE ID = {displayedBlog.BlogID}", connection);
                cmd.ExecuteNonQuery();
            }
        }

        private void FrmBlogDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (Utils.IsFormOpen("FrmBlog"))
            //{
            //    foreach (var form in this.MdiParent.MdiChildren)
            //    {
            //        if (form.Text == "FrmBlog")
            //        {
            //            form.Close();
            //        }
            //    }
            //    FrmBlog frmBlog = new FrmBlog();
            //    frmBlog.MdiParent = this.MdiParent;
            //    frmBlog.Show();
            //}
            //else
            //{
            //    FrmBlog frmBlog = new FrmBlog();
            //    frmBlog.MdiParent = this.MdiParent;
            //    frmBlog.Show();
            //}
        }
    }

}
