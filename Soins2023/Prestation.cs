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
            this.DateHeureSoin = dateHeureSoin;
            this.Libelle = libelle;
            this.intervenant = intervenant;

            intervenant.AjoutePrestation(this);
        }

        public DateTime DateHeureSoin
        {
            get => dateHeureSoin;
            set
            {
                try
                {
                    if (DateTime.Compare(value, DateTime.Now) == -1)
                        dateHeureSoin = value;
                    else
                    {
                        throw new Exception("La prestation doit avoir deja eu lieu");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);     
                }
            }
        }

        public string Libelle { get => libelle; set => libelle = value; }
        internal Intervenant Intervenant { get => intervenant; set => intervenant = value; }

        /// <summary>
        /// Passe par la methode statique compare en rend -1 si DateHeureSoin est anterieure a prestation.dateHeureSoin, 
        /// 0 si egale 
        /// 1 si superieure
        /// </summary>
        /// <param name="prestation"></param>
        /// <returns></returns>
        public int CompareTo(Prestation prestation)
        {
            //if(this.DateHeureSoin.Date == prestation.DateHeureSoin.Date)
            //{
            //    return 0;
            //}
            //else if(this.DateHeureSoin.Date > prestation.DateHeureSoin.Date)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return -1;
            //}
            return DateTime.Compare(this.DateHeureSoin.Date, prestation.DateHeureSoin.Date);
        }

        /// <summary>
        /// Methode surchargé de toString
        /// </summary>
        /// <returns>Retourne un string contenant les données de la prestation</returns>
        public string toString()
        { 
            if(this.Intervenant is IntervenantExterne)
            {
                IntervenantExterne intervenant = (IntervenantExterne)this.Intervenant;
                return "Libelle : " + this.Libelle + " - " + this.DateHeureSoin + " - " + intervenant.toString();
            }
            else
            {
                return "Libelle : " + this.Libelle + " - " + this.DateHeureSoin + " - " + this.Intervenant.toString();
            } 
        }
    }
}
