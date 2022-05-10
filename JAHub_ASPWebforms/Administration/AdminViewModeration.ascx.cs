using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using JAHubLib;
using JAHub_ASPWebforms.Administration;

namespace JAHub_ASPWebforms.Administration
{
    public partial class AdminViewModeration : System.Web.UI.UserControl
    {
        private int currentIndex = 0;

        protected override void OnInit(EventArgs e)
        {
            Page.RegisterRequiresControlState(this);
            base.OnInit(e);
        }

        protected override object SaveControlState()
        {
            return currentIndex == 0 ? null : (object)currentIndex;
        }

        protected override void LoadControlState(object state)
        {
            if (state != null)
            {
                currentIndex = (int)state;
            }
        }


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
            dsInfractions.SelectParameters["UserId"].DefaultValue = this.UserId.ToString();
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {

            // if the list of controls is empty it should probably just show 
            //if (rptUserInfractions.Items.Count == 0)
            //{
            //    lblNoInfractions.Visible = true;
            //}
        }

        public AdminViewModeration()
        {
            
        }

        protected void btnAddInfraction_Click(object sender, EventArgs e)
        {
            if (phUserInfractions.Controls.Count < 1)
            {
                usrAddInfraction infraction = (usrAddInfraction)LoadControl("~/Administration/usrAddInfraction.ascx");

                // AddInfraction needs to insert UserId
                infraction.UserId = this.UserId;

                phUserInfractions.Controls.Add(infraction);
            }
        }

        protected void rptUserInfractions_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                usrInfractionItem item = (usrInfractionItem)e.Item.FindControl("admUserInfraction");

                DataRowView drvItem = e.Item.DataItem as DataRowView;

                DataRow itemRow = drvItem.Row;

                // Inserting the values for each part of the row
                item.Reason = "Reason: " + itemRow["Reason"].ToString();
                item.ID = itemRow["ID"].ToString();
                item.RecordId = Int32.Parse(itemRow["ID"].ToString());
                item.AddedBy = "Added By ID: " + itemRow["Admin"].ToString();
                item.DateOfEntry = itemRow["TimeStamp"].ToString();
            }
        }
    }
}