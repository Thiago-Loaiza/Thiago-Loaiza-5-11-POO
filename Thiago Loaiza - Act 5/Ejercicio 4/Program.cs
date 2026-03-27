using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4. Se cuenta con la siguiente información:
                    ● Las edades de 20 estudiantes del turno mañana.
                    ● Las edades de 30 estudiantes del turno tarde.
                    ● Las edades de 15 estudiantes del turno noche.
                Las edades de cada estudiante deben ingresarse por teclado.
                a) Obtener el promedio de las edades de cada turno (tres promedios)
                b) Imprimir dichos promedios (promedio de cada turno)
                c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
                promedio de edades menor.
             */
            int i, valor, promM = 0, promT = 0, promN = 0, Mprom = 0, sumaM = 0, sumaT = 0, sumaN = 0;
            string linea;
            Console.WriteLine("Ingresa edades del turno mañana");
            for (i = 1; i <= 20; i++)
            {
                Console.WriteLine("Estudiante" + i);
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                sumaM = sumaM + valor;
            }
            promM = sumaM / 20;

            Console.WriteLine("Ingresa edades del turno tarde");

            for (i = 1; i <= 30; i++)
            {
                Console.WriteLine("Estudiante" + i);
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                sumaT = sumaT + valor;
            }
            promT = sumaT / 30;
            Console.WriteLine("Ingresa edades del turno noche");

            for (i = 1; i <= 15; i++)
            {
                Console.WriteLine("Estudiante " + i);
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                sumaN = sumaN + valor;
            }
            promN = sumaN / 15;

            if (promM < promT && promM < promN)
            {
                promM = Mprom;
            }

            if (promT < promM && promT < promN)
            {
                promT = Mprom;
            }

            if (promN < promT && promN < promM)
            {
                promN = Mprom;
            }
            Console.WriteLine("Promedios del turno mañana : " + promM);
            Console.WriteLine("Promedios del turno tarde : " + promT);
            Console.WriteLine("Promediso del turno noche : " + promN);
            Console.WriteLine("Promedio menor de todos los turnos : " + Mprom);
            Console.ReadKey();
        }
    }
}
