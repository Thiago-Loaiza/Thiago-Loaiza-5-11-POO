using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio_1
{
    /*
     1. Confeccionar una clase que represente un empleado. Definir como atributos su
        nombre y su sueldo. En el constructor cargar los atributos y luego en otro
        método imprimir sus datos y por último uno que imprima un mensaje si debe
        pagar impuestos (si el sueldo supera a 3000)
     */
    internal class Empleado
    {
        private int sueldo;
        private string nombre;
        public Empleado()
        {
            string linea;
            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }
        public void Imprimir()
        {
            Console.WriteLine("El empleado " + nombre + " con su sueldo de " + sueldo);
        }

        public void CalImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("El empleado tiene que pagar impuestos");
            }
        }

        static void Main(string[] args)
        {
            Empleado em = new Empleado();
            em.Imprimir();
            em.CalImpuestos();
            Console.ReadKey();
        }
    }
}
