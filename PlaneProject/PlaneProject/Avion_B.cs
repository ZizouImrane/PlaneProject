using System;
/* 
* Project   : PlaneProject
* Authors   : Schaub Yannis, El-Haddad Imrane
* Group     : IBO A3
*/
namespace PlaneProject
{
    public class Avion_B : Avion
    {
        private static int nb_min = 20; // On fixe à 20 le nombre minimal d'équipage

        public Avion_B(string type, float poid, int capacite, int rayon) : base(type, poid, capacite, rayon)
        {
        }

        public bool Nb_Equipage(int nb_equipage)
        {
            if(nb_equipage < nb_min)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
