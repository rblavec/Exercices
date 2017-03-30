using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statut
{
    class Personne
    {


        #region méthodes

        public override string ToString()
        {
            return string.Format("{0}, {1} : {2}", Nom, Prenom, Statut);
        }
        #endregion


        #region propriétés
        public string Nom { get; }
        public string Prenom { get; }
        public StatutEmployés Statut { get; }
        #endregion propriétés




        #region constructeurs
        public Personne(string nom, string prenom, StatutEmployés statut) 
        {
            Nom = nom;
            Prenom = prenom;
            Statut = statut;

        }

        #endregion


    }
}
