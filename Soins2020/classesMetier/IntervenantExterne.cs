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
public IntervenantExterne(string nom, string prenom,string specialite, string adresse, string tel, List<Prestation> lesPrestation)
            :base (nom,prenom,lesPrestation)
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
