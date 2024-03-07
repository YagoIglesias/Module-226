/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 29.02.2024
/// Description : Classe qui permet de créer les segments pour afficher les chiffres

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleToAttribute("UnitTest1")]

namespace exSeptSeg
{
    internal class Segment
    {
        /// <summary>
        /// forme du segment
        /// </summary>
        private char _symbole = ' '; 

        /// <summary>
        /// position sur l'axe x
        /// </summary>
        private int _X = 0;

        /// <summary>
        /// position sur l'axe Y
        /// </summary>
        private int _Y = 0;

        /// <summary>
        /// allumer ou eteindre
        /// </summary>
        private bool _on = false;

        /// <summary>
        /// nom du segmen
        /// </summary>
        private string _id = null;

        /// <summary>
        /// pouvoir utiliser le symbole
        /// </summary>
        public char Symbole
        {
            get { return _symbole; }

            /*set { _symbole = value; }*/
        }

        /// <summary>
        /// pouvoir reutiliser la position sur l'axe X
        /// </summary>
        public int X 
        { 
            get { return _X; }
            
            /*set { _X = value; }*/
        }

        /// <summary>
        /// pouvoir reutiliser la position sur l'axe Y
        /// </summary>
        public int Y 
        { 
            get { return _Y; }
            
            /*set { _Y = value; }*/ 
        }

        /// <summary>
        /// pouvoir allumer ou eteindre
        /// </summary>
        public bool On 
        { 
            get { return _on; } 

            set { _on = value; }
        }

        /// <summary>
        /// donner le nom du segment
        /// </summary>
        public string Id 
        { 
            get { return _id; }

            /*set { _id = value; }*/ 
        }

        /// <summary>
        /// constructeur des segments
        /// </summary>
        /// <param name="segForm"></param>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        /// <param name="onOff"></param>
        /// <param name="name"></param>
        public Segment(char symbole, int positionX, int positionY, string id)
        {
            _symbole = symbole;
            _X = positionX;
            _Y = positionY;
            _id = id;
        }

        /// <summary>
        /// méthode pour allumer ou eteindre 
        /// </summary>
        /// <param name="onOff"></param>
        public void OnOFF()
        {
            if (On == true)
            {
                Console.SetCursorPosition(_X, _Y);
                Console.WriteLine(_symbole);
            }
            else if (On == false)
            {
                Console.SetCursorPosition(_X, _Y);
                Console.WriteLine(" ");
            }

        }

        /// <summary>
        /// constructeur par default
        /// </summary>
        public Segment()
        {

        }

    }
}
