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
    public partial class FrmRadaStatus : Form
    {
        public FrmRadaStatus()
        {
            InitializeComponent();
        }

        private void FrmRadaStatus_Load(object sender, EventArgs e)
        {
            /* This needs to:
             * - Take userId from Session
             * - run a query to see if farmer record exists
             * - if the record exists, check for rada status
             * - if Radastatus == RadaRegistrationType.NotRegistered
             *     - change lblStatusType to say "Not Registered"
             *     - make "Click here to..." button visible
             *     - set lblStatusExplanation to say "You are not presently registered with... and
             *      cannot..." or something
             * if Rada status == RadaRegistrationType.AwaitingVerification
             *     - change lblStatusType to say "Awaiting Verification"
             *     - set lblStatusExplanation to say "Your details have been recorded, please wait
             *     until you are visited by so-and-so"
             * if RadaStatus == RadaRegistrationType.NotConnected
             *     - change lblStatusExplanation to "Awaiting Connection"
             *     - set lblStatusExplanation to say "Please wait while your account details are 
             *     transferred from your previous RADA application to this account"
             * if RadaStatus == RadaRegistrationType.FullyConnected
             *     - change lblStatusExplanation to "Fully Connected"
             *     - set lblStatusExplanation to say "Your Account is Fully Connected"
             *     - make the boxes of Details visible, set to "Not edit"
             */
        }
    }
}
