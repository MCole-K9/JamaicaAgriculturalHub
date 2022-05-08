using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using JAHubLib;
using JAHub_ASPWebforms.Account;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

namespace JAHub_ASPWebforms
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    // Set Anti-XSRF token
            //    ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
            //    ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            //}
            //else
            //{
            //    // Validate the Anti-XSRF token
            //    if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
            //        || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
            //    {
            //        throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
            //    }
            //}
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserId"] != null)
            {
                usrNavbarAccountLogout accountLogoutSection = (usrNavbarAccountLogout)LoadControl("~/Account/usrNavbarAccountLogout.ascx");

                phAccount.Controls.Add(accountLogoutSection);

                // Using this to make certain items only visible given a certain user role
                switch (Session["UserRole"])
                {
                    default:
                        // this shouldn't actually happen
                        break;
                    case UserRole.Admin:
                        liAdmin.Visible = true;
                        btnAdministration.Visible = true;
                        break;
                }

            }
            else
            {
                usrNavbarLoginRegister loginRegister = (usrNavbarLoginRegister)LoadControl("~/Account/usrNavbarLoginRegister.ascx");

                phAccount.Controls.Add(loginRegister);


                liAdmin.Visible = false;
                btnAdministration.Visible = false;
            }
        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

        protected void btnLogin_OnClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                lblLoginResult.Text = "Please enter both the Email Address and Password and try" +
                    " " + " again.";
                lblLoginResult.CssClass = "text-danger";
            }
            else if (!String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                PasswordResult result = JAHubLib.Session.Login(txtEmail.Text.ToLower(), txtPassword.Text);

                if (result == PasswordResult.Success)
                {
                    using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                    {
                        connection.Open();

                        String userReadUserInfo = "SELECT ID, FirstName, LastName, UserRole FROM " +
                            $"[User] WHERE EmailAddress = '{txtEmail.Text}';";

                        SqlCommand cmd = new SqlCommand(userReadUserInfo, connection);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            Session["UserId"] = reader["ID"];
                            Session["FirstName"] = reader["FirstName"];
                            Session["LastName"] = reader["LastName"];
                            Session["UserRole"] = reader["UserRole"];
                            Session.Timeout = 60;
                        }
                        reader.Close();

                        connection.Close();
                    }

                    // idk if this actually goes where it should
                    Response.Redirect(Request.RawUrl);
                }
                else if (result == PasswordResult.CredentialsIncorrect)
                {
                    lblLoginResult.Text = "Email Address or Password is incorrect, please check your" +
                        " " + "credentials and try again";
                    lblLoginResult.CssClass = "text-danger";

                }
                else if (result == PasswordResult.NoMatchingCredentials)
                {
                    lblLoginResult.Text = "Email Address not found, please check your credentials" +
                        " " + "or register for an account";
                    lblLoginResult.CssClass = "text-danger";

                }
            }

        }

    }

}