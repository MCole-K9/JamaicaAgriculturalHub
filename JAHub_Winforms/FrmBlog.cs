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
    public partial class FrmBlog : Form
    {
        public FrmBlog()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Blog", connection);
            connection.Open();
            SqlDataReader sqlData = cmd.ExecuteReader();
            // TODO: Reminder to use the "Task List" Feature more in VS
            Utils.DisplayBlogsFromDatabase(sqlData, pnlContainer);
            connection.Close();
        }

        private void btnCreateBlog_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen("FrmCreateBlog"))
            {

                FrmCreateBlog createBlog = new FrmCreateBlog();
                createBlog.MdiParent = this.MdiParent;
                createBlog.Show();
            }
            else
            {
                foreach (var form in this.MdiParent.MdiChildren)
                {
                    if (form.Text == "FrmCreateBlog")
                    {
                        form.BringToFront();
                    }
                }
            }
            
        }

        private void btnMyBlogs_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen("FrmUserBlogs"))
            {

                FrmUserBlogs userBlogs = new FrmUserBlogs();
                userBlogs.MdiParent = this.MdiParent;
                userBlogs.Show();
            }
            else
            {
                foreach (var form in this.MdiParent.MdiChildren)
                {
                    if (form.Text == "FrmUserBlogs")
                    {
                        form.BringToFront();
                    }
                }
            }
        }

        private void btnBlogs_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen("FrmBlog"))
            {
                FrmBlog blogs = new FrmBlog();
                blogs.MdiParent = this.MdiParent;
                blogs.Show();
            }
            else
            {
                foreach (var form in this.MdiParent.MdiChildren)
                {
                    if (form.Text == "FrmBlog")
                    {
                        form.BringToFront();
                    }
                }
            }
        }

        private void pnlContainer_ClientSizeChanged(object sender, EventArgs e)
        {
            pnlContainer.Padding = new Padding(0, 0, 0, 0);
        }

        private void btnSearchBar_Click(object sender, EventArgs e)
        {
            Utils.ClearPanel(pnlContainer);
            if (txtSearchBar.Text != "")
            {
                SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
                connection.Open();
                SqlCommand SearchCmd = new SqlCommand($"SELECT * FROM [Blog] WHERE Title LIKE '%{txtSearchBar.Text}%'", connection);;
                SqlDataReader reader = SearchCmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Utils.DisplayBlogsFromDatabase(reader, pnlContainer);
                }
                else
                {
                    MessageBox.Show("No Results Found");
                }
                connection.Close();
            }
        }

        private void txtSearchBar_Enter(object sender, EventArgs e)
        {
            btnSearchBar.Enabled = true;
        }

        private void comboSort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Utils.ClearPanel(pnlContainer);
            SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
            connection.Open();
            SqlCommand SortCmd = new SqlCommand();
            SortCmd.Connection = connection;
            if (comboSort.SelectedItem.ToString() == "A-Z")
            {
                SortCmd.CommandText = "EXEC SortBlogsAscending";
            }
            else if (comboSort.SelectedItem.ToString() == "Z-A")
            {
                SortCmd.CommandText = "EXEC SortBlogsDescending";
            }
            else if (comboSort.SelectedItem.ToString() == "Rating")
            {
                SortCmd.CommandText = "EXEC SortBlogsRating";
            }
            else if (comboSort.SelectedItem.ToString() == "Latest")
            {
                SortCmd.CommandText = "EXEC SortBlogsNewest";
            }
            else if (comboSort.SelectedItem.ToString() == "Oldest")
            {
                SortCmd.CommandText = "EXEC SortBlogsOldest";
            }
            SqlDataReader reader = SortCmd.ExecuteReader();
            Utils.DisplayBlogsFromDatabase(reader, pnlContainer);
            connection.Close();
        }
    }
}
