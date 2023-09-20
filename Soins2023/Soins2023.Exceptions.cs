using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        public SoinsException(string message)
            : base("Erreur de : " + System.Environment.UserName + " le " + DateTime.Now + "\n" + message)
        {


            JObject jsonException = new JObject
            (
                new JProperty("Erreur de :", System.Environment.UserName),
                new JProperty("Date de l'erreur : ", DateTime.Now),
                new JProperty("Message : ", message)
            );

            File.WriteAllText(@"E:\GOGOR\bloc 2\CSharp Deuxieme Annee\Soins2023\Soins2023\logs.json", JsonConvert.SerializeObject(jsonException));

            //StreamWriter sw = new StreamWriter(fileName, true);
            //sw.WriteLine();
            //sw.WriteLine(message);
            //sw.Close();



        }
    }
}
