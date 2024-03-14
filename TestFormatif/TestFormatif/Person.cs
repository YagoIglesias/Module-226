/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date   : 14.03.2024
/// Description : Classe pour créer les personne 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFormatif
{
    internal class Person
    {
        private string _lastName;
        private string _firstName;
        private string _nickName;
        private string _telNbr;
        private string _mailAdr;
        private List<Memo>_memos = new List<Memo>();

        /// <summary>
        /// recuperer ou mettre a jour le prenom
        /// </summary>
        public string LastName { get { return _lastName; } }

        /// <summary>
        /// recuperer ou mettre a jour le nom
        /// </summary>
        public string FirstName { get { return _firstName; } }


        /// <summary>
        /// recuperer ou mettre a jour le nickname
        /// </summary>
        public string NickName { get { return _nickName; } }


        /// <summary>
        /// recuperer ou mettre a jour le telephone
        /// </summary>
        public string TelNbr { get { return _telNbr; } }


        /// <summary>
        /// recuperer ou mettre a jour le mail
        /// </summary>
        public string MailAdr { get { return _mailAdr; } }


        /// <summary>
        /// recuperer ou mettre a jour la liste des memos
        /// </summary>
        public List<Memo> Memos { get { return _memos;} }

        /// <summary>
        /// constructeur des personnes
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="nickName"></param>
        /// <param name="telNbr"></param>
        /// <param name="mailAdr"></param>
        public Person(string lastName,string firstName, string nickName, string telNbr, string mailAdr) 
        {
            _lastName = lastName;
            _firstName = firstName;
            _nickName = nickName;
            _telNbr = telNbr;
            _mailAdr = mailAdr;

        }

        /// <summary>
        /// màthode pour recuper le nom complet 
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            string fullName = _firstName + " " + _lastName;

            return fullName;
            
        }

        /// <summary>
        /// méthode pour ajouter un nouveau memo à la liste des memos
        /// </summary>
        /// <param name="_message"></param>
        /// <returns></returns>
        public int WriteMemo(string message) 
        {
            // intancier le message et le rajouter dans la liste
            Memo memo = new Memo(message: message);
            _memos.Add(memo);

            // conter les elements de la list
            int length = _memos.Count();
            
            //retourner les elemnts de la list
            return length;

        }



    }
}
