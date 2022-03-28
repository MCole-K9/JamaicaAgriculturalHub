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
using System.IO;

namespace JAHub_Winforms
{
    public partial class FrmGrantDetails : Form
    {
        public FrmGrantDetails()
        {
            InitializeComponent();
        }

        public FrmGrantDetails(Grantinfo grantinfo)
        {
            InitializeComponent();
            txtexpirydate.Text = grantinfo.ExpiryDate;
            txttitle.Text = grantinfo.Title;
            rtbgrantdescription.Text = grantinfo.GrantDescription;

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Grantinfo grantinfo = new Grantinfo();


            grantinfo.ExpiryDate = txtexpirydate.Text;
            grantinfo.Title = txttitle.Text;
            grantinfo.GrantDescription = rtbgrantdescription.Text;


            FrmGrantDetails form1 = new FrmGrantDetails(grantinfo);
            form1.MdiParent = this.MdiParent;
            // form1.Show(); 



        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbscanpicture.ImageLocation = ofd.FileName;

                //Form2 form2 = new Form2();
                //form2.Show();
            }
        }
    }
}



/*  var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        /* private void button1_Click(object sender, EventArgs e)
          {
             /* string url = https://www.google.com/search?q=shorty+meaning&rlz=1C1CHBD_enJM925JM925&oq=&aqs=chrome.2.35i39i362j46i39i362j35i39i362l5j69i59i450.4578214j0j7&sourceid=chrome&ie=UTF-8;

                  grantinfo.Navigate(url);
          }*/
