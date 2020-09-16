using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace classesMetier
{
    class Dossier
    {
        private string nomPatient;
        private string prenomPatient;
        private DateTime dateNaissance;
        private Prestation unePrestation;
        private List<Prestation> mesPrestation;

        public Dossier(string nomPatient, string prenomPatient, DateTime dateNaissance)
        {
            this.nomPatient = nomPatient;
            this.prenomPatient = prenomPatient;
            this.dateNaissance = dateNaissance;
        }

        public Dossier(string nomPatient, string prenomPatient, DateTime dateNaissance, List<Prestation> mesPrestation)
        {
            this.nomPatient = nomPatient;
            this.prenomPatient = prenomPatient;
            this.dateNaissance = dateNaissance;
            this.mesPrestation = new List<Prestation>();
        }

        public Dossier(string nomPatient, string prenomPatient, DateTime dateNaissance, Prestation unePrestation)
        {
            this.nomPatient = nomPatient;
            this.prenomPatient = prenomPatient;
            this.dateNaissance = dateNaissance;
            this.unePrestation = unePrestation;
        }

        public string NomPatient { get => nomPatient; set => nomPatient = value; }
        public string PrenomPatient { get => prenomPatient; set => prenomPatient = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public Prestation UnePrestation { get => unePrestation; set => unePrestation = value; }
        public List<Prestation> MesPrestation { get => mesPrestation; set => mesPrestation = value; }

        public void AjoutePrestation(string unLibelle, DateTime uneDate,Intervenant UnIntervenant)
        {
            Prestation unePrestation = new Prestation(unLibelle, uneDate, UnIntervenant);
            this.mesPrestation.Add(unePrestation);
        }
        public int GetNbPrestationExterne()
        {
            int nb = 0;
            foreach (Prestation unePrestation in mesPrestation)
            {
                if (unePrestation.L_Intervenant is IntervenantExterne)
                {
                    nb = nb + 1;
                }
            }
            return nb;
        }
        public int GetNbPrestation()
        {
            int nb = 0;
            foreach (Prestation unePrestation in mesPrestation)
            {
                nb += 1;
            }
            return nb;
        }
        public int GetNbJourSoins()
        {
            int cpt = 1;
            Prestation  p;
            this.mesPrestation.Sort((x, y) => DateTime.Compare(x.DateSoin.Date, y.DateSoin.Date)); //Compare les deux date et les trie de manière décroissante
            if (this.mesPrestation.Count == 0)
            {
                return 0;
            }
            p = this.mesPrestation[0];
            foreach(Prestation maPrestation in this.mesPrestation)
            {
                cpt = cpt + maPrestation.CompareTo(p);
                p = maPrestation;
            }
            return cpt;
 
        }
        public void AfficheDossier()
        {
            Console.WriteLine("-------Debut de Dossier-------\nNom : " + this.NomPatient + " Prénom : " + this.PrenomPatient +
                " Date de Naissance : " + this.DateNaissance.Date.ToString("dd/MM/yyyy"));
            foreach (Prestation unePrestation in mesPrestation)
            {
                if (unePrestation.L_Intervenant is IntervenantExterne)
                {
                    Console.WriteLine("\t" + unePrestation.Libelle + " - " + unePrestation.DateSoin +
                                  " - " + "Intervenant : " + unePrestation.L_Intervenant.Nom + " - "
                                  + unePrestation.L_Intervenant.Prenom + " Spécialité : " + ((IntervenantExterne)unePrestation.L_Intervenant).Specialite +
                                  "\n\t" + ((IntervenantExterne)unePrestation.L_Intervenant).Adresse + " - " + ((IntervenantExterne)unePrestation.L_Intervenant).Tel + "\n");
                }
                else
                {
                    Console.WriteLine("\t" + unePrestation.Libelle + " - " + unePrestation.DateSoin +
                                  " - " + "Intervenant : " + unePrestation.L_Intervenant.Nom + " - "
                                  + unePrestation.L_Intervenant.Prenom + "\n");
                }
            }
            Console.WriteLine("-------Fin du Dossier-------\n");
        }
    }
}
