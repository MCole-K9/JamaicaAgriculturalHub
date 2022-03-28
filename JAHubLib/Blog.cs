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
        

        public User Author { get; set; }
        public string PublishDateString { get; set; }
        public string BlogBody { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }

        public Blog()
        {
            PublishDateString = DateTime.Now.ToString();
            Author = new User();
            Author.FirstName = "Elliot";
            Author.LastName = "Morrison";
            BlogBody = "Content";
            Title = "Title";
            Description = "Description";
            Rating = 0;
        }
       
       

        public Blog(string blogBody, string title, string description, User author, string pds, int rating)
        {

            PublishDateString = pds;
            BlogBody = blogBody;
            Title = title;
            Description = description;
            Author = author;
            Rating = rating;
        }

        
        public string GetAuthorName()
        {
            return Author.FirstName + " " + Author.LastName;
        }
        

    }
}
