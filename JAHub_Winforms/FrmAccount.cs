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
using System.Data.SqlClient;

namespace JAHub_Winforms
{
    public partial class FrmAccount : Form
    {
       
        public FrmAccount()
        {
            InitializeComponent();
            
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select FirstName+ ' ' +LastName as FullName, Gender from [dbo].[User] where ID = " + Session.UserId, connection);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    lblDisplaysUserName.Text = sdr.GetValue(0).ToString();
                    lblDiaplayGender.Text = sdr.GetValue(1).ToString();
                }
                sdr.Close();
            } 
           
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {

            FrmUpdateName frmUpdateName = new FrmUpdateName();
            frmUpdateName.MdiParent = this.MdiParent;
            frmUpdateName.Show();
        }

        private void btnUpdateGender_Click(object sender, EventArgs e)
        {
            FrmUpdateGender frmUpdateGender = new FrmUpdateGender();
            frmUpdateGender.MdiParent = this.MdiParent;
            frmUpdateGender.Show();
        }
    }
}
