using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace JAHubLib
{
    public class Blog
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
        public string PublishDateString { get; set; }
        public string BlogBody { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }
        //so for next time we create some different blog instances and past them to frmBlog
        public Blog()
        {
            PublishDateString = DateTime.Now.ToString();
            Author = "John Doe";
            BlogBody = "";
            Title = "Title";
            Description = "desc";
            Rating = 0;
            BlogPostContainer = new Panel();
            BlogPost = new Panel();
            ViewBlog = new Button();
            BlogTitle = new Label();
            BlogAuthor = new Label();
            BlogDescription = new Label();
            BlogRating = new Label();
            PublishDate = DateTime.Now;//simulated time object to be passed for each blog
            BlogDate = new Label();
        }
       
       

        public Blog(string blogBody, string title, string description, string author, string pds, int rating)
        {

            PublishDateString = pds;
            BlogBody = blogBody;
            Title = title;
            Description = description;
            Author = author;
            Rating = rating;

            BlogPostContainer = new Panel();
            BlogPost = new Panel();
            ViewBlog = new Button();
            BlogTitle = new Label();
            BlogAuthor = new Label();
            BlogDescription = new Label();
            BlogRating = new Label();
            PublishDate = DateTime.Now;//simulated time object to be passed for each blog
            BlogDate = new Label();
        }

        public void InitializeBlogComponents()  
        {
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

            BlogTitle.Text = Title;
            BlogTitle.Font = new Font("Calibri", 12, FontStyle.Bold);
            BlogTitle.AutoSize = true;
            BlogTitle.Top = 10;
            BlogTitle.Left = 10;

            //Author Label

            BlogAuthor.Text = Author;
            BlogAuthor.Font = new Font("Calibri", 10, FontStyle.Italic);
            BlogAuthor.AutoSize = true;
            BlogAuthor.Top = 5 + BlogTitle.Height;
            BlogAuthor.Left = 10;

            //Author Label
            //DateTime date = DateTime.Now;//simulated time object to be passed for each blog

            BlogDate.Text = PublishDate.ToShortDateString();
            BlogDate.Font = new Font("Calibri", 10, FontStyle.Italic);
            BlogDate.AutoSize = true;
            BlogDate.Top = BlogTitle.Height + BlogAuthor.Height;
            BlogDate.Left = 10;

            //Desc Label
            BlogDescription.Text = Description;
            BlogDescription.Font = new Font("Calibri", 10);
            BlogDescription.AutoSize = true;
            BlogDescription.Top = 95;
            BlogDescription.Left = 10;

            //Rating label
            BlogRating.Text = Rating + " Person(s) Found This Helpful";
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
