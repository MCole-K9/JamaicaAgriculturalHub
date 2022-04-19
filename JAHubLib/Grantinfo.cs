﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAHubLib;
using System.Data.SqlClient;

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



        public string GrantDescription { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Requirement { get; set; }
        public string ApplicationId { get; set; }
        public int GrantOfficerId { get; set; }
        public int ID { get; set; }
        public string FilePath { get; set; }


        public Grantinfo()
        {
            grantDescription = "";
            title = "";
            filename = "";
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
            this.ApplicationId = grantinfo.ApplicationId;
            this.GrantOfficerId = grantinfo.GrantOfficerId;
            this.ID=grantinfo.ID;   

            this.GrantOfficerId = grantinfo.GrantOfficerId; 
            
        }


        public void DeleteGrant()
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                Grantinfo grantinfo = new Grantinfo();
               
                connection.Open();
                string query = $" Delete FROM [Grant] WHERE ID = {grantinfo.ID}";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader sqlRead = cmd.ExecuteReader();

                {
                    while (sqlRead.Read())
                    {
                        
                        grantinfo.ID = (int)sqlRead["ID"];
                        grantinfo.GrantDescription = sqlRead["Description"].ToString();
                        grantinfo.Requirement = sqlRead["Requirements"].ToString();
                        grantinfo.ExpiryDate = (DateTime)sqlRead["Deadline"];
                        grantinfo.ApplicationId = sqlRead["Application_Form"].ToString();
                        grantinfo.GrantOfficerId = (int)sqlRead["GrantOfficer"];
                        grantinfo.Title = sqlRead["Title"].ToString();

                    }
                }

            }
        }

        public void ViewAllMyGrants()
        {


        }


       
    }

}




    

