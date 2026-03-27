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
             3. Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
                a) La cantidad de valores ingresados negativos.
                b) La cantidad de valores ingresados positivos.
                c) La cantidad de múltiplos de 15.
                d) El valor acumulado de los números ingresados que son pares.
             */
            int mult, i, valor, contN = 0, contP = 0, contM15 = 0, acumPar = 0;
            string linea;
            Console.WriteLine("cargara una serie de 10 numeros");
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine("Ingresa un numero entero:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if(valor < 0)
                {
                    contN++;
                }
                if (valor > 0)
                {
                    contP++;
                }
                if (valor % 15 == 0)
                {
                    contM15++;
                }
                if (valor % 2 == 0)
                {
                    acumPar = acumPar + valor;
                }
            }
            Console.WriteLine("Cantidad de numero Negativos : " + contN);
            Console.WriteLine("Cantidad de numero Positivos : " + contP);
            Console.WriteLine("Cantidad de numeros Multiplos de 15 : " + contM15);
            Console.WriteLine("Acumulacion de los numeros pares : " + acumPar);
            Console.ReadKey();
        }
    }
}
