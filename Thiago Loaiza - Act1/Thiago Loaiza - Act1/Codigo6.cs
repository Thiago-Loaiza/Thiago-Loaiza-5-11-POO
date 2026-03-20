namespace Punto_6
{
    using System;
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            //6. Escribir un programa que lea el peso (en kilogramos) y la altura (en metros) de una persona,
            //y mostrar por pantalla su índice de masa corporal (IMC) (El IMC se calcula dividiendo el peso entre el cuadrado de la altura).


            Console.Write("Ingrese su peso en kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Ingrese su altura en metros: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("Su Masa corporal es: " + imc);
        }
    }
}