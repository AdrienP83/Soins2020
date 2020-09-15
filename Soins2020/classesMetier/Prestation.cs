using System;
using System.Collections.Generic;
using System.Text;

namespace classesMetier
{
    class Prestation
    {
        private string libelle;
        private DateTime dateSoin;
        private Intervenant l_Intervenant;

        public Prestation(string libelle, DateTime dateSoin, Intervenant l_Intervenant)
        {
            this.libelle = libelle;
            this.dateSoin = dateSoin;
            this.l_Intervenant = l_Intervenant;
            this.l_Intervenant.AjoutePrestation(this);       
        }

        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime DateSoin { get => dateSoin; set => dateSoin = value; }
        public Intervenant L_Intervenant { get => l_Intervenant; set => l_Intervenant = value; }
        public int CompareTo(Prestation unePrestation)
        {
            if (this.DateSoin.Date == unePrestation.DateSoin.Date)
            {
                return 0;
            }
            else if (this.DateSoin.Date > unePrestation.DateSoin.Date)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

    }
}
