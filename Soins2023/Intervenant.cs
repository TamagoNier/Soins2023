using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class Intervenant
    {
        private string nom;
        private string prenom;
        protected List<Prestation> prestations = new List<Prestation>(); 

        public Intervenant(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public List<Prestation> ListePresta { get => prestations;}

        public void AjoutePrestation(Prestation prestation)
        {
            this.prestations.Add(prestation);
        }

        /// <summary>
        /// Methode surchargé de toString
        /// </summary>
        /// <returns>Retourne un string contenant les données de l'intervenant</returns>
        public string toString()
        {
            return "Intervenant : " + this.Nom + " " + this.Prenom;
        }

        /// <summary>
        /// </summary>
        /// <returns>Retourne le nombre de préstations</returns>
        public int GetNbPrestations()
        {
            return prestations.Count;
        }
    }
}
