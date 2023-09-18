using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soins2023
{
    class SoinsException: Exception
    {
        string fileName = ConfigurationManager.AppSettings["LogFileName"];

        public SoinsException(string message)
            : base("Erreur de : " + System.Environment.UserName + " le " + DateTime.Now + "\n" + message)
        {
            StreamWriter sw = new StreamWriter(fileName, true);
            sw.WriteLine("Erreur de : " + System.Environment.UserName + " le " + DateTime.Now);
            sw.WriteLine(message);
            sw.Close();
        }
    }
}
