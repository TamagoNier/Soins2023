using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class Prestation
    {
        private DateTime dateHeureSoin;
        private string libelle;
        private Intervenant intervenant;

        public Prestation(DateTime dateHeureSoin, string libelle, Intervenant intervenant)
        {
            this.dateHeureSoin = dateHeureSoin;
            this.libelle = libelle;
            this.intervenant = intervenant;
        }

        /**
         * Compare si la date de la prestation actuelle est superieure à une autre et renvoi un 
         * boolean en concequence
         */
        public Boolean CompareTo(Prestation prestation)
        {
            return this.dateHeureSoin.Date == prestation.dateHeureSoin.Date;
        }
    }
}
