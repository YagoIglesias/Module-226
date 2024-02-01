/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 25.01.2024
/// Description : Exercice 1 module 223, implementer la classe étudiant avec des constructeurs différants

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_étudiant_Ex1_226
{
    class Students
    {
        // declaration des variables nécessaires
        /// <summary>
        /// Nom
        /// </summary>
        public string _lastName = " ";

        /// <summary>
        /// Prénom
        /// </summary>
        public string _firstName = " ";

        /// <summary>
        /// numero d'étudiant
        /// </summary>
        public int _studentNumber = 0;

        /// <summary>
        /// maître de classe 
        /// </summary>
        public string _classTeacher = " ";

        /// <summary>
        /// login 
        /// </summary>
        public string _login = " ";

        /// <summary>
        /// notes
        /// </summary>
        public double _grade1 = 0;
        public double _grade2 = 0;
        public double _grade3 = 0;

        /// <summary >
        /// constructeur pour creer un eleve avec tout les parametres
        /// </summary>
        /// <param name="lastName">nom</param>
        /// <param name="firstName">prénom</param>
        /// <param name="studentNumber">numero d'étudiant</param>
        /// <param name="classTeacher">maître principale</param>
        /// <param name="login">login</param>
        /// <param name="grade1">notes</param>
        /// <param name="grade2">notes</param>
        /// <param name="grade3">notes</param>
        public Students(string lastName, string firstName, int studentNumber, string classTeacher,
            string login, double grade1, double grade2, double grade3)
        {
            // inserer les valeurs des parametres dans les proprietes
            // nom et prenom
            _lastName = lastName;
            _firstName = firstName;

            // numero d'étudiant
            _studentNumber = studentNumber;

            // maître de classe 
            _classTeacher = classTeacher;

            // login 
            _login = login;

            // notes
            _grade1 = grade1;
            _grade2 = grade2;
            _grade3 = grade3;
            
        }
        

        /// <summary >
        /// constructeur par default
        /// </summary>
        public Students()
        {
           
        }

        /// <summary>
        /// constructeur pour creer un etudiant avec son numero d'etudiant
        /// </summary>
        /// <param name="studentNumber">numero d'étudiant</param>
        public Students(int studentNumber)
        {
            // numero d'étudiant 
            _studentNumber = studentNumber;
        }

        /// <summary>
        /// constructeur d'eleve par nom, prenom et numero d'etudiant
        /// </summary>
        /// <param name="lastName">nom</param>
        /// <param name="firstName">prénom</param>
        /// <param name="studentNumber">numero d'étudiant</param>
        public Students(string lastName, string firstName, int studentNumber)
        {
            // nom et prenom
            _lastName = lastName;
            _firstName = firstName;

            // numero d'étudiant
            _studentNumber = studentNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lastName">nom</param>
        /// <param name="firstName">prénom</param>
        /// <param name="studentNumber">numero d'étudiant</param>
        /// <param name="classTeacher">maître principale</param>
        /// <param name="login">login</param>
        public Students(string lastName, string firstName, int studentNumber, string classTeacher,
            string login)
        {
            // nom et prenom
            _lastName = lastName;
            _firstName = firstName;

            // numero d'étudiant
            _studentNumber = studentNumber;

            // maître de classe 
            _classTeacher = classTeacher;

            // login 
            _login = login;
        }

        /// <summary>
        /// méthode pour calculer la moyenne
        /// </summary>
        public double Average()
        {
            // variable pour la moyenne
            double average = 0;

            // creation et stockage de la moyenne
            average = (_grade1 + _grade2 + _grade3)/3;
            
            // retourner la valeure de la moyenne
            return Math.Round(average,2);
        }

        /// <summary>
        /// méthode pour situation de l'eleve
        /// </summary>
        public void Status()
        {
            // si la moyenne est superieure ou egale a 4 "reussite"
            if (Average() >= 4)
            {
                Console.WriteLine("En réussite");
            }
            else
            {
                Console.WriteLine("En échec");
            }
        }


    }
}
