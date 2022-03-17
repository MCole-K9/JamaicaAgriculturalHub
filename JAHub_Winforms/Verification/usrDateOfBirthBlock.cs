using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms.Verification
{
    public partial class usrDateOfBirthBlock : UserControl
    {
        bool isYearValid;
        bool isMonthValid;
        bool isDayValid;
        public usrDateOfBirthBlock()
        {
            InitializeComponent();
        }

        private void cmbYear_Validating(object sender, CancelEventArgs e)
        {
            if (cmbYear.SelectedIndex <= 0)
            {
                dateBlockErrorProvider.SetIconAlignment(cmbYear, ErrorIconAlignment.MiddleRight);
                dateBlockErrorProvider.SetError(cmbYear, "Field Cannot be Blank");

                isYearValid = false;
            }
            else
            {
                dateBlockErrorProvider.SetError(cmbYear, String.Empty);

                isYearValid = true;
            }
        }

        private void cmbMonth_Validating(object sender, CancelEventArgs e)
        {
            if (cmbMonth.SelectedIndex < 0)
            {
                dateBlockErrorProvider.SetIconAlignment(cmbMonth, ErrorIconAlignment.MiddleRight);
                dateBlockErrorProvider.SetError(cmbMonth, "Field Cannot be Blank");

                isMonthValid = false;
            }
            else
            {
                dateBlockErrorProvider.SetError(cmbMonth, String.Empty);

                isMonthValid = true;
            }

            // method to see what month it is and change the number of days accordingly
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

                dateBlockErrorProvider.SetIconAlignment(cmbDay, ErrorIconAlignment.MiddleRight);
                dateBlockErrorProvider.SetError(cmbDay, "Ensure that you have chosen the correct date");

                isDayValid = false;                
            }
        }

        private void cmbDay_Validating(object sender, CancelEventArgs e)
        {
            if (cmbDay.SelectedIndex <= 0)
            {
                dateBlockErrorProvider.SetIconAlignment(cmbDay, ErrorIconAlignment.MiddleRight);
                dateBlockErrorProvider.SetError(cmbDay, "Field Cannot Be Blank");

                isDayValid = false;
            }
            else
            {
                dateBlockErrorProvider.SetError(cmbDay, String.Empty);

                isDayValid = true;
            }
        }

        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateBlockErrorProvider.SetError(cmbDay, String.Empty);
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateBlockErrorProvider.SetError(cmbMonth, String.Empty);
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateBlockErrorProvider.SetError(cmbYear, String.Empty);
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
    }
}
