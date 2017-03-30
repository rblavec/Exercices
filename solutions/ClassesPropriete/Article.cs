using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPropriete
{
    public class Article : IComparable // toutes les classes sont des dérivés d'Object
    {
        public int Id { get; }
        public string Libellé { get; set; }
        public double Poids { get; set; }


        public Article(int id, string libellé, double poids)
        {
            Id = id;
            Libellé = libellé;
            Poids = poids;
            
        }

        public override string ToString()
        {
           return string.Format("{0}, {1}, {2}g", Id, Libellé, Poids);
        }

        public int CompareTo(object obj)//renvoie un 0 1 ou -1 selon le resultat de la comparaison
        {

            Article a = (Article)obj;//transforme object en article
            return Poids.CompareTo(a.Poids);

        }
    }
}
