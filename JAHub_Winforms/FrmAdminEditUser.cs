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
using JAHub_Winforms.Verification;

namespace JAHub_Winforms
{
    public partial class FrmAdminEditUser : Form
    {
        User _user;
        public FrmAdminEditUser(int userId)
        {
            InitializeComponent();
            TopLevel = false;

            _user = new User();
            _user.ReadFromDatabase(userId);

            // I want to show the middle initial, but it's not important rn
            lblEditUser.Text = $"Edit User: {_user.FirstName} {_user.LastName}" +
                $" (ID: {_user.UserID}; Role: {_user.UserRole})";

            flwControlsHolder.Controls.Add(new usrNameBlock(_user.FirstName, _user.MiddleName, 
                _user.LastName));
            flwControlsHolder.Controls.SetChildIndex(
                flwControlsHolder.Controls[flwControlsHolder.Controls.Count - 1], 0);
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            // run validations for the relevant controls
            // if good, run an update record function in User
            // if not good, tell them to their face
        }
    }
}
