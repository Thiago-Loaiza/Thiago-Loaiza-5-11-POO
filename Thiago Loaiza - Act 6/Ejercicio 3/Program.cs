using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Empleado
    {
        /*
         3. Confeccionar una clase que represente un empleado. Definir como atributos su
            nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
            sus datos y por último uno que imprima un mensaje si debe pagar impuestos
            (si el sueldo supera a 3000).
         */
        private string nombre;
        private double sueldo;

        public void Cargar()
        {
            Console.WriteLine("Ingrese el nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el sueldo:");
            sueldo = double.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Sueldo: " + sueldo);
        }

        public void PagaImpuestos()
        {
            if (sueldo > 3000)
                Console.WriteLine("Debe pagar impuestos");
            else
                Console.WriteLine("No paga impuestos");
        }

        static void Main(string[] args)
        {
            Empleado emp = new Empleado();
            emp.Cargar();
            emp.Imprimir();
            emp.PagaImpuestos();
            Console.ReadKey();
        }
    }
}