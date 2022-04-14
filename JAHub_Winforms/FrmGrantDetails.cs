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
            txtexpirydate.Text = grantinfo.ExpiryDate.ToString();
            lbltitle.Text = grantinfo.Title;
            rtbgrantdescription.Text = grantinfo.GrantDescription;
            rtbRequirement.Text = grantinfo.Requirement;    


        }





        private void Form1_Load(object sender, EventArgs e)
        {



           Grantinfo grantinfo = new Grantinfo();
            

           /* //grantinfo.ExpiryDate =;
            grantinfo.Title = lbltitle.Text;
            grantinfo.GrantDescription = rtbgrantdescription.Text;*/


            FrmGrantDetails form1 = new FrmGrantDetails(grantinfo);
           // form1.MdiParent = this.MdiParent;
            // form1.Show(); 



        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbRequirement.ImageLocation = ofd.FileName;

                //Form2 form2 = new Form2();
                //form2.Show();
            }
        }
    }
}



