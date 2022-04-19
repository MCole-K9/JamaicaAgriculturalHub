using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHub_Winforms.Verification;
using JAHub_Winforms;
using JAHubLib;

namespace JAHub_Winforms
{
    public partial class FrmRadaViewRegistration : Form
    {
        Farmer farmer;
        int _userId;

        usrNameBlock nameBlock;
        usrDateOfBirthBlock dateOfBirthBlock;
        usrTrnBlock trnBlock;
        usrContactBlock contactBlock;
        usrHoldingsBlock holdingsBlock;
        usrIndustryBlock industryBlock;
        usrOrganizationsBlock organizationsBlock;
        public FrmRadaViewRegistration(int userId)
        {
            InitializeComponent();

            this._userId = userId;
            farmer = new Farmer();

            farmer.GetFullRecordFromDatabase(_userId);
        }

        private void FrmRadaViewRegistration_Load(object sender, EventArgs e)
        {
            // Instantiating all of the controls with their relevant parameters
            nameBlock = new usrNameBlock(farmer.FirstName, farmer.MiddleName, farmer.LastName);
            dateOfBirthBlock = new usrDateOfBirthBlock(farmer.DateOfBirth);
            trnBlock = new usrTrnBlock(farmer.TaxRegistrationNumber);
            contactBlock = new usrContactBlock(farmer.Email, farmer.PhoneNumbers);
            holdingsBlock = new usrHoldingsBlock(farmer);
            industryBlock = new usrIndustryBlock(farmer);
            organizationsBlock = new usrOrganizationsBlock(farmer.Organizations);

            // Adding the controls to the FlowLayoutPanel
            flpRadaViewRegistration.Controls.Add(nameBlock);
            flpRadaViewRegistration.Controls.Add(dateOfBirthBlock);
            flpRadaViewRegistration.Controls.Add(trnBlock);
            flpRadaViewRegistration.Controls.Add(contactBlock);
            flpRadaViewRegistration.Controls.Add(holdingsBlock);
            flpRadaViewRegistration.Controls.Add(industryBlock);

            if (farmer.Organizations.Count != 0)
            {
                flpRadaViewRegistration.Controls.Add(organizationsBlock);
            }
        }
    }
}
