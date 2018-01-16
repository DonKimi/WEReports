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
        private static List<String> files = new List<string>();


        static void Main(string[] args)
        {
            checkForEverything(rootPath);

            foreach (String file in files)
            {
                Console.WriteLine(file + "\n");
            }
            
            

            Console.ReadKey();
        }

        private static void checkForEverything(String sDir)
        {
            try
            {
                foreach (String dir in Directory.GetDirectories(sDir))
                {
                    foreach (String fil in Directory.GetFiles(dir, "*.wer"))
                    {
                        files.Add(fil);
                    }
                    checkForEverything(dir);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void checkForData()
        {
            foreach (String fil in files)
            {

            }
        }

    }
}

