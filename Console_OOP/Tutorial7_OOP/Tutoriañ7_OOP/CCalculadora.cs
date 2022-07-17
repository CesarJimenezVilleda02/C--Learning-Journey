using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Con el mismo namespace para todos el prograama los reconoce dentro del mismo scope
namespace Tutorial7_OOP
{
    class CCalculadora
    {
        // ponemos acceso tipo y nombre
        public double a;
        public double b;

        // solo la clase -- protected deja verla en herencia
        private double r;

        // Cuando no se crea el constructor el compilador hac uno por defecto que llama al padre
        // que siempre es object
        // Constructor es funcion sin tipo con el mismo nombre de la clase
        public CCalculadora(double X, double Y)
        {
            a = X;
            b = Y;
        }

        public void Suma()
        {
            // si redeclaramos una var con el mismo nombre se va a ir por la mas cercana en el scope
            // double a = 5
            // la podemos seguir accediendo this.b
            r = a + b;

            Muestra();
        }

        // OVERLOADING
        public double Suma(double x, double y) => x + y;
        public double Suma(int x, int y) => x + y;

        // Se puede usar sin una instancia de una clase
        static public int Suma(int x, int y) => x + y;


        // nos permiten anadirle reglas de negocio a diferencia de si tenemos el obj pelon
        public double get_a() => a;
        public double get_b() => b;
        public double get_r() => r;
        //public double get_r()
        //{
        //    return r;
        //}

        public double set_a(double new_a)
        {
            a = new_a; return a;
        }
        public double set_b(double new_b)
        {
            b = new_b; return b;
        }

        private  void Muestra()
        {
            Console.WriteLine($"a={a} b={b} r={r}");
        }

        // las propiedades permiten el acceso con getters y setters usando la sntaxis normal ej. calc.A es calc.get_a
        public double A
            // en vez de la A se puede usar la a originalmente sin repetir
        {
            get
            {
                return a;
            }
            set
            {
                // value es una keyword que se va a referir al valor que le llega al set
                a = value;
            }
        }
    }
}
