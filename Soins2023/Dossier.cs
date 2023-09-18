using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class Dossier
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private List<Prestation> prestations = new List<Prestation>();
        private readonly DateTime dateCreation = DateTime.Now;

        public Dossier(string nom, string prenom, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }
        public Dossier(string nom, string prenom, DateTime dateNaissance, Prestation presta):this(nom, prenom, dateNaissance)
        {
            this.prestations.Add(presta);
        }
        public Dossier(string nom, string prenom, DateTime dateNaissance, List<Prestation> newListePrestations):this(nom, prenom, dateNaissance)
        {
            this.prestations = newListePrestations;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => nom = value; }
        public DateTime DateNaissance { get => dateNaissance;}
        public DateTime DateCreation { get => dateCreation;}

        /// <summary>
        /// Ajoute une prestation à la liste de prestations de la classe dossier
        /// </summary>
        /// <param name="prestation"></param>
        public void AjoutePrestation(Prestation prestation)
        {
            this.prestations.Add(prestation);
        }

        /// <summary>
        /// Ajoute une liste de prestations à la liste de prestation de la classe dossier
        /// </summary>
        /// <param name="prestations"></param>
        public void AjoutePrestations(List<Prestation> prestations)
        {
            this.prestations.AddRange(prestations);
        }


        /// <summary>
        /// Traverse la liste des prestation et pour chaque prestation compare si il n'y a pas de doublons de dates
        /// Rends le nombre de jours de prestations
        /// </summary>
        /// <returns></returns>
        public int GetNbJoursSoinV1()
        {
            Int32 compteur;
            List<Prestation> jourPresta = new List<Prestation>();
            jourPresta.Add(this.prestations[0]);

            foreach (Prestation presta in this.prestations)
            {
                compteur = 0;
                while(compteur < jourPresta.Count)
                {
                    if (jourPresta[compteur].CompareTo(presta) != 0)
                    {
                        jourPresta.Add(presta);
                    }
                    compteur++;
                }
            }
            return jourPresta.Count;
        }

        /// <summary>
        /// Traverse la liste en deux temps afin de comparer les dates de la liste des prestations, 
        /// si une date se repete, le compteur n'est pas concateneé
        /// </summary>
        /// <returns>Rends le nombre de jours de prestations</returns>
        public int GetNbJoursSoinV2()
        {
            int nbJoursPresta = 0;

            for (int i = 0; i < this.prestations.Count - 1; i++)
            {
                for (int j = i + 1; j < this.prestations.Count; j++)
                {
                    if (this.prestations[j].CompareTo(this.prestations[i]) != 0)
                    {
                        nbJoursPresta++;
                    }
                    
                }
            }
            if(this.prestations.Count > 0  && nbJoursPresta == 0)
            {
                return 1;
            }else
            {
                return nbJoursPresta;
            }
        }

        public int GetNbPrestationsExternes()
        {
            int nbPrestaExt = 0;

            foreach(Prestation prestation in this.prestations)
            {
                if(prestation.Intervenant is IntervenantExterne)
                {
                    nbPrestaExt++;
                }
            }
            return nbPrestaExt;
        }

        /// <summary>
        /// Methode surchargé de toString
        /// </summary>
        /// <returns>Retourne un string contenant les données du dossier</returns>
        public string toString()
        {
            Console.WriteLine("Debut dossier");
            Console.WriteLine("Nom : " + this.Nom + " Prenom : " + this.Prenom);
            foreach(Prestation prestation in this.prestations)
            {
                Console.WriteLine("\t" + prestation.toString());
            }
            return "Fin du Dossier";
        }
    }
}
