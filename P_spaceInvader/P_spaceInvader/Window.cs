/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 22.02.2024
/// Description : Classe pour créer la fenetre de jeu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_spaceInvader
{
    internal class Window
    {
        /// <summary>
        /// largeur de la fenetre du jeu
        /// </summary>
        private int _width = 0;

        /// <summary>
        /// hauteur de la fenetre du jeu 
        /// </summary>
        private int _height = 0;

        /// <summary>
        /// definir et metre a jour la largeur de la fenetre
        /// </summary>
        public int Width 
        { 
            get { return _width; }

            set { _width = value; }
        } 

        /// <summary>
        /// definir et metre a jour la largeur de la fenetre
        /// </summary>
        public int Height 
        { 
            get { return _height; }

            set { _height = value; }
        }

        /// <summary>
        /// constructeur de la fenetre du jeu 
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Window(int width, int height)
        {
            // attribuer la valeur du parametre pour la largeur
            Width = width;

            // attribuer la valeur du parametre pour la hauteur
            Height = height;

            // creation de la fenetre avec les valeurs des parametres
            Console.SetWindowSize(Width, Height);

            // titre de la fenetre
            Console.Title = "Spicy Invader";

            // masquer le courseur de la console
            Console.CursorVisible = false;

            // effacer le menu
            Console.Clear();

        }
    }
}
