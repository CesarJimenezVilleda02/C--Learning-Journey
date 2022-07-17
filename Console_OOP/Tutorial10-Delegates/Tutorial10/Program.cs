using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial10
{
    // DELEGADOS
    // Es una referencia una funcion, si no regresa nada y tiene dos parametros enteros
    // puede ser una referencia a otro metodo si ambos son iguales. 
    // void function(in a, intb) puede ser void impuestos(int cant, int imp) o void calorias(int km, int tiempo)
    // Cuando invocamos un elegado este llama a la funcion a la que referencia
    // Un delegado es como la definicion de un tipo de funcion, en este podemos almacenar funciones
    internal class Program
    {
        // ponemos la palabra delegate para decir que estamos haciendo un delegado -- luego la func con la estructura
        public delegate void Midelegado(string m);

        static void Main(string[] args)
        {
            // Al crear un delegado le metemos la funcion
            Midelegado delegado = new Midelegado(CRadio.MetodoRadio);
            delegado("Hola a todos.");

            // Cambiamos a la nueva referencia
            delegado = new Midelegado(CPastel.MetodoPastel);
            delegado("Hola a todos.");

            // DELEGADOS 2
            CRefri mirefri = new CRefri(70, -20);
            Random rnd = new Random();

            // Los vamos anadiendo a la lista interna del delegado
            mirefri.AdicionaMetodoReservas(new DReservasBajas(Informekilos));
            mirefri.AdicionaMetodoReservas(new DReservasBajas(CTienda.MandaViveres));

            mirefri.AdicionaMetodoDescongelado(new DDescongelado(InformeGrados));

            while (mirefri.Kilos > 0) 
            {
                mirefri.Trabajar(rnd.Next(1, 5));
            }
        }

        // Son funciones que embonan con los delegates que definimos en el refri, por eso los agregamos al refri
        // para que este los use.
        public static void Informekilos(int pkilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->Reservas bajas de alimentos,estoy a nivel de main");
            Console.WriteLine("-->Quedan {0} kilos", pkilos);
        }

        public static void InformeGrados(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--->Se descongela el refri!, estoy a nivel de main");
            Console.WriteLine("--->Esta a {0} grados", pGrados);
        }          
    }
}
