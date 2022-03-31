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

namespace JAHub_Winforms.Verification
{
    public partial class usrDateOfBirthBlock : UserControl
    {
        /* TO DO
         * - Solve the problem of matching SelectedIndex of cmbDay, etc. to 
         * - datetime object inside of farmer
         */

        #region Variables and Properties

        bool isYearValid;
        bool isMonthValid;
        bool isDayValid;

        public String Day => cmbDay.SelectedText;
        public String Month => cmbMonth.SelectedText;
        public String Year => cmbYear.SelectedText;

        #endregion

        public usrDateOfBirthBlock()
        {
            InitializeComponent();
        }

        public usrDateOfBirthBlock(Farmer farmer)
        {
            // need to figure out how to make this correspond to farmer
            DateTime givenDate = farmer.DateOfBirth.Value;

            cmbDay.SelectedIndex = cmbDay.FindString("{0}", givenDate.Day);
            cmbMonth.SelectedIndex = cmbMonth.FindString("{0}", givenDate.Month);
            cmbYear.SelectedIndex = cmbYear.FindString("{0}", givenDate.Year);
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
            }

            // necessary to set the number of days in the month to change values in cmbDay
            int _daysPerMonth;

            switch (cmbMonth.SelectedIndex)
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
                cmbDay.Focus();
            }
            else if (!isMonthValid)
            {
                cmbMonth.Focus();
            }
            else if (!isYearValid)
            {
                cmbYear.Focus();
            }
        }
    }
}
