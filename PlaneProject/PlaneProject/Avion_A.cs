using System;
/* 
* Project   : PlaneProject
* Authors   : Schaub Yannis, El-Haddad Imrane
* Group     : IBO A3
*/
namespace PlaneProject
{
    public class Avion_A : Avion
    {
        private const double seuil = 0.5;

        public Avion_A(string type, float poid, int capacite, int rayon) : base(type, poid, capacite, rayon)
        {

        }

        public bool Test(double condition)
        {
            if (condition >= seuil)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
