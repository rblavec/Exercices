using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = "Triage de";
            string prenom = "données : ";
            Console.WriteLine("Bonjour, je voici le tableau intitulé {1} {0}", prenom, nom);
            string s = @"voici les données du ""tableau"" non trié : "; //@"" affiche tel quel ce qui est écris entre les doublees cotes "
            //pour mettre une double cote dans ces derniere il faut doubler les double cote "" 
            Console.WriteLine(s);
            string[] tableau = new string[4] { "a", "c", "g", "b" };
            afficherTableau(tableau);
            triTableau(tableau);
            string[] tabTrier = triTableau(tableau);
            Console.WriteLine();
            string p = @"voici les données du ""tableau"" trié : "; //@"" affiche tel quel ce qui est écris entre les doublees cotes "
            //pour mettre une double cote dans ces derniere il faut doubler les double cote "" 
            Console.WriteLine(p);
            afficherTableau(tabTrier);
            Console.ReadKey();

        }

        static void afficherTableau(string[] tabEntrée)//tabEntrée est une copie de tableau (tabEntrée est connu que dans la fonction)
        {
            for (int i = 0; i < tabEntrée.Length; i++) 
            Console.Write(tabEntrée[i] + " ");
        }

        static string []triTableau(string [] tabEntrée)//static string[] car on veut recevoir unn tableur de caractere
        {
        bool permutation = true;
        string[] tabModif = new string[tabEntrée.Length] ;
        for (int i = 0; i<tabEntrée.Length; i++)
            {
                tabModif[i] = tabEntrée[i];
            }
        while (permutation == true)
            {
                permutation = false;
                    for (int i = 1; i < tabModif.Length; i++)
                {
                    
                    int resultComp = tabModif[i - 1].CompareTo(tabModif[i]);
                    if (resultComp > 0)
                    {
                        string stockage;
                        stockage = tabModif[i];
                        tabModif[i] = tabModif[i - 1];
                        tabModif[i - 1] = stockage;
                        permutation = true;

                    }

                }
            }
            return tabModif;
        }
        

            
        
        
    }
}
