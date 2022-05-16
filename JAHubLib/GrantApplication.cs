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
        private int iD;


        public int GrantApplicationId { get { return grantApplicationId; } set { grantApplicationId = value; } }
         public string FilledApplication { get { return filledApplication; } set { filledApplication = value; } }   
        public DateTime TimeStamp { get { return timeStamp; } set { timeStamp = value; } }

      

        public int ID { get { return iD; } set { iD = value; } }


        //public object DateTime { get; private set; }

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

      

        public int CreateApplication(GrantApplication grantApplication)
        {
            //grantApplication.FilledApplication = "Hellow mate";
            string query = $"INSERT INTO [Grant_Application] ( Filled_Application, [Grant]) "  +
                      $"Values ( '{grantApplication.FilledApplication}', {grantApplication.GrantApplicationId})";

            Utilities.executeInputQuery(query);
            return 1;

        }


    }


}
