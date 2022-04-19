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
    public partial class usrIndustryBlock : UserControl
    {
        /* TO DO
         * 
         */
        
        bool isChoiceSelected;
        bool _usesHeavyMachinery;

        public bool UsesHeavyMachinery => _usesHeavyMachinery;
        public decimal NumberOfEmployees => nudNumberOfEmployees.Value;

        public usrIndustryBlock()
        {
            InitializeComponent();
        }

        public usrIndustryBlock(Farmer farmer)
        {
            InitializeComponent();
            nudNumberOfEmployees.Value = farmer.NumberOfEmployees;
            
            if (farmer.NumberOfEmployees == 0)
            {
                lblNumberOfEmployees.Visible = false;
                nudNumberOfEmployees.Visible = false;
            }
            
            if (farmer.UsesHeavyMachinery == true)
            {
                rdoIndustryYes.Select();
            }
            else
            {
                rdoIndustryNo.Select();
            }

            rdoIndustryNo.Enabled = false;
            rdoIndustryYes.Enabled = false;
            nudNumberOfEmployees.Enabled = false;

            isChoiceSelected = true;
        }

        // in reality this is not the space where this event should go, but
        // it doesn't actually matter because this should only get called if:
        // A. the user tabs over the control
        // B. at the end when the user tried to submit
        private void rdoIndustryYes_Validating(object sender, CancelEventArgs e)
        {
            validateRdoButtons();
            _usesHeavyMachinery = true;
        }

        // same thing for this function
        private void rdoIndustryNo_Validating(object sender, CancelEventArgs e)
        {
            validateRdoButtons();
            _usesHeavyMachinery = false;
        }

        public void validateRdoButtons()
        {
            if (!rdoIndustryNo.Checked && !rdoIndustryYes.Checked)
            {
                errIndustryBlock.SetIconAlignment(lblHeavyMachinery, ErrorIconAlignment.MiddleRight);
                errIndustryBlock.SetError(lblHeavyMachinery, "Please select 'Yes' or 'No'");

                isChoiceSelected = false;
                
            }
            else
            {
                errIndustryBlock.SetError(lblHeavyMachinery, "");

                isChoiceSelected = true;
            }
        }


        public bool IsBlockValid()
        {
            if (isChoiceSelected)
            {
                return true;
            }

            validateRdoButtons();

            return false;
        }

        public void SetControlFocus()
        {
            // pretty sure that .Focus doesn't work for labels, need to check to be sure
            lblHeavyMachinery.Select();
        }
    }
}
