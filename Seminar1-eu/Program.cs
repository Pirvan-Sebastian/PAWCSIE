using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Client c = new Client("vilcea", "Lucian", "adrsevaemail@gmail.com", "0724543090");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
