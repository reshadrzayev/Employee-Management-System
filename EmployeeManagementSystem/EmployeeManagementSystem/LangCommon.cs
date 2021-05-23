using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class LangCommon
    {
        static public IniFile ini2 = new IniFile("details.ini");
        static public string language = GetLanguage();

        static public ResourceManager rm = new ResourceManager("EmployeeManagementSystem." + language, Assembly.GetExecutingAssembly());

        public static string GetLanguage()
        {

            string dil = ini2.Read("Language");
            string lang = "az";
            switch (dil)
            {
                case "az": lang = "az"; break;
                case "en": lang = "en"; break;
                default: lang = "az"; break;

            }
            //language = lang;
            return lang;
        }
    }
}
