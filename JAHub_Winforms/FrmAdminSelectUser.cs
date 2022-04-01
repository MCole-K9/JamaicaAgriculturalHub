using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms
{
    public partial class FrmAdminSelectUser : Form
    {
        public FrmAdminSelectUser()
        {
            InitializeComponent();
            TopLevel = false;
        }

        private void FrmAdminSelectUser_Load(object sender, EventArgs e)
        {
            // what do you rename a datagrid's value as?
            // anyway, clear it on start

            // run the query to get user information (which is?)
            // create the relevant columns (including the button)
            // create the datatable to hold this information
            // create the query for relevant user information (which is?)
            // run the SetCurrentUser method of FrmAdminContainer with the selected userId
        }
    }
}
