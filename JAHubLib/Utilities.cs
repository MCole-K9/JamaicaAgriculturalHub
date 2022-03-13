using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JAHubLib
{
    public static class Utilities
    {
        //Returns file path from base-directory up to Project Namespace
        public  static string GetFilePath()
        {
            String path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.Length - 10);

            return path;
        }

        public static void SomeMethodName()
        {
            // Matthew Added Comment Here
        }
    }
}
