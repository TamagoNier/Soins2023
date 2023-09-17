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
        protected List<Prestation> listePresta = new List<Prestation>(); 

        public Intervenant(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public List<Prestation> ListePresta { get => listePresta;}

        public void AjoutePrestation(Prestation prestation)
        {
            this.listePresta.Add(prestation);
        }
    }
}
