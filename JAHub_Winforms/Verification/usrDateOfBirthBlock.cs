using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHubLib;
using System.Data.SqlTypes;

namespace JAHub_Winforms.Verification
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
        December = 12
    }

    public partial class usrDateOfBirthBlock : UserControl
    {

        #region Variables and Properties

        bool isYearValid;
        bool isMonthValid;
        bool isDayValid;

        int year;
        int month;
        int day;

        public int Day => day;
        public int Month => month;
        public int Year => year;

        #endregion

        public usrDateOfBirthBlock()
        {
            InitializeComponent();

            cmbMonth.DataSource = Enum.GetValues(typeof(Month));

            cmbMonth.DisplayMember = cmbMonth.DataSource.ToString();
        }

        public usrDateOfBirthBlock(SqlDateTime date)
        {
            InitializeComponent();

            // need to figure out how to make this correspond to farmer
            DateTime givenDate = date.Value;

            cmbDay.SelectedIndex = cmbDay.FindString("{0}", givenDate.Day);
            cmbMonth.SelectedIndex = cmbMonth.FindString("{0}", givenDate.Month);
            cmbYear.SelectedIndex = cmbYear.FindString(Int32.Parse(givenDate.Year));

            isDayValid = true;
            isMonthValid = true;
            isYearValid = true;
        }

        private void cmbYear_Validating(object sender, CancelEventArgs e)
        {
            if (cmbYear.SelectedIndex <= 0)
            {
                errDateBlock.SetIconAlignment(cmbYear, ErrorIconAlignment.MiddleRight);
                errDateBlock.SetError(cmbYear, "Field Cannot be Blank");

                isYearValid = false;
            }
            else
            {
                errDateBlock.SetError(cmbYear, String.Empty);

                isYearValid = true;
                year = Int32.Parse(cmbYear.SelectedItem.ToString());
            }
        }

        private void cmbMonth_Validating(object sender, CancelEventArgs e)
        {
            if (cmbMonth.SelectedIndex < 0)
            {
                errDateBlock.SetIconAlignment(cmbMonth, ErrorIconAlignment.MiddleRight);
                errDateBlock.SetError(cmbMonth, "Field Cannot be Blank");

                isMonthValid = false;
            }
            else
            {
                errDateBlock.SetError(cmbMonth, String.Empty);

                isMonthValid = true;
                month = (int)cmbMonth.SelectedValue;
            }

            // necessary to set the number of days in the month to change values in cmbDay
            int _daysPerMonth;

            switch (cmbMonth.SelectedValue)
            {
                case 0:
                    _daysPerMonth = 31;
                    break;
                case 1:
                    _daysPerMonth = 28; 
                    break;
                case 2:
                    _daysPerMonth = 31;
                    break;
                case 3:
                    _daysPerMonth = 30;
                    break;
                case 4:
                    _daysPerMonth = 31;
                    break;
                case 5:
                    _daysPerMonth = 30;
                    break;
                case 6:
                    _daysPerMonth = 31;
                    break;
                case 7:
                    _daysPerMonth = 31;
                    break;
                case 8:
                    _daysPerMonth = 30;
                    break;
                case 9:
                    _daysPerMonth = 31;
                    break;
                case 10:
                    _daysPerMonth = 30;
                    break;
                case 11:
                    _daysPerMonth = 31;
                    break;
                default:
                    _daysPerMonth = 31;
                    break;
            }

            // This changes the number of days to match the chosen month, preventing "31st of February" e.g.
            if(_daysPerMonth != cmbDay.Items.Count)
            {
                cmbDay.BeginUpdate();

                cmbDay.Items.Clear();


                for(int i = 1; i <= _daysPerMonth; i++)
                {
                    cmbDay.Items.Add(i.ToString());
                }
                
                cmbDay.SelectedIndex = cmbDay.FindString(_daysPerMonth.ToString());

                cmbDay.EndUpdate();

                errDateBlock.SetIconAlignment(cmbDay, ErrorIconAlignment.MiddleRight);
                errDateBlock.SetError(cmbDay, "Ensure that you have chosen the correct date");

                isDayValid = false;                
            }
        }

        private void cmbDay_Validating(object sender, CancelEventArgs e)
        {
            if (cmbDay.SelectedIndex <= 0)
            {
                errDateBlock.SetIconAlignment(cmbDay, ErrorIconAlignment.MiddleRight);
                errDateBlock.SetError(cmbDay, "Field Cannot Be Blank");

                isDayValid = false;
            }
            else
            {
                errDateBlock.SetError(cmbDay, String.Empty);

                isDayValid = true;
                day = Int32.Parse(cmbDay.SelectedItem.ToString());
            }
        }

        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            errDateBlock.SetError(cmbDay, String.Empty);
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            errDateBlock.SetError(cmbMonth, String.Empty);
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            errDateBlock.SetError(cmbYear, String.Empty);
        }

        public bool IsBlockValid()
        {
            if (isYearValid)
            {
                if (isMonthValid)
                {
                    if (isDayValid)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

        public void SetControlFocus()
        {
            if (!isDayValid)
            {
                cmbDay.Select();
            }
            else if (!isMonthValid)
            {
                cmbMonth.Select();
            }
            else if (!isYearValid)
            {
                cmbYear.Select();
            }
        }
    }
}
