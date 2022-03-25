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
    public partial class FrmCreateBlog : Form
    {
        User user = new User();
        public FrmCreateBlog()
        {
            InitializeComponent();
        }
        public FrmCreateBlog(User u)
        {
            user = u;
            InitializeComponent();
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
                foreach (var form in this.MdiParent.MdiChildren)
                {
                    if (form.Text == "FrmCreateBlog")
                    {
                        form.BringToFront();
                    }
                }
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
                foreach (var form in this.MdiParent.MdiChildren)
                {
                    if (form.Text == "FrmUserBlogs")
                    {
                        form.BringToFront();
                    }
                }
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
                foreach (var form in this.MdiParent.MdiChildren)
                {
                    if (form.Text == "FrmBlog")
                    {
                        form.BringToFront();
                    }
                }
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Blog newBlog = new Blog();
            newBlog.Author.Firstname = user.Firstname;
            newBlog.Author.Lastname = user.Lastname;
            newBlog.Title = txtTitle.Text;
            newBlog.Description = rtbDescription.Text;
            newBlog.PublishDateString = DateTime.Now.ToShortDateString();
            newBlog.BlogBody = rtbBody.Text;
            FrmBlogDetails blogDetails = new FrmBlogDetails(newBlog);
            blogDetails.MdiParent = this.MdiParent;
            blogDetails.Show();
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DQRLF1VA;Initial Catalog=BlogDetailsDB;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO BlogDetailsTable VALUES ('" + newBlog.Title + "','" + newBlog.GetAuthorName() + "','" + newBlog.Description + "','" + newBlog.BlogBody + "','" + newBlog.PublishDateString + "'," + newBlog.Rating + ");");


            cmd.Connection = connection;
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Saved To Database!");
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }
        }
    }
}
