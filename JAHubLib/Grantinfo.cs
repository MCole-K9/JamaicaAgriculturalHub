using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAHubLib;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace JAHubLib
{
    public class Grantinfo : User
    {

        private string grantDescription;
        private string title;
        public string filename;
        public string requirement;
        private DateTime expiryDate;
        private string filePath;
        private int application_Form;



        public string GrantDescription { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Requirement { get; set; }
        public string Application_Form { get; set; }
        public int GrantOfficerId { get; set; }
        public string FilePath { get; set; }
        public int ID { get; set; }
        

       // Grantinfo grantinfo = new Grantinfo(); 
        public Grantinfo()
        {
            GrantDescription = "";
            Title = "";
            FileName = "";
            requirement = "";
            ExpiryDate = DateTime.Now;
            ID = 0;
            Application_Form = "";
            GrantOfficerId = 0;
            FilePath = "";
            
        }


        public Grantinfo(string grantDescription, string title, string filename, DateTime expirydate, int id)
        {
            this.GrantDescription = grantDescription;
            this.Title = title;
            this.FileName = filename;
            this.ExpiryDate = expirydate;
            this.ID = id;
        }

        public Grantinfo(Grantinfo grantinfo)
        {
            this.GrantDescription = grantinfo.GrantDescription;
            this.Title = grantinfo.Title;
            this.FileName = grantinfo.FileName;
            this.ExpiryDate = grantinfo.ExpiryDate;
            this.Application_Form = grantinfo.Application_Form;
            this.GrantOfficerId = grantinfo.GrantOfficerId;
            this.ID=grantinfo.ID;   
            this.GrantOfficerId = grantinfo.GrantOfficerId; 
            
        }


        public void DeleteGrant(int userID)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                Grantinfo grantinfo = new Grantinfo();
               
                connection.Open();
                string query = $" Delete FROM [Grant] WHERE ID = {userID}";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader sqlRead = cmd.ExecuteReader();

                {
                    while (sqlRead.Read())
                    {
                        
                        grantinfo.ID = (int)sqlRead["ID"];
                        grantinfo.GrantDescription = sqlRead["Description"].ToString();
                        grantinfo.Requirement = sqlRead["Requirements"].ToString();
                        grantinfo.ExpiryDate = (DateTime)sqlRead["Deadline"];
                        grantinfo.Application_Form = sqlRead["Application_Form"].ToString();
                        grantinfo.GrantOfficerId = (int)sqlRead["GrantOfficer"];
                        grantinfo.Title = sqlRead["Title"].ToString();

                    }
                }

            }
        }

        public void UpdateGrant(int userID)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                Grantinfo grantinfo = new Grantinfo();

                connection.Open();
                string query = $" UPDATE [Grant] SET Description = '{grantinfo.GrantDescription}', Requirements = '{grantinfo.Requirement}', Deadline = {grantinfo.ExpiryDate.ToString("yyyy-mm-dd")},Application_Form = '{grantinfo.Application_Form}' WHERE ID = {userID}";
                SqlCommand cmd = new SqlCommand(query, connection);
               SqlDataAdapter adapter = new SqlDataAdapter(cmd);

               DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cmd.ExecuteNonQuery();

                }

            }

        public string uploadfile( string filename)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt | *.txt";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Grantinfo grantinfo = new Grantinfo();
                grantinfo.FilePath = openFileDialog.FileName;
                grantinfo.FileName = openFileDialog.SafeFileName;

                Utilities.FTPFileUpload(grantinfo.FilePath, grantinfo.FileName);

                filename = grantinfo.FileName; 
            }
            return filename;
        }



        public int FetchGrantApplication(int grantapplication)
        {
                Grantinfo grantinfo = new Grantinfo();
          
                int grantApplication = 0;
                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {
                    connection.Open();

                    string query = $"SELECT Application_Form FROM [Grant_application] WHERE Application_Form = {grantapplication}";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    SqlDataReader sqlData = cmd.ExecuteReader();

                    while (sqlData.Read())
                    {
                        grantApplication = (int)sqlData["Application_Form"];


                    }
                    sqlData.Close();

                }
                return grantapplication;
            
        }

        public int CreateApplication(string filename)
        {
            Grantinfo grantinfo = new Grantinfo();
            grantinfo.FileName=filename;    
            string query = $"INSERT INTO [Grant] (FileName,)" +
                    $"Values ( '{grantinfo.FileName}')";

            Utilities.executeInputQuery(query);
            return 1;

        }
        public int CreateGrant(Grantinfo grantinfo)
        {
            string query = $"INSERT INTO [Grant] ( Title,Description,Requirements,Application_Form,Deadline,GrantOfficer) " +
                    $"Values ( '{grantinfo.Title}','{grantinfo.GrantDescription}', '{grantinfo.Requirement}', '{grantinfo.FileName}', {grantinfo.ExpiryDate.ToString("dd-MM-yyyy")},{grantinfo.GrantOfficerId})";

            Utilities.executeInputQuery(query);
            return 1;

        }


    }

}




    

