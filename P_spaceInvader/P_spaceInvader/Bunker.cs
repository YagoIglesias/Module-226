/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 21.03.2024
/// Description : Creation de la classe Bunker affin de pouvoir créer l'objet bunker du jeux

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_spaceInvader
{
    internal class Bunker
    {
        /// <summary>
        /// variable pour la position du bunker sur l'axe X
        /// </summary>
        private int _positionX = 0;

        /// <summary>
        /// variable pour la position du bunker sur l'axe Y
        /// </summary>
        private int _positionY = 0;

        /// <summary>
        /// variable pour le symbole du bunker
        /// </summary>
        private string _symbol = null;

        /// <summary>
        /// vies du bunker 
        /// </summary>
        private int _lives = 0;

        /// <summary>
        /// recuperer la position du bunker sur l'axe X
        /// </summary>
        public int PositionX 
        { 
            get 
            { 
                return _positionX; 
            } 
        }

        /// <summary>
        /// recuperer la position du bunker sur l'axe Y
        /// </summary>
        public int PositionY 
        { 
            get 
            { 
                return _positionY; 
            } 
        }

        /// <summary>
        /// recuperer ou mettre à jour le symbole du bunker 
        /// </summary>
        public string Symbol 
        { 
            get 
            { 
                return _symbol; 
            } 
            set 
            { 
                _symbol = value; 
            } 
        }

        /// <summary>
        /// recuperer ou mettre a jour la vie du bunker 
        /// </summary>
        public int Lives 
        { 
            get 
            { 
                return _lives; 
            } 
            set 
            { 
                _lives = value; 
            } 
        }

        /// <summary>
        /// constructeur de l'object bunker
        /// </summary>
        /// <param name="positionX">permet d'inserer la position sur l'axe X</param>
        /// <param name="positionY">permet d'inserer la position sur l'axe Y</param>
        /// <param name="symbol">permet d'inserer la forme du bunker</param>
        /// <param name="lives">permet d'inser le nombre de vies du bunker</param>
        public Bunker(int positionX, int positionY, string symbol, int lives) 
        {
            _positionX = positionX;
            _positionY = positionY;
            _symbol = symbol;
            _lives = lives;

        }

        








    }
}
