using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /*
     3. Fábrica de Computadoras (Herencia y Constructores con base)
        Crear una clase base llamada Computadora que contenga los atributos Marca y
        MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
        Luego, definir dos clases derivadas de la clase base:
         Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
         Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
        Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
        tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
        clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
        de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.
     */

    public class Computadora
    {
        protected string marca;
        protected int memoriaram;

        public string Marca
        {
            set {  marca = value; }
            get { return marca; }
        }

        public int MemoriaRAM
        {
            set {  memoriaram = value; }
            get { return memoriaram; }
        }

        public Computadora(string marca, int memoriaram)
        {
            Marca = marca;
            MemoriaRAM = memoriaram;
        }
    }

    public class Notebook : Computadora
    {
        private double tamañopantalla;

        public double TamañoPantalla
        {
            set { tamañopantalla = value; }
            get { return tamañopantalla;}
        }

        public Notebook(double tamañopantalla, string marca, int memoriaram) : base(marca, memoriaram)
        {
            TamañoPantalla = tamañopantalla;
        }

        public void MostrarNotebook()
        {
            Console.WriteLine("Datos de la Notebook");
            Console.WriteLine("Marca : " +Marca);
            Console.WriteLine("RAM : " + MemoriaRAM);
            Console.WriteLine("Pulgadas : " +TamañoPantalla);
        }
    }

    public class Escritorio : Computadora
    {
        private int potenciafuente;

        public int PotenciaFuente
        {
            set { potenciafuente = value; }
            get { return potenciafuente; }
        }

        public Escritorio(int potenciafuente, string marca, int memoriaram) : base(marca, memoriaram)
        {
            PotenciaFuente = potenciafuente;
        }

        public void MostrarEscritorio()
        {
            Console.WriteLine("Datos de la Escritorio");
            Console.WriteLine("Marca : " + Marca);
            Console.WriteLine("Ram : " + MemoriaRAM);
            Console.WriteLine("Potencia: " + PotenciaFuente);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Marca de la Notebook: ");
            string MarcaNot = Console.ReadLine();

            Console.Write("Velocidad RAM de la Notebook: ");
            int RamNot = int.Parse(Console.ReadLine());

            Console.Write("Tamaño de pantalla ");
            double TamañoPan = double.Parse(Console.ReadLine());

            Notebook notebook1 = new Notebook(TamañoPan, MarcaNot, RamNot);

            Console.WriteLine();
            notebook1.MostrarNotebook();
            Console.WriteLine();

            Console.Write("Marca de la de escritorio: ");
            string MarcaEsc = Console.ReadLine();

            Console.Write("Velocidad RAM de la de escritorio: ");
            int RamEsc = int.Parse(Console.ReadLine());

            Console.Write("Potencia en Watts de la de escritorio ");
            int PotenciaFue = int.Parse(Console.ReadLine());

            Escritorio escritorio1 = new Escritorio(PotenciaFue, MarcaEsc, RamEsc);

            Console.WriteLine();
            escritorio1.MostrarEscritorio();

            Console.ReadKey();

        }
    }
}
