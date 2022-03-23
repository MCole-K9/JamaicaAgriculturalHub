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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* This needs to:
             * - Lock all controls in parent *except this box* until user/pass is filled
             * - take the entered credentials from a user
             * - check the credentials against a database
             * - if match:
             *  - create some kind of indicator of session (ID, Role)
             *      - ID and Role must be globally accessible
             *  - unlock all controls
             *  - show controls according to user role
             * - if !match, advise the user accordingly
             *  - could potentially have a "3 strikes and you're out" policy, this is secondary
             * 
             */
        }
    }
}
