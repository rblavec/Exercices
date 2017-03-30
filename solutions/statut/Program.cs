using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statut
{
    class Program
    {
        static void Main(string[] args)
        {


            Personne p1 = new Personne("TURPIN", "Abel", StatutEmployés.CDI);
            Personne p2 = new Personne("BONNEAU", "Achille", StatutEmployés.CDD | StatutEmployés.DP);
            Personne p3 = new Personne("BLONDEL", "Adelphe", StatutEmployés.CDI | StatutEmployés.DP | StatutEmployés.CHSCT | StatutEmployés.SYND );
            Personne p4 = new Personne("BLACK", "Aimé", StatutEmployés.CDI);
            Personne p5 = new Personne("PERRIER", "Aimée", StatutEmployés.CDI);
            Personne p6 = new Personne("JORDAN", "Alain", StatutEmployés.CDD | StatutEmployés.CHSCT );
            Personne p7 = new Personne("BAUDRY", "Alban", StatutEmployés.CDD);
            Personne p8 = new Personne("ORLEANS", "Albert", StatutEmployés.CDI| StatutEmployés.DP | StatutEmployés.SYND);
            Personne p9 = new Personne("VALOIS", "Alexandra", StatutEmployés.CDI | StatutEmployés.SYND);
            Personne p10 = new Personne("WEST", "Alexandre", StatutEmployés.CDI | StatutEmployés.CHSCT | StatutEmployés.DP | StatutEmployés.SYND);
            List<Personne> Liste = new List<Personne>();
            Liste.Add(p1);
            Liste.Add(p2);
            Liste.Add(p3);
            Liste.Add(p4);
            Liste.Add(p5);
            Liste.Add(p6);
            Liste.Add(p7);
            Liste.Add(p8);
            Liste.Add(p9);
            Liste.Add(p10);

            foreach (var a in Liste)
            {
                
                Console.WriteLine(a);
            }



            List<Personne> cddChsct = new List<Personne>();
            cddChsct.Add(p6);
            foreach (var b in Liste)           
            {
                if (true)
                {
                    //TODO : gérer le test if

                }
                
                Console.WriteLine(b);
            }

            List<Personne> cdiDp = new List<Personne>() { p3, p8, p10 };
           

            Console.ReadKey();

        }
    }


    [Flags]
    public enum StatutEmployés
    {
        Aucun = 0,
        CDI = 1,
        CDD = 2,
        DP = 4,
        CHSCT =8,
        SYND = 16
    }

}
