using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Operaciones
    {
        /*
         4. Implementar la clase operaciones. Se deben cargar dos valores enteros,
            calcular su suma, resta, multiplicación y división, cada una en un método,
            imprimir dichos resultados.
         */
        private int num1, num2;

        public void Cargar()
        {
            string linea;

            Console.WriteLine("Ingrese el primer número:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("Ingrese el segundo número:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
        }

        public void Sumar()
        {
            int suma = num1 + num2;
            Console.WriteLine("Suma: " + suma);
        }

        public void Restar()
        {
            int resta = num1 - num2;
            Console.WriteLine("Resta: " + resta);
        }

        public void Multiplicar()
        {
            int multi = num1 * num2;
            Console.WriteLine("Multiplicación: " + multi);
        }

        public void Dividir()
        {
            if (num2 != 0)
            {
                int div = num1 / num2;
                Console.WriteLine("División: " + div);
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero");
            }
        }

        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            op.Cargar();
            op.Sumar();
            op.Restar();
            op.Multiplicar();
            op.Dividir();
            Console.ReadKey();
        }
    }
}