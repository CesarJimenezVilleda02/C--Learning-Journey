using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial14
{
    internal class CAuto
    {
        public double costo;
        public string modelo;

        // Constructor -- valores de argumentos por defecto
        public CAuto(string pModelo = "Vosho", double pCosto = 1020)
        {
            // Inicializamos los datos
            costo = pCosto;
            modelo = pModelo;
        }

        public void MuestraInformacion()
        {
            // Mostramos la informacion necesaria
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Costo {0}", costo);
            Console.WriteLine("---------------");
        }


    }
}
