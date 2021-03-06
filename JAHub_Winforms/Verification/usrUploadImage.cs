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

namespace JAHub_Winforms.Verification
{
    public partial class usrUploadImageBlock : UserControl
    {
        
        Bitmap profilePicture;

        public Bitmap ProfilePicture => profilePicture;

        public usrUploadImageBlock()
        {
            InitializeComponent();
        }

        public usrUploadImageBlock(Bitmap image)
        {
            profilePicture = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    profilePicture = new Bitmap(ofd.FileName);

                    picProfileImage.Image = profilePicture;
                }
            }
        }
    }
}
