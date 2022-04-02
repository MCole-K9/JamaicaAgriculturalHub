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
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace JAHub_Winforms
{
    public partial class FrmAdminViewModeration : Form
    {
        DataTable dtbCurrentInfractions;
        DataTable dtbAddedInfractions;
        DataTable dtbRemovedInfractions;

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
        }

        private void FrmAdminViewModeration_Load(object sender, EventArgs e)
        {
            // This will primarily set up the db schema and populate it

            // These are all for dtbCurrentInfractions
            DataColumn dclTimeStamp = new DataColumn();
            dclTimeStamp.ColumnName = "TimeStamp";
            dclTimeStamp.DataType = typeof(SqlDateTime);

            DataColumn dclAdmin = new DataColumn();
            dclAdmin.ColumnName = "Administered By";
            dclAdmin.DataType = typeof(String);

            DataColumn dclReason = new DataColumn();
            dclReason.ColumnName = "Reason/Nature of Infraction";
            dclReason.DataType = typeof(String);

            dtbCurrentInfractions.Columns.Add(dclTimeStamp);
            dtbCurrentInfractions.Columns.Add(dclAdmin);
            dtbCurrentInfractions.Columns.Add(dclReason);

            // run the query through the connection to populate the table
            // run the foreach loop to add each infraction
        }
    }
}
