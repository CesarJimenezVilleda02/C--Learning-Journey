using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos el refri
            CRefri miRefri = new CRefri(50, -20);
            Random rnd = new Random();

            // Creamos el sink
            // Sink1 tiene el codigo que se ejecutara cuando suceda el evento
            CRefriSink sink1 = new CRefriSink();
            CTiendaSink sink2 = new CTiendaSink();

            // Adicionamos el sink al refri
            miRefri.AgregarSink(sink1);
            miRefri.AgregarSink(sink2);

            // El refri hace su trabajo
            while (miRefri.Kilos > 0 && sink1.paro == false)
            {
                // El refri trabajayle sacamos kilos al azar
                miRefri.Trabajar(rnd.Next(1, 5));
            }

        }
    }
}
