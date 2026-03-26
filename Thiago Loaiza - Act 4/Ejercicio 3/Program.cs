using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta
                ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el
                valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.
             */
            int num, acum = 0;
            string linea;
            Console.WriteLine("Ingresa numero a sumar por por teclado, ingresa 9999 para terminar la acumulacion");

            do
            {
                linea = Console.ReadLine();
                num = int.Parse(linea);
                if (num != 9999)
                {
                    Console.WriteLine("Valor acumulado total");
                    acum = acum + num;
                    Console.WriteLine(acum);
                }
                else
                {
                    Console.WriteLine("9999 ingresado, programa finalizado");
                }
            }
            while (num != 9999);
            Console.ReadKey();
        }
    }
}
