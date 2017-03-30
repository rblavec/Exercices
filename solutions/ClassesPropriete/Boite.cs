using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPropriete
{
    public class Boite
    {
        #region champs privés
        private double _hauteur;
        private double _longeur;
        private double _largeur;
        private Couleurs _couleur;
        private Matieres _matiere;
        private static int _nbBoites = 0;
        private Etiquette _etiquetteFragile;
        private Etiquette _etiquetteDest;
        #endregion



        public void Etiqueter(string destinataire)
        {
            _etiquetteDest = new Etiquette { Couleur = Couleurs.blanc, Format = Formats.L, Texte = destinataire };
            //MyObject obj = new MyObject(); --> creation d'instance
            Console.WriteLine("{0} {1} {2}", _etiquetteDest.Couleur, _etiquetteDest.Format, _etiquetteDest.Texte);


        }

        public void Etiqueter(string destinataire, bool fragile)//composition
        {
            if (fragile)
            {
                _etiquetteFragile = new Etiquette { Couleur = Couleurs.rouge, Format = Formats.S, Texte = "FRAGILE" };

            }
            Etiqueter(destinataire);

        }

        public void Etiqueter(Etiquette destinataire, Etiquette fragile)//agregation
        {
            _etiquetteDest = destinataire;
            _etiquetteFragile = fragile;
        }
        


        public bool Compare(Boite autreBoite)
        {
            if (this.Hauteur == autreBoite.Hauteur && this.Largeur == autreBoite.Largeur &&
                 this.Longeur == autreBoite.Longeur && this.Matiere == autreBoite.Matiere)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region Constructeurs
        public Boite()
        {
            //_matiere = TypeMatiere.carton;
            //_hauteur = 30.0;
            //_longeur = 30.0;
            //_largeur = 30.0;
            _nbBoites++;
            //Articles = new ArrayList();
            Articles = new List<Article>();
            //Articles = new Dictionary<int, Article>();
        }

        public Boite(double Long, double Larg, double Haut) : this()
        {
            _hauteur = Long;
            _longeur = Larg;
            _largeur = Haut;
        }

        public Boite(Matieres Mat, double Long, double Larg, double Haut) : this(Long, Larg, Haut)
        {
            Matiere = Mat;
        }


        #endregion


        #region Propriétés
        //public ArrayList Articles { get; } //sa met des objets dans la collection, tout ce qu'on voulait en tant qu'objet
        public List<Article> Articles { get; }

        //public Dictionary<int, Article> Articles { get; }


        public double Hauteur
        {
            get { return _hauteur; }
            //set { _hauteur = value; }

        }

        public double Longeur
        {
            get { return _longeur; }
        }

        public double Largeur
        {
            get { return _largeur; }
        }

        public Couleurs Couleur { get; set; }// = les deux lignes du dessous
                                             //    {
                                             //        get { return _couleur; }
                                             //set { _couleur = value; }
                                             //    }

        public Matieres Matiere { get; private set; }// = la ligne du dessous
        //{
        //    get { return _matiere; }
        //}

        public double Volume
        {
            get { return _largeur * _longeur * _hauteur; }
        }

        public static int NbBoites
        { get { return _nbBoites; } }


        #endregion


    }
}
