/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 25.01.2024
/// Description : Classe pour créer le menu du jeu 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_spaceInvader
{
    internal class Menu
    {
        /// <summary>
        /// variable pour prendre et metre a jour le choix de l'utilisateur
        /// </summary>
        private string _playerChoice = null;

        /// <summary>
        /// recupere le choix de l'utilisateur
        /// </summary>
        public string PlayerChoice 
        { 
            get { return _playerChoice; }
            
            set { _playerChoice = value; } 
        }

        /// <summary>
        /// Constructeur de création du menu
        /// </summary>
        public Menu()
        {
            // Menu
            Console.WriteLine();
            Console.WriteLine("   ***************************");
            Console.WriteLine("  |        Spicy Invader     |");
            Console.WriteLine("   ***************************\n");
            Console.WriteLine("Menu : \n");
            Console.WriteLine("1.- Jouer\n");
            Console.WriteLine("2.- Options\n");
            Console.WriteLine("3.- Highscore\n");
            Console.WriteLine("4.- A propos\n");
            Console.WriteLine("5.- Quitter\n");

            // Choix de l'utilisateur
            Console.Write("Votre choix : ");
            PlayerChoice = Console.ReadLine();
            Console.WriteLine();

            // switch pour verifier le choix
            switch (PlayerChoice)
            {
                case "1":
                    Play();
                    break;

                case "2":
                    Options();
                    break;

                case "3":
                    About();
                    break;

                case "4":
                    Exit();
                    break;

                default:
                    Console.WriteLine("Selectionez une option de la liste");
                    break;

            }
        }

        /// <summary>
        /// méthode pour lancer le jeu
        /// </summary>
        public void Play()
        {
            // instancier l'objet game
            Game spicyInvader = new Game();
            // debuter le jeu avec la méethode
            spicyInvader.StartGame();

        }

        /// <summary>
        /// méthode pour afficher les options du jeu 
        /// </summary>
        public void Options()
        {
            Console.Clear();
            Console.WriteLine("Options : ");
            Console.WriteLine("Son : o/n");
            PlayerChoice = Console.ReadLine().ToLower();
            if (PlayerChoice == "o")
            {

            }
            else if (PlayerChoice == "n")
            {

            }
            Console.WriteLine("Difficulté :");
            Console.WriteLine("1.- Facile  2.- Difficile");
            PlayerChoice = Console.ReadLine();
            if (PlayerChoice == "1")
            {

            }
            else if (PlayerChoice == "2")
            {

            }
            Console.Clear();
            Play();
        }

        /// <summary>
        /// méthode pour afficher le score le plus haut 
        /// </summary>
        public void Highscore()
        {

        }

        /// <summary>
        /// méthode pour afficher les informations du jeu
        /// </summary>
        public void About()
        {
            Console.Clear();
            Console.WriteLine("Spicy Invader est un jeu dans le quelle nous combatons des aliens avec notre vaisseau");
            Console.Write("Le but est de detruire les aliens avant plus avoir de vie, car nous avons que 3");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1.- Menu       2.- Play");
            PlayerChoice = Console.ReadLine();

        }

        /// <summary>
        /// méthode pour sortir du menu 
        /// </summary>
        public void Exit()
        {

        }
    }
}
