using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JAHubLib
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public string PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
        public string BillingStreetAddress { get; set; }
        public string BillingCity { get; set; }
        public string BIllingParish { get; set; }

        public void FetchPaymentID()
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = "Select (ID) From [Payment]";

                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader sqlData = cmd.ExecuteReader())
                {
                    while (sqlData.Read())
                    {
                        this.PaymentID = (int)sqlData["ID"];
             
                    }
                }
            }
        }

    }
}
