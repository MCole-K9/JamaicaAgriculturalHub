using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JAHub_ASPWebforms.Administration
{
    public partial class AdminViewModeration : System.Web.UI.UserControl
    {
        int _userid;
        String _name;

        public int UserId
        {
            get
            {
                return _userid;
            }
            set
            {
                _userid = value;
            }
        }
        public String Name
        {
            get
            {
                return _name;
            }
            set {
                _name = value; 
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lblViewModerationFor.Text = $"View Moderation for User {_name} (ID: {_userid})";
        }

        public AdminViewModeration()
        {
            
        }
    }
}