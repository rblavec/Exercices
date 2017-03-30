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

            //Boite c = new Boite();
            //c.Hauteur = 12.5;
           

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

            var a1 = new Article(1, "Article 1", 540);
            var a2 = new Article(2, "Article 2", 200);
            var a3 = new Article(3, "Article 3", 600);

            //b1.Articles.Add(2, a2);
            //b1.Articles.Add(3, a3);
            //b1.Articles.Add(1, a1); //on rajoute dans la liste a1,a2,a3

            //b1.Articles["Article 2"].Poids = 2154;

            for (int i = 0; i < b1.Articles.Count; i++)
            {
                //Console.WriteLine(b1.Articles[i]); // affiche automatiquement la méthode tostring sur l'objet mis en parametre = Console.WriteLine(b1.Articles[i].ToString());

                b1.Articles[i].Libellé = "Bouteille"; // --> avec List<Classe>, (ici Classe = Article) on aura obligatoirement des articles donc sa simplifie par rapport a ArrayList


                //if (b1.Articles[i] is Article)
                //{
                //    Article a = (Article)b1.Articles[i]; //transtypage
                //    a.Libellé = "Bouteille"; //Libellé est une propriétés  --> avec array list
                //    //((Article)b1.Articles[i]).Libellé = "gdgsdggd";

                //}
                //else
                //    throw new ArgumentException();

            }

            ////b1.Articles.RemoveAt(2);//enleve deuxieme  occurence de l'objet
            b1.Articles.Sort(); //utilise la méthode compareto sur tout les objets de Articles

            foreach (var a in b1.Articles) //pour tout les objet a dans la collection b1.Article
            {
                Console.WriteLine(a);
            }


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
