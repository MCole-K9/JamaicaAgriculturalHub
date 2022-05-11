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
    public partial class FrmSignup : Form
    {
        bool isEmailValid;
        int isInt = 0;
        public FrmSignup()
        {
            InitializeComponent();

            
        }
        String Gender;
        private void FrmSignup_Load(object sender, EventArgs e)
        {
           
        }

        public bool validateFirstNameTxtbox()
        {
            
            bool chk = false;
            if (txtFirstName.Text == "")
            {
                errorProvider.SetError(txtFirstName, "Enter Your First Name");
                txtFirstName.Focus();
                chk = false;
            }
            else if(int.TryParse(txtFirstName.Text, out isInt))
            {
                errorProvider.SetError(txtFirstName, "Enter a Valid First Name");
                txtFirstName.Focus();
                chk = false;
            }
            else
            {
                errorProvider.Clear();
                chk = true;
            }
            return chk;
        }
        public bool validateMiddleNameTxtbox()
        {
            bool chk = false;
            if (txtMiddleName.Text == "")
            {
                errorProvider.SetError(txtMiddleName, "Enter Your Middle Name");
                txtMiddleName.Focus();
                chk = false;
            }
            else if (int.TryParse(txtFirstName.Text, out isInt))
            {
                errorProvider.SetError(txtMiddleName, "Enter a Valid Middle Name");
                txtFirstName.Focus();
                chk = false;
            }
            else
            {
                errorProvider.Clear();
                chk = true;
            }
            return chk;
        }
        public bool validateLastNameTxtbox()
        {
            bool chk = false;
            if (txtLastName.Text == "")
            {
                errorProvider.SetError(txtLastName, "Enter Your Last Name");
                txtLastName.Focus();
                chk = false;
            }
            else if (int.TryParse(txtFirstName.Text, out isInt))
            {
                errorProvider.SetError(txtLastName, "Enter a Valid Last Name");
                txtFirstName.Focus();
                chk = false;
            }
            else
            {
                errorProvider.Clear();
                chk = true;
            }
            return chk;
        }
        public bool CheckifEmailExist()
        {
            bool chk;
            SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
            connection.Open();
            String Sqlquery = $"select * from [dbo].[User] where EmailAddress = '{txtEmail.Text}'";
            //read on suldatareader...... check if whats in the text box is same as in the database if ture return t else return false
            SqlDataAdapter sda = new SqlDataAdapter(Sqlquery, connection);
           

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                chk = false;
                errorProvider.SetError(txtEmail, "This Email account is already a member.");
                txtEmail.Focus();
            }
            else
            {
                chk = true;
                //MessageBox.Show("Not Working");
            }
            connection.Close();
            return chk;
        }
         public bool validateEmailTxtbox()
        {
            bool chk = false;
            if (txtEmail.Text.IndexOf("@") > -1)
            {
                if (txtEmail.Text.IndexOf(".", txtEmail.Text.IndexOf("@")) > txtEmail.Text.IndexOf("@"))
                {
                    txtEmail.CharacterCasing = CharacterCasing.Lower;
                    errorProvider.SetError(txtEmail, "");

                    isEmailValid = true;
                    chk = true;
                }
            }
            else if (txtEmail.Text == "")
            {
                errorProvider.SetIconAlignment(txtEmail, ErrorIconAlignment.MiddleRight);
                errorProvider.SetError(txtEmail, "Field Cannot be Blank");

                isEmailValid = false;
                chk = false; 
            }

            else
            {
                errorProvider.SetIconAlignment(txtEmail, ErrorIconAlignment.MiddleRight);
                errorProvider.SetError(txtEmail, "Must be a valid email, e.g. someone@example.com");

                isEmailValid = false;
                chk = false;
            }
            return chk;
        }
        public bool validatePasswordTxtbox()
        {
            bool chk = false;
            if (txtPassword.Text == "")
            {
                errorProvider.SetError(txtPassword, "Enter A Password");
                txtPassword.Focus();
                chk = false;
            }
            else
            {
                errorProvider.Clear();
                chk = true;
            }
            return chk;
        }
        public bool validateConfirmPasswordTxtbox()
        {
            bool chk = false;
            if (txtConfirmPassword.Text == "")
            {
                errorProvider.SetError(txtConfirmPassword, "Re-Enter Password"); ////reword
                txtPassword.Focus();
                chk = false;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider.SetError(txtConfirmPassword, "Password Not Matched");
                chk = false;
            }
            else
            {
                errorProvider.Clear();
                chk = true; 
            }
            return chk;
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
           
            if (isEmailValid)
            {
                txtEmail.Text.ToLower();
            }
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
             

            if (validateFirstNameTxtbox() && validateMiddleNameTxtbox() && validateLastNameTxtbox() && validateEmailTxtbox() && CheckifEmailExist() && validatePasswordTxtbox() && validateConfirmPasswordTxtbox() == true)
            {
                //errorProvider.Clear();
                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SignupUser", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@EmailAddress", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtConfirmPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@UserRole", 2);
                    cmd.ExecuteNonQuery();
                    //connection.Close();
                    MessageBox.Show("Account created successfully,now login with your cridentials.","Signup Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmLogin login = new FrmLogin();
                    login.MdiParent = this.MdiParent;
                    login.Show();
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Failed to Create Account","Unsuccessful",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }



        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.MdiParent = this.MdiParent;
            login.Show();
            this.Close();
        }

        
    }
}
