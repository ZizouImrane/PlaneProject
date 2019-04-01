using System;
/* 
* Project   : PlaneProject
* Authors   : Schaub Yannis, El-Haddad Imrane
* Group     : IBO A3
*/
namespace PlaneProject
{
    public class Vol
    {
        Random rand = new Random();

        private string ville_dep;
        private string ville_arr;
        private string heure_dep;
        private string heure_arr;
        private Avion avion;
        /*private Avion_B avion2;
        private Avion_C avion3;*/
        private Pilote p1;
        private int num;
        private static readonly string[] stat = new string[] { "À l'heure", "Retardé", "Annulé" };

        public Vol(string ville_dep, string ville_arr, string heure_dep, string heure_arr, Avion a)
        {
            this.ville_dep = ville_dep;
            this.ville_arr = ville_arr;
            this.heure_dep = heure_dep;
            this.heure_arr = heure_arr;
            this.avion = a;
        }

        public Vol()
        {
            this.ville_dep = "0";
            this.ville_arr = "0";
            this.heure_dep = "0";
            this.heure_arr = "0";
            this.num = rand.Next(1, 9999);
            this.avion = new Avion_A("Cons", 0, 0, 0);
            this.p1 = new Pilote();

        }
        public String StatusA()
        {
            if(Avion.Test(0.7)) // on fait en sorte que ça marche toujours car on a aucune info sur la manière dont doit être réalisé le test
            {
                return( "Statut du vol n° "+Num+" : "+stat[0]+"\n\nVille départ : "+Ville_dep+" | Heure départ : "+Heure_dep+"\nVille arrivée : "+Ville_arr+" | Heure arrivée : "+Heure_arr+"\n");
            }
            else
            {
                return ("Vol n° " + Num + " : " + stat[1] + "\n\nVille départ : " + Ville_dep + " | Heure départ : -- \nVille arrivée : " + Ville_arr + " | Heure arrivée : -- \n");
            }

        }

        public String StatusB()
        {
            if (Avion2.Nb_Equipage(25)) // je fais en sorte que ça marche car on a aucune info sur la manière de l'utiliser
            {
                return("Statut du vol n° " + Num + " : " + stat[0] + "\n\nVille départ : " + Ville_dep + " | Heure départ : " + Heure_dep + "\nVille arrivée : " + Ville_arr + " | Heure arrivée : " + Heure_arr + "\n");
            }
            else
            {
                return ("Vol n° " + Num + " : " + stat[1] + "\n\nVille départ : " + Ville_dep + " | Heure départ : -- \nVille arrivée : " + Ville_arr + " | Heure arrivée : -- \n");

            }
        }

        public String StatusC()
        {
            if (Avion3.ExpYear(P1))
            {
                return("Statut du vol n° " + Num + " : " + stat[0] + "\n\nVille départ : " + Ville_dep + " | Heure départ : " + Heure_dep + "\nVille arrivée : " + Ville_arr + " | Heure arrivée : " + Heure_arr + "\n");
            }
            else
            {
                return ("Vol n° " + Num + " : " + stat[1] + "\n\nVille départ : " + Ville_dep + " | Heure départ : -- \nVille arrivée : " + Ville_arr + " | Heure arrivée : -- \n");
            }
        }

        public string Ville_dep { get => ville_dep; set => ville_dep = value; }
        public string Ville_arr { get => ville_arr; set => ville_arr = value; }
        public string Heure_dep { get => heure_dep; set => heure_dep = value; }
        public string Heure_arr { get => heure_arr; set => heure_arr = value; }
        public Avion Avion { get => avion; set => avion = value; }
        public int Num { get => num; set => num = value; }
        public Pilote P1 { get => p1; set => p1 = value; }
    }
}
