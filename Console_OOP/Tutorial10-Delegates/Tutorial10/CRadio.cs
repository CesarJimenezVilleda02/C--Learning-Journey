using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial10
{
    internal class CRadio
    {
        // Metodo que actuara como delegado
        public static void MetodoRadio(string pMsj)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la clase radio y el mensaje es:");
            Console.WriteLine(pMsj);
        }
    }
}
