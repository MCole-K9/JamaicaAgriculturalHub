using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace JAHub_Winforms.Moderation
{
    public partial class usrInfractionAdder : UserControl
    {
        DataTable addedInfractions;
        int userId;
        int adminId;

        public usrInfractionAdder(DataTable addedInfractions, int userId, int adminId)
        {
            InitializeComponent();

            // This should get a reference to the control it sits within and the datatable it corresponds to
            // 
        }

        private void usrInfractionEntry_Load(object sender, EventArgs e)
        {
            SqlDateTime currentTime = new SqlDateTime(DateTime.Now);
            lblTimeStamp.Text = currentTime.ToString();
            
            // This needs to generate the SqlDatetime of now, then represent that information as a
            // string and set the value of the XXXX shit to that

            // 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // This should add the 
        }
    }
}
