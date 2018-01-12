using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WEReports
{
    class Folder
    {
        private String path;
        private String[] subfolder;
        private String[] datas;
        
        public Folder(String path)
        {
            this.path = path;

        }

        public void check()
        {
            this.checkForSubfolder();
            this.checkForData();
        }

        private void checkForSubfolder()
        {
            try
            {
                subfolder = Directory.GetDirectories(this.path);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void checkForData()
        {
            try
            {
                datas = Directory.GetFiles(this.path);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

    }

}

