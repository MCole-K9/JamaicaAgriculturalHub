using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHubLib;

namespace JAHub_Winforms.Grant_Controls
{
    public partial class UserControlGrantSubmission : UserControl
    {
        GrantApplication grantApplication = new GrantApplication();
        public UserControlGrantSubmission()
        {
            InitializeComponent();
            
            lblfilename.Text =grantApplication.FilledApplication;
        }
    }
}
