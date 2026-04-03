using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Cuadrado
    {
        private int lado;
        /*
         2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes
            métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.
         */
        public void Cargar()
        {
            string linea;
            Console.WriteLine("Ingrese el valor del lado:");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
        }

        public void CalcularPerimetro()
        {
            int perimetro = lado * 4;
            Console.WriteLine("Perímetro: " + perimetro);
        }

        public void CalcularSuperficie()
        {
            int superficie = lado * lado;
            Console.WriteLine("Superficie: " + superficie);
        }

        public void Imprimir()
        {
            Console.WriteLine("Lado: " + lado);
        }

        static void Main(string[] args)
        {
            Cuadrado c = new Cuadrado();
            c.Cargar();
            c.Imprimir();
            c.CalcularPerimetro();
            c.CalcularSuperficie();
            Console.ReadKey();
        }
    }
}