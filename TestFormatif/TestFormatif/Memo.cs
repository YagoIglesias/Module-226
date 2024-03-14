/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date   : 14.03.2024
/// Description : Classe pour les memos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFormatif
{
    internal class Memo
    {
        private string _message;

        /// <summary>
        /// recuperer ou mettre a jour le message
        /// </summary>
        public string Message { get { return _message; } }


        /// <summary>
        /// recuper ou mettre a jour la date
        /// </summary>
        public DateTime _writeDate { get;}

        /// <summary>
        /// constructeur des memos 
        /// </summary>
        /// <param name="message"></param>
        public Memo(string message) 
        {
            _message = message;
        }




    }
}
