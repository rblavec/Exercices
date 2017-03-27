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
            Boite b1 = new Boite(30, 40, 50);
            Boite b2 = new Boite(24, 56, 74);
            Etiquette etqDest = new Etiquette { Couleur = Couleurs.blanc, Format = Formats.L, Texte = "Adresse" };
            Etiquette etqFrag = new Etiquette { Couleur = Couleurs.rouge, Format = Formats.S, Texte = "FRAGILE" };
            b2.Etiqueter(etqDest, etqFrag);
            b1.Etiqueter("M.Dupont Jean", true);
            Boite b3 = new Boite(15, 5, 12);
            Etiquette etq = new ClassesPropriete.Etiquette { Couleur = Couleurs.bleu, Texte = "texte divers", Format = Formats.XL };
            Console.WriteLine("Il y a {0} boites", Boite.NbBoites);
            Console.ReadKey();
            //Math.Abs();
        }


    }

    public enum Couleurs
    {
        blanc,
        bleu,
        vert,
        jaune,
        orange,
        rouge,
        marron
    }

    public enum Matieres
    {
        carton,
        plastique,
        bois,
        métal
    }

    public enum Formats
    {
        XS,
        S,
        M,
        L,
        XL

    }


}
