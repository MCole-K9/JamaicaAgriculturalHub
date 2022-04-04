using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHubLib;
using System.Data.SqlClient;

namespace JAHub_Winforms
{
    public static class Utils
    {
        //Returns true or false if there is an instance of the form passed in is already runninn
        public static bool IsFormOpen(string frmTxtProp)
        {
            var OpenForms =  Application.OpenForms.Cast<Form>();
            bool isOpen = OpenForms.Any(q => q.Text == frmTxtProp);
            return isOpen;
            
        }
        public static void ClearPanel(Panel pnl)
        {
            while (pnl.Controls.Count > 0)
            {
                pnl.Controls.RemoveAt(0);
            }
        }
        public static void DisplayBlogsFromDatabase(SqlDataReader sqlData, Panel pnlContainer)
        {
            while (sqlData.Read())
            {
                Blog blog = new Blog();

                blog.BlogID = (int)sqlData["ID"];
                blog.Title = sqlData["Title"].ToString();
                blog.AuthorID = (int)sqlData["Author"];
                blog.Description = sqlData["Description"].ToString();
                blog.BlogBody = sqlData["Body"].ToString();
                blog.PublishDateString = sqlData["PublishedDate"].ToString();
                blog.Rating = Convert.ToInt16(sqlData["Rating"]);
                Blog_Controls.ucBlogPost ucBlogPost = new Blog_Controls.ucBlogPost(blog);
                pnlContainer.Controls.Add(ucBlogPost);
                ucBlogPost.Dock = DockStyle.Top;

            }
        }
    }
}
