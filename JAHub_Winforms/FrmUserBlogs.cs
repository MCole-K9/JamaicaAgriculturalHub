﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms
{
    public partial class FrmUserBlogs : Form
    {
        public FrmUserBlogs()
        {
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
    }
}
