using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAHubLib;

namespace JAHubLib
{
    public class Grantinfo
    {

        private string grantDescription;
        private string title;
        public string filename;
        private string expiryDate;

        public string GrantDescription { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string ExpiryDate { get; set; }
        public Grantinfo()
        {
            grantDescription = "";
            title = "";
            filename = "";
        }

        public Grantinfo(string grantDescription, string title, string filename)
        {
            this.GrantDescription = grantDescription;
            this.Title = title;
            this.FileName = filename;
        }

        public Grantinfo(Grantinfo grantinfo)
        {
            this.GrantDescription = grantinfo.GrantDescription;
            this.Title = grantinfo.Title;
            this.FileName = grantinfo.FileName;
        }
    }
}
