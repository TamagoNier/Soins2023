using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier;

namespace Soins2023
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IntervenantExterne i1 = new IntervenantExterne("Jean", "Joe", "magie therapeutique", "Rue Du Grand Mage", "0545989898");

                DateTime dateHeureSoin = new DateTime(2024, 01, 12, 15, 0, 0);
                DateTime dateHeureSoin2 = new DateTime(2024, 01, 14, 17, 0, 0);

                DateTime dateNaiss = new DateTime(2004, 01, 23, 6, 0, 0);

                Prestation p1 = new Prestation(dateHeureSoin, "vaccin contre covid", i1);
                Prestation p2 = new Prestation(dateHeureSoin2, "vaccin contre covid", i1);
                i1.AjoutePrestation(p1);
                i1.AjoutePrestation(p2);
                List<Prestation> prestations = new List<Prestation>();
                prestations.Add(p1);
                prestations.Add(p2);

                Dossier d1 = new Dossier("Gerard", "Julie", dateNaiss, prestations);
                
                Console.WriteLine(d1.GetNbJoursSoinV1());
                Console.WriteLine("Execution avec succées");

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
