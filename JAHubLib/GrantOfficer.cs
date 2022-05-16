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

       
        private int grantofficerId;
       
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

    
     
    }
}



