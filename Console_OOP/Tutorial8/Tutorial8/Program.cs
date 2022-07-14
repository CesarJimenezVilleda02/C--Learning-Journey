using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interface -- son como clases abstractas, indican las funciones que un objeto debe implementar
            // Sin atributos, metodos ni instanciable
            CSuma s = new CSuma();
            s.Calcular(4.5, 6.7);
            s.Mostrar();

            // Podemos guardad cualuqier objeto que tenga implementada esta interrfaz
            IOperacion operacion = new CSuma(); // no importa en donde esten en la cadena de herencia

            CSuma s2 = new CSuma();
            // Normalmente los dos harian referencia al mismo objeto, no se esta copiando
            // Con IClonable implementado podriamos hacerlo
            CSuma s3 = s2;

            //Clonandolo -- primero hacemos el casting porque retorna object no CSuma
            CSuma s4 = (CSuma)s3.Clone(); // Este si es una copia y no el mismo

        }
    }
}
