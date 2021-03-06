using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Data.SqlClient;

namespace JAHubLib
{
    public static class Utilities
    {
        //Returns file path from base-directory up to Project Namespace
        public  static string GetDesktopFilePath()
        {
            String path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.Length - 25);

            return path;
        }
        public static int GetDesktopFilePathLength()
        {
            String path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.Length - 25);

            return path.Length;
        }

        public static string getConnectionString()
        {
            return "Data Source=jamaicaagriculturalhub.mssql.somee.com;Initial Catalog=jamaicaagriculturalhub;Persist Security Info=True;User ID=Ethan_Hughs_SQLLogin_1;Password=yq8mavdef8";
        }

        public static string CopyImage(string source, string fileName)
        {
            fileName = Path.GetFileName(fileName);
            string destination = Path.Combine($"{GetDesktopFilePath()}\\Images", fileName);

            if (File.Exists(destination))
            {
                FileReplace(source, destination);
            }
            else
            {
                File.Copy(source, destination);
            }
            


            return destination;
        }
        public static void FileReplace(string source, string destination)
        {
            if (File.Exists(destination + ".bak")) File.Delete(destination + ".bak");
            File.Copy(destination, destination + ".bak");
            File.Delete(destination);
            File.Copy(source, destination);
        }

        //Deletes Files(Images) that are not in the database
        public static void DeleteImages()
        {
            try
            {
                string[] Directoryimages = Directory.GetFiles($"{GetDesktopFilePath()}/Images");
                List<String> DBimages = new List<String>();

                using (SqlConnection connection = new SqlConnection(getConnectionString()))
                {
                    connection.Open();

                    string query = "Select (Image) FROM Product";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        DBimages.Add($"{GetDesktopFilePath()}/Images\\{sqlDataReader["Image"].ToString()}");
                    }
                }

                for (int i = 0; i < Directoryimages.Length; i++)
                {
                    bool isInDB = false;

                    foreach (var item in DBimages)
                    {
                        if (Directoryimages[i] == item)
                        {
                            isInDB = true;
                        }
                    }

                    if (!isInDB)
                    {
                        System.GC.Collect();
                        System.GC.WaitForPendingFinalizers();
                        File.Delete(Directoryimages[i]);
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
            
        }
        public static string getCreateBlogSqlString(Blog newBlog)
        {
            return "INSERT INTO Blog (Title, Author, Description, Body, PublishedDate, Rating) VALUES ('" + newBlog.Title + "','" + newBlog.AuthorID + "','" + newBlog.Description + "','" + newBlog.BlogBody + "','" + newBlog.PublishDateString + "'," + newBlog.Rating + ");";
        }

        public static string getUpdateBlogSqlString(Blog newBlog)
        {
            return $"UPDATE [Blog] SET Title = '{newBlog.Title}', Description = '{newBlog.Description}', Body = '{newBlog.BlogBody}' WHERE ID = '{newBlog.BlogID}'";
        }

        //M.C..Trying to kill repitition
        //E.M.. Repition pronounced dead
        public static int executeInputQuery(string query)
        {
            using(SqlConnection conn = new SqlConnection(getConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                
                int i = cmd.ExecuteNonQuery();

                return i;

            }
        }

        public static void FTPFileUpload(string filePath, string fileName)
        {

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://vtdics.com/"+fileName);
            request.Credentials = new NetworkCredential("jahub@vtdics.com", ")HE6eJ*,;47q");
            request.Method = WebRequestMethods.Ftp.UploadFile;

            using (Stream fileStream = File.OpenRead(filePath))
            using (Stream ftpStream = request.GetRequestStream())
            {
                fileStream.CopyTo(ftpStream);
            }

        }
    }
}
