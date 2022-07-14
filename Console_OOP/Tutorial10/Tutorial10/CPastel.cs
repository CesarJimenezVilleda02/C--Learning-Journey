using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial10
{
    internal class CPastel
    {
        public static void MetodoPastel(string pMsj)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Estamos en la clase pastel y el pastel dice:");
            Console.WriteLine(pMsj);
        }
    }
}
