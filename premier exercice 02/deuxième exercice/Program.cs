using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deuxième_exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien de nombres premiers : ");
            string valeur1 = Console.ReadLine();
            int n = int.Parse(valeur1);

            int nbr, divise, compt = 2;
            bool estPremier;
            Console.WriteLine("1\n2");
                nbr = 3;
            while (n != compt )
            {
                divise = 3;
                estPremier = true;
                while (divise > nbr) // estPremier=false)
                {
                    if (nbr % divise == 0)
                    {
                        estPremier = false;
                   
                    }
                    else
                    {
                        divise = divise + 2;

                    }
                }
                if (estPremier == true)
                {
                    Console.WriteLine(nbr);
                    compt = compt + 1;
                }
                nbr = nbr + 2; // nbr impair

            }
            Console.ReadKey();
        }
        
    }
}
