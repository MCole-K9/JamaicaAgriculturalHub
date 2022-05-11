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

            // These are all for dtbAddedInfractions
            dtbAddedInfractions = new DataTable();

            DataColumn dclAddedInfractionTime = new DataColumn();
            dclAddedInfractionTime.ColumnName = "TimeStamp";
            dclAddedInfractionTime.DataType = typeof(SqlDateTime);

            DataColumn dclAddedInfractionUser = new DataColumn();
            dclAddedInfractionUser.ColumnName = "User";
            dclAddedInfractionUser.DataType = typeof(int);

            DataColumn dclAddedInfractionAdmin = new DataColumn();
            dclAddedInfractionAdmin.ColumnName = "Admin";
            dclAddedInfractionAdmin.DataType = typeof(int);

            DataColumn dclAddedInfractionReason = new DataColumn();
            dclAddedInfractionReason.ColumnName = "Reason";
            dclAddedInfractionReason.DataType = typeof(String);
            dclAddedInfractionReason.MaxLength = 120;

            dtbAddedInfractions.Columns.Add(dclAddedInfractionTime);
            dtbAddedInfractions.Columns.Add(dclAddedInfractionUser);
            dtbAddedInfractions.Columns.Add(dclAddedInfractionAdmin);
            dtbAddedInfractions.Columns.Add(dclAddedInfractionReason);


            // This is just for dtbRemovedInfraction
            dtbRemovedInfractions = new DataTable();

            DataColumn dclRemovedInfractionId = new DataColumn();
            dclRemovedInfractionId.ColumnName = "ID";
            dclRemovedInfractionId.DataType = typeof(int);

            dtbRemovedInfractions.Columns.Add(dclRemovedInfractionId);
                       
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

                String command = $"SELECT ID, TimeStamp, Admin, Reason FROM [Infraction] WHERE [User] = {_userId};";

                SqlCommand infractionsQuery = new SqlCommand (command, connection);

                SqlDataReader reader = infractionsQuery.ExecuteReader();

                while (reader.Read())
                {
                    dtbCurrentInfractions.Rows.Add(reader["ID"], reader["TimeStamp"], reader["Admin"].ToString(),
                        reader["Reason"].ToString());
                }

                connection.Close();
            }
            if (dtbCurrentInfractions.Rows.Count > 0)
            {
                // This just gets rid of the placeholder text that says "user has no infractions"
                flpInfractionsHolder.Controls.RemoveAt(Controls.Count - 1);
                
                foreach (DataRow row in dtbCurrentInfractions.Rows)
                {
                    flpInfractionsHolder.Controls.Add(new usrInfractionItem(row, flpInfractionsHolder, dtbRemovedInfractions));
                }
            }

            
        }

        private void btnAddInfraction_Click(object sender, EventArgs e)
        {
            if (flpInfractionsHolder.Controls.Contains(lblNoInfractions))
            {
                flpInfractionsHolder.Controls.Remove(lblNoInfractions);
            }

            flpInfractionsHolder.Controls.Add(new usrInfractionAdder(dtbAddedInfractions, _userId, Session.UserId, flpInfractionsHolder));
        }

        private void FrmAdminViewModeration_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Writing the new entries to the Database
            if (dtbAddedInfractions.Rows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {
                    connection.Open();
                    String command = "INSERT INTO Infraction (TimeStamp, Infraction.[User], Infraction.[Admin], Reason) VALUES ";

                    foreach (DataRow row in dtbAddedInfractions.Rows)
                    {
                        if (row[3].ToString().Contains('\''))
                        {
                            String replacementValue = row[3].ToString().Replace("\'", "''");
                            row[3] = replacementValue;
                        }
                        
                        command += $"('{row[0]}', {row[1]}, {row[2]}, '{row[3]}')";


                        if(dtbAddedInfractions.Rows.IndexOf(row) == dtbAddedInfractions.Rows.Count - 1)
                        {
                            command += ";";
                        }
                        else
                        {
                            command += ", ";
                        }
                    }

                    //command.Replace(" '", "''");
                    //command.Replace("\"", "\\" + "\"");

                    SqlCommand addNewInfractions = new SqlCommand(command, connection);

                    addNewInfractions.ExecuteNonQuery();

                    connection.Close();
                }
            }

            // Removing the old entries from the database
            if(dtbRemovedInfractions.Rows.Count > 0)
            {
                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {
                    connection.Open();

                    String command = "DELETE FROM Infraction WHERE ID in (";

                    foreach(DataRow row in dtbRemovedInfractions.Rows)
                    {
                        command += $"{row[0]}";

                        if(dtbRemovedInfractions.Rows.IndexOf(row) == dtbRemovedInfractions.Rows.Count - 1)
                        {
                            command += ");";
                        }
                        else
                        {
                            command += ",";
                        }
                    }

                    SqlCommand removeDeletedInfractions = new SqlCommand (command, connection);

                    removeDeletedInfractions.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }
    }
}
