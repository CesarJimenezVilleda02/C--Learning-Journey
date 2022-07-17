// Using nos permite usar otros namespaces
using System; // el que me permite trabajar con la consola
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Namespace es como nombramos el conjunto de clases para que se puedan usar en otros archivos
namespace Tutorial1
{
    // Program es la clase del programa en general
    class Program
    {
        // Punto en el que el programa va a iniciar
        static void Main(string[] args)
        {
            // Cambio de linea
            Console.WriteLine("Iniciado");

            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine("Hola soy " + i.ToString());
                Console.WriteLine("Hola soy {0}", i);
            }

            // Tipos de datos
            bool hola = false;
            int numero = 3;
            float flotante = 5.6F;
            // Se pone uno solo
            char cadena = 'H';
            string texto = "changos";

            Console.WriteLine("Tengo un total de {0} en mi {1}", numero, texto);

            // Inicializar
            int holaNoMeUso;
            holaNoMeUso = 5;

            // No cambia de lineaa
            Console.Write("Hola");
            Console.Write("Hola");
            Console.Write("Hola");

            // Operadores aritmeticosI
            //+suma
            //-resta
            // * multiplicacion
            ///division
            //%modulo
            //=asignacion
            //()agrupacion

            double value1 = 9.7;
            double value2 = 1.3;

            double resultado = value1 + value2;
            Console.WriteLine("El resultado es: {0}", resultado);
            
            resultado = value1 - value2;
            Console.WriteLine("El resultado es: {0}", resultado);

            resultado = value1 * value2;
            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}