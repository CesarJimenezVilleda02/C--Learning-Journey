using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Cuando tenemos herencia podremos guardar CEmpleados en variables de CPersonal
// pero no tendriamos la capacidad de usar las caracteristicas del hijo, para
// esto usariamos casting de la sig manera
// ((CEmpleado)empleado).Mensaje(); --- a esto se le llama casting
// entre parentesis pongo el tipo que me interesa, esto se puede con cualquier supertipo como object
// y solo se le hace casting al que nos interesa
// El casting solo se necesita cuando el supertipo no cuenta con un metodo que el hijo si tiende, si 
// es con un metodo que se hereda y se le hace override se puede usar libremente.
namespace Tutorial7_OOP
{
    // el modificador sealed dice que no podemos prodicir herencias a partir de esta clase
    sealed class CEmpleado: CPersonal
        // sin constructor se llama al del padre
        // las propiedades tambien se heredan
    {
        public string puesto { get; set; }
        public double salario { get { return salario; } set {
                if(value <= 0)
                {
                    Console.WriteLine("Salario no permitido");
                    return;
                }
                salario = value;
            } 
        }

        public CEmpleado(string nombre, int edad, string puesto, double salario) : base(nombre, edad)
            // en el hijo solo mando al base que hace referencia al del padre los datos del hijo que necesita
        {
            this.salario = salario;
            this.puesto = puesto;
        }

        public void MuestraEmpleado()
        {
            // tambien puedo hacer uso de las propiedades en el objeto
            Console.WriteLine($"Nombre: {nombre} {edad} de la empresa {empresa}");
            // por el protected en el padre se pueden usar nombre y edad, sino seria con Nombre y Edad
            // Console.WriteLine($"Nombre: {Nombre} {Edad} de la empresa {empresa}");
        }

        // Override es para sobreescribir lo del padre y adecuarlo a nuestras necesidades
        public sealed override void Muestra()
            // cuando usamos sealed decimos que ya para abajo no le pueden hacer override
        {
            Console.WriteLine($"Nombre: {nombre} {edad} de la empresa {empresa}");
        }

        // Con el new en el metodo se hace desde 0 el codigo, es como el virtual pero es mas util
        // cuando no tenemos acceso al original - al llamar este metodo se usa la version de la clase
        // y no la heredada
        // public new void Muestra() { }
        // Otro patron es usar el new y dentro del cuerpo llamar el original con base.Muestra() y agregar 
        // una funcion extra.
    }
}
