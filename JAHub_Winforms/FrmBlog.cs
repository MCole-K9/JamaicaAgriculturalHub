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
    public partial class FrmBlog : Form
    {


        public FrmBlog()
        {
            InitializeComponent();

            SqlConnection connection = new SqlConnection("Data Source=jamaicaagriculturalhub.mssql.somee.com;Initial Catalog=jamaicaagriculturalhub;Persist Security Info=True;User ID=Ethan_Hughs_SQLLogin_1;Password=yq8mavdef8");

            SqlCommand cmd = new SqlCommand("SELECT * FROM Blog", connection);
            connection.Open();
            SqlDataReader sqlData = cmd.ExecuteReader();

            while (sqlData.Read())
            {
                Blog blog = new Blog();


                blog.Title = sqlData["Title"].ToString();
                blog.Author.UserID = sqlData["Author"].ToString();
                blog.Description = sqlData["Description"].ToString();
                blog.BlogBody = sqlData["Body"].ToString();
                blog.PublishDateString = sqlData["PublishedDate"].ToString();
                blog.Rating = Convert.ToInt16(sqlData["Rating"]);
                Blog_Controls.ucBlogPost ucBlogPost = new Blog_Controls.ucBlogPost(blog);
                pnlContainer.Controls.Add(ucBlogPost);
                ucBlogPost.Dock = DockStyle.Top;

            }

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

        private void btntest_Click(object sender, EventArgs e)
        {
            Blog testblog = new Blog();
            Blog_Controls.ucBlogPost ucBlogPost = new Blog_Controls.ucBlogPost(testblog);
            pnlContainer.Controls.Add(ucBlogPost);
            ucBlogPost.Dock = DockStyle.Top;
        }

        private void pnlContainer_ClientSizeChanged(object sender, EventArgs e)
        {
            pnlContainer.Padding = new Padding(0, 0, 0, 0);
        }
    }
}
