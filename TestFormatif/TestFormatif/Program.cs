/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date   : 14.03.2024
/// Description : Program du test formatif 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFormatif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciation des 5 personnes
            Person artikodin = new Person(lastName: "Amiel", firstName: "Albert",
                                          nickName: "Artikodin", telNbr: "+41 78 123 45 67", 
                                          mailAdr: "aa@poke.org");

            Person bulbizard = new Person(lastName: "Blanc", firstName: "Barnabé",
                nickName: "Bulbizard", telNbr: "+41 79 876 54 32", mailAdr: "bb@poke.org");

            Person chelours = new Person(lastName: "Cina", firstName: "Cédric",
                nickName: "Chelours", telNbr: "+41 76 555 11 22", mailAdr: "cc@poke.org");

            Person draco = new Person(lastName: "Dutronc", firstName: "Damien", 
                nickName: "Draco", telNbr: "+41 77 666 00 07", mailAdr: "dd@poke.org");

            Person evoli = new Person(lastName: "Ecoffey", firstName: "Eric", nickName: "Evoli", telNbr: "+41 79 454 45 45", mailAdr: "ee@poke.org");

            // intanciation de la liste de personnes
            List<Person> personList = new List<Person>();

            // ajout des personnes
            personList.Add(artikodin);
            personList.Add(bulbizard);
            personList.Add(chelours);
            personList.Add(draco);
            personList.Add(evoli);

            // variable pour la reponse de l'utilisateur
            string answer = " ";

            // boucle pour continuer ou arreter
            do
            {
                // affichage du programe
                Console.WriteLine("SAISIE:   Respectez le pattern => [ nickname > message ]");
                Console.WriteLine("          Si rien  n'est saisi, le programme passe à la suite");

                // instancier un memo
                Memo memo = new Memo(message: " ");

                // boucle pour la saisie
                while (memo.Message != "")
                {
                    // instanciation de l'object memo 
                    memo = new Memo(message: Console.ReadLine());

                    // tableau de memo
                    string[] tab = memo.Message.Split(' ');

                    // parcourrir la lsite pour avoir le nickName
                    foreach (Person item in personList)
                    {
                        // si l'index du tableu est = au nickname de la personne
                        if (tab[0] == item.NickName)
                        {
                            // on attribue le memo à cette personne
                            item.WriteMemo(memo.Message);

                        }

                    }


                }

                // affichage
                Console.WriteLine("AFFICHAGE: ");
                Console.WriteLine();

                // parcourrie la liste de personnes 
                for (int i = 0; i < personList.Count; i++)
                {
                    // parcourir la liste des memos des personnes
                    for (int j = 0; j < personList[i].Memos.Count; j++)
                    {
                        // afficher le nom complet
                        Console.WriteLine(personList[i].GetFullName() + " =>");
                        // afficher le memo
                        Console.WriteLine("  " + personList[i].Memos[j].Message);
                    }

                }
                // demander si l'utilisateur veut continuer
                Console.WriteLine("Voulez-vous continuer ? (o / n): ");
                answer = Console.ReadLine().ToLower();

            } while (answer != "n");


            




          

            // pas fermer la console
            Console.ReadLine();
        }
    }
}
