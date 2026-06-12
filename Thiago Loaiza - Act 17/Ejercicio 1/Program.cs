using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /*
        1. Personal de un Gimnasio (Herencia Simple y Propiedades)
        Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
        Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
        método para imprimir estos datos básicos.

        Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
        un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
        para imprimir todos los datos del profesor (incluyendo los heredados).

        En el programa principal (Main):
         Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
        llamar a su método de impresión.
         Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
        que puede acceder tanto a sus métodos propios como a los de la clase base.
    */
    public class PersonaGimnasio
    {
        protected string nombre;
        protected int dni;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int Dni
        {
            set { dni = value; }
            get{ return dni; }
        }

        public void ImprimirPersona()
        {
            Console.WriteLine(" --- ");
            Console.WriteLine("Esta persona del empleado se llama " + Nombre + " tiene el numero de dni : " + Dni );
            Console.WriteLine(" --- ");
        }
    }

    public class Profesor : PersonaGimnasio
    {
        private string especialidad;

        public string Especialidad
        {
            set {  especialidad = value; }
            get { return especialidad; }
        }

        public void ImprimirProfesor()
        {
            Console.WriteLine(" --- ");
            Console.WriteLine("El profesor llamado " + Nombre + " de la especialidad " + Especialidad + " con su numero de DNI : " + dni);
            Console.WriteLine(" --- ");
        }
    }
    internal class Prueba
    {
        static void Main(string[] args)
        {
            PersonaGimnasio perso1 = new PersonaGimnasio();

            Console.WriteLine("Ingrese el nombre de esta persona:");
            perso1.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de DNI de la persona");
            perso1.Dni = int.Parse(Console.ReadLine());

            perso1.ImprimirPersona();

            Profesor prof1 = new Profesor();

            Console.WriteLine("Ingrese la especialidad del este profesor");
            prof1.Especialidad = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de esta persona:");
            prof1.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de DNI de la persona");
            prof1.Dni = int.Parse(Console.ReadLine());

            prof1.ImprimirProfesor();

            Console.ReadKey();
        }    
    }
}

