using System;
using System.Collections.Generic;
using System.Text;

namespace classesMetier
{
    class IntervenantExterne :Intervenant
    {
        private string specialite;
        private string adresse;
        private string tel; 
        /// <summary>
        /// Constructeur qui hérite de la classe Intervenant
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="specialite"></param>
        /// <param name="adresse"></param>
        /// <param name="tel"></param>
        /// <param name="lesPrestation"></param>
public IntervenantExterne(string nom, string prenom,string specialite, string adresse, string tel)
            :base (nom,prenom)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }

        public string Specialite { get => specialite; set => specialite = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Tel { get => tel; set => tel = value; }

    }
}
