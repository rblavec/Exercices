using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int v = 0;
            Console.WriteLine("Veuillez saisir un mot :");
            string mot = Console.ReadLine();
            CalculConsVoy(mot, out c, out v);
            Console.WriteLine("\nil y a dans le mot {0} : \n-{1} voyelles \n-{2} consonnes",mot,v,c);
            Console.ReadKey();
            Console.WriteLine("\nAu revoir !");
            Console.ReadKey();


        }
        static void CalculConsVoy(string mot, out int nbrCons, out int nbrVoy)
        {
            nbrVoy = 0;
            nbrCons = 0;
            mot = mot.ToLower();
            for (int i = 0; i < mot.Length; i++)

                if (mot[i] == 'a' || mot[i] == 'e' || mot[i] == 'i' || mot[i] == 'o' || mot[i] == 'u' || mot[i] == 'y')
                {
                    nbrVoy++;
                }
                else nbrCons++;
            }
        }
    }

