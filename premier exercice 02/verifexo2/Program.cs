using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifexo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien de nombres premiers ?");
            string valeur = Console.ReadLine();
            int n = int.Parse(valeur);

            int nbr, divis, compt = 2;
            bool estPremier;
            Console.WriteLine("1\n2");
            nbr = 3;


                while (n != compt)
            {
                divis = 3;
                estPremier = true;

                while (divis > nbr)
                {
                    if (nbr % divis == 0)
                    {
                        estPremier = false;
                    }
                    else
                    {
                        divis = divis + 2;

                    }
                   
                }
                nbr = nbr + 2;//nbr impairs

            } 


        }
    }
}
