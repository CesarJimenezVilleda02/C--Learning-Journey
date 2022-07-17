using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial8
{
    internal class CResta
    {
        private double r = 0;
        private ArrayList resultados = new ArrayList();

        // Metodos a implementar --- deben tener las mismas caracteristicas
        public void calcular(double a, double b)
        {
            r = a - b;
        }
        public void mostrar()
        {
            Console.WriteLine("El resultado de la resta es(0)", r);
            resultados.Add(r);
        }

        // Metodos propios de la clase
        public void muestraResultados()
        {
            // Primero invoca el GetEnumerator e invoca MoveNext(), checa si es verdadero, con Current guarda en r y se sigue
            // el foreach hace el typecast adecuado
            foreach (double r in resultados)
                Console.WriteLine(r);
        }
    }
}
