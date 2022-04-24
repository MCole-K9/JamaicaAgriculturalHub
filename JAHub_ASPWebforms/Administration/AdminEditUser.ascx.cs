using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JAHub_ASPWebforms.Administration
{
    public partial class AdminEditUser : System.Web.UI.UserControl
    {
        public String _userName;
        public String UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public int UserId { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}