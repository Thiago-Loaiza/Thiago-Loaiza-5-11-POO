namespace Punto_3
{
    using System;
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            //3. Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.

            Console.Write("Ingrese el primer número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            double n3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el cuarto número: ");
            double n4 = double.Parse(Console.ReadLine());

            double suma = n1 + n2 + n3 + n4;
            double promedio = suma / 4;

            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadKey();

        }
    }
}