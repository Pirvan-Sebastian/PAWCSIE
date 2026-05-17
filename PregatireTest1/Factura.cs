using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregatireTest1
{
    [Serializable]
    public enum StatusFactura { Emis, Platita}
    public class Factura
    {
        public DateTime DataEmitere { get; set; }
        public DateTime DataScadenta { get; set; }
        public string Serie {  get; set; }
        public int Numar {  get; set; }
        public string Client {  get; set; }
        public decimal Suma {  get; set; }
        public StatusFactura Status { get; set; }

        public bool EsteDepasita
        {
            // getter pentru Prop EsteDepasita 
            //Daca data de acum e mai mare ca data scadenta, a depasit
            // return true deci e depasita
            get { return DateTime.Now.Date > DataScadenta.Date; }
        }
    }
}
