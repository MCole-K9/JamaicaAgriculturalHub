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


        public int GrantApplicationId { get { return grantApplicationId; } set { grantApplicationId = value; } }
         public string FilledApplication { get { return filledApplication; } set { filledApplication = value; } }   
        private DateTime TimeStamp { get { return timeStamp; } set { timeStamp = value; } }
    }

     
}
