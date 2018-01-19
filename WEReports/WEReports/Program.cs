using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;
using System.Xml;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace WEReports
{
    class Program
    {
        private static String rootPath = @"T:\AWP_11_STE\wer_reports\";
        private static List<String> files = new List<string>();
        private static List<File> listeFiles = new List<File>();
        private static XmlDocument xmlDoc = new XmlDocument();
        private static Dictionary<String, List<String>> dictionary = new Dictionary<String, List<String>>();


        static void Main(string[] args)
        {
            //checkForEverything(rootPath);

            //foreach (String file in files)
            //{
            //    Console.WriteLine(file + "\n");
            //}

            //createXml();
            
            Console.WriteLine(bla);
            Console.ReadKey();
        }

        private static void checkForEverything(String sDir)
        {
            String user;

            try
            {
                foreach (String dir in Directory.GetDirectories(sDir))
                {
                    foreach (String fil in Directory.GetFiles(dir, "*.wer"))
                    {

                        listeFiles.Add(new File(fil));

                        user = fil.Replace(@"T:\AWP_11_STE\wer_reports\", "");
                        user = Regex.Replace(user, @"\\App.*", "");
                        
                        if (dictionary.Keys.Contains(user))
                        {}
                        else
                        {
                            dictionary.Add(user, null);
                            //idee: liste erstellen, mit jedem neuen key pfade in liste zwischenspeichern, am ende liste key zuordnen
                        }
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

        private static void createXml()
        {
            XmlNode device = xmlDoc.CreateElement("device");
            xmlDoc.AppendChild(device);

            XmlAttribute mac = xmlDoc.CreateAttribute("mac");
            mac.Value = GetMacAddress().ToString();
            device.Attributes.Append(mac);
            XmlAttribute timestamp = xmlDoc.CreateAttribute("timestamp");
            timestamp.Value = DateTime.Now.ToString();
            device.Attributes.Append(timestamp);

            XmlNode user = xmlDoc.CreateElement("user");
            device.AppendChild(user);
            XmlAttribute username = xmlDoc.CreateAttribute("username");
            username.Value = "Julia";
            user.Attributes.Append(username);

            xmlDoc.Save(rootPath + "Report.xml");
        }

    }
}