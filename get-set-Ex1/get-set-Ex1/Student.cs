/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 25.01.2024
/// Description : Exercice 1 module 223, implementer la classe étudiant avec des constructeurs différants, en utilisant le get et le set

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleToAttribute("get-set-Ex1Test")] 

namespace get_set_Ex1
{
    internal class Student
    {
        // declaration des variables nécessaires
        /// <summary>
        /// Nom
        /// </summary>
        private string _lastName = " ";

        /// <summary>
        /// Prénom
        /// </summary>
        private string _firstName = " ";

        /// <summary>
        /// numero d'étudiant
        /// </summary>
        private int _studentNumber = 0;

        /// <summary>
        /// maître de classe 
        /// </summary>
        private string _classTeacher = " ";

        /// <summary>
        /// login 
        /// </summary>
        private string _login = " ";

        /// <summary>
        /// notes
        /// </summary>
        private double _grade1 = 0;
        private double _grade2 = 0;
        private double _grade3 = 0;



        /// <summary >
        /// constructeur par default
        /// </summary>
        public Student()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="studentNumber"></param>
        /// <param name="classTeacher"></param>
        /// <param name="login"></param>
        /// <param name="grade1"></param>
        /// <param name="grade2"></param>
        /// <param name="grade3"></param>
        public Student(string lastName, string firstName, int studentNumber, string classTeacher,
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

        /// <summary>
        /// constructeur pour creer un etudiant avec son numero d'etudiant
        /// </summary>
        /// <param name="studentNumber">numero d'étudiant</param>
        public Student(int studentNumber)
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
        public Student(string lastName, string firstName, int studentNumber)
        {
            // nom et prenom
            _lastName = lastName;
            _firstName = firstName;

            // numero d'étudiant
            _studentNumber = studentNumber;
        }

        /// <summary>
        /// constructeur avec parametres nom, prenom, numero d'etudiant, maitre de classe et login
        /// </summary>
        /// <param name="lastName">nom</param>
        /// <param name="firstName">prénom</param>
        /// <param name="studentNumber">numero d'étudiant</param>
        /// <param name="classTeacher">maître principale</param>
        /// <param name="login">login</param>
        public Student(string lastName, string firstName, int studentNumber, string classTeacher,
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
            average = (_grade1 + _grade2 + _grade3) / 3;

            // retourner la valeure de la moyenne
            return Math.Round(average, 2);
        }

        /// <summary>
        /// méthode pour situation de l'eleve
        /// </summary>
        public string Status(double average)
        {
            string status = " ";

            // si la moyenne est superieure ou egale a 4 "reussite"
            if (average >= 4)
            {
                status = "En réussite";
                //Console.WriteLine(status);
            }
            else
            {
                status = "En échec";
            }

            return status;

        }

        /// <summary>
        /// méthode pour recuperer le nom 
        /// </summary>
        /// <returns name="_firstName">nom</returns>
        public string getFirstName()
        {
            // si le parametre est vide ça affiche rien
            if (_firstName == null)
                return null;

            return _firstName;
            
        }

        /// <summary>
        /// méthode pour mettre a jour le nom
        /// </summary>
        /// <param name="firstName">nom</param>
        public void setFirstName(string firstName)
        {
            // si le parametre est pas vide il affiche la valeur
            if (firstName != null)
                _firstName = firstName;
            
        }

        /// <summary>
        /// méthode pour recuperer le prenom
        /// </summary>
        /// <returns name="_lastName">prenom</returns>
        public string getLastName()
        {
            return _lastName;
        }

        /// <summary>
        /// méthode pour mettre a jour le nom
        /// </summary>
        /// <param name="lastName">prenom</param>
        public void setLastName(string lastName)
        {
            _lastName = lastName;
        }

        /// <summary>
        /// propriete pour recuperer et mettre a jour le numero d'etudiant
        /// </summary>
        public int StudentNumber
        {
            get
            {
                return _studentNumber;
            }

            set
            {
                _studentNumber = value;
            }
        }

        /// <summary>
        /// proprietes pour recuperer et mettre a jour le mettre de classe
        /// </summary>
        public string ClassTeacher
        {
            get 
            { 
                return _classTeacher; 
            }

            set 
            {
                _classTeacher = value; 
            }
        }

        /// <summary>
        /// méthode pour recuperer le login
        /// </summary>
        /// <returns name="_login">login</returns>
        public string getLogin()
        {
            return _login;
        }

        /// <summary>
        /// méthode pour mettre a jour le login
        /// </summary>
        /// <param name="login">login</param>
        public void setLogin(string login)
        {
            _login = login;
        }

        /// <summary>
        /// propriete pour recuperer et mettre a jour la note1
        /// </summary>
        public double Grade1
        {
            get
            {
                return _grade1;
            }

            set 
            { 
                _grade1 = value; 
            }
        }

        /// <summary>
        /// propriete pour recuperer et mettre a jour la note2
        /// </summary>
        public double Grade2
        {
            get
            {
                return _grade2;
            }

            set
            {
                _grade2 = value;
            }
        }

        /// <summary>
        /// propriete pour recuperer et mettre a jour la note3
        /// </summary>
        public double Grade3
        {
            get
            {
                return _grade3;
            }

            set
            {
                _grade3 = value;
            }
        }


    }
}
