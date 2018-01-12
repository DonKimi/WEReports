using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WEReports
{
    class Program
    {
        private static String rootPath = @"T:\AWP_11_STE\wer_reports";
        private static String[] subfolders;
        


        static void Main(string[] args)
        {
            Folder rootFolder = new Folder(rootPath);

            rootFolder.check();
        }
    }
}

