using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc.
            //(No se ingresan valores por teclado)

            int x = 0, num = 0;
            Console.WriteLine("Imprimiendo serie de numeros 11");
            while (x < 25)
            {
                num = num + 11;
                Console.Write(num);
                Console.Write(" - ");
                
                x++;
            }
            Console.ReadKey();
        }
    }
}
