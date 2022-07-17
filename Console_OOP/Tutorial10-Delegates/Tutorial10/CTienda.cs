using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial10
{
    internal class CTienda
    {
        static public void MandaViveres(int pKilos)
        // Metodo a invocar cuando sucede el evento
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--> Le enviaremos sus viveres. Estoy en la tienda.");
            Console.WriteLine($"--> {pKilos} kilos enviados al cliente.");
        }
    }
}
