using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Configuration;
using System.Data.SqlClient;
using JAHubLib;

namespace JAHub_Winforms
{
    public partial class FrmUpdateName : Form
    {
        

        public FrmUpdateName()
        {
            InitializeComponent();
        }

        

        private void FrmUpdateName_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
            connection.Open();
            SqlCommand cmd = new SqlCommand("select FirstName, MiddleName, LastName from  [dbo].[User] where ID = " + Session.UserId ,connection);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtUpdateFirstName.Text = sdr.GetValue(0).ToString();
                txtUpdateLastName.Text = sdr.GetValue(2).ToString();   
            }
            connection.Close();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUpdateFirstName_Click(object sender, EventArgs e)
        {

            btnFName.FlatAppearance.BorderColor = Color.Blue;
                
         }

        private void txtUpdateLastName_Click(object sender, EventArgs e)
        {
            btnLName.FlatAppearance.BorderColor = Color.Blue;   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtUpdateFirstName.Text == "")
            {
                //errorProviderFirstName.SetIconAlignment(txtUpdateFirstName, ErrorIconAlignment.MiddleRight);
               errorProviderFirstName.SetError(txtUpdateFirstName, "Please enter Name to be updated.");
            }
            else if(txtUpdateLastName.Text == "")
            {
                //errorProviderFirstName.SetIconAlignment(txtUpdateFirstName, ErrorIconAlignment.MiddleRight);
                errorProviderLastName.SetError(txtUpdateLastName, "Please enter Name to be updated.");
                
            }
            else
            {
                errorProviderFirstName.Clear();
                errorProviderLastName.Clear();

                SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
                String sqlquery = "UPDATE [dbo].[User] SET FirstName = '" + txtUpdateFirstName.Text +"', LastName = '" + txtUpdateLastName.Text + "' WHERE ID = "+ Session.UserId;

                connection.Open();
                SqlCommand sqlcmd = new SqlCommand(sqlquery, connection);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your Name was changed successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                this.Close();


            }
        }
    }
}
