using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHubLib.Verification
{
    public partial class usrLandBlock : UserControl
    {
        public usrLandBlock()
        {
            InitializeComponent();
        }

        private void nudLandMeasurement_Validating(object sender, CancelEventArgs e)
        {
            // I would probably prefer to use "TextChanged" or some other event like that, but
            // this will work for the time being
            if (nudLandMeasurement.Value <= 0)
            {
                landBlockErrorProvider.SetIconAlignment(nudLandMeasurement, ErrorIconAlignment.MiddleRight);
                landBlockErrorProvider.SetError(nudLandMeasurement, "Value must be greater than 0");
            }
            else
            {
                landBlockErrorProvider.SetError(nudLandMeasurement, "");
            }
        }
    }
}
