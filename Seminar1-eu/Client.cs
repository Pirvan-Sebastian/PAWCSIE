using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    public class Client
    {
        public string Nume { get; set; }

        public string Prenume { get; set; }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Contains("@") && value.Contains('.'))
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException("Email invalid");
                }
            }

        }

        private string _telefon;
        public string Telefon
        {
            get { return _telefon; }
            set
            {
                if (value.Length != 10)
                    throw new ArgumentException("Numar de telefon invalid");
                _telefon = value;
            }

        }

    public Client(string nume, string prenume, string email, string telefon)
        {
            Nume = email;
            Prenume = prenume;
            Email = email;
            Telefon = telefon;
        }
    }
}
