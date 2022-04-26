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

namespace JAHub_Winforms
{
    public partial class FrmViewAllMyApplication : Form
    {
     
        public FrmViewAllMyApplication()
        {
           
            InitializeComponent();

        }

        public void ReadFromDatabase(int grantofficerID)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                
               /// grantinfo.ViewAllMyGrants();
                connection.Open();
                Grantinfo grantinfo = new Grantinfo();

                // fetch GrantOfficer Table ID

                String query = $"SELECT * FROM [Grant] WHERE GrantOfficer = {grantofficerID}";


                SqlCommand cmd = new SqlCommand(query, connection);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    grantinfo.ID =(int)reader["ID"];;
                    grantinfo.requirement = reader["Requirements"].ToString();
                    grantinfo.GrantDescription = reader["Description"].ToString();
                    grantinfo.ExpiryDate = (DateTime)reader["Deadline"];
                    grantinfo.Application_Form = reader["Application_Form"].ToString();
                    grantinfo.GrantOfficerId = (int)reader["GrantOfficer"];
                    grantinfo.Title = reader["Title"].ToString();

                    Grant_Controls.UserControlDisplayGrant userControlDisplayGrant = new Grant_Controls.UserControlDisplayGrant(grantinfo);
                    pnlContainerAdminViewGrants.Controls.Add(userControlDisplayGrant);
                    userControlDisplayGrant.Dock = DockStyle.Top;
                }

                connection.Close();
            }
        }

        private void FrmViewAllMyApplication_Load(object sender, EventArgs e)
        {
            Size = new Size(1102, 1200);
            Grantinfo grantinfo = new Grantinfo();
            grantinfo.GrantOfficerId = GrantOfficer.FetchGrantOfficerID(Session.UserId);

            ReadFromDatabase(grantinfo.GrantOfficerId);
        }

        private void btnViewAllMyGrants_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen(" FrmViewAllMyApplication"))
            {

                FrmViewAllMyApplication frmViewAllMyApplication = new FrmViewAllMyApplication();
                frmViewAllMyApplication.MdiParent = this.MdiParent;
                frmViewAllMyApplication.Show();
            }
            else
            {
                foreach (var form in this.MdiParent.MdiChildren)
                {
                    if (form.Text == "FrmViewAllMyApplication")
                    {
                        form.BringToFront();
                    }
                }
            }
        }

        private void btngrantcreate_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen(" FrmCreateGrant"))
            {

                FrmCreateGrant frmCreateGrant = new FrmCreateGrant();
                frmCreateGrant.MdiParent = this.MdiParent;
                frmCreateGrant.Show();
            }
            else
            {
                foreach (var form in this.MdiParent.MdiChildren)
                {
                    if (form.Text == "FrmCreateGrant")
                    {
                        form.BringToFront();
                    }
                }
            }
            
        }

        private void btnDeleteGrant_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen(" FrmViewAllMyApplication"))
            {

                FrmViewAllMyApplication frmViewAllMyApplication = new FrmViewAllMyApplication();
                frmViewAllMyApplication.MdiParent = this.MdiParent;
                frmViewAllMyApplication.Show();
            }
            else
            {
                foreach (var form in this.MdiParent.MdiChildren)
                {
                    if (form.Text == "FrmViewAllMyApplication")
                    {
                        form.BringToFront();
                    }
                }
            }
        }

        private void btnUpdateGrant_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen(" FrmViewAllMyApplication"))
            {

                FrmViewAllMyApplication frmViewAllMyApplication = new FrmViewAllMyApplication();
                frmViewAllMyApplication.MdiParent = this.MdiParent;
                frmViewAllMyApplication.Show();
            }
            else
            {
                foreach (var form in this.MdiParent.MdiChildren)
                {
                    if (form.Text == "FrmViewAllMyApplication")
                    {
                        form.BringToFront();
                    }
                }
            }
           
        }
    }
}
