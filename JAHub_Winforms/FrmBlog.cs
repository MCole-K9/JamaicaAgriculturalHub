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

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DQRLF1VA;Initial Catalog=BlogDetailsDB;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("SELECT * FROM BlogDetailsTable", connection);
            //connection.Open();
            //SqlDataReader sqlData = cmd.ExecuteReader();

            //while (sqlData.Read())
            //{
            //    Blog blog = new Blog();

            //    blog.Title = sqlData["Title"].ToString();
            //    blog.Author = sqlData["Author"].ToString();
            //    blog.Description = sqlData["Description"].ToString();
            //    blog.BlogBody = sqlData["BlogBody"].ToString();
            //    blog.PublishDateString = sqlData["PublishDateString"].ToString();
            //    blog.Rating = Convert.ToInt16(sqlData["Rating"]);
            //    blog.CreateBlogPost(pnlContainer);
            //    blog.ViewBlog.Click += ViewBlog_Click;
            //    void ViewBlog_Click(object sender, EventArgs e)
            //    {
            //        FrmBlogDetails DisplayedBlog = new FrmBlogDetails(blog);
            //        DisplayedBlog.Show();
            //    }
            //}
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
    }
}
