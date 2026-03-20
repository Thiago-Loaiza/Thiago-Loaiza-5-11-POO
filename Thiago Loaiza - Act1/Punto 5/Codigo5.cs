namespace Punto_6
{
    using System;
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            //5. Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo (La circunferencia se calcula multiplicando el doble del radio por π (pi),
            //y el área se calcula multiplicando π por el cuadrado del radio).

            Console.Write("Ingrese el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());

            double circunferencia = 2 * 3.14 * radio;
            double area = 3.14 * radio * radio;

            Console.WriteLine("La circunferencia es: " + circunferencia);
            Console.WriteLine("El área es: " + area);
            Console.ReadKey();

        }
    }
}