using System;

namespace Ejercicio_4
{
    /*
     4. Armar tres clases: Animal, Mamífero y Perro.
        La clase Animal debe tener un atributo especie.
        La clase Mamífero, que hereda de Animal, debe tener un atributo
        tipoAlimentacion.
        La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
        Cada clase debe tener un constructor que reciba los datos correspondientes
        y los imprima indicando a qué clase pertenecen. Los datos deben ser
        asignados previamente
        Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
        constructores.
     */
    public class Animal
    {
        protected string especie;

        public string Especie
        {
            set { especie = value; }
            get { return especie; }
        }

        public Animal(string especie)
        {
            Especie = especie;

            Console.WriteLine("Constructor Animal");
            Console.WriteLine("Especie: " + Especie);
        }
    }

    public class Mamifero : Animal
    {
        protected string tipoAlimentacion;

        public string TipoAlimentacion
        {
            set { tipoAlimentacion = value; }
            get { return tipoAlimentacion; }
        }

        public Mamifero(string especie, string tipoAlimentacion)
            : base(especie)
        {
            TipoAlimentacion = tipoAlimentacion;

            Console.WriteLine("Constructor Mamifero");
            Console.WriteLine("Tipo alimentacion: " + TipoAlimentacion);
        }
    }

    public class Perro : Mamifero
    {
        private string nombre;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public Perro(string especie, string tipoAlimentacion, string nombre)
            : base(especie, tipoAlimentacion)
        {
            Nombre = nombre;

            Console.WriteLine("Constructor Perro");
            Console.WriteLine("Nombre: " + Nombre);
        }
    }

    class Prueba
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese especie: ");
            string especie = Console.ReadLine();

            Console.Write("Ingrese tipo de alimentacion: ");
            string alimentacion = Console.ReadLine();

            Console.Write("Ingrese nombre del perro: ");
            string nombre = Console.ReadLine();

            Console.WriteLine();

            Perro perro = new Perro(especie, alimentacion, nombre);

            Console.ReadKey();
        }
    }
}