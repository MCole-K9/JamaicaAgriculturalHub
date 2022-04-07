using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;


namespace JAHubLib
{
    public class Blog
    {
        

        public int AuthorID { get; set; }
        public string PublishDateString { get; set; }
        public string BlogBody { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int BlogID { get; set; }

        public Blog()
        {
            PublishDateString = DateTime.Now.ToString();
            AuthorID = Session.UserId;
            BlogBody = "Content";
            Title = "Title";
            Description = "Description";
            Rating = 0;
        }

        public string GetAuthorName(int authorId)
        {
            SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
            connection.Open();
            SqlCommand cmd = new SqlCommand($"SELECT FirstName, LastName FROM [User] WHERE ID = {authorId}",connection);
            SqlDataReader sqlData = cmd.ExecuteReader();
            if (sqlData.Read())
            {
                string FullName = sqlData["FirstName"].ToString() + " " + sqlData["LastName"].ToString();
                connection.Close();
                return FullName;
            }
            else
            {
                throw new Exception("ERROR_RETRIEVING_AUTHOR_NAME");
            }
            
        }

        public void CreateBlogPost(int userID, string title, string desc, string body)
        {
            Blog newBlog = new Blog();
            newBlog.AuthorID = userID;
            newBlog.Title = title;
            newBlog.Description = desc;
            newBlog.PublishDateString = DateTime.Now.ToShortDateString();
            newBlog.BlogBody = body;
            newBlog.Rating = 0;
            SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
            connection.Open();
            SqlCommand cmd = new SqlCommand(Utilities.getCreateBlogSqlString(newBlog), connection);
            int i = cmd.ExecuteNonQuery();
            if (i == 0)
            {
                throw new Exception("DATABASE_ERROR_NO_ROWS_AFFECTED");
            }
            else
            {
                connection.Close();
            }
        }

    }
}
