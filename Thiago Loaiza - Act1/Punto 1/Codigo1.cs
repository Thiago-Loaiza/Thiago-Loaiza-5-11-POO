namespace Punto_1
{
    using System;
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            //1. Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo
            //(El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).
            Console.Write("Ingrese el valor del lado del cuadrado: ");
            int lado = int.Parse(Console.ReadLine());

            int perimetro = lado * 4;

            Console.WriteLine("El perímetro del cuadrado es: " + perimetro);
            Console.ReadKey();
        }
    }
}