using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using JAHubLib;

namespace JAHub_Winforms
{
    public partial class FrmUpdateGender : Form
    {
        public FrmUpdateGender()
        {
            InitializeComponent();
        }

        private void FrmUpdateGender_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select Gender from [dbo].[User] where ID = " + Session.UserId, connection);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    //lblDisplaysUserName.Text = sdr.GetValue(0).ToString();
                    if(sdr.GetValue(0).ToString()== "Male")
                    {
                        rbtnMale.Checked = true;
                        rbtnFemale.Checked = false;
                        rbtnratherNotSay.Checked = false;
                    }
                    else if(sdr.GetValue(0).ToString() == "Female")
                    {
                        rbtnFemale.Checked = true;
                        rbtnratherNotSay.Checked = false;
                        rbtnMale.Checked = false;
                    }
                    else
                    {
                        rbtnratherNotSay.Checked = true;
                        rbtnMale.Checked = false;
                        rbtnFemale.Checked = false;
                    }
                    //if (sdr.GetValue(0).ToString() == "Rather Not Say")
                    //{
                    //    rbtnratherNotSay.Checked = true;
                    //    rbtnMale.Checked = false;
                    //    rbtnFemale.Checked = false;
                    //}

                    //txtUpdateLastName.Text = sdr.GetValue(2).ToString();
                }
                sdr.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String Gender = "";
            if (rbtnMale.Checked == true)
            {
                Gender = "Male";
            }
            if (rbtnFemale.Checked == true)
            {
                Gender = "Female";
            }
            if (rbtnratherNotSay.Checked == true)
            {
                Gender = "Rather Not Say";
            }

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                String sqlquery = $"UPDATE [dbo].[User] SET Gender = '{Gender}'  WHERE ID = '{ Session.UserId}'";

                connection.Open();
                SqlCommand sqlcmd = new SqlCommand(sqlquery, connection);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your Gender was changed successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //connection.Close();
                this.Close();
            }
           
        }
    }
}
