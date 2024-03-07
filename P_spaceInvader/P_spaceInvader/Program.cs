/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 25.01.2024
/// Description : Permet d'executer le programme avec toutes les classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace P_spaceInvader
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // instancier le menu 
            Menu menu = new Menu();





            // pas fermer la console
            Console.ReadLine();
        }
    }
}
