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
    /* TO DO
     * [] OnLoad change title of form to show user's name and ID
     * 
     */

    public partial class FrmAdminViewModeration : Form
    {
        int _userId;

        public FrmAdminViewModeration(int userId)
        {
            InitializeComponent();
            TopLevel = false;
            _userId = userId;
        }

        private void FrmAdminViewModeration_Load(object sender, EventArgs e)
        {
            // set the label to the user's name and id
        }
    }
}
