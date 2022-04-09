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


            SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            int i = cmd.ExecuteNonQuery();

            return i;

        }
    }


}
