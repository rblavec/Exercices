using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tabMots = new string [5] { "a", "d", "b", "c", "a" }; //les crochets indique la creation d'un tableau et il ne faut pas oublié de l'initialiser avec new string
            
            affichagetableau(tabMots);
            triTableau(tabMots);
            affichagetableau(tabMots);
            Console.ReadKey();
        }

        static void affichagetableau (string [] tab)
        {
            for (int i = 0; i < tab.Length; i++)
                Console.Write(tab[i] + " ");
                       
        }

        static void triTableau (string[] tri)
        {
            int comparaison;
            string caisse;
            bool changement = true;

            while (changement == true)
            {
                changement = false;
                for (int i = 0; i < tri.Length - 1; i++)
                {

                    comparaison = tri[i].CompareTo(tri[i + 1]);
                    if (comparaison > 0)
                    {
                        caisse = tri[i];
                        tri[i] = tri[i + 1];
                        tri[i + 1] = caisse;

                    }


                }
            }
            Console.ReadLine();

        }
    }
}
