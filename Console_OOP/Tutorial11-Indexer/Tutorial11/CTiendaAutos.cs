using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial11
{
    internal class CTiendaAutos
    {
        private ArrayList disponibles;

        public CTiendaAutos()
        {
            disponibles[0] = new CAuto("Soul", 220000.50);
            disponibles[1] = new CAuto("Fit", 175600.70);
            disponibles[2] = new CAuto("March", 168900.00);
            disponibles[3] = new CAuto("Spark", 160400.40);
        }

        // Indexer --- ponemos el this para usar la clase actual y luego definimos el arg que 
        // usaremos que entrara con la sintaxis []
        // En donde esta el this iria el nombre de la propiedad, con esto podemos usar tienda[1] en vez de tienda.disponibles[1]
        public CAuto this[int indice]
        {
            get { return (CAuto)disponibles[indice]; }
            set { disponibles[indice] = value; }
        }
    }

}
