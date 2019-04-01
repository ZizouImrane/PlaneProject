using System;
/* 
* Project   : PlaneProject
* Authors   : Schaub Yannis, El-Haddad Imrane
* Group     : IBO A3
*/
namespace PlaneProject
{
    abstract public class Avion
    {

        protected string type;
        protected double poid;
        protected int capacite;
        protected int rayon;

        protected Avion(string type, double poid, int capacite, int rayon)
        {
            this.type = type;
            this.poid = poid;
            this.capacite = capacite;
            this.rayon = rayon;
        }

        public abstract bool Test();

    }
}
