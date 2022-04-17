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
            lblexpirydategrantdetails.Text = grantinfo.ExpiryDate.ToString();
            txtcreategranttitle.Text = grantinfo.Title;
            rtbdescription.Text = grantinfo.GrantDescription;
            rtbrequirement.Text = grantinfo.Requirement;
            txtapplicationnumber.Text = grantinfo.ApplicationId;
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(1102, 1200);

            Grantinfo grantinfo = new Grantinfo();
            
            FrmGrantDetails form1 = new FrmGrantDetails(grantinfo);
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {//  rtbRequirement.ImageLocation = ofd.FileName;

                //Form2 form2 = new Form2();
                //form2.Show();
            }
        }
    }
}



