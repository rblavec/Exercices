using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace premier_exercice_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la valeur du premier nombre : ");
            string valeur1 = Console.ReadLine();
            int p = int.Parse(valeur1);

            Console.WriteLine("Entrez la valeur du second nombre : ");
            string valeur2 = Console.ReadLine(); //Sa retourne une chaine de caractères
            int q = int.Parse(valeur2); //c'est une sorte de convertisseur

           while (p!=q)
            {

           if (p>q)
                {
                    p = p - q;
                }
           else
                {
                    q = q - p;
                        }

            }

            Console.WriteLine("le PGCD de ces deux nombres est de " + p);
            Console.ReadKey();
        }
    }
}
