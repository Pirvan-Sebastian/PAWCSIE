using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    public class Bilet : IPretCalculabil, IValidabil
    {
        public string NumeFilm { get; set; }
        public int NumarSala { get; set; }
        public TipFilm TipFilm { get; set; }
        public DateTime ExpiraLa { get; set; }
        public Client Client { get; set; }

        private int _numarLoc;

        public int NumarLoc
        {
            get { return _numarLoc; }
            set
            {
                if (value < 1 || value > 200)
                    throw new ArgumentOutOfRangeException("Numarul locului este invalid");
                else
                    _numarLoc = value;
            }
        }

        private double _pretBaza;
        public double PretBaza
        {
            get { return _pretBaza; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Pretul de baza este invalid");
                _pretBaza = value;
            }
        }

        public Bilet(string numeFilm, int numarSala, TipFilm tipFilm, DateTime expiraLa, Client client, int numarLoc, double pretBaza)
        {
            NumeFilm = numeFilm;
            NumarSala = NumarSala;
            TipFilm = TipFilm;
            Client = Client;
            NumarLoc = NumarLoc;
            PretBaza = PretBaza;

        }


        public double CalculeazaPretFinal()
        {
            throw new NotImplementedException();
        }

        public virtual bool EsteValid()
        {
            throw new NotImplementedException();
        }

        public virtual double GetReducere()
        {
            throw new NotImplementedException();
        }
        
    }
}
