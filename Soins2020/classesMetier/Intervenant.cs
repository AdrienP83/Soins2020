using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace classesMetier
{
    class Intervenant
    {
        private string nom;
        private string prenom;
        private List<Prestation> lesPrestation;

        public Intervenant(string nom, string prenom, List<Prestation> lesPrestation)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.lesPrestation = lesPrestation;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public void AjoutePrestation(Prestation unePrestation)
        {
            this.lesPrestation.Add(unePrestation);
        }

    }
}
