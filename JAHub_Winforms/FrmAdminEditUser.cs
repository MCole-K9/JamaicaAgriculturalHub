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
    public partial class FrmAdminEditUser : Form
    {
        User _user;
        public FrmAdminEditUser(int userId)
        {
            InitializeComponent();
            TopLevel = false;

            _user = new User();
            _user.ReadFromDatabase(userId);
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            // run validations for the relevant controls
            // if good, run an update record function in User
            // if not good, tell them to their face
        }
    }
}
