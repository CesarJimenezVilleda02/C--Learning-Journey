using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial8
{
    // si esta implementando a IOperacion debe implementar todos los metodos abstractos
    internal class CSuma : IOperacion, ICloneable, IComparable
    // se le pone que implementa la operacion y cloneable, para varias interfaces ponemos la comma
    {
        private double r = 0;
        // Los ArrayLists y los arreglos normales son un objeto que tiene la interfaz IEnumerable por lo que puede ser iterable
        // IEnumerable tiene un metodo GetEnumerator() que nos da el iterador
        // IEnumerable resultados = new ArrayList();
        ArrayList resultados = new ArrayList();

        // Metodos a implementar --- deben tener las mismas caracteristicas
        public void Calcular(double a, double b)
        {
            r = a + b;
        }
        public void Mostrar()
        {
            Console.WriteLine("El resultado de la suma es(0)", r);
            resultados.Add(r);
        }

        // Metodos propios de la clase
        public void muestraResultados()
        {
            // En el for each se pueden usar IEnumerable
            foreach (double r in resultados)
                Console.WriteLine(r);
            // IEnumerator tiene 3 metodos
            // bool  MoveNext()
            // object Current { get; }
            // void Reset();
        }

        public object Clone()
        {
            // Retornamos un objeto con la misma infrmacion
            CSuma temp = new CSuma();
            temp.resultados = resultados;
            return temp;
        }

        // Hay varios metodos que esperan que tengas el IComparable para sortear por ejemplo
        // en los arreglos existe el .Sort(), el cual necesita el ICoparable
        public int CompareTo(object compare)
        {
            // le hacmos el casting
            CSuma temp = (CSuma)compare;

            // El local es menor
            if(temp.r > r) return -1;
            // Es mayor
            if(temp.r < r) return 1;
            // Iguales
            else return 0;
        }
    }
}
