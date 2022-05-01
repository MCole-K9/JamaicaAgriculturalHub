using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class CreateBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int id = (int)Session["UserID"];
            }catch(Exception)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "clickLoginNavBtn()", true);
            }
            if(Session["BlogForEdit"] != null)
            {
                if (!IsPostBack)
                {
                    Blog b = (Blog)Session["BlogForEdit"];
                    btnPost.Text = "Save";
                    txtBlogBody.Value = b.BlogBody;
                    txtDescription.Value = b.Description;
                    txtTitle.Value = b.Title;
                }
            }
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            if (txtBlogBody.Value == " " || txtDescription.Value == "" || txtTitle.Value == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertFunction", "alert(\"Fill Out All Feilds\")", true);
            }
            else
            {
                Blog b = (Blog)Session["BlogForEdit"];
                string ParsedBody = txtBlogBody.Value.Replace("'", "''");
                b.BlogBody = ParsedBody;
                b.Description = txtDescription.Value;
                b.Title = txtTitle.Value;

                if (Session["BlogForEdit"] != null)
                {
                    try
                    {
                        b.UpdateBlogPost(b);
                        Session.Remove("BlogForEdit");
                        Response.Redirect("~/MyBlogs.aspx");
                    }
                    catch (Exception ex)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertFunction", $"alert(\"{ex.Message}\")", true);
                    }
                }
                else
                {
                    try
                    {
                        b.CreateBlogPost((int)Session["UserId"], txtTitle.Value, txtDescription.Value, ParsedBody);
                        Response.Redirect("~/Blog.aspx");
                    }
                    catch (Exception ex)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertFunction", $"alert(\"{ex.Message}\")", true);
                    }
                }
                
                
            }
        }
    }
}