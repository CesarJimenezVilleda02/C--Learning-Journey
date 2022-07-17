using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial7_OOP
{
    internal static class Program
    {
        static void Main()
        {
            // crear instancia
            CCalculadora calc1 = new CCalculadora();

            // Acceder a los atributos
            calc1.a = 2;
            calc1.b = 3;

            calc1.Suma();

            // calc1.Muestra();

            // crear instancia
            CCalculadora calc2 = new CCalculadora();

            // Acceder a los atributos
            calc1.a = 30;
            calc1.b = 58;

            calc1.Suma();

            // calc1.Muestra();
        }
    }
}
