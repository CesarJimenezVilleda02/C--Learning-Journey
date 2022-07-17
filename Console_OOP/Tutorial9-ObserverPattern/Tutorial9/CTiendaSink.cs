using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial9
{
    internal class CTiendaSink : IEventoRefri
    {
        public void EReservasBajas(int pKilos)
        // Metodo a invocar cuando sucede el evento
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--> Le enviaremos sus viveres.");
            Console.WriteLine($"--> {pKilos} kilos enviados al cliente.");
        }

        public void EDescongelado(int grados)// no le interesa este evento a la tienda
        {
        }

    }
}
