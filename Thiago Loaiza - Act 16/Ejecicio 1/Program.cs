using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio_1
{
    /*
     * 1. Confeccionar una clase Persona que tenga como atributos el nombre y la
        edad (definir las propiedades para poder acceder a dichos atributos). Definir
        un método para imprimirlos. Plantear una segunda clase Empleado que
        herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
        método para imprimir su sueldo. Definir un objeto de la clase Persona y
        llamar a sus métodos y propiedades. También crear un objeto de la clase
        Empleado y llamar a sus métodos y propiedades.
    */

    public class Persona
    {
        protected string nombre;
        protected int edad;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int Edad
        {
            set { edad = value; }
            get { return edad; }
        }

        public void ImprimirPerson()
        {
            Console.WriteLine("La persona : " + Nombre + " con una edad de " + Edad);
        }
    }

    public class Empleado : Persona
    {
        protected int sueldo;

        public int Sueldo
        {
            set { sueldo = value; }
            get { return sueldo; }
        }

        public void ImprimirSueld()
        {
            Console.WriteLine("El sueldo del empleado " + Nombre + " es : $" + Sueldo);
        }
    }
    class Prueba
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();

            Console.Write("Ingrese el nombre: ");
            persona1.Nombre = Console.ReadLine();

            Console.Write("Ingrese la edad: ");
            persona1.Edad = int.Parse(Console.ReadLine());

            persona1.ImprimirPerson();

            Empleado empleado = new Empleado();

            empleado.Nombre = persona1.Nombre;

            Console.Write("Ingrese el sueldo del empleado: ");
            empleado.Sueldo = int.Parse(Console.ReadLine());

            empleado.ImprimirSueld();
        }
    }
}
