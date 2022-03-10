using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms
{
    public static class Utils
    {
        //Returns true or false if there is an instance of the form passed in is already runninn
        public static bool IsFormOpen(string frmTxtProp)
        {
            var OpenForms =  Application.OpenForms.Cast<Form>();
            bool isOpen = OpenForms.Any(q => q.Text == frmTxtProp);
            return isOpen;
            
        }
    }
}
