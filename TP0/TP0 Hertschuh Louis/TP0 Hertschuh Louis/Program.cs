using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        int etatProgramme = 2;

        while (etatProgramme == 2)
        {
            string nom = string.Empty;
            string prenom = string.Empty;
            string sortieNomprenom = string.Empty;
            Console.WriteLine("Bienvenue sur mon programme, jeune étranger imberbe!");

            Console.WriteLine("Donne moi ton nom, vil chenapan");
            while (nom == string.Empty)
            {
                nom = Console.ReadLine();
                if (nom.Any(char.IsDigit))
                {
                    Console.WriteLine("Le nom contient au moins un chiffre");
                    nom = string.Empty;
                }
            }


            Console.WriteLine("Et quel est ton prénom, petit galopin : ");
            while (prenom == string.Empty)
            {
                prenom = Console.ReadLine();
                if (prenom.Any(char.IsDigit))
                {
                    Console.WriteLine("Le prénom contient au moins un chiffre");
                    prenom = string.Empty;
                }
            }

            sortieNomprenom = string.Format("Bonjour {0} ! ", formatNomPrenom(nom, prenom));
            Console.WriteLine(sortieNomprenom);

            int taille = 0; //En cm
            int poids = 0; //En kg
            int age = 0;

            Console.WriteLine("Quel est ta taille (en cm) ?");
            while (taille <= 0)
            {
                if (!int.TryParse(Console.ReadLine(), out taille))
                {
                    Console.WriteLine("Erreur : nombre invalide");
                }
                else if (taille <= 0)
                {
                    Console.WriteLine("La taille soit être supérieur à 0");
                    taille = 0;
                }
            }

            Console.WriteLine("Quel est ton poids (en kg) ?");
            while (poids <= 0)
            {
                if (!int.TryParse(Console.ReadLine(), out poids))
                {
                    Console.WriteLine("Erreur : nombre invalide");
                }
                else if (poids <= 0)
                {
                    Console.WriteLine("Le poids soit être supérieur à 0");
                    poids = 0;
                }
            }

            float imc = calculIMC(poids, taille);

            Console.WriteLine(string.Format("Vous avez un IMC de {0}.", imc.ToString("0.0")));
            commenterIMC(imc);
            Console.WriteLine("Quel est ton âge ?");
            while (age <= 0)
            {
                if (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Erreur : nombre invalide");
                }
                else if (age <= 0)
                {
                    Console.WriteLine("L'âge soit être supérieur à 0");
                    age = 0;
                }
            }

            if (age < 18)
            {
                Console.WriteLine("Haha le minot");
            }

            int nombreCheveux = 0;
            Console.WriteLine("Combien as tu de cheveux ?");
            while (nombreCheveux < 100000 || nombreCheveux > 150000)
            {
                if (!int.TryParse(Console.ReadLine(), out nombreCheveux))
                {
                    Console.WriteLine("Erreur : nombre invalide");
                }
                else if (nombreCheveux > 150000)
                {
                    Console.WriteLine("Erreur : trop de cheveux");
                }
                else if (nombreCheveux < 100000)
                {
                    Console.WriteLine("Erreur : trop peu de cheveux");
                }
            }

            
            
            int selectionNouveauEtatProgramme = 0;
            
            Console.WriteLine("Fin du programme, que voulez vous faire ? ");
            Console.WriteLine("1 - Quitter le programme");
            Console.WriteLine("2 - Recommencer le programme");
            Console.WriteLine("3 - Compter jusqu'à 10");
            Console.WriteLine("4 - Téléphoner à Tata Jacqueline");
            
            while (selectionNouveauEtatProgramme == 0)
            {
                if (!int.TryParse(Console.ReadLine(), out selectionNouveauEtatProgramme) )
                {
                    Console.WriteLine("Erreur : nombre invalide");
                    selectionNouveauEtatProgramme = 0;
                }
                else if (selectionNouveauEtatProgramme < 1 || selectionNouveauEtatProgramme > 4)
                {
                    Console.WriteLine("Erreur : le nombre choisi n'est pas entre 1 et 4");
                    selectionNouveauEtatProgramme = 0;
                }
                else
                {
                    etatProgramme = selectionNouveauEtatProgramme;
                }
            }
        }

        if (etatProgramme == 3)
        {
            Console.WriteLine("Comptage :");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i.ToString());
                Thread.Sleep(1000);
            }
            etatProgramme = 1;
        }

        if (etatProgramme == 4)
        {
            Console.WriteLine("Téléphone : +33602842019");
            Thread.Sleep(1000);

                Console.WriteLine("Bip......");
                
                
                Thread.Sleep(2000);

                Console.WriteLine("Elle vous a raccroché au nez....");
                Thread.Sleep(2000);

                etatProgramme = 1;
        }

        if (etatProgramme == 1)
        {
            Console.WriteLine("So long, king bowser (message d'aurevoir).");
            Thread.Sleep(3000);
            return;
        }


        return; //Return au cas ou on quitte la boucle
    }

    private static string formatNomPrenom(string nom, string prenom)
    {
        return string.Format("{0} {1}", prenom.ToLower(), nom.ToUpper());
    }

    private static float calculIMC(int poids, int taille)
    {
        float tailleEnMetre = taille / (float)100;
        return poids / (tailleEnMetre * tailleEnMetre);
    }

    private static void commenterIMC(float imc)
    {
        const string commentaire0 = "Attention à l’anorexie !";
        const string commentaire1 = "Vous êtes un peu maigrichon !";
        const string commentaire2 = "Vous êtes de corpulence normale !";
        const string commentaire3 = "Vous êtes en surpoids !";
        const string commentaire4 = "Obésité modérée !";
        const string commentaire5 = "Obésité sévère !";
        const string commentaire6 = "Obésité morbide !";
        if (imc < 16.5)
        {
            Console.WriteLine(commentaire0);
        }
        else if (imc < 18.5)
        {
            Console.WriteLine(commentaire1);
        }
        else if (imc < 25)
        {
            Console.WriteLine(commentaire2);
        }
        else if (imc < 30)
        {
            Console.WriteLine(commentaire3);
        }
        else if (imc < 35)
        {
            Console.WriteLine(commentaire4);
        }
        else if (imc < 40)
        {
            Console.WriteLine(commentaire5);
        }
        else
        {
            Console.WriteLine(commentaire6);
        }
    }
}