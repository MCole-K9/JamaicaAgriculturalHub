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

namespace JAHub_Winforms
{
    public partial class FrmGeneralGrantInfo : Form
    {
        public FrmGeneralGrantInfo()
        {
            InitializeComponent();
        }
        

        private void lbllinkclickhere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Grantinfo grantinfo = new Grantinfo();

            grantinfo.ExpiryDate = "23/12/20";
            grantinfo.Title = "Sagicor";
            grantinfo.GrantDescription = " At Sagicor we Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

            FrmGrantDetails form1 = new FrmGrantDetails(grantinfo);
            // form1.MdiParent = this.MdiParent;
            form1.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Grantinfo grantinfo = new Grantinfo();
            grantinfo.ExpiryDate = "23/02/22";
            grantinfo.Title = "RADA";
            grantinfo.GrantDescription = " At RADA we Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";


            FrmGrantDetails form1 = new FrmGrantDetails(grantinfo);
            form1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Grantinfo grantinfo = new Grantinfo();
            grantinfo.ExpiryDate = "23/11/24";
            grantinfo.Title = "Scotia";
            grantinfo.GrantDescription = " At Scotia we Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

            FrmGrantDetails form1 = new FrmGrantDetails(grantinfo);
            form1.Show();
        }
    }
}
