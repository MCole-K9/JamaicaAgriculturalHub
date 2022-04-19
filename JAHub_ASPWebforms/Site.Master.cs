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
                
                // add the "YOUR ACCOUNT/LOGOUT" user control
                
                // this should show some kind of "currently logged in as"
                // include:
                // * First Name
                // * Last Name
                // * UserId
                // * Role
                // Should also allow the ability to log out (Does this require ajax/jquery?
            }
            else
            {
                usrNavbarLoginRegister loginRegister = (usrNavbarLoginRegister)LoadControl("~/Account/usrNavbarLoginRegister.ascx");

                phAccount.Controls.Add(loginRegister);
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
                        String userReadUserInfo = "SELECT UserId, FirstName, LastName, UserRole FROM " +
                            $"[User] WHERE EmailAddress = '{txtEmail.Text}";

                        SqlCommand cmd = new SqlCommand(userReadUserInfo, connection);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader["UserId"] != null)
                        {
                            Session["UserId"] = reader["UserId"];
                            Session["FirstName"] = reader["FirstName"];
                            Session["LastName"] = reader["LastName"];
                            Session["Role"] = reader["Role"];
                            Session.Timeout = 60;
                        }
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