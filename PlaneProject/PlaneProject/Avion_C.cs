using System;
/* 
* Project   : PlaneProject
* Authors   : Schaub Yannis, El-Haddad Imrane
* Group     : IBO A3
*/
namespace PlaneProject
{
    public class Avion_C : Avion
    {

        public Avion_C(string type, float poid, int capacite, int rayon) : base(type, poid, capacite, rayon)
        {
        }


        public bool ExpYear(Pilote p1)
        {
            if (p1.Annee_experience < 5)
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
