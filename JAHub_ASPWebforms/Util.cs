using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JAHub_ASPWebforms
{
    public static class Util
    {
        public static string GetSolFilePath()
        {
            string path = HttpRuntime.AppDomainAppPath;
            return path.Substring(0, path.Length - 19);
        }
    }
}