using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial8
{
    // Son como tipos de datos que definen comportamiento
    internal interface IOperacion
    {
        //Lo de aqui adentro va a ser la interfaz y debe llevar los prototipos
        void Calcular(double a, double b);
        void Mostrar();
    }
}
