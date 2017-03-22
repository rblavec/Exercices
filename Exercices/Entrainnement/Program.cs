using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrainnement
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
            Console.ReadKey();
        }

        static void Demo()
        {
            string texte;
            string phrase;
            int nbPhrases, nbmots, nbCaractères; //plusieurs déclaration

            const double PI = 3.1415926;
            const string DEB_LISTE = " - ";

            phrase = "Le C# est un langage moderne et puissant!"; // on affecte une valeur avec le signe = à la variable phrase
            texte = phrase;
            texte = texte + " Il est utilisé pour toutes sortes d'applications\n"; // + permet de concatainé des chaines entres elles
            texte += DEB_LISTE + "Application console\n"; // texte = texte + "abc" peut aussi se dire texte += "abc"
            texte += DEB_LISTE + "Application denétrée winforms et WPF\n";

            Console.WriteLine(texte);
            char lettre;
            lettre = phrase[3]; //on prend le character numero 3 de la chaine de characters phrase
            Console.WriteLine(lettre); // on met pas de guillemet

            //short s = 2;
            // s++; // s = 3 peut se dire s = s + 1; ou s += 1; ou encore s++;
            // Console.WriteLine("la valeur de s est : " + s); 

            //int[] tabPos = new int[3]; // on a declarer un tableau de 3 entiers / on a un tableau avec des cases vides ici on peut déclarer de 0 à 2 vu qu'on a 3 cases
            //char[] tabChars = new char[5];  
            //tabPos[0] = 3; //ici on rempli les cases du tableau composé d'entiers on dit qu'on l'initialise
            //tabPos[1] = 3;
            //tabPos[2] = 4;

            int[] tabPos = new int[5] { 3, 4, 40, 50, 60 }; //autre façon de faire un tableau d'entiers
            // Console.WriteLine(tabPos); // si on met juste comme sa on aura system.int32 
            //string s = ""; peut aussi se dire string s = string.Empty; sa veut dire que la chaine est vide

            Console.WriteLine(tabPos.Length); //longeur du tableau, nombre d'éléments

            for (int i = 0; i < tabPos.Length; i++) //on créé un entier i initialisé à 0 et à chaque boucle sa l'incremente de 1 tant que i<longueur du tableau
            {// int i = 0 =variable compteur et tabPos.Length indique la taille si on met i+=2 sa saute de 2 
                //et si on veut le faire à l'enver i-- mais on dois faire avant for (int i=tabPos.Length-1; i>=0; i--)
                Console.WriteLine(tabPos[i]); 

            }

            int j = 0;
            while (j < tabPos.Length) //sa veut dire la même chose que le bloc au dessu avec la boucle int = 0; i > tabPos.Length; i++)
            {
                Console.WriteLine(tabPos[j]);
                j++;


            }

            Console.Clear(); //efface l'écran
            Console.WriteLine(texte);

            nbPhrases = 0;
            for (int i = 0; i < texte.Length; i++) //attention au sens de > !!
            {
                if (texte[i] == '\n') // les caractères uniques sont mis entre simple ' et non des doubles // = est une affectation, == est une comparaison
                {
                    nbPhrases++;

                }

            }
            Console.WriteLine("il y a " + nbPhrases + " phrases dans le texte");

            Console.Clear();
            int nbMots = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase [i] == ' ' || phrase[i] == '\'' || phrase[i] == '\n' ) //|| veut dire ou // '\'' veut dire que l'on compte le caractère '
                {
                    nbMots++;
                }

            }
            nbMots++;
            Console.WriteLine("il y a " + nbMots + " mots dans le texte");

            Console.WriteLine("entrer un nombre :");
            string valeur = Console.ReadLine();

            int x = int.Parse(valeur);

        }

    }
}
