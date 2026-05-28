using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    /*
     2. Implementar la clase operaciones. Se deben cargar dos valores enteros en el
        constructor, calcular su suma, resta, multiplicación y división, cada una en un
        método, imprimir dichos resultados.
     */
    class Operaciones
    {
        private int num1;
        private int num2;
        private int total;

        public Operaciones(int a, int b)
        {
            num1 = a;
            num2 = b;
            total = 0;
        }

        public void Sumar()
        {
            total = num1 + num2;
        }

        public void Restar()
        {
            total = num1 - num2;
        }

        public void Multiplicar()
        {
            total = num1 * num2;
        }

        public void Dividir()
        {
            total = num1 / num2;
        }

        public int Returnartotal()
        {
            return total;
        }

        public void Impresion()
        {
            Console.WriteLine("El total es : " + total);
        }
    }
    internal class Calculadora
    {
        private Operaciones cuenta1;

        public Calculadora()
        {
            cuenta1 = new Operaciones(3, 3);
        }

        public void Calcular()
        {
            cuenta1.Sumar();
            Console.WriteLine("La operacion Suma: ");
            cuenta1.Impresion();
            cuenta1.Restar();
            Console.WriteLine("La operacion Resta: ");
            cuenta1.Impresion();
            cuenta1.Multiplicar();
            Console.WriteLine("La operacion Multiplicar: ");
            cuenta1.Impresion();
            cuenta1.Dividir();
            Console.WriteLine("La operacion Dividir: ");
            cuenta1.Impresion();
        }

        static void Main(string[] args)
        {
            Calculadora C = new Calculadora();
            C.Calcular();
            Console.ReadKey();
        }
    }
}
