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
        public Panel BlogPostContainer = new Panel();
        public Panel BlogPost = new Panel();
        public Button viewBlog = new Button();
        public Label BlogTitle = new Label();
        public Label BlogAuthor = new Label();
        public DateTime PublishDate = DateTime.Now;//simulated time object to be passed for each blog
        public Label BlogDate = new Label();
        public String BlogBody { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Author { get; set; }

        public Blog()
        {
            Author = "John Doe";
            BlogBody = "";
            Title = "";
            Description = "";
            BlogPostContainer.Height = 130;
            BlogPostContainer.BorderStyle = BorderStyle.None;
            BlogPostContainer.Padding = new Padding(10, 0, 10, 10);

            //Panel for the individual blogs
            
            BlogPost.Width = 880;
            BlogPost.BackColor = Color.LightSeaGreen;
            BlogPost.BorderStyle = BorderStyle.FixedSingle;
            BlogPost.Height = 120;

            //View Button
            
            viewBlog.Text = "View";
            viewBlog.BackColor = Color.White;
            viewBlog.Top = 15;
            viewBlog.Left = 870 - viewBlog.Width;

            //Title Label
            
            BlogTitle.Text = "How to Dig Up Soil";
            BlogTitle.Font = new Font("Calibri", 12, FontStyle.Bold);
            BlogTitle.AutoSize = true;
            BlogTitle.Top = 10;
            BlogTitle.Left = 10;

            //Author Label
            
            BlogAuthor.Text = "John Doe";
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

        }
        public void CreateBlogPost(Panel pnlContainer)
        {
            BlogPostContainer.Controls.Add(BlogPost);
            BlogPost.Controls.Add(viewBlog);
            BlogPost.Controls.Add(BlogTitle);
            BlogPost.Controls.Add(BlogAuthor);
            BlogPost.Controls.Add(BlogDate);
            pnlContainer.Controls.Add(BlogPostContainer);
            BlogPostContainer.Dock = DockStyle.Top;
        }

    }
}
