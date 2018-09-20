using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datingsimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatoire = new Random();
            int randomNames = aleatoire.Next(6);
            int randomAnimal = aleatoire.Next(3);
            int randomSchool = aleatoire.Next(7);
            int conclusion = aleatoire.Next(4);
            Console.WriteLine("");
            int value = 0;
            string name = "";
            string end = "";
            string animal = "";
            string school = "";
            int scenario = 0;
            if (randomNames == 0)
            {
                name = "Natacha";
            }
            else if (randomNames == 1)
            {
                name = "Samantha";
            }
            else if (randomNames == 2)
            {
                name = "Rosalie";
            }
            else if (randomNames == 3)
            {
                name = "Annie";
            }
            else if (randomNames == 4)
            {
                name = "Julie";
            }
            else if (randomNames == 5)
            {
                name = "Mélissa";
            }
            if (conclusion == 0)
            {
                end = "Alors ils vécurent heureux et eurent beaucoup d'enfants";
            }
            else if (conclusion == 1)
            {
                end = "Ils allèrent donc se fourrer en silence dans un buisson";
            }
            else if (conclusion == 2)
            {
                end = "L'homme fourra et s'en alla, laissant la fille seule, en pleurs";
            }
            else if (conclusion == 3)
            {
                end = "C'était l'amour avec un grand A, une parfaite chime, à chaque sodium revient son chlore";
            }
            if (randomAnimal == 0)
            {
                animal = "chats";
            }
            else if (randomAnimal == 1)
            {
                animal = "chiens";
            }
            else if (randomAnimal == 2)
            {
                animal = "hamsters";
            }
            if (randomSchool == 0)
            {
                school = "Aménagement et urbanisme";
            }
            else if (randomSchool == 1)
            {
                school = "Travail Social";
            }
            else if (randomSchool == 2)
            {
                school = "ATM";
            }
            else if (randomSchool == 3)
            {
                school = "Musique";
            }
            else if (randomSchool == 4)
            {
                school = "Arts et lettres";
            }
            else if (randomSchool == 5)
            {
                school = "Sciences humaines";
            }
            else if (randomSchool == 6)
            {
                school = "Sciences natures";
            }
            Console.WriteLine("Bienvenue dans le Dating Simulator, pour repondre, veuillez appuyer sur le chiffre des mots à dire puis enter. Pour continuer, appuyer sur  n importe quelle touche.");
            Console.ReadKey();
            Console.WriteLine("Une jolie fille vous approche...");
            Console.WriteLine("1-Bonjour :)");
            Console.WriteLine("2-Euh, Salut ;p");
            value = Convert.ToInt32(Console.ReadLine());
            if (value == 1)
            {
                scenario = 1;
            }
            else if (value == 2)
            {
                Console.WriteLine("Est-ce que je deranges?");
                Console.WriteLine("1- Non, non pas du tout!");
                Console.WriteLine("2- Oui, un peu...");
                value = Convert.ToInt32(Console.ReadLine());
                if (value == 1)
                {
                    scenario = 1;
                }
                else if (value == 2)
                {
                    Console.WriteLine("Ah excuse-moi... :/");
                    Console.ReadKey();
                }
            }
            if (scenario == 1)
            {
                Console.WriteLine("Ca va?");
                Console.WriteLine("1- Super!");
                Console.WriteLine("2- Oui, j imagines...");
                value = Convert.ToInt32(Console.ReadLine());
                if (value == 1)
                {
                    scenario = 2;
                }
                else if (value == 2)
                {
                    Console.WriteLine("Es-tu sur?");
                    Console.WriteLine("1- Oui, oui ;p");
                    Console.WriteLine("2- Non, ma vie est nulle :(");
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value == 1)
                    {
                        scenario = 2;
                    }
                    else if (value == 2)
                    {
                        Console.WriteLine("Ohh pourquoi... :(");
                        Console.WriteLine("1- Mon chat est mort, je suis en echec et je n ai pas d amis.");
                        Console.WriteLine("2- Je n ai pas envie d en parler... (air mysterieux)");
                        value = Convert.ToInt32(Console.ReadLine());
                        if (value == 1)
                        {
                            Console.WriteLine("Pauvre toi, ca ne doit pas etre facile... :(");
                            Console.WriteLine("1- Non, mais je vis avec");
                            Console.WriteLine("2- J en suis au bord du suicide...");
                            value = Convert.ToInt32(Console.ReadLine());
                            if (value == 1)
                            {
                                scenario = 2;
                            }
                            else if (value == 2)
                            {
                                Console.WriteLine("Euh... desole je dois partir... :/ (Malaise)");
                                Console.ReadKey();
                            }
                        }
                        else if (value == 2)
                        {
                            scenario = 2;
                        }

                    }
                }
            }
            if (scenario == 2)
            {
                Console.WriteLine("Nicee :), c est quoi ton nom?");
                Console.ReadLine();
                Console.WriteLine("Ah ok, moi c est " + name + "");
                Console.WriteLine("1- Joli nom ;)");
                Console.WriteLine("2- Ok");
                value = Convert.ToInt32(Console.ReadLine());
                if (value == 1)
                {
                    Console.WriteLine("Merci, toi aussi ;)");
                    Console.WriteLine("1- Merci :)");
                    Console.WriteLine("2- Merci, et toi tu as de beaux yeux ;)");
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value == 1)
                    {
                        scenario = 3;
                    }
                    else if (value == 2)
                    {
                        scenario = 4;
                    }
                }
                else if (value == 2)
                {
                    scenario = 3;
                }
            }
            if (scenario == 3)
            {
                Console.WriteLine("Dis-moi, tu aimes les " + animal + "?");
                Console.WriteLine("1- Oui");
                Console.WriteLine("2- Non");
                Console.ReadLine();
                Console.WriteLine("T es dans quel programme?");
                Console.ReadLine();
                Console.WriteLine("Cool moi c est " + school + "(appuyez sur une touche)");
                Console.ReadKey();
                Console.WriteLine("Qu est ce que vous lui dites?");
                Console.WriteLine("1- T'as un joli cul :)");
                Console.WriteLine("2- T'as de beaux yeux ;)");
                Console.WriteLine("3- T'as de beaux cheveux <3");
                Console.WriteLine("4- Kesse tu veux au fond?");
                Console.WriteLine("5- T'es mignonne ;p");
                Console.WriteLine("6- Bon, on va fourrer?");
                Console.WriteLine("7- Qu'est ce que tu dirais d'une promenade romantique? ;)");
                value = Convert.ToInt32(Console.ReadLine());
                if (value == 1)
                {
                    Console.WriteLine("Gros cochon! Déguerpis!");
                    Console.ReadKey();
                }
                else if (value == 2)
                {
                    scenario = 4;
                }
                else if (value == 3)
                {
                    scenario = 4;
                }
                else if (value == 4)
                {
                    Console.WriteLine("Non mais t'es con ou quoi? Je m'en vais c'est bon...");
                    Console.ReadKey();
                }
                else if (value == 5)
                {
                    scenario = 4;
                }
                else if (value == 6)
                {
                    Console.WriteLine("WTF! On se connais à peine! T'es qu'un sale gros pervers!");
                    Console.ReadKey();
                }
                else if (value == 7)
                {
                    Console.WriteLine("Tu lis dans mes pensées? ;) <3 (appuyez sur une touche)");
                    Console.ReadKey();
                    Console.WriteLine("" + end + "");
                }

            }
            if (scenario == 4)
            {
                Console.WriteLine("Oh merci, t'es trop chou <3 (appuyez sur une touche)");
                Console.ReadKey();
                Console.WriteLine("Dis-moi, es-ce que tu m'aimes?");
                Console.WriteLine("1- Oui");
                Console.WriteLine("2- Non");
                value = Convert.ToInt32(Console.ReadLine());
                if (value == 1)
                {
                    Console.WriteLine("" + end + "");
                    Console.ReadKey();
                }
                else if (value == 2)
                {
                    Console.WriteLine("Non mais c'est quoi l'idée de niaiser une pauvre fille innocente comme moi :'(");
                    Console.ReadKey();
                }
            }
        }
    }
}
