﻿using System;
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
using JAHub_Winforms.Moderation;

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
            dtbCurrentInfractions = new DataTable();

            DataColumn dclInfractionId = new DataColumn();
            dclInfractionId.ColumnName = "ID";
            dclInfractionId.DataType = typeof(int);

            DataColumn dclTimeStamp = new DataColumn();
            dclTimeStamp.ColumnName = "TimeStamp";
            dclTimeStamp.DataType = typeof(SqlDateTime);

            DataColumn dclAdmin = new DataColumn();
            dclAdmin.ColumnName = "Administered By";
            dclAdmin.DataType = typeof(String);

            DataColumn dclReason = new DataColumn();
            dclReason.ColumnName = "Reason/Nature of Infraction";
            dclReason.DataType = typeof(String);

            dtbCurrentInfractions.Columns.Add(dclInfractionId);
            dtbCurrentInfractions.Columns.Add(dclTimeStamp);
            dtbCurrentInfractions.Columns.Add(dclAdmin);
            dtbCurrentInfractions.Columns.Add(dclReason);

            using(SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                String command = "SELECT ID, TimeStamp, Admin, Reason FROM [Infraction]";

                SqlCommand infractionsQuery = new SqlCommand (command, connection);

                SqlDataReader reader = infractionsQuery.ExecuteReader();

                while (reader.Read())
                {
                    dtbCurrentInfractions.Rows.Add(reader["ID"], reader["TimeStamp"].ToString(), reader["Admin"].ToString(),
                        reader["Reason"].ToString());
                }

                connection.Close();
            }
            if (dtbCurrentInfractions.Rows.Count > 0)
            {
               // This just gets rid of the placeholder text that says "user has no infractions"
               flwInfractionsHolder.Controls.RemoveAt(Controls.Count - 1);
            }

            foreach (DataRow row in dtbCurrentInfractions.Rows)
            {
                flwInfractionsHolder.Controls.Add(new usrInfractionItem(row, flwInfractionsHolder, dtbRemovedInfractions));
            }
        }

        private void btnAddInfraction_Click(object sender, EventArgs e)
        {
            if (flwInfractionsHolder.Controls.Contains(lblNoInfractions))
            {
                flwInfractionsHolder.Controls.Remove(lblNoInfractions);
            }

            flwInfractionsHolder.Controls.Add(new usrInfractionAdder(dtbAddedInfractions, _userId, Session.UserId));
        }
    }
}
