using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAHubLib
{
    public class User
    {
        public string Firstname { set; get; }
        public string Lastname { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Email { set; get; } 
        public string UserID { set; get; }

        protected User()
        {
            Firstname = "";
            Lastname = "";
            Username = "";
            Password = "";
            Email = "";
            UserID = "";
        }
        protected User(string fn,string ln, string un,string em,string uid)
        {
            Firstname = fn;
            Lastname = ln;
            Username = un;
            Email = em;
            UserID = uid;
        }
        protected User(User user)
        {
            Firstname = user.Firstname;
            Lastname = user.Lastname;
            Username = user.Username;
            Password = user.Password;
            Email = user.Email;
            UserID = user.UserID;
        }
        
    }
}
