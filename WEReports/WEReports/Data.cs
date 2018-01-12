using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WEReports
{
    class Data
    {
        public String path;
        private String[] lines;

        private String appName;
        private String appPath;
        private int reportType;
        private int date;
        
        public void readFile()
        {
            try
            {
                lines = System.IO.File.ReadAllLines(this.path, UTF32Encoding.Unicode);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        
        public void editLines()
        {
            foreach(String line in lines)
            {
                Regex regexAppName = new Regex(@"AppName\=(.*)");
                Regex regexAppPath = new Regex(@"AppPath\=(.*)");
                Regex regexReportType = new Regex(@"ReportType\=(.*)");
                Regex regexDate = new Regex(@"EventTime\=(.*)");

                Match matchAppName = regexAppName.Match(line);
                Match matchAppPath= regexAppPath.Match(line);
                Match matchReportType = regexReportType.Match(line);
                Match matchDate = regexDate.Match(line);

                if (matchAppName.Success)
                {
                    Console.WriteLine(matchAppName.Groups[1].Value);
                }
                else if (matchAppPath.Success) 
                {
                    Console.WriteLine(matchAppPath.Groups[1].Value);
                }
                else if (matchReportType.Success)
                {
                    Console.WriteLine(matchReportType.Groups[1].Value);
                }
                else if (matchDate.Success)
                {
                    Console.WriteLine(matchDate.Groups[1].Value);
                }
            }
        }

        public Report toReport()
        {
            try
            {
                return new Report(this.appName, this.appPath, this.reportType, this.date);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
