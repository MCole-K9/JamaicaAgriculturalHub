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
        Grantinfo grantinfo = new Grantinfo();
      
        public UserControlGrantSubmission()
        {
            InitializeComponent();
            
            //lblfilename.Text =grantApplication.FilledApplication;
        }

        public UserControlGrantSubmission(Grantinfo gr)
        {
           grantinfo = gr;   
            
            lblfilename.Text = grantinfo.FileName;
            
        }
    }
}
