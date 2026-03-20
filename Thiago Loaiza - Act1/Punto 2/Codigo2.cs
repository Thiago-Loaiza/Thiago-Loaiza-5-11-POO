namespace Punto_2
{
    using System;
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            //2. Escribir un programa en el cual se ingresen cuatro números,
            //calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.

            Console.WriteLine("Hola Mundo");
            int num1, num2, num3, num4, suma, producto;
            string linea;

            Console.Write("Ingresa el primero numero");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingresa el segundo numero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            suma = num1 + num2;
            Console.WriteLine(suma);

            Console.Write("Ingresa el tercer numero");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.Write("Ingresa el cuarto numero");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            producto = num3 * num4;
            Console.WriteLine(producto);

            Console.ReadKey();

        }
    }
}