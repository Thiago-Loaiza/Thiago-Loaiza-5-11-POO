using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    /*
        4. Cadena de Herramientas (Herencia Multinivel y Orden de Constructores)
        Armar una estructura jerárquica compuesta por tres clases consecutivas en una línea de
        herencia: Material, Herramienta y Martillo.

         La clase Material (base) debe tener un atributo TipoMaterial (ej: Madera, Acero,
        Plástico).
         La clase Herramienta (que hereda de Material) debe añadir el atributo
        FuncionPrincipal.
         La clase Martillo (que hereda de Herramienta) debe añadir el atributo PesoGramos.

        Cada una de las tres clases debe contar con un constructor encargado de recibir sus datos
        correspondientes. Al momento de ejecutarse, cada constructor debe realizar la asignación y,
        acto seguido, imprimir un mensaje en consola indicando a qué clase pertenece
        (ejemplo: &quot;Constructor de la clase Material ejecutado&quot;).

        En el método Main, crear únicamente un objeto de la clase final Martillo pasándole todos los
        parámetros requeridos. Observar y verificar en la consola el orden secuencial de ejecución
        en cadena de los constructores (desde la raíz hasta la clase derivada).
     */
    public class Material
    {
        protected string tipomaterial;

        public string TipoMaterial
        {
            set { tipomaterial = value; }
            get { return tipomaterial; }
        }

        public Material(string tipomaterial)
        {
            TipoMaterial = tipomaterial;

            Console.WriteLine("Ejecucion del costructor de Material:");
            Console.WriteLine("El tipo de material es : " + TipoMaterial); 
        }
    }

    public class Herramienta : Material
    {
        protected string funcionprincipal;

        public string FuncionPrincipal
        {
            set { funcionprincipal = value; }
            get { return funcionprincipal; }
        }

        public Herramienta(string funcionprincipal, string tipomaterial) : base(tipomaterial)
        {
            FuncionPrincipal = funcionprincipal;

            Console.WriteLine("Ejecucion del costructor de Herramiento:");
            Console.WriteLine("Su funcion principal es : " + FuncionPrincipal);
        }
    }

    public class Martillo : Herramienta
    {
        protected double gramos;

        public double Gramos
        {
            set { gramos = value; }
            get{ return gramos; }
        }

        public Martillo(double gramos,string funcionprincipal, string tipomaterial) : base(funcionprincipal, tipomaterial)
        {
            Gramos = gramos;

            Console.WriteLine("Ejecucion del costructor de Herramiento:");
            Console.WriteLine("Su peso en : " + Gramos);
        }
    }

    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tipo de material");
            string tipomaterial = Console.ReadLine();
            Console.WriteLine("Ingrese la funcion principal de esta herramienta ");
            string funcionprincipal = Console.ReadLine();
            Console.WriteLine("Ingrese el peso en gramos de esta herramienta ");
            double gramos = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Martillo mat = new Martillo(gramos,funcionprincipal,tipomaterial);
            Console.ReadKey();
        }
    }
}
