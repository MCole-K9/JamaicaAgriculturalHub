using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlTypes;

namespace JAHub_ASPWebforms.Verification
{
    enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
    }

    public partial class usrDateOfBirthBlock : System.Web.UI.UserControl
    {
        int day;

        public int Day 
        {
            get
            {
                return Int32.Parse(ddlDay.SelectedValue);
            }
            set
            {
                ddlDay.SelectedIndex = ddlDay.Items.IndexOf(ddlDay.Items.FindByValue(value.ToString()));
            }
        }
        
        public int Month
        {
            get
            {
                return Int32.Parse(ddlMonth.SelectedValue);
            }
            set
            {
                ddlMonth.SelectedIndex = ddlMonth.Items.IndexOf(ddlMonth.Items.FindByValue(value.ToString()));
            }
        }
        public int Year
        {
            get
            {
                return Int32.Parse(ddlYear.SelectedValue);
            }
            set
            {
                ddlYear.SelectedIndex = ddlYear.Items.IndexOf(ddlYear.Items.FindByValue(value.ToString()));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public usrDateOfBirthBlock()
        {

        }

        public usrDateOfBirthBlock(SqlDateTime date)
        {
            // need to figure out how to make this correspond to farmer
            DateTime givenDate = date.Value;

            ddlDay.SelectedIndex = givenDate.Day;
            ddlMonth.SelectedIndex = givenDate.Month;
            ddlYear.SelectedIndex = givenDate.Year;

        }

        protected void ddlMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int daysInMonth;

            switch (ddlMonth.SelectedIndex)
            {
                case 0:
                    daysInMonth = 31;
                    break;
                case 1:
                    daysInMonth = 28;
                    break;
                case 2:
                    daysInMonth = 31;
                    break;
                case 3:
                    daysInMonth = 30;
                    break;
                case 4:
                    daysInMonth = 31;
                    break;
                case 5:
                    daysInMonth = 30;
                    break;
                case 6:
                    daysInMonth = 31;
                    break;
                case 7:
                    daysInMonth = 31;
                    break;
                case 8:
                    daysInMonth = 30;
                    break;
                case 9:
                    daysInMonth= 31;
                    break;
                case 10:
                    daysInMonth = 30;
                    break;
                case 11:
                    daysInMonth = 31;
                    break;
                default:
                    daysInMonth = 31;
                    break;
            }

            ddlDay.Items.Clear();

            for(int i = 0; i < daysInMonth; i++)
            {
                ddlDay.Items.Add((i + 1).ToString());
            }
        }

    }
}