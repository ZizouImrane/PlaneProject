using System;
/* 
* Project   : PlaneProject
* Authors   : Schaub Yannis, El-Haddad Imrane
* Group     : IBO A3
*/
namespace PlaneProject
{
    public class Pilote
    {
        private int matricule;
        private string nom;
        private string adresse;
        private int annee_experience;

        public Pilote()
        {
        }

        public int Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Annee_experience { get => annee_experience; set => annee_experience = value; }
    }
}