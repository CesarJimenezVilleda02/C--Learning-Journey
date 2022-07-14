using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tutorial14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Convert.ToInt32(Console.ReadLine());

            // PARAMETROS NOMBRADOS -- evitas el orden
            CAuto autoTest1 = new CAuto(pCosto: 120);
            autoTest1.MuestraInformacion();

            // PARAMETROS POR DEFECTO
            CAuto autoTest2 = new CAuto("Audi");
            autoTest2.MuestraInformacion();

            // PARA SERIALIZAR VARIOS ES CON COMPOSICION, en este todos los qu esten dentro tambien deben tener Serializable
            if (opcion == 0)
            {
                CAuto auto1 = new CAuto("Soul", 220000.50);

                //Stream -- es una secuencia de datos en las que nos podemos mover
                FileStream fs = new FileStream("MiArchivo.arc", FileMode.Create, FileAccess.Write, FileShare.None);

                //Creamos escritor
                BinaryWriter writer = new BinaryWriter(fs);

                writer.Write(auto1.modelo);
                writer.Write(auto1.costo);

                fs.Close();
            }
            else
            {
                //Stream
                FileStream fs = new FileStream("MiArchivo.arc", FileMode.Open, FileAccess.Read, FileShare.None);

                //Creamos escritor
                BinaryReader lector = new BinaryReader(fs);

                string modelo = lector.ReadString();
                double costo = lector.ReadDouble();

                (new CAuto(modelo, costo)).MuestraInformacion();

                fs.Close();
            }

            long cantidad = 0;
            int valor = 0;

            //Stream
            FileStream fs2 = new FileStream("MiArchivo.arc", FileMode.Open, FileAccess.Read, FileShare.None);

            //Creamos escritor
            cantidad = fs2.Length;

            // podriamos hacerlo de atras hacia delantw con SeekOrigin.End o con un While que se detenga porque si es el final
            // regresa char negativo.
            // leemos de byte en byte
            for (long i = 0; i < cantidad; i++)
            {
                // offset es en donde empezar y luego de donde empezamos a contar
                fs2.Seek(i, SeekOrigin.Begin);
                valor = fs2.ReadByte();
                Console.WriteLine((char)valor);
            }
            fs2.Close();
        }
    }
}
