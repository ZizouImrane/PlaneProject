using System;
using System.Collections.Generic;
/* 
* Project   : PlaneProject
* Authors   : Schaub Yannis, El-Haddad Imrane
* Group     : IBO A3
*/
namespace PlaneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour ! Bienvenue dans votre outil de gestion des vols.\nCombien de vols voulez vous créer ?");
            int n=int.Parse(Console.ReadLine());
            int i = 0;
            List<string> info = new List<string>();
            do
            {
                Console.WriteLine("Type d'avion ? 1 pour grand, 2 pour moyen, 3 pour petit\n");
                int k = int.Parse(Console.ReadLine());

                if (k == 1)
                {
                    Avion_A a1 = new Avion_A("Boeing", 2999, 500, 29);
                    Pilote p1 = new Pilote(); //Pas besoin d'initialiser ses variables
                    Vol v1 = new Vol();
                    Console.WriteLine("Ville de départ : ");
                    v1.Ville_dep = Console.ReadLine();
                    Console.WriteLine("Ville d'arrivée : ");
                    v1.Ville_arr = Console.ReadLine();
                    Console.WriteLine("Heure départ : ");
                    v1.Heure_dep = Console.ReadLine();
                    Console.WriteLine("Heure arrivée : ");
                    v1.Heure_arr = Console.ReadLine();
                    v1.Avion1 = a1;
                    info.Add(v1.StatusA());
                    /* INUTILE
                    if (v1.GetType() == typeof(Avion_A))
                    {
                        v1.StatusA();
                    }
                    else if (v1.GetType() == typeof(Avion_B))
                    {
                        v1.StatusB();
                    }
                    else if (v1.GetType() == typeof(Avion_C))
                    {
                        v1.StatusC();
                    }*/

                    i++;
                }

                else if (k == 2)
                {

                    Avion_B a2 = new Avion_B("A333", 1500, 300, 25);
                    Pilote p2 = new Pilote(); //Pas besoin d'initialiser ses variables
                    Vol v2 = new Vol();
                    Console.WriteLine("Ville de départ : ");
                    v2.Ville_dep = Console.ReadLine();
                    Console.WriteLine("Ville d'arrivée : ");
                    v2.Ville_arr = Console.ReadLine();
                    Console.WriteLine("Heure départ : ");
                    v2.Heure_dep = Console.ReadLine();
                    Console.WriteLine("Heure arrivée : ");
                    v2.Heure_arr = Console.ReadLine();
                    v2.Avion2 = a2;

                    info.Add(v2.StatusB());
                    i++;
                }

                else if (k == 3)
                {

                    Avion_C a3 = new Avion_C("A380", 1175, 200, 19);
                    Pilote p3 = new Pilote(); //Pas besoin d'initialiser ses variables
                    p3.Matricule = 1154;
                    p3.Nom = "Paul Skins";
                    p3.Adresse = "13 rue du loup phoque";

                    p3.Annee_experience = 7; // ANNEE EXPERIENCE DU PILOTE ici car on aucune information sur la manière de l'utiliser

                    Vol v3 = new Vol();
                    Console.WriteLine("Ville de départ : ");
                    v3.Ville_dep = Console.ReadLine();
                    Console.WriteLine("Ville d'arrivée : ");
                    v3.Ville_arr = Console.ReadLine();
                    Console.WriteLine("Heure départ : ");
                    v3.Heure_dep = Console.ReadLine();
                    Console.WriteLine("Heure arrivée : ");
                    v3.Heure_arr = Console.ReadLine();
                    v3.Avion3 = a3;

                    info.Add(v3.StatusC());
                    i++;
                }
                else
                {
                    Console.WriteLine("Saisir un chiffre compris entre 1 et 3");
                    System.Environment.Exit(1);
                }
            }
            while (i < n) ;
            Console.Clear();
            for (int j = 0;j<n;j++)
            {
                Console.WriteLine(info[j]);
            }
        }
    }
}
