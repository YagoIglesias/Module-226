/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 25.01.2024
/// Description : Test des constructeurs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_étudiant_Ex1_226
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creation d'une constante pour le nombre d'eleves
            const int STUDENTS = 4;

            // creer un tableau pour enregistrer les etudiants crees
            Students[] tabStudents = new Students[STUDENTS];

            // creation d'un eleve
            Students alfond = new Students(lastName: "Alfond", firstName: "Alexandre", studentNumber: 1001,
                classTeacher: "ACD", login: "alfondal", grade1: 4, grade2: 4.5, grade3: 5);

            //deuxieme etudiant avec constructeur par default
            Students burqui = new Students();

            // troisieme etudiant avec constructeur numero d'etudiant
            Students curchod = new Students(studentNumber:1003);

            // quatrieme etudiant avec constructeur nom, prenom et numero de l'eleve
            Students durant = new Students(lastName: "Durant", firstName: "David", studentNumber: 1004);

            // stocker l'etudiant crée dans le tableau 
            tabStudents[0] = alfond;
            tabStudents[1] = burqui;
            tabStudents[2] = curchod;
            tabStudents[3] = durant;


            // tester l'affichage d'un eleve
            /*Console.WriteLine(tabStudents[0]._lastName);
            Console.WriteLine(tabStudents[0]._firstName);
            Console.WriteLine(tabStudents[0]._studentNumber);
            Console.WriteLine(tabStudents[0]._classTeacher);
            Console.WriteLine(tabStudents[0]._login);
            Console.Write(tabStudents[0]._grade1);
            Console.Write(tabStudents[0]._grade2);
            Console.Write(tabStudents[0]._grade3);*/

            // test d'afficher la moyenne de l'eleve
            /* Console.WriteLine(alfond.Average());

             // test d'affichage de sa situation
             alfond.Status();*/

            // valeurs de l'eleve avec constructeur par default
            tabStudents[1]._firstName = "Burki";
            tabStudents[1]._lastName = "Bernard";
            tabStudents[1]._studentNumber = 1002;
            tabStudents[1]._classTeacher = "AGT";
            tabStudents[1]._login = "burquibe";
            tabStudents[1]._grade1 =3.5;
            tabStudents[1]._grade2 = 0 ;
            tabStudents[1]._grade3 = 3.5 ;

            // valeurs etudiant 3 avec constructeur "numero de leleve"
            tabStudents[2]._lastName = "Curchod";
            tabStudents[2]._firstName = "Christian";
            tabStudents[2]._classTeacher = "AGX";
            tabStudents[2]._login = "burquibe";
            tabStudents[2]._grade1 = 5;
            tabStudents[2]._grade2 = 3.5;
            tabStudents[2]._grade3 = 3;

            // valeurs etudiant avec constructeur nom, prenom et numero de l'eleve
            tabStudents[3]._classTeacher = "AMG";
            tabStudents[3]._login = "durandda";
            tabStudents[3]._grade1 = 6;
            tabStudents[3]._grade2 = 5.5;
            tabStudents[3]._grade3 = 5.5;

            // affichage des etudiants
            for (int i = 0; i < tabStudents.Length; i++)
            {
                // retour a la ligne
                Console.WriteLine();

                // affichage du nom, prenom, moyenne et situation
                Console.Write(tabStudents[i]._firstName + " " + tabStudents[i]._lastName+"\n" );
                Console.Write(tabStudents[i].Average()+"\n");
                tabStudents[i].Status();

                // retour a la ligne
                Console.WriteLine();

            }

            // pas fermer la console
            Console.ReadLine();
        }
    }
    
}
