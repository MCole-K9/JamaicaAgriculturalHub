using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHubLib.Verifcation
{
    public partial class usrIndustryBlock : UserControl
    {
        public usrIndustryBlock()
        {
            InitializeComponent();
        }

        private void rdoIndustryYes_Validating(object sender, CancelEventArgs e)
        {
            // if neither this nor the other one is chosen, set the error provider
            // with message "either yes or no"
        }

        private void rdoIndustryNo_Validating(object sender, CancelEventArgs e)
        {
            // if neither this nor the other one is chosen, set the error provider
            // with message "either yes or no"
        }
    }
}
