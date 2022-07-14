using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial7_OOP
{
    // si se anade abstract antes de la clase esta deja de poder ser instanciada
    class CPersonal
    {
        // se conoce en todas las clases -- CPersonal.empresa
        static public string empresa = "Constructores SA de CV";

        // Con protected si lo puede ver el hijo -- es un acceso que solo se usa en la herencia
        // privado -- solo interior
        // protegido -- padres e hijos
        protected string nombre;
        protected int edad;
        
        // SOBRECARGA DE CONSTRUCTOR -- al final del dia son metodo5656565665566
        public CPersonal()
        {
            this.nombre = "";
            this.edad = 0;
        }


        public CPersonal(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        // Propiedades
        public string Nombre { set { nombre = value; } }
        public int Edad { set { edad = value; } }

        // Con virtual decimos que el hijo lo puede llegar a modificar
        public virtual void Muestra()
        {
            // todos usan y tienen sincronizada la estatica de la clase
            Console.WriteLine($"Nombre: {nombre} {edad} de la empresa {empresa}");
            
        }
        public string NombreEmpresa { set { empresa = value; } }

        // los metodos abstractos se define un prototipo pero no se le da ningun valor
        // public abstract void Muestra()
        // todas las clases que hereden de este prodicto tendran como responsabilidad
        // implementar este metodo, nos ayuda a definir conceptualmente todo

        // Destructor -- no lleva acceso ni tipo
        ~CPersonal()
            // se llama siempre cuando salen del scope
        {
            Console.WriteLine("Se ha eliminado el objeto.");
            nombre = "";
            edad = 0;
        }
    }
 
}
