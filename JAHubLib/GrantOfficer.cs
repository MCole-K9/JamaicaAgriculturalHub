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
        string AgencyName { get; set; }
        int GrantOfficerId { get; set; }

        public int CreateGrant(Grantinfo grantinfo)
        {

            //  grantinfo.ID = ;
            string query = $"INSERT INTO [Grant] ( Description,Requirement,Deadline,Application,GrantOfficer)" +
                    $"Values ( '{grantinfo.GrantDescription}', {grantinfo.Requirement}, {grantinfo.ExpiryDate}, '',{GrantOfficerId})";

       

       /* public bool isLoggedin = true;
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


            SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            int i = cmd.ExecuteNonQuery();

            return i;

            }

        }*/

            public int CreateGrant(Grantinfo grantinfo)
             {
                
                string query = $"INSERT INTO [Grant] ( Description,Requirements,Deadline,GrantOfficer)" +
                        $"Values ( '{grantinfo.GrantDescription}', '{grantinfo.Requirement}', {grantinfo.ExpiryDate.ToString("yyyy-mm-dd")},'{grantinfo.GrantOfficerId}')";

                Utilities.executeInputQuery(query);



                return 1;

             }
        }
    }


            }
            return grantinfo.GrantOfficerId;
        }



    }
}
}
