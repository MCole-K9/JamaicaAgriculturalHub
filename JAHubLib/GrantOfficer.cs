using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using JAHubLib;

namespace JAHubLib
{

    public class GrantOfficer : User
    {

        private string agencyName;
        private int grantofficerId;
       public string AgencyName
        {
            get { return agencyName; }  
            set { agencyName = value; } 
        }
        public int GrantOfficerId
        {
            get { return grantofficerId; }  
            set { grantofficerId = value; } 
        }
       

       


        public bool isLoggedin = true;
        public void FetchGrantOfficerID()
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = isLoggedin ? $"SELECT * FROM [User] WHERE ID = {Session.UserId}" : $"SELECT * FROM User WHERE ID = {this.GrantOfficerId}";

                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader sqlData = cmd.ExecuteReader();

                while (sqlData.Read())
                {
                    this.GrantOfficerId = (int)sqlData["ID"];


                }
                sqlData.Close();

            }

        }

            public int CreateGrant(Grantinfo grantinfo)
             {
                
                string query = $"INSERT INTO [Grant] ( Description,Requirements,Deadline,GrantOfficer)" +
                        $"Values ( '{grantinfo.GrantDescription}', '{grantinfo.Requirement}', {grantinfo.ExpiryDate.ToString("yyyy-mm-dd")},'{grantinfo.GrantOfficerId}')";

                Utilities.executeInputQuery(query);



                return 1;

             }


         public static int FetchGrantOfficerID(int userid)
        {
            int grantOId = 0;
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query =  $"SELECT ID FROM [GrantOfficer] WHERE UserID = {userid}" ;

                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader sqlData = cmd.ExecuteReader();

                while (sqlData.Read())
                {
                    grantOId= (int)sqlData["ID"];


                }
                sqlData.Close();

            }
            return grantOId;
        }
    }
}
