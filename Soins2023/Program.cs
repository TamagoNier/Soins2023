using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier;
using Outils;

namespace Soins2023
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IntervenantExterne i1 = new IntervenantExterne("Jean", "Joe", "magie therapeutique", "Rue Du Grand Mage", "0545989898");
                IntervenantExterne i2 = new IntervenantExterne("Trueman", "Joel", "pistoThérapie", "Rue du Victor", "0606060660");
                Intervenant i3 = new Intervenant("Trueman", "Joel");

                DateTime dateHeureSoin = new DateTime(2024, 01, 12, 15, 0, 0);
                DateTime dateHeureSoin2 = new DateTime(2024, 01, 12, 17, 0, 0);
                DateTime dateHeureSoin3 = new DateTime(2025, 08, 14, 15, 0, 0);
                DateTime dateHeureSoin4 = new DateTime(2024, 03, 18, 17, 0, 0);
                DateTime dateHeureSoin5 = new DateTime(2024, 03, 14, 18, 0, 0);

                DateTime dateNaiss = new DateTime(2004, 01, 23, 6, 0, 0);

                Prestation p1 = new Prestation(dateHeureSoin, "vaccin contre covid", i1);
                Prestation p2 = new Prestation(dateHeureSoin2, "vaccin contre covid", i3);

                Prestation p3 = new Prestation(dateHeureSoin3, "soins a la jambe", i2);
                Prestation p4 = new Prestation(dateHeureSoin4, "soins au coude", i1);
                Prestation p5 = new Prestation(dateHeureSoin5, "soins au genoux", i3);




                List<Prestation> prestations = new List<Prestation>();
                prestations.Add(p1);
                prestations.Add(p2);

                List<Prestation> prestations2 = new List<Prestation>();
                prestations2.Add(p3);
                prestations2.Add(p4);
                prestations2.Add(p5);

                Dossier d1 = new Dossier("Gerard", "Julie", dateNaiss, prestations);
                Dossier d2 = new Dossier("Grabulax", "LeDaro", dateNaiss, prestations2);

                Console.WriteLine(Traitement.TesteDossier(d1));
                Console.WriteLine(Traitement.TesteDossier(d2));
                Console.WriteLine("---------------------------------------");

                Traitement.TesteGetNbPrestationI(i3);
                Traitement.TesteGetNbPrestationIE(i2);
                

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Nombre de jours de soin D1 : " + d1.GetNbJoursSoinV2());
                Console.WriteLine("Nombre de jours de soin D2 : " + d2.GetNbJoursSoinV2());
                Console.WriteLine("Nombre de soins externes D1: " + d1.GetNbPrestationsExternes());
                Console.WriteLine("Nombre de soins externes D2: " + d2.GetNbPrestationsExternes());
                Console.WriteLine("Execution avec succées");

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
