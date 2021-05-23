using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void CreateIniIfNotExists()
        {
            string path = "details.ini";
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }
            IniFile ini = new IniFile(path);
            
        }

        static void Main()
        {

            CreateIniIfNotExists();
            
            //MessageBox.Show(dil);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
