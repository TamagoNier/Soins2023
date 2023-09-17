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

        private Prestation prestation;
        private List<Prestation> listePresta = new List<Prestation>();

        public Dossier(string nom, string prenom, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }
        public Dossier(string nom, string prenom, DateTime dateNaissance, Prestation presta)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.listePresta.Add(presta);
        }
        public Dossier(string nom, string prenom, DateTime dateNaissance, List<Prestation> newListePrestations)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            foreach (Prestation presta in newListePrestations)
            {
                this.listePresta.Add(presta);
            }
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => nom = value; }
        public DateTime DateNaissance { get => dateNaissance;}

        /**
         * La methode prend un par un les dates de la liste et compare les dates avant de la compter ou non
         */
        public string GetNbJoursSoinV1()
        {
            Int32 compteur;
            List<Prestation> jourPresta = new List<Prestation>();
            jourPresta.Add(this.listePresta[0]);

            foreach (Prestation presta in this.listePresta)
            {
                compteur = 0;
                while(compteur < jourPresta.Count)
                {
                    if (!jourPresta[compteur].CompareTo(presta))
                    {
                        jourPresta.Add(presta);
                    }
                    compteur++;
                }
            }
            return "Nombre de jours de soin : " + jourPresta.Count;
        }


    }
}
