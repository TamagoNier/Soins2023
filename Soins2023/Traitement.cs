using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier;

namespace Outils
{
    static class Traitement
    {
        /// <summary>
        /// Affiche les élements present au sein d'un dossier
        /// </summary>
        /// <param name="dossier"></param>
        /// <returns></returns>
        public static string TesteDossier(Dossier dossier)
        {
            return dossier.toString();
        }
    }
}
