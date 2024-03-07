/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 22.02.2024
/// Description : Programme qui affiche un sept segments réalise à partir d'un diagramme de séquence

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exSeptSeg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// constantes pour le nombre max de segments
            /// </summary>
            const int _MAX_SEG = 7;

            char segmentDisplay = '9';

            // tableau de segments
            Segment[] segments = new Segment[_MAX_SEG];

            // instancier les segments 
            Messenger messenger = new Messenger(emuluator:segments);
            // si la premier case du tableau est vide on remplie le tableau 
            if (segments[0] == null)
            {
                messenger.S_DecodeDigit(segmentDisplay);
            }
            // parcurir tout les segments du tableau 
            for (int i = 0; i < segments.Length; i++)
            {
                // verifier si il sont allumer ou etaints
                segments[i].On = messenger.B_DecodeDigit(segmentDisplay)[i];
                // afficher les segments 
                segments[i].OnOFF();
            }
                      


            // pas fermer le programe
            Console.ReadLine();
        }
    }
}
