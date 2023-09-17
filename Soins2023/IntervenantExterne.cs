using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class IntervenantExterne : Intervenant
    {
        private string specialite;
        private string adresse;
        private string tel;

        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, string tel):base(nom, prenom)
        {
            this.specialite = specialite;
            this.Adresse = adresse;
            this.Tel = tel;
        }

        public string Specialite { get => specialite; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Tel { get => tel; set => tel = value; }
    }
}
