using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;

namespace WEReports
{
    class Program
    {
        private static String rootPath = @"T:\AWP_11_STE\wer_reports";
        private static List<String> files = new List<string>();
        static List<File> listeFiles = new List<File>();


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
                        listeFiles.Add(new File(fil));
                    }
                    checkForEverything(dir);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }


        public static PhysicalAddress GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress();
                }
            }
            return null;
        }

        private static void checkForData()
        {
            foreach (File x in listeFiles)
            {
                x.readFile();
                x.editLines();
                // in xml datei schreiben
            }

        }

    }
}

