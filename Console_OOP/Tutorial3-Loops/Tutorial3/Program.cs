using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            // CICLOS

            // FOR
            // de forma regresiva i--
            // de 2 en dos i++
            // la i puede empezar donde sea
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Soy el {0} del ciclo", i);
            }

            for (int i = 0; i < 100; i++)
            {
                Console.Write(i);
                if(i % 2 == 0)
                {
                    Console.Write("Fizz");
                }
                if (i % 3 == 0)
                {
                    Console.Write("Buzz");
                }
                Console.WriteLine();
            }

            //  WHILE
            int count = 0;
            while(count < 10)
            {
                count++;
                Console.WriteLine("El contador vale {0}", count);
            }

            // DO WHILE
            int contador = 0;
            // cuando necesitamos al menos una repeticion
            do
            {
                contador++;
                Console.WriteLine("El contador vale {0}", contador);
            } while(contador < 10);
        }
    }
}