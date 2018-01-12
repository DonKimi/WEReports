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

            Data test = new Data();
            test.path = @"T:\AWP_11_STE\wer_reports\Guenther\AppCrash_AD2F1837.HPPrint_7abab9a238d31ce95943fa32488e7ff1e0ef441f_8eaf7b11_1838f853\Report.wer";
            test.readFile();
            test.editLines();
            Console.ReadKey();
        }
    }
}

