using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceErreurs
{
    class Program
    {
        static void Main(string[] args)
        {
            string id = "";
            bool loginOk = false;
            while (loginOk == false)
            {
                Console.WriteLine("Veuillez saisir un identifiant d'au moins 5 caractères:");
                id = Console.ReadLine();
                
                try
                {
                    verificationLogin(id);
                    Console.WriteLine("Votre identifiant a été validé !");
                    loginOk = true;
                }
                catch (FormatException erreur)
                {
                    Console.WriteLine(erreur.Message);
                    
                }
            }
            string mdp = "";
            bool mdpOk = false;
            while (mdpOk == false)
            {
                Console.WriteLine("\nVeuillez saisir un mot de passe contenant entre 6 et 12 caractères :");
                mdp = Console.ReadLine();
                try
                {
                    verificationMdp(mdp);
                    Console.WriteLine("\nVotre mot de passe a été validé !");
                    mdpOk = true;
                }
                catch (FormatException erreur2)
                {
                    Console.WriteLine(erreur2.Message);
                }

            }
                Console.WriteLine("\nVotre compte a bien été créé. Un message vient de vous être envoyé");
                Console.WriteLine("\nVeuillez noter votre nouvelle identifiant et mot de passe :\n-Id : {0}\n-mdp : {1}", id, mdp);
                Console.ReadLine();
        }

        static bool verificationLogin(string login)
        {
            bool loginOk = true;
            if (login.Length < 5)
            {
                throw new FormatException("\nVotre identifiant ne contient pas assez de caractères !\n");
                loginOk = false;
            }
            return loginOk;
        }
        
        static bool verificationMdp(string verifMdp)
        {
            bool mdpOk = true;
            if (verifMdp[0] == ' ' || verifMdp[verifMdp.Length - 1] == ' ')
            {
                throw new FormatException("\nun mot de passe ne doit pas contenir un espace en début ou en fin de mot !\n");
                mdpOk = false;
            }
            else
            {

                if (verifMdp.Length >= 6 && verifMdp.Length <= 12)
                    mdpOk = true;
                else
                {
                    throw new FormatException("\nVotre mot de passe ne contenait pas le nombre de caractères necessaires !");
                    mdpOk = false;
                }
            }
            return mdpOk;
        }
            
        }
}

