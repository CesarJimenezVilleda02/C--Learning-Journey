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
            //se pone el tipo de dato y luego los corchetes para declarar arreglo
            int[] numbers = { 1, 2, 3, 4, 5 };

            // tambien valido -- se le pone tamano fijo
            int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };

            // lo cramos de 5 valores
            int[] numbers3 = new int[5];

            int acum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {  
                acum += numbers[i];
            }
            Console.WriteLine("El promedio de los numeros es: {0}", acum / numbers.Length);

            // Declare a jagged array --- arreglo de arreglos de diferentes tamanos
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

            // Matrices
            Random rnd = new Random();

            // con la comma indicas cuantos niveles y en el int pones renglones por columnas
            int[,] matrix = new int[4, 7];

            // el .Length te da el tamano total del arrego, el .GetLength(dimension) te da el tamano de la dimension
            for(int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // un arreglo de dos dimensiones es un tipo en si
                    // i y j son las coordenadas
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }

            // Imprimimos los datos.
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}, ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}