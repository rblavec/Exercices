using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifexo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le premier nombre : ");
            string premier = Console.ReadLine();
            int p = int.Parse(premier);

            Console.WriteLine("Entrez le deuxième nombre : ");
            string deuxieme = Console.ReadLine();
            int q = int.Parse(deuxieme);

            while (p != q)
            {
                if (p > q)
                {
                    p = p - q;
                }
                else
                {
                    q = q - p;
                }
            }
            
            Console.WriteLine("Le PGCD est : " + p);
            Console.ReadLine();
        }

    }


}
