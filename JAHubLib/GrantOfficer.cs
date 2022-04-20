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

        public static int FetchGrantOfficerID(int userid)
        {
            int grantOId = 0;
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = $"SELECT ID FROM [GrantOfficer] WHERE UserID = {userid}";

                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader sqlData = cmd.ExecuteReader();

                while (sqlData.Read())
                {
                    grantOId = (int)sqlData["ID"];


                }
                sqlData.Close();

            }
            return grantOId;
        }

        public int CreateGrant(Grantinfo grantinfo)
        {
            string query = $"INSERT INTO [Grant] ( Title,Description,Requirements,Deadline,GrantOfficer)" +
                    $"Values ( '{grantinfo.Title}','{grantinfo.GrantDescription}', '{grantinfo.Requirement}', {grantinfo.ExpiryDate.ToString("yyyy-mm-dd")},'{grantinfo.GrantOfficerId}')";

            Utilities.executeInputQuery(query);
            return 1;

        }

     
    }
}



