/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 25.01.2024
/// Description : Test des constructeurs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace get_set_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creation d'une constante pour le nombre d'eleves
            const int STUDENTS = 4;

            // recup average 
            double average = 0;

            // creer un tableau pour enregistrer les etudiants crees
            Student[] tabStudents = new Student[STUDENTS];

            // creation d'un eleve
            Student alfond = new Student(lastName: "Alfond", firstName: "Alexandre", studentNumber: 1001,
                classTeacher: "ACD", login: "alfondal", grade1: 4, grade2: 4.5, grade3: 5);

            //deuxieme etudiant avec constructeur par default
            Student burqui = new Student();

            // troisieme etudiant avec constructeur numero d'etudiant
            Student curchod = new Student(studentNumber: 1003);

            // quatrieme etudiant avec constructeur nom, prenom et numero de l'eleve
            Student durant = new Student(lastName: "Durant", firstName: "David", studentNumber: 1004);

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
            tabStudents[1].setFirstName("Burki");
            tabStudents[1].setLastName ("Bernard");
            tabStudents[1].StudentNumber = 1002;
            tabStudents[1].ClassTeacher = "AGT";
            tabStudents[1].setLogin("burquibe");
            tabStudents[1].Grade1 = 3.5;
            tabStudents[1].Grade2 = 0;
            tabStudents[1].Grade3 = 3.5;

            // valeurs etudiant 3 avec constructeur "numero de leleve"
            tabStudents[2].setFirstName("Curchod");
            tabStudents[2].setLastName("Christian");
            tabStudents[2].ClassTeacher = "AGX";
            tabStudents[2].setLogin("burquibe");
            tabStudents[2].Grade1 = 5;
            tabStudents[2].Grade2 = 3.5;
            tabStudents[2].Grade3 = 3;

            // valeurs etudiant avec constructeur nom, prenom et numero de l'eleve
            tabStudents[3].ClassTeacher = "AMG";
            tabStudents[3].setLogin("durandda");
            tabStudents[3].Grade1 = 6;
            tabStudents[3].Grade2 = 5.5;
            tabStudents[3].Grade3 = 5.5;

            // affichage des etudiants
            for (int i = 0; i < tabStudents.Length; i++)
            {
                // retour a la ligne
                Console.WriteLine();

                // affichage du nom, prenom, moyenne et situation
                Console.Write(tabStudents[i].getFirstName() + " " + tabStudents[i].getLastName() + "\n");
                Console.Write(tabStudents[i].Average() + "\n");
                average = tabStudents[i].Average();
                Console.WriteLine(tabStudents[i].Status(average));

                // retour a la ligne
                Console.WriteLine();

            }

            // pas fermer la console
            Console.ReadLine();

        }
    }
}
