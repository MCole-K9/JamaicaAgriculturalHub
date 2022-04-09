using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace JAHubLib
{
    public class Category
    {
        int ID { get; set; }
        string CategoryName { get; set; }

        public List<Category> GetCategoryList()
        {
            List<Category> list = new List<Category>(); 

            list.Add( new Category { CategoryName = "Select Category", ID = 0 });

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = "Select * From Category";

                SqlCommand cmd = new SqlCommand(query, connection);
                

                using(SqlDataReader sqlData = cmd.ExecuteReader())
                {
                    while (sqlData.Read())
                    {
                        list.Add(new Category {ID = (int)sqlData[0],  CategoryName = sqlData[1].ToString() });
                    }
                }

            }
            return list;
        }
    }
}
