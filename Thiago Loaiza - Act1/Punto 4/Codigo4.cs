namespace Punto_4
{
    using System;
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            //4. Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente.
            //Mostrar lo que debe abonar el comprador.

            Console.Write("Ingrese el precio del artículo: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());

            double total = precio * cantidad;

            Console.WriteLine("El total a pagar es: " + total);
            Console.ReadKey();
        }
    }
}