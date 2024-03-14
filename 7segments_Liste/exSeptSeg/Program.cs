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
            const int _MAX_SEG = 8;

            // créer une liste
            List<Messenger> list = new List<Messenger>();

            // nombre de 7 segments selectionez par l'utilisateur
            char segmentDisplay = ' ';

            // demander à l'utilisateur combien de sept segments il veut 
            Console.WriteLine("Combien voulez-vous de 7-segments ? ");
            Console.Write("Votre chiffre : ");
            segmentDisplay = Convert.ToChar(Console.Read());

            // tableau de segments
            Segment[] segments = new Segment[_MAX_SEG];

            Random rnd = new Random();

            // remplir la liste avec des messenger
            for (int i = 0; i < segmentDisplay; i++)
            {
                // instancier les segments 
                Messenger messenger = new Messenger(emuluator: segments, positionX: i, positionY: 0);
                list.Add(messenger);

                int value = rnd.Next(0,_MAX_SEG);

                // si la premier case du tableau est vide on remplie le tableau 
                if (segments[0] == null)
                {
                    messenger.S_DecodeDigit(Convert.ToChar(value));
                }
                // parcurir tout les segments du tableau 
                for (int j = 0; j < segments.Length; j++)
                {
                    // verifier si il sont allumer ou etaints
                    segments[j].On = messenger.B_DecodeDigit(segmentDisplay)[j];
                    // afficher les segments 
                    segments[j].OnOFF();
                }
            }

            

            //messenger.DisplayDOT(true);         


            // pas fermer le programe
            Console.ReadLine();
        }
    }
}
