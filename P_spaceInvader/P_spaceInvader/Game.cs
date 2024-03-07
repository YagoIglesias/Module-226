/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 25.01.2024
/// Description : Classe pour lancer le jeu 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_spaceInvader
{
    internal class Game
    {
        /// <summary>
        /// méthode pour commencer le jeu
        /// </summary>
        public void StartGame()
        {
            // création de la fenetre pour le jeu
            Window window = new Window(width: 150, height: 40);

            SpaceShip playerShip = new SpaceShip(positionX:75, positionY: 40,lives:3, symbole: " <*> ");
            playerShip.Draw();
            while (true)
            {
                playerShip.Update(15);

            }
            
        }
    }
}
