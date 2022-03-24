using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace JAHubLib
{
    public class BlogRenderer
    {
        public Panel BlogPostContainer { get; set; }
        public Panel BlogPost { get; set; }
        public Button ViewBlog { get; set; }
        public Label BlogTitle { get; set; }
        public Label BlogAuthor { get; set; }
        public Label BlogDescription { get; set; }
        public Label BlogRating { get; set; }
        public DateTime PublishDate { get; set; }
        public Label BlogDate { get; set; }
        public Blog Blog { get; set; }

        public BlogRenderer()
        {
            BlogPostContainer = new Panel();
            BlogPost = new Panel();
            ViewBlog = new Button();
            BlogTitle = new Label();
            BlogAuthor = new Label();
            BlogDescription = new Label();
            BlogRating = new Label();
            PublishDate = DateTime.Now;
            BlogDate = new Label();
        }
        public void SetBlogInstance(Blog b)
        {
            Blog = b;
        }
        public void InitializeBlogComponents()
        {
            //Main Container
            BlogPostContainer.Height = 130;
            BlogPostContainer.BorderStyle = BorderStyle.None;
            BlogPostContainer.Padding = new Padding(10, 0, 10, 10);

            //Panel for the individual blogs
            BlogPost.Width = 880;
            BlogPost.BackColor = Color.LightSeaGreen;
            BlogPost.BorderStyle = BorderStyle.FixedSingle;
            BlogPost.Height = 120;

            //View Button
            ViewBlog.Text = "View";
            ViewBlog.BackColor = Color.White;
            ViewBlog.Top = 15;
            ViewBlog.Left = 870 - ViewBlog.Width;

            //Title Label
            BlogTitle.Text = Blog.Title;
            BlogTitle.Font = new Font("Calibri", 12, FontStyle.Bold);
            BlogTitle.AutoSize = true;
            BlogTitle.Top = 10;
            BlogTitle.Left = 10;

            //Author Label
            BlogAuthor.Text = Blog.Author.Firstname + " " + Blog.Author.Lastname;
            BlogAuthor.Font = new Font("Calibri", 10, FontStyle.Italic);
            BlogAuthor.AutoSize = true;
            BlogAuthor.Top = 30;
            BlogAuthor.Left = 10;

            //Author Label
            BlogDate.Text = PublishDate.ToShortDateString();
            BlogDate.Font = new Font("Calibri", 10, FontStyle.Italic);
            BlogDate.AutoSize = true;
            BlogDate.Top = 50;
            BlogDate.Left = 10;

            //Desc Label
            BlogDescription.Text = Blog.Description;
            BlogDescription.Font = new Font("Calibri", 10);
            BlogDescription.AutoSize = true;
            BlogDescription.Top = 95;
            BlogDescription.Left = 10;

            //Rating label
            BlogRating.Text = Blog.Rating + " Person(s) Found This Helpful";
            BlogRating.Font = new Font("Calibri", 10, FontStyle.Italic);
            BlogRating.AutoSize = true;
            BlogRating.Top = 95;
        }
        public void CreateBlogPost(Panel pnlContainer)
        {
            BlogPostContainer.Controls.Add(BlogPost);
            BlogPost.Controls.Add(ViewBlog);
            BlogPost.Controls.Add(BlogTitle);
            BlogPost.Controls.Add(BlogAuthor);
            BlogPost.Controls.Add(BlogDate);
            BlogPost.Controls.Add(BlogDescription);
            BlogPost.Controls.Add(BlogRating);
            pnlContainer.Controls.Add(BlogPostContainer);
            BlogPostContainer.Dock = DockStyle.Top;
            InitializeBlogComponents();

            //to make up for the width changing due to autosize
            BlogRating.Left = 870 - BlogRating.Width;
        }
    }
}
