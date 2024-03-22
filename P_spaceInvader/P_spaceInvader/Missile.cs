/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 22.02.2024
/// Description : Creation de la classe Missile affin de pouvoir créer l'objet missile

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace P_spaceInvader
{
    internal class Missile
    {
        /// <summary>
        /// position du missile sur l'axe X
        /// </summary>
        private int _positionX = 0;
        /// <summary>
        /// position du missile sur l'axe Y
        /// </summary>
        private int _positionY = 0;
        /// <summary>
        /// vitesse du missile
        /// </summary>
        private double _speed = 0;
        /// <summary>
        /// nombre de vies du missile
        /// </summary>
        private int _lives = 0;
        /// <summary>
        /// forme du missile
        /// </summary>
        private string _symbole = null;
        /// <summary>
        /// recuperer ou mettre a jour la position sur l'axe X du missile 
        /// </summary>
        public int PositionX 
        { 
            get 
            { 
                return _positionX; 
            } 
            set 
            {
                _positionX = value; 
            } 
        }
        /// <summary>
        /// recuperer ou mettre a jour la position sur l'axe Y du missile 
        /// </summary>
        public int PositionY 
        {
            get 
            { 
                return _positionY; 
            }

            set 
            { 
                _positionY = value; 
            }

        }
        /// <summary>
        /// recuperer ou mettre a jour la vitesse du missile
        /// </summary>
        public double Speed
        { 
            get 
            { 
                return _speed;
            } 
            set 
            { 
                _speed = value;
            } 
        }
        /// <summary>
        /// recuperer ou mettre a jour la vie du missile 
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
        /// recuperer ou mettre a jour la forme du missile 
        /// </summary>
        public string Symbole 
        { 
            get 
            { 
                return _symbole; 
            } 
            set 
            { 
                _symbole = value; 
            } 
        }

        /// <summary>
        /// constructeur qui permet d'initialiser le missile 
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        /// <param name="lives"></param>
        /// <param name="symbole"></param>
        public Missile(int positionX,int positionY, int lives, string symbole)
        {
            _positionX = positionX;
            _positionY = positionY;
            _lives = lives;
            _symbole = symbole; 

        }

        /// <summary>
        /// mettre a jour le missile
        /// </summary>
        public void Update(double speed,int posX,int posY)
        {
            // vitesse du missile 
            _speed = speed;
            // position du vaiseau sur l'axeX
            _positionX = posX;
            // position du vaiseau sur l'axeY
            _positionY = posY;


            // dessiner le missile jusqu'a la hauteur max
            for (int i = 0; i < Console.WindowHeight-3; i++)
            {
                // possitioner le courseur
                Console.SetCursorPosition(_positionX,_positionY--);
                // voir le missile
                Thread.Sleep(Convert.ToInt32(speed));
                // dessiner le vaiseau
                Draw();
                // possitioner le courseur
                Console.SetCursorPosition(_positionX, _positionY);
                Console.WriteLine("   ");

                // si le missile attaint la hauteur maximale 
                if (_positionY == Console.WindowHeight-36)
                {
                    _lives = 0;
                    Console.SetCursorPosition(_positionX, _positionY);
                    Draw();

                }

            }
            // une fois le misile finis son parcours on lui rajoute une vie
            _lives = 1;

            // on crée un nouveau 
            IsAlive();

        }

        /// <summary>
        /// méthode pour dessiner le missile
        /// </summary>
        public void Draw()
        {
            // si le misile a une vie on peut le dessiner 
            if (_lives > 0)
            {
                // position du courseur dans l'axe X et Y
                Console.SetCursorPosition(_positionX, _positionY - 1);
                // dessiner la forme du missile
                Console.WriteLine(_symbole);
            }


        }

        /// <summary>
        /// méthode pour verifier la vie du missile 
        /// </summary>
        /// <param name="isAlive"></param>
        /// <returns></returns>
        public bool IsAlive()
        {
            bool isAlive = false;

            if (Lives > 0)
            {
                isAlive = true;
            }
            // si le missile a pas de vie on l'efface
            else
            {
                isAlive = false;
                _symbole = " ";
                Console.WriteLine(_symbole);
            }
            return isAlive;
        }



        

    }
}
