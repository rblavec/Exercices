using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicules
{
    public class Program
    {
        static void Main(string[] args)
        {
            Voiture car = new Voiture("claude", Energie.Gazole);
            Console.WriteLine (car.Description);
            Console.ReadKey();
        }
    }

    public class Vehicule
    {
        public string Nom { get; }
        public int NbRoues { get; }
        public Energie Energie { get; }

        public virtual string Description
        {
            get
            {
                return string.Format("Véhicule {0} roule sur {1} roues et à l'énergie {2}", Nom, NbRoues, Energie);
            }

        }

        public Vehicule(string nom, int nbRoues, Energie energie)
        {
            Nom = nom;
            NbRoues = nbRoues;
            Energie = energie;

        }

    }

    public class Voiture : Vehicule
    {

        public override string Description
        {
            get
            {
                return string.Format("je suis une voiture \r\n") + base.Description ;
            }
        }
        public Voiture(string nom, Energie energie) : base(nom, 4, Energie.Gazole)
        {

        }
    }

    public enum Energie
    {
        Aucune,
        Essence,
        Gazole,
        GPL,
        Electrique
    }

}
