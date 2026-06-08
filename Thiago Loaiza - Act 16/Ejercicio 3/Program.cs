using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /*
    3. Crear una clase base Vehículo que contenga atributos marca y
        velocidadMaxima.
        Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
        una debe tener un constructor que reciba los valores de los atributos base
        mediante la palabra clave base, y un atributo propio (cantidadPuertas en
        Auto, cilindrada en Moto).
        Crear un objeto de cada clase y mostrar todos sus datos por consola.
     */
    public class Vehiculo
    {
        protected string marca;
        protected int velocidadMaxima;

        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }

        public int VelocidadMaxima
        {
            set { velocidadMaxima = value; }
            get { return velocidadMaxima; }
        }

        public Vehiculo(string marca, int velocidadMaxima)
        {
            Marca = marca;
            VelocidadMaxima = velocidadMaxima;
        }
    }

    public class Auto : Vehiculo
    {
        private int cantidadPuertas;

        public int CantidadPuertas
        {
            set { cantidadPuertas = value; }
            get { return cantidadPuertas; }
        }

        public Auto(string marca, int velocidadMaxima, int cantidadPuertas)
            : base(marca, velocidadMaxima)
        {
            CantidadPuertas = cantidadPuertas;
        }

        public void MostrarAuto()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Velocidad maxima: " + VelocidadMaxima);
            Console.WriteLine("Cantidad de puertas: " + CantidadPuertas);
        }
    }

    public class Moto : Vehiculo
    {
        private int cilindrada;

        public int Cilindrada
        {
            set { cilindrada = value; }
            get { return cilindrada; }
        }

        public Moto(string marca, int velocidadMaxima, int cilindrada)
            : base(marca, velocidadMaxima)
        {
            Cilindrada = cilindrada;
        }

        public void MostrarMoto()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Velocidad maxima: " + VelocidadMaxima);
            Console.WriteLine("Cilindrada: " + Cilindrada);
        }
    }

    class Prueba
    {
        static void Main(string[] args)
        {
            Console.Write("Marca del auto: ");
            string marcaAuto = Console.ReadLine();

            Console.Write("Velocidad maxima del auto: ");
            int velAuto = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de puertas: ");
            int puertas = int.Parse(Console.ReadLine());

            Auto auto = new Auto(marcaAuto, velAuto, puertas);

            Console.WriteLine();

            Console.Write("Marca de la moto: ");
            string marcaMoto = Console.ReadLine();

            Console.Write("Velocidad maxima de la moto: ");
            int velMoto = int.Parse(Console.ReadLine());

            Console.Write("Cilindrada: ");
            int cil = int.Parse(Console.ReadLine());

            Moto moto = new Moto(marcaMoto, velMoto, cil);

            Console.WriteLine();
            Console.WriteLine("Datos del auto");
            auto.MostrarAuto();

            Console.WriteLine();

            Console.WriteLine("Datos de la moto");
            moto.MostrarMoto();

            Console.ReadKey();
        }
    }
}