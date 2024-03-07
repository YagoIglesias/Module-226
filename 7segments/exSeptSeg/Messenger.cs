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
        const int _MAX_SEG = 7;

        /// <summary>
        /// tableau de segments
        /// </summary>
        private Segment[] _sEmulator = new Segment[_MAX_SEG]; 

        /// <summary>
        /// tableau allumer ou etaint
        /// </summary>
        private bool[] _bEmulator = new bool[_MAX_SEG];

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="emuluator"></param>
        public Messenger(Segment[] emuluator)
        {
            _sEmulator = emuluator;
        }

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
            }
            return _sEmulator;

            /*switch (digit)
            {
                case '0':
                    _sEmulator[0] = new Segment(symbole: '═', positionX: 2, positionY: 1,  id: "A");
                    _sEmulator[1] = new Segment(symbole: '║', positionX: 3, positionY: 2,  id: "B");
                    _sEmulator[2] = new Segment(symbole: '║', positionX: 3, positionY: 4,  id: "C");
                    _sEmulator[3] = new Segment(symbole: '═', positionX: 2, positionY: 5,  id: "D");
                    _sEmulator[4] = new Segment(symbole: '║', positionX: 1, positionY: 4,  id: "E");
                    _sEmulator[5] = new Segment(symbole: '║', positionX: 1, positionY: 2,  id: "F");
                    _sEmulator[6] = new Segment(symbole: '═', positionX: 2, positionY: 3,  id: "G");

                    return _sEmulator;

                    case '1':
                    _sEmulator[0] = new Segment(symbole: '═', positionX: 2, positionY: 1,  id: "A");
                    _sEmulator[1] = new Segment(symbole: '║', positionX: 3, positionY: 2,  id: "B");
                    _sEmulator[2] = new Segment(symbole: '║', positionX: 3, positionY: 4,  id: "C");
                    _sEmulator[3] = new Segment(symbole: '═', positionX: 2, positionY: 5,  id: "D");
                    _sEmulator[4] = new Segment(symbole: '║', positionX: 1, positionY: 4,  id: "E");
                    _sEmulator[5] = new Segment(symbole: '║', positionX: 1, positionY: 2,  id: "F");
                    _sEmulator[6] = new Segment(symbole: '═', positionX: 2, positionY: 3,  id: "G");
                    return _sEmulator;


                case '2':
                    _sEmulator[0] = new Segment(symbole: '═', positionX: 2, positionY: 1,  id: "A");
                    _sEmulator[1] = new Segment(symbole: '║', positionX: 3, positionY: 2,  id: "B");
                    _sEmulator[2] = new Segment(symbole: '║', positionX: 3, positionY: 4,  id: "C");
                    _sEmulator[3] = new Segment(symbole: '═', positionX: 2, positionY: 5,  id: "D");
                    _sEmulator[4] = new Segment(symbole: '║', positionX: 1, positionY: 4,  id: "E");
                    _sEmulator[5] = new Segment(symbole: '║', positionX: 1, positionY: 2,  id: "F");
                    _sEmulator[6] = new Segment(symbole: '═', positionX: 2, positionY: 3,  id: "G");
                    return _sEmulator;

                    case '3':
                    _sEmulator[0] = new Segment(symbole: '═', positionX: 2, positionY: 1,  id: "A");
                    _sEmulator[1] = new Segment(symbole: '║', positionX: 3, positionY: 2,  id: "B");
                    _sEmulator[2] = new Segment(symbole: '║', positionX: 3, positionY: 4,  id: "C");
                    _sEmulator[3] = new Segment(symbole: '═', positionX: 2, positionY: 5,  id: "D");
                    _sEmulator[4] = new Segment(symbole: '║', positionX: 1, positionY: 4,  id: "E");
                    _sEmulator[5] = new Segment(symbole: '║', positionX: 1, positionY: 2,  id: "F");
                    _sEmulator[6] = new Segment(symbole: '═', positionX: 2, positionY: 3,  id: "G");
                    return _sEmulator;

                    case '4':
                    _sEmulator[0] = new Segment(symbole: '═', positionX: 2, positionY: 1,  id: "A");
                    _sEmulator[1] = new Segment(symbole: '║', positionX: 3, positionY: 2,  id: "B");
                    _sEmulator[2] = new Segment(symbole: '║', positionX: 3, positionY: 4,  id: "C");
                    _sEmulator[3] = new Segment(symbole: '═', positionX: 2, positionY: 5,  id: "D");
                    _sEmulator[4] = new Segment(symbole: '║', positionX: 1, positionY: 4,  id: "E");
                    _sEmulator[5] = new Segment(symbole: '║', positionX: 1, positionY: 2,  id: "F");
                    _sEmulator[6] = new Segment(symbole: '═', positionX: 2, positionY: 3,  id: "G");
                    return _sEmulator;

                    case '5':
                    _sEmulator[0] = new Segment(symbole: '═', positionX: 2, positionY: 1,  id: "A");
                    _sEmulator[1] = new Segment(symbole: '║', positionX: 3, positionY: 2,  id: "B");
                    _sEmulator[2] = new Segment(symbole: '║', positionX: 3, positionY: 4,  id: "C");
                    _sEmulator[3] = new Segment(symbole: '═', positionX: 2, positionY: 5,  id: "D");
                    _sEmulator[4] = new Segment(symbole: '║', positionX: 1, positionY: 4,  id: "E");
                    _sEmulator[5] = new Segment(symbole: '║', positionX: 1, positionY: 2,  id: "F");
                    _sEmulator[6] = new Segment(symbole: '═', positionX: 2, positionY: 3,  id: "G");
                    return _sEmulator;

                    case '6':
                    _sEmulator[0] = new Segment(symbole: '═', positionX: 2, positionY: 1,  id: "A");
                    _sEmulator[1] = new Segment(symbole: '║', positionX: 3, positionY: 2,  id: "B");
                    _sEmulator[2] = new Segment(symbole: '║', positionX: 3, positionY: 4,  id: "C");
                    _sEmulator[3] = new Segment(symbole: '═', positionX: 2, positionY: 5,  id: "D");
                    _sEmulator[4] = new Segment(symbole: '║', positionX: 1, positionY: 4,  id: "E");
                    _sEmulator[5] = new Segment(symbole: '║', positionX: 1, positionY: 2,  id: "F");
                    _sEmulator[6] = new Segment(symbole: '═', positionX: 2, positionY: 3,  id: "G");
                    return _sEmulator;

                    case '7':
                    _sEmulator[0] = new Segment(symbole: '═', positionX: 2, positionY: 1,  id: "A");
                    _sEmulator[1] = new Segment(symbole: '║', positionX: 3, positionY: 2,  id: "B");
                    _sEmulator[2] = new Segment(symbole: '║', positionX: 3, positionY: 4,  id: "C");
                    _sEmulator[3] = new Segment(symbole: '═', positionX: 2, positionY: 5,  id: "D");
                    _sEmulator[4] = new Segment(symbole: '║', positionX: 1, positionY: 4,  id: "E");
                    _sEmulator[5] = new Segment(symbole: '║', positionX: 1, positionY: 2,  id: "F");
                    _sEmulator[6] = new Segment(symbole: '═', positionX: 2, positionY: 3,  id: "G");
                    return _sEmulator ;

                    case '8':
                    _sEmulator[0] = new Segment(symbole: '═', positionX: 2, positionY: 1,  id: "A");
                    _sEmulator[1] = new Segment(symbole: '║', positionX: 3, positionY: 2,  id: "B");
                    _sEmulator[2] = new Segment(symbole: '║', positionX: 3, positionY: 4,  id: "C");
                    _sEmulator[3] = new Segment(symbole: '═', positionX: 2, positionY: 5,  id: "D");
                    _sEmulator[4] = new Segment(symbole: '║', positionX: 1, positionY: 4,  id: "E");
                    _sEmulator[5] = new Segment(symbole: '║', positionX: 1, positionY: 2,  id: "F");
                    _sEmulator[6] = new Segment(symbole: '═', positionX: 2, positionY: 3,  id: "G");
                    return _sEmulator;

                    case '9':
                    _sEmulator[0] = new Segment(symbole: '═', positionX: 2, positionY: 1,  id: "A");
                    _sEmulator[1] = new Segment(symbole: '║', positionX: 3, positionY: 2,  id: "B");
                    _sEmulator[2] = new Segment(symbole: '║', positionX: 3, positionY: 4,  id: "C");
                    _sEmulator[3] = new Segment(symbole: '═', positionX: 2, positionY: 5,  id: "D");
                    _sEmulator[4] = new Segment(symbole: '║', positionX: 1, positionY: 4,  id: "E");
                    _sEmulator[5] = new Segment(symbole: '║', positionX: 1, positionY: 2,  id: "F");
                    _sEmulator[6] = new Segment(symbole: '═', positionX: 2, positionY: 3,  id: "G");
                    return _sEmulator;

                default:
                    return _sEmulator;
            }*/


        }




        /*/// <summary>
        /// chifre a afficher
        /// </summary>
        public int NumberToDisplay { get; set; }

        /// <summary>
        /// activer le DP
        /// </summary>
        public bool Activate { get; set; }

        /// <summary>
        /// position sur l'axe x
        /// </summary>
        public int PositionXmessenger { get; set; }

        /// <summary>
        /// position sur l'axe Y
        /// </summary>
        public int PositionYmessenger { get; set; }


        /// <summary>
        /// constructeur messenger
        /// </summary>
        /// <param name="positionX"></param>
        /// <param name="positionY"></param>
        public Messenger()
        {
 
            
        }

        /// <summary>
        /// méthode pour afficher
        /// </summary>
        /// <param name="numberToDisplay"></param>
        public void SevenDisplay(int numberToDisplay)
        {
            NumberToDisplay = numberToDisplay;

            switch (NumberToDisplay)
            {
                case 0:
                    segA.OnOFF(true);
                    segB.OnOFF(true);
                    segC.OnOFF(true);
                    segD.OnOFF(true);
                    segE.OnOFF(true);
                    segF.OnOFF(true);
                    segG.OnOFF(false);
                break;

                case 1:
                    segA.OnOFF(false);
                    segB.OnOFF(false);
                    segC.OnOFF(false);
                    segD.OnOFF(false);
                    segF.OnOFF(true);
                    segE.OnOFF(true);
                    segG.OnOFF(false);
                break;

                case 2:
                    segA.OnOFF(true);
                    segB.OnOFF(true);
                    segG.OnOFF(true);
                    segE.OnOFF(true);
                    segD.OnOFF(true);
                    segF.OnOFF(false);
                    segC.OnOFF(false);
                break;

                case 3:
                    segA.OnOFF(true);
                    segB.OnOFF(true);
                    segG.OnOFF(true);
                    segE.OnOFF(false);
                    segD.OnOFF(true);
                    segF.OnOFF(false);
                    segC.OnOFF(true);
                break;

                case 4:
                    segA.OnOFF(false);
                    segB.OnOFF(true);
                    segC.OnOFF(true);
                    segD.OnOFF(false);
                    segE.OnOFF(false);
                    segF.OnOFF(true);
                    segG.OnOFF(true);
                 break;

                case 5:
                    segA.OnOFF(true);
                    segB.OnOFF(false);
                    segC.OnOFF(true);
                    segD.OnOFF(true);
                    segE.OnOFF(false);
                    segF.OnOFF(true);
                    segG.OnOFF(true);
                break;

                case 6:
                    segA.OnOFF(true);
                    segB.OnOFF(false);
                    segC.OnOFF(true);
                    segD.OnOFF(true);
                    segE.OnOFF(true);
                    segF.OnOFF(true);
                    segG.OnOFF(true);
                break;

                case 7:
                    segA.OnOFF(true);
                    segB.OnOFF(true);
                    segC.OnOFF(true);
                    segD.OnOFF(false);
                    segE.OnOFF(false);
                    segF.OnOFF(false);
                    segG.OnOFF(false);
                break;

                case 8:
                    segA.OnOFF(true);
                    segB.OnOFF(true);
                    segC.OnOFF(true);
                    segD.OnOFF(true);
                    segE.OnOFF(true);
                    segF.OnOFF(true);
                    segG.OnOFF(true);
                break;

                case 9:
                    segA.OnOFF(true);
                    segB.OnOFF(true);
                    segC.OnOFF(true);
                    segD.OnOFF(true);
                    segE.OnOFF(false);
                    segF.OnOFF(true);
                    segG.OnOFF(true);
                break;

                default:
                    break;
            }

        }

        /// <summary>
        /// activer le DP
        /// </summary>
        /// <param name="activate"></param>
        public void DisplayDOT(bool activate)
        {
            Activate = activate;

            if (Activate == true)
            {
                Console.SetCursorPosition(segDP.PositionX, segDP.PositionY);
                Console.WriteLine(" " + segDP.SegForm);
            }
            else if (Activate == false)
            {

            }
        }*/


    }
}
