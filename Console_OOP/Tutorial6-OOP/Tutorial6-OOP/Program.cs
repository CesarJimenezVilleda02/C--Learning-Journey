using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial1
{
    class Program
    {
        public struct Empleado
        {
            public string name;
            public int edad;
            public double sueldo;
            public int id;

            public Empleado(string name, int edad, int sueldo)
            {
                Random rnd = new Random();
                this.name = name;
                this.edad = edad;
                this.sueldo = sueldo;
                this.id = rnd.Next(1, 1000);
            }

            // Se puede hacer override porque ToString siempre viene en objetos de C#
            public override string ToString()
            {
                // StringBuilder cadena = new StringBuilder();
                // cadena.AppendFormat("Empleado {}", name);
                // return cadena.ToString();
                return $"Nombre: {name}, Edad: {edad}, ID: {id}, Sueldo: {sueldo}";
            }
            
            public void Aumento()
            {
                this.sueldo += 1000;
            }

        }

        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Juanito", 29, 10000);
            // el writeline usa el tostring siempre que imprime algo
            Console.WriteLine(empleado);
            empleado.Aumento();
            Console.WriteLine(empleado);

            // Arreglos de estructuras
            Empleado empleado1 = new Empleado("Juanito", 29, 10000);
            Empleado empleado2 = new Empleado("Pedrito", 29, 5000);
            Empleado empleado3 = new Empleado("Manuelito", 29, 7500);

            //Empleado[] empleados = { empleado1, empleado2, empleado3 };
            //Empleado[] empleados = new Empleado[3];
        }
    }
}