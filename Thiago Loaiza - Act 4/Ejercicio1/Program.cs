using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
                $500, realizar un programa que lea los sueldos que cobra cada empleado e
                informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
                de $300. Además el programa deberá informar el importe que gasta la empresa
                en sueldos al personal.
             */
            int salario, acum = 0, acum2 = 0, acumTotal = 0;
            string linea, empleado;
            Console.WriteLine("Sistema de sueldos de la empresa, maximos de sueldo entre 100 y 500");

            do
            {
                Console.WriteLine("Ingresa nombre del empleado");
                empleado = Console.ReadLine();
                Console.WriteLine("Ahora su salario");
                linea = Console.ReadLine();
                salario = int.Parse(linea);
                Console.WriteLine("   ");
                if (salario > 100 && salario < 300)
                {
                    Console.WriteLine(empleado + " Tiene salario mediano");
                    Console.WriteLine("   ");
                    acum++;
                    acumTotal = acumTotal + salario;
                }
                if (salario > 300)
                {
                    Console.WriteLine(empleado + " Tiene salario Alto");
                    Console.WriteLine("   ");
                    acum2++;
                    acumTotal = acumTotal + salario;
                }
            }
            while (salario > 0);
            Console.WriteLine("La cantidad de salarios medianos es " + acum);
            Console.WriteLine("La cantidad de salarios altos es " + acum2);
            Console.WriteLine("La total de dinero destinado a salarios " + acumTotal);

            Console.ReadKey();
        }
    }
}
