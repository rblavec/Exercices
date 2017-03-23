using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refetout
{
    class Program
    {
        static void Main(string[] args)
        {
            int v;//nombre de voyelles
            int c;//nombre de cosonnes
            Console.WriteLine("saisir un mot : ");//saisi du mot par l'utilisateur
            string motUser = Console.ReadLine();//on enregistre le mot dans la variable motUser    
            voyCons(out v, out c, motUser);//on appel la fonction de passage par reference et on envoir le motUser ce qu'on passe en parametre de la fonction, v, c et motUSER
            Console.WriteLine("{0}, comprend {1} cosonnes et {2} voyelles", motUser, c, v);//on ecris le texte entre cote puis on entre avec des accolades les variables
            //puis on les défini en fin de texte
            Console.ReadLine();

        }
        static void voyCons(out int nbrvoy, out int nbrCons, string motUser)//on met pas de out ) string motUser ce qui permet de conserver les majuscules du mot ecris 
            //par l'utilsateur
        {
            nbrvoy = 0;//on met de base la valeur de voyelle et consonnes à 0
            nbrCons = 0;
            motUser = motUser.ToLower();//met le mot en minuscule car on a entré en bas les lettres aeiou en minuscule.
            for(int i=0; i<motUser.Length; i++)//on scan le mot
            {
                if (motUser[i] == 'a' || motUser[i] == 'e' || motUser[i] == 'i' || motUser[i] == 'o' || motUser[i] == 'u' || motUser[i] == 'y')//Caractère donc simple cote
                {
                    nbrvoy++;//alt+fleche deplace la ligne
                }
                else nbrCons++;
            }
        }
    }
}
