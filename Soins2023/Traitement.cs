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

        /// <summary>
        /// </summary>
        /// <param name="intervenant">Retourne le nombre des prestations de l'intervenant en paramétre</param>
        public static void TesteGetNbPrestationI(Intervenant intervenant)
        {
            Console.WriteLine("Nb Prestations Intervenant : " + intervenant.GetNbPrestations());
        }

        /// <summary>
        /// </summary>
        /// <param name="intervenant">Retourne le nombre des prestations de l'intervenant externe en paramétre</param>
        public static void TesteGetNbPrestationIE(IntervenantExterne intervenant)
        {
            Console.WriteLine("Nb Prestations Intervenant Externe: " + intervenant.GetNbPrestations());
        }
    }
}
