/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 29.02.2024
/// Description : Classe qui permet de créer l'object Messenger afin de l'afficher

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleToAttribute("UnitTest1")]

namespace exSeptSeg
{
    internal class Messenger
    {
        /// <summary>
        /// constantes pour le nombre max de segments
        /// </summary>
        const int _MAX_SEG = 8;

        /// <summary>
        /// tableau de segments
        /// </summary>
        private Segment[] _sEmulator = new Segment[_MAX_SEG]; 

        /// <summary>
        /// tableau allumer ou etaint
        /// </summary>
        private bool[] _bEmulator = new bool[_MAX_SEG];

        /// <summary>
        /// position sur l'axe X du messenger
        /// </summary>
        private int _positionX = 0; 

        /// <summary>
        /// position sur l'axe Y du messenger
        /// </summary>
        private int _positionY = 0;

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="emuluator"></param>
        public Messenger(Segment[] emuluator,int positionX,int positionY)
        {
            _sEmulator = emuluator;
            _positionX = positionX;
            _positionY = positionY;
        }

        /// <summary>
        /// segments actives ou desactives selon le chifre qu'on veut afficher
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        public bool[] B_DecodeDigit(char digit) 
        {
            switch (digit)
            {
                case '0':
                    _bEmulator[0] = true;
                    _bEmulator[1] = true;
                    _bEmulator[2] = true;
                    _bEmulator[3] = true;
                    _bEmulator[4] = true;
                    _bEmulator[5] = true;
                    _bEmulator[6] = false;

                    return _bEmulator;

                case '1':
                    _bEmulator[0] =  false;
                    _bEmulator[1] = false;
                    _bEmulator[2] = false;
                    _bEmulator[3] = false;
                    _bEmulator[4] = true;
                    _bEmulator[5] = true;
                    _bEmulator[6] = false;

                    return _bEmulator;

                case '2':
                    _bEmulator[0] = true;
                    _bEmulator[1] = true;
                    _bEmulator[2] = true;
                    _bEmulator[3] = true;
                    _bEmulator[4] = true;
                    _bEmulator[5] = false;
                    _bEmulator[6] = false;

                    return _bEmulator;

                case '3':
                    _bEmulator[0] = true;
                    _bEmulator[1] = true;
                    _bEmulator[2] = true;
                    _bEmulator[3] = false;
                    _bEmulator[4] = true;
                    _bEmulator[5] = false;
                    _bEmulator[6] = true;

                    return _bEmulator;

                case '4':
                    _bEmulator[0] = false;
                    _bEmulator[1] = true;
                    _bEmulator[2] = true;
                    _bEmulator[3] = false;
                    _bEmulator[4] = false;
                    _bEmulator[5] = true;
                    _bEmulator[6] = true;

                    return _bEmulator;

                case '5':
                    _bEmulator[0] = true;
                    _bEmulator[1] = false;
                    _bEmulator[2] = true;
                    _bEmulator[3] = true;
                    _bEmulator[4] = false;
                    _bEmulator[5] = true;
                    _bEmulator[6] = true;

                    return _bEmulator;

                case '6':
                    _bEmulator[0] = true;
                    _bEmulator[1] = false;
                    _bEmulator[2] = true;
                    _bEmulator[3] = true;
                    _bEmulator[4] = true;
                    _bEmulator[5] = true;
                    _bEmulator[6] = true;

                    return _bEmulator;

                case '7':
                    _bEmulator[0] = true;
                    _bEmulator[1] = true;
                    _bEmulator[2] = true;
                    _bEmulator[3] = false;
                    _bEmulator[4] = false;
                    _bEmulator[5] = false;
                    _bEmulator[6] = false;

                    return _bEmulator;

                case '8':
                    _bEmulator[0] = true;
                    _bEmulator[1] = true;
                    _bEmulator[2] = true;
                    _bEmulator[3] = true;
                    _bEmulator[4] = true;
                    _bEmulator[5] = true;
                    _bEmulator[6] = true;

                    return _bEmulator;

                case '9':
                    _bEmulator[0] = true;
                    _bEmulator[1] = true;
                    _bEmulator[2] = true;
                    _bEmulator[3] = true;
                    _bEmulator[4] = false;
                    _bEmulator[5] = true;
                    _bEmulator[6] = true;

                    return _bEmulator;

                default:

                    return _bEmulator;
            }
        }

        /// <summary>
        /// Création des segments 
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        public Segment[] S_DecodeDigit(char digit)
        {
            if (digit != ' ')
            {
                _sEmulator[0] = new Segment(symbole: '═', positionX: 2, positionY: 1, id: "A");
                _sEmulator[1] = new Segment(symbole: '║', positionX: 3, positionY: 2, id: "B");
                _sEmulator[2] = new Segment(symbole: '║', positionX: 3, positionY: 4, id: "C");
                _sEmulator[3] = new Segment(symbole: '═', positionX: 2, positionY: 5, id: "D");
                _sEmulator[4] = new Segment(symbole: '║', positionX: 1, positionY: 4, id: "E");
                _sEmulator[5] = new Segment(symbole: '║', positionX: 1, positionY: 2, id: "F");
                _sEmulator[6] = new Segment(symbole: '═', positionX: 2, positionY: 3, id: "G");
                _sEmulator[7]= new Segment(symbole: '°', positionX: 3, positionY: 5, id: "DP");
            }
            return _sEmulator;

        }

        /// <summary>
        /// activer le DP
        /// </summary>
        /// <param name="activate"></param>
        public void DisplayDOT(bool activate)
        {
            if (activate == true)
            {
                Console.SetCursorPosition(_sEmulator[7].X, _sEmulator[7].Y);
                Console.WriteLine(" " + _sEmulator[7].Symbole);
            }
            else if (activate == false)
            {

            }
        }
    }
}
