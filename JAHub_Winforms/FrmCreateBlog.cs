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
        Blog blog = new Blog();
        bool IsUpdate = false;
        public FrmCreateBlog()
        {
            InitializeComponent();
        }
        public FrmCreateBlog(Blog b)
        {
            InitializeComponent();
            blog = b;
            txtTitle.Text = b.Title;
            rtbDescription.Text = b.Description;
            rtbBody.Text = b.BlogBody;
            btnPost.Text = "Save";
            IsUpdate = true;
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
            if(txtTitle.Text != "" && rtbDescription.Text != "" && rtbBody.Text != "")
            {
                if (IsUpdate)
                {
                    try
                    {
                        blog.Title = txtTitle.Text;
                        blog.Description = rtbDescription.Text;
                        blog.BlogBody = rtbBody.Text;
                        blog.UpdateBlogPost(blog);
                        MessageBox.Show("Blog Post Updated!");
                        if (Utils.IsFormOpen("FrmBlog"))
                        {
                            foreach (var form in this.MdiParent.MdiChildren)
                            {
                                if (form.Text == "FrmBlog")
                                {
                                    form.Close();
                                }
                            }
                            FrmBlog frmBlog = new FrmBlog();
                            frmBlog.MdiParent = this.MdiParent;
                            frmBlog.Show();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    Blog newBlog = new Blog();
                    try
                    {
                        string ParsedBody = rtbBody.Text.Replace("'", "''");
                        newBlog.CreateBlogPost(Session.UserId, txtTitle.Text, rtbDescription.Text, ParsedBody);
                        MessageBox.Show("Blog Post Created!");
                        if (Utils.IsFormOpen("FrmBlog"))
                        {
                            foreach (var form in this.MdiParent.MdiChildren)
                            {
                                if (form.Text == "FrmBlog")
                                {
                                    form.Close();
                                }
                            }
                        }
                        FrmBlog frmBlog = new FrmBlog();
                        frmBlog.MdiParent = this.MdiParent;
                        frmBlog.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Fill Out All Feilds","Empty Feilds",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
