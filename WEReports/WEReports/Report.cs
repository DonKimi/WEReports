using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEReports
{
    class Report
    {
        private String appName;
        private String appPath;
        private int reportType;
        private String user;
        private String mac;
        private int date;
        
        public Report(String appName, String appPath, int reportType, int date)
        {
            this.appName = appName;
            this.appPath = appPath;
            this.reportType = reportType;
            this.date = date;
        }

    }
}
