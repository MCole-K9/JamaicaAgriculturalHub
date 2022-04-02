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
    /* TO DO
     * [x] OnLoad change title of form to show user's name and ID
     * 
     */

    public partial class FrmAdminViewModeration : Form
    {
        int _userId;
        String _name;
        String _role;

        public FrmAdminViewModeration(int userId, String name, String userRole)
        {
            InitializeComponent();
            TopLevel = false;
            _userId = userId;
            _name = name;
            _role = userRole;

            lblUserName.Text = $"{_name} (ID: {_userId}; Role: {_role})";

            // need this to pull a list of infractions
            // which means the infraction list needs to exist
            // which means db work
            //
        }

        private void FrmAdminViewModeration_Load(object sender, EventArgs e)
        {
            // set the label to the user's name and id
        }
    }
}
