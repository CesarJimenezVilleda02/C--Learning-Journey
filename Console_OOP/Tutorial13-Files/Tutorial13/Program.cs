using System;

// para serializar binario
using System.Runtime.Serialization.Formatters.Binary;
// para serializar SOAP -- primero se debe agregar en referencias
using System.Runtime.Serialization.Formatters.Soap;
// para XML
using System.Xml.Serialization;
using System.IO;

namespace Tutorial13
{
    internal class Program
    {
        // Serializacion es guadar objetos en un medio de almacenamiento
        // Binaria
        // SOAP
        // XML
        static void Main(string[] args)
        {
            int opcion = Convert.ToInt32(Console.ReadLine());
            
            // PARA SERIALIZAR VARIOS ES CON COMPOSICION, en este todos los qu esten dentro tambien deben tener Serializable
            if(opcion == 0)
            {
                CAuto auto1 = new CAuto("Soul", 220000.50);
                CAuto auto2 = new CAuto("Fit", 175600.70);
                CAuto auto3 = new CAuto("March", 168900.00);
                CAuto auto4 = new CAuto("Spark", 160400.40);

                // SERIALIZACION
                // 1 instancia de formatteador
                // SoapFormatter formateador = new SoapFormatter(); -- para SOAP
                // XXmlSerializar formateador = new XmlSerializer(typeof(CAuto)); se le debe pasar el tipo para formato
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                // 2 crear stream
                // Autos.aut es el nombre del archivo, modo de apertura, modo de uso, exclusividad
                Stream myStream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                // 3 Serializar
                binaryFormatter.Serialize(myStream, auto1);

                myStream.Close();
                Console.WriteLine("AUTOS GUARDADOS");
            } else
            {
                // 1 instancia de formatteador
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                // 2 crear stream
                // Autos.aut es el nombre del archivo, modo de apertura, modo de uso, exclusividad
                Stream myStream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                // Obtenemos el original -- deserializamos y le hacemos el casting
                CAuto miAuto = (CAuto)binaryFormatter.Deserialize(myStream);
                miAuto.MuestraInformacion();

                myStream.Close();
            }

        }
    }
}
