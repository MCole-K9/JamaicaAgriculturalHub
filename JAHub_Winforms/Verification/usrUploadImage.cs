using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms.Verification
{
    public partial class usrUploadImageBlock : UserControl
    {
        public usrUploadImageBlock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // broadly: OpenFileDialog or whatever
            // (make sure it's only set to allow png, jpg/jpeg, gif)
            // get and store the image (in what?)
            // display a small version of the image in the box on the left
        }
    }
}
