﻿using System;
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
            Vehicule car = new Voiture("Citroen", Energie.GPL);
            Console.WriteLine(car.Description);

            Vehicule mot = new Moto("Harley", Energie.Essence);
            Console.WriteLine(mot.Description);
            Console.ReadKey();
            //Vehicule avion = new Vehicule("nom", 5, Energie.Electrique); //Ne fonctionne pas car Vehicule est abstrait --> impossible d'instancier Vehicule

            int res = car.CompareTo(mot);//on recupere le resultat de la comparaison
            if (res < 0)
                Console.WriteLine("{0} est plus économique que {1}", car.nom, mot);
            else if (res > 0)
                Console.WriteLine("{0} est moins économique que {1}", car.nom, mot.nom);
            else
                Console.WriteLine("{0} est autant économique que {1}", car.nom, mot.nom);

            Console.ReadKey();

        }
    }

    public abstract class Vehicule : IComparable
    {
        private string _nom;
        private int _nbRoues;
        private Energie _energie;


        public abstract double CalculerConso();

        public int CompareTo(object obj)
        {
            if (obj is Vehicule)
            {
                Vehicule v;
                v = (Vehicule)obj;  // on transforme la variable de type objet en vehicule pour acceder aux propriétés de véhicule. 
                                    //Vehicule v = (Vehicule)obj;
                if (PRK < v.PRK) return -1;
                else if (PRK > v.PRK) return 1;
                else return 0;



            }
            else
                throw new ArgumentException();

        }


        #region propriétés
        public string nom { get; }
        public int nbRoues { get; }
        public Energie energie { get; }
        public abstract double PRK { get; }
        public virtual string Description
        {
            get
            {
                return string.Format("Vehicule {0} roule sur {1} roues et à l'énergie {2}.\n", _nom, _nbRoues, _energie);
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

        public override double PRK
        {
            get
            {
                return 3;
            }
        }

        public override double CalculerConso()
        {
            throw new NotImplementedException();
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

        public override double PRK
        {
            get
            {
                return 2;
            }
        }

        public override double CalculerConso()
        {
            throw new NotImplementedException();
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