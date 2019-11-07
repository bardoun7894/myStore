using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string fileDay = "D://test/1.txt";

            // if the file of Validity is exist in disk d 
            if (!File.Exists(fileDay))
            {

                int day = DateTime.Now.Day + 2;
                File.WriteAllText(fileDay, day.ToString());
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBranchAdd());
        }
    }
}
