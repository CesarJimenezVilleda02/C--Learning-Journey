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
            SaludarNVeces(5);
            Console.WriteLine(Factorial(5));
        }

        public static void SaludarNVeces(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hola mucho gusto!");
            }
        }

        // son privados por defecto
        public static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = i * fact;
            }

            return fact;
        }

    }
}