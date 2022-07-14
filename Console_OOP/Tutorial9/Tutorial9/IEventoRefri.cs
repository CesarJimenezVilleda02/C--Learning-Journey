using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial9
{
    // Aqui se va a definir el evento del refri
    interface IEventoRefri
    {
        // Cantidad de alimento
        void EReservasBajas(int pKilos);

        void EDescongelado(int grados);
    }
}
