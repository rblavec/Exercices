using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPropriete
{
    class Program
    {
        static void Main(string[] args)
        {
            double volumeObjet;
            Boite b = new Boite();
            volumeObjet = b.Volume;
            Console.WriteLine(volumeObjet);
            Console.ReadKey();

        }
    }

    public enum TypeCouleurs
    {
        blanc,
        bleu,
        vert,
        jaune,
        orange,
        rouge,
        marron
    }

    public enum TypeMatiere
    {
        carton,
        plastique,
        bois,
        métal
    }
    public class Boite
    {
        private double _hauteur;
        private double _longeur;
        private double _largeur;
        private TypeCouleurs _couleur;
        private TypeMatiere _matiere;

        public Boite()
        {
            _matiere = TypeMatiere.carton;
            _hauteur = 30.0;
            _longeur = 30.0;
            _largeur = 30.0;
        }


        #region Propriétés
        public double Hauteur
        {
            get { return _hauteur; }

        }
 
        public double Longeur
        {
            get { return _longeur; }
        }

        public double Largeur
        {
            get { return _largeur; }
        }

        public TypeCouleurs Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public TypeMatiere Matiere
        {
            get { return _matiere; }
        }

        public double Volume
        {
            get { return _largeur * _longeur * _hauteur; }
        }
        #endregion


    }

}
