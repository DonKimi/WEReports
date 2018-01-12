using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WEReports
{
    class Data
    {
        private String path;
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
