using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6
{
    internal class FakeDatabase
    {

        public static List<Carte> Carti = new List<Carte>()
        {
            new Carte()
            {
                Id=Guid.NewGuid(),
                Titlu="Mizerabilii",
                Autor="Victor hugo",
                Gen = GenCarte.Roman
            }
        };
    }
}
