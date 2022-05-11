using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAHubLib
{
    public class GrantApplication
    {
        private int grantApplicationId;
        private string filledApplication;
        private DateTime timeStamp;
        private string farmer;
        private string grant;


        public int GrantApplicationId { get { return grantApplicationId; } set { grantApplicationId = value; } }
         public string FilledApplication { get { return filledApplication; } set { filledApplication = value; } }   
        public DateTime TimeStamp { get { return timeStamp; } set { timeStamp = value; } }

        public string Farmer { get { return farmer; } set { farmer = value;} }

        public string Grant { get { return grant; } set { grant = value; } }


        public object DateTime { get; private set; }

        //var date1 = new DateTime(2008, 3, 1, 7, 0, 0);
        public GrantApplication() 
        {
            GrantApplicationId = 0;
            FilledApplication = "";
            TimeStamp = timeStamp;  
        }

        public GrantApplication(GrantApplication grantApplication) 
        {
            GrantApplicationId = grantApplication.GrantApplicationId;   
            FilledApplication = grantApplication.FilledApplication; 
            TimeStamp = grantApplication.TimeStamp;   
        }

       /* public int CreateGrant(GrantApplication grantApplication)
        {
            string query = $"INSERT INTO [Grant_application] ( Filled_Application,Grant,TimeStamp,Farmer)" +
                    $"Values ( '{grantApplication.FilledApplication}','{grantApplication.TimeStamp}', '{grantApplication.Grant}', {grantApplication.TimeStamp.ToString("yyyy-mm-dd")},'{grantApplication.Farmer}')";

            Utilities.executeInputQuery(query);
            return 1;

        }*/

        public int CreateApplication(GrantApplication grantApplication)
        {
            string query = $"INSERT INTO [Grant_Application] ( Filled_Application,Grant)" +
                    $"Values ( '{grantApplication.FilledApplication}','{grantApplication.GrantApplicationId}')";

            Utilities.executeInputQuery(query);
            return 1;

        }


    }


}



/*
   string query = $"INSERT INTO [Grant_Application] ( Filled_Application,Grant)" +
                    $"Values ( '{grantApplication.FilledApplication}','{grantApplication.GrantApplicationId}'/*, '{grantinfo.Requirement}', {grantinfo.ExpiryDate.ToString("yyyy-mm-dd")},'{grantinfo.GrantOfficerId}')";*/