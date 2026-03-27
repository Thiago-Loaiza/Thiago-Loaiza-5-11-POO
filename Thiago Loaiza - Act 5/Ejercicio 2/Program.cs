using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             2. Realizar un programa que lea los lados de n triángulos, e informar:
                a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
                iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
                b) Cantidad de triángulos de cada tipo.
                c) Tipo de triángulo que posee menor cantidad.
             */

            int valor, i, n, cantidad = 0, contEq=0, contI=0, contEs=0;
            string linea, lado, lado2, lado3, menorT = "n";
            Console.WriteLine("Ingresa cuantos triangulos establecera");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            for (i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingresa el primer lado");
                lado = Console.ReadLine();
                valor = int.Parse(lado);
                Console.WriteLine("Ingresa el segundo lado");
                lado2 = Console.ReadLine();
                valor = int.Parse(lado2);
                Console.WriteLine("Ingresa el tercer lado");
                lado3 = Console.ReadLine();
                valor = int.Parse(lado3);
                if (lado == lado2 && lado2 == lado3 && lado3 == lado)
                {
                    Console.WriteLine("Es equilatero");
                    contEq++;
                }

                if (lado == lado2 && lado != lado3)
                {
                    Console.WriteLine("Es isoceles");
                    contI++;
                }
                if (lado3 == lado && lado != lado2)
                {
                    Console.WriteLine("Es isoceles");
                    contI++;
                }
                if (lado3 == lado2 && lado != lado3)
                {
                    Console.WriteLine("Es isoceles");
                    contI++;
                }

                if (lado != lado2 && lado2 != lado3 && lado3 != lado)
                {
                    Console.WriteLine("Es escaleno");
                    contEs++;
                }

                if(contEq > contEs && contI > contEs)
                {
                    menorT = "Escaleno";
                }
                if (contEs > contEq && contI > contEq)
                {
                    menorT = "Equilatero";
                }
                if (contEq > contI && contEs > contI)
                {
                    menorT = "Isoceles";
                }


            }
            Console.WriteLine("cantidad de triangulos equilatero : " + contEq);
            Console.WriteLine("cantidad de triangulos isoceles : " + contI);
            Console.WriteLine("cantidad de triangulos escaleno : " + contEs);
            Console.WriteLine("el menor tipo de triangulos es : " + menorT);
            Console.ReadKey();
        }
    }
}
