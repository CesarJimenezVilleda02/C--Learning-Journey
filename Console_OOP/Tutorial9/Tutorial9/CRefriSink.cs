using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial9
{
    internal class CRefriSink : IEventoRefri
        // las clases sink deben implementar al sink de eventos
    {
        public bool paro { get; set; }

        public void EReservasBajas(int pKilos)
            // Metodo a invocar cuando sucede el evento
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--> Reservas bajas de alimentos.");
            Console.WriteLine($"--> Quedan {pKilos}.");
        }

        public void EDescongelado(int grados)
        // Metodo a invocar cuando sucede el evento
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--> el refri se descongela.");

            if (grados > 0) paro = true;
        }


    }
}
