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
            // AREA DE UN CUADRADO
            double lado = 5.0;
            double area = 0.0;
            double perimetro = 0.0;
            // calcular area
            area = lado * lado;
            // calcular perimetro
            perimetro = lado * 4;
            // mostrar resultados
            Console.WriteLine("El area de un cuadrado de lado {0} es {1}", lado, area);
            Console.WriteLine("El perimetro es {0}", perimetro);

            // CELCIOUS A FARENHEIT
            double C = 38.3;
            double F = 0.0;

            // Convertir
            F = (C * 1.8) + 32;
            // Mostrar resultado.
            Console.WriteLine("{0}C son {1}F", C, F);

            // PEDIR INFORMACION EN FORMATO STRING
            string name;

            Console.WriteLine("Como te llamas?");
            name = Console.ReadLine();

            Console.WriteLine("Hola {0}", name);

            // PEDIR INFORMACION EN FORMATO NUMERICO
            int anos;
            double peso;

            Console.WriteLine("Cuantos anos tienes?");
            // Me va a retornar una cadena y hay que guardarla como numero
            anos = Convert.ToInt32(Console.ReadLine()); // Convert es una clase
            //peso = Convert.ToDouble(Console.ReadLine()); // Convert es una clase

            Console.WriteLine("Tienes {0} anos", anos);

            // EJERCICIOS
            int lado1, lado2, area2, perimetro2;

            Console.WriteLine("Ingresa el tamano del lado 1 del reactangulo");
            lado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el tamano del lado 2 del reactangulo");
            lado2 = Convert.ToInt32(Console.ReadLine());

            area2 = lado1 * lado2;
            perimetro2 = lado1 * 2 + lado2 * 2;

            Console.WriteLine("El area del rectangulo es de {0}", area2);
            Console.WriteLine("El perimetro del rectangulo es de {0}", perimetro2);

            // IFSITOS
            // == es el de igualdad en C#
            // != diferente a en C#
            // && es el and en C#
            // || es el or en C#
            // ! es el not en C#
            if(1 > 3)
            {
                Console.WriteLine("Cae en el primer ifsito");
            } else if (2 > 3)
            {
                Console.WriteLine("Cae en el elseif");
            } else
            {
                Console.WriteLine("Cae en el else");
            }

            // SWITCH
            int seleccion;

            Console.WriteLine("Selecciona una opcion");
            seleccion = Convert.ToInt32(Console.ReadLine());

            // tambien se puede usar con cadenas
            switch (seleccion)
            {
                case 1:
                    Console.WriteLine("Elegiste 1");
                    // Si no le ponemos el break se va a los otros case
                    break;
                case 2:
                    Console.WriteLine("Elegiste 2");
                    break;
                // Si no cae en los demas
                default:
                    Console.WriteLine("No disponible");
                    break;
            }



        }
    }
}
