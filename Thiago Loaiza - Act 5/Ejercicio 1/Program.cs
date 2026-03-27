using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            muestre la tabla de multiplicar del mismo(los primeros 13 términos)
            Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.
            */

            int mult, i,valor;
            string linea;
            Console.WriteLine("Ingresa un numero para ver sus primeros 13 terminos de su tabla:");
            linea = Console.ReadLine();
            valor = int.Parse(linea);

            for (i = 0; i <= 13; i++)
            {
                mult = valor * i;
                Console.WriteLine(mult);
            }
            Console.ReadKey();
        }
    }
}
