/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 25.01.2024
/// Description : Creation de la classe veiseau pour créer des vaiseau

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Input;

namespace P_spaceInvader
{
    internal class SpaceShip
    {
        /// <summary>
        /// vitese du vaiseau 
        /// </summary>
        private double _speed = 0;
        /// <summary>
        /// position du vaiseau sur l'axe X
        /// </summary>
        private int _positionX = 0;
        /// <summary>
        /// position du vaiseau sur l'axe Y
        /// </summary>
        private int _positionY = 0;
        /// <summary>
        /// nombres de vie sur le réseau 
        /// </summary>
        private int _lives = 0;
        /// <summary>
        /// forme du vaiseau 
        /// </summary>
        private string _symbole = null;

        public int PositionX 
        { 
            get { return _positionX; }
            
            set { _positionX = value; }
        }

        public int PositionY 
        { 
            get { return _positionY; }
            
            set { _positionY = value; } 
        }

        public int Lives 
        { 
            get { return _lives; }

            set { _lives = value; }
        }

        public string Symbolbole
        {
            get { return _symbole; }

            set { _symbole = value; }
        }


        /// <summary>
        /// contructeur du vaiseau qui permet d'initialiser la position, le nombre de vies et l'image du vaisseau
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        /// <param name="lives"></param>
        /// <param name="symbole"></param>
        public SpaceShip(int positionX,int positionY,int lives,string symbole )
        {
            _positionX = positionX;
            _positionY = positionY;
            _lives = lives;
            _symbole = symbole;
        }

        /// <summary>
        /// mettre à jour le possitionement du vaiseau à chaque deplacement 
        /// </summary>
        public void Update(double speed)
        {
            _speed = speed;

            if (Keyboard.IsKeyDown(Key.Left))
            {
                // fleche gauche
                if (PositionX > 0)
                {
                    Console.SetCursorPosition(PositionX--, PositionY);
                    Thread.Sleep(Convert.ToInt32(speed));
                    Draw();
                }
                else if (PositionX == 0)
                {
                    PositionX = 0;
                }
            }

            // fleche droite
            if (Keyboard.IsKeyDown(Key.Right))
            {
                if (PositionX <= Console.WindowWidth - 7)
                {
                    Console.SetCursorPosition(PositionX++, PositionY);
                    Thread.Sleep(Convert.ToInt32(speed));
                    Draw();

                }
                else if (PositionX == Console.WindowWidth - 7)
                {
                    PositionX = Console.WindowWidth - 7;
                }
            }
            // espace
            if (Keyboard.IsKeyDown(Key.Space))
            {
                // tir du missile 
                Shoot(); 
            }
                
        }

        /// <summary>
        /// desine le vaisseau à sa position
        /// </summary>
        public void Draw()
        {
            // indiquer la position ou desinner le vaiseau 
            Console.SetCursorPosition(_positionX, _positionY);
            // dessiner le vaiseau
            Console.WriteLine(_symbole);
        }

        /// <summary>
        /// retourne vrais si le nombre de vie du vaiseau est superieur à 0
        /// </summary>
        public bool IsAlive()
        {
            bool isAlive = false;   

            if (Lives > 0)
            {
                isAlive = true;
            }
            return isAlive;
        }

        /// <summary>
        /// creation d'un missile 
        /// </summary>
        Missile missile = new Missile(positionX: 75, positionY: 40, lives: 1, symbole: "  ± ");

        /// <summary>
        /// méthode pour tirer un missile 
        /// </summary>
        public void Shoot()
        {
            // si il n'y a pas de missile ou qu'un missile à plus de vie 
            if (missile.Lives > 0)
            {
                // rajouter une vie 
                missile.Lives = 1;
                // dire que le missile est en vie
                missile.IsAlive();
                // faire bouger le missile
                missile.Update(speed:15,posX:PositionX,posY:PositionY);

            }
            
        }



    }
}
