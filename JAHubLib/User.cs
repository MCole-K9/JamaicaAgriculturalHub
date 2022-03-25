using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAHubLib
{
    public class User
    {
        // Unsorted whether or not User should compose itself for specific roles, or if 
        // User will inherit. i suggest composition--Sheriff
        public string Firstname { set; get; }
        public string Lastname { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Email { set; get; } 
        public string UserID { set; get; }
        public UserRole UserRole { get; set; }                
    }
}
