using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculeDeux
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicule car = new Voiture("Citroen", Energie.GPL);
            Console.WriteLine(car.Description);

            Vehicule mot = new Moto("Harley", Energie.Essence);
            Console.WriteLine(mot.Description);
            Console.ReadKey();


        }
    }

    public class Vehicule
    {
        private string _nom;
        private int _nbRoues;
        private Energie _energie;

        #region propriétés
        public string nom { get; }
        public int nbRoues { get; }
        public Energie energie { get; }
        public virtual string Description
        {
            get
            {
                return string.Format("Vehicule {0} roule sur {1} roues et à l'énergie {2}\n", _nom, _nbRoues, _energie);
            }

        }
        #endregion


        #region constructeur
        public Vehicule(string nom, int nbRoues, Energie energie)
        {
            _nom = nom;
            _nbRoues = nbRoues;
            _energie = energie;
        }
        #endregion
    }

    public class Moto : Vehicule
    {

        #region constructeur
        public Moto(string nom, Energie energie) : base("Harley Davidson", 2, Energie.GPL)
        {

        }
        #endregion
        public override string Description
        {
            get
            {
                return string.Format("Je suis une moto\r\n") + base.Description;
            }
        }
    }

    public class Voiture : Vehicule
    {
        #region constructeur
        public Voiture(string nom, Energie energie) : base(nom, 4, Energie.Electrique)
        {

        }
        #endregion
        public override string Description
        {
            get
            {
                return "Je suis une voiture\r\n" + base.Description;
            }

        }

    }

    public enum Energie
    {
        Aucune,
        Essence,
        GPL,
        Electrique
    }
}
