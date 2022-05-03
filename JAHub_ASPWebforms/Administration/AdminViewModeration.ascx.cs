﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using JAHubLib;

namespace JAHub_ASPWebforms.Administration
{
    public partial class AdminViewModeration : System.Web.UI.UserControl
    {

        public int UserId
        {
            get
            {
                return ViewState["ModerationUserId"] == null ? 0 : (int)ViewState["ModerationUserId"];
            }
            set
            {
                ViewState["ModerationUserId"] = value;
            }
        }
        public String Name
        {
            get
            {
                return ViewState["ModerationUserFullName"] == null ? 
                    String.Empty : (String)ViewState["ModerationUserFullName"];
            }
            set {
                ViewState["ModerationUserFullName"] = value; 
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            //DataTable dtbAddedInfractions = new DataTable();

            //DataColumn dclAddedInfractionTime = new DataColumn();
            //dclAddedInfractionTime.ColumnName = "TimeStamp";
            //dclAddedInfractionTime.DataType = typeof(SqlDateTime);

            //DataColumn dclAddedInfractionUser = new DataColumn();
            //dclAddedInfractionUser.ColumnName = "User";
            //dclAddedInfractionUser.DataType = typeof(int);

            //DataColumn dclAddedInfractionAdmin = new DataColumn();
            //dclAddedInfractionAdmin.ColumnName = "Admin";
            //dclAddedInfractionAdmin.DataType = typeof(int);

            //DataColumn dclAddedInfractionReason = new DataColumn();
            //dclAddedInfractionReason.ColumnName = "Reason";
            //dclAddedInfractionReason.DataType = typeof(String);
            //dclAddedInfractionReason.MaxLength = 120;

            //dtbAddedInfractions.Columns.Add(dclAddedInfractionTime);
            //dtbAddedInfractions.Columns.Add(dclAddedInfractionUser);
            //dtbAddedInfractions.Columns.Add(dclAddedInfractionAdmin);
            //dtbAddedInfractions.Columns.Add(dclAddedInfractionReason);


            //// This is just for dtbRemovedInfraction
            //DataTable dtbRemovedInfractions = new DataTable();

            //DataColumn dclRemovedInfractionId = new DataColumn();
            //dclRemovedInfractionId.ColumnName = "ID";
            //dclRemovedInfractionId.DataType = typeof(int);

            //dtbRemovedInfractions.Columns.Add(dclRemovedInfractionId);

            //// These are all for dtbCurrentInfractions
            //DataTable dtbCurrentInfractions = new DataTable();

            //DataColumn dclInfractionId = new DataColumn();
            //dclInfractionId.ColumnName = "ID";
            //dclInfractionId.DataType = typeof(int);

            //DataColumn dclTimeStamp = new DataColumn();
            //dclTimeStamp.ColumnName = "TimeStamp";
            //dclTimeStamp.DataType = typeof(SqlDateTime);

            //DataColumn dclAdmin = new DataColumn();
            //dclAdmin.ColumnName = "Administered By";
            //dclAdmin.DataType = typeof(String);

            //DataColumn dclReason = new DataColumn();
            //dclReason.ColumnName = "Reason/Nature of Infraction";
            //dclReason.DataType = typeof(String);

            //dtbCurrentInfractions.Columns.Add(dclInfractionId);
            //dtbCurrentInfractions.Columns.Add(dclTimeStamp);
            //dtbCurrentInfractions.Columns.Add(dclAdmin);
            //dtbCurrentInfractions.Columns.Add(dclReason);

            //using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            //{
            //    connection.Open();

            //    String command = "SELECT ID, TimeStamp, Admin, Reason FROM [Infraction];";

            //    SqlCommand infractionsQuery = new SqlCommand(command, connection);

            //    SqlDataReader reader = infractionsQuery.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        dtbCurrentInfractions.Rows.Add(reader["ID"], reader["TimeStamp"], reader["Admin"].ToString(),
            //            reader["Reason"].ToString());
            //    }

            //    connection.Close();
            //}

            //foreach (DataRow row in dtbCurrentInfractions.Rows)
            //{
            //    // I'd the list of infractions, probably
            //}

            // if the list of controls is empty it should probably just show 
            if(rptUserInfractions.Items.Count == 0)
            {
                // Make some thing that says "No items lol" visible
            }
        }

        public AdminViewModeration()
        {
            
        }

        protected void btnAddInfraction_Click(object sender, EventArgs e)
        {
            // why is this not showing up?
            usrAddInfraction infraction = (usrAddInfraction)LoadControl("~/Administration/usrAddInfraction.ascx");
            

            phUserInfractions.Controls.Add(infraction);
        }

        protected void rptUserInfractions_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            // not sure how to do this
        }
    }
}