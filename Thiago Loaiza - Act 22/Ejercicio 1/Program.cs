using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /*
        Actividad 1: Control de horarios en un gimnasio
        Problema:
        Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin (usar
        DateTime).
         Implementar un constructor que permita cargar los datos desde consola y otro
        que cargue valores por defecto (sobrecarga de constructores).
         Incluir un método para calcular la duración de la clase usando TimeSpan.
         Crear un vector de 3 clases de gimnasio y mostrar:
        1. La clase que tenga la mayor duración.
        2. El nombre y el horario de inicio de la clase más temprana.
        */
    /*
     robots = new RobotEnsamblador[3];

                for (int i = 0; i < 3; i++)
                {
                    robots[i] = new RobotEnsamblador();
                }
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Gimnasio[] clases = new Gimnasio[3];

            for (int i = 0; i < clases.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre de la clase:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la hora de inicio (horas:minutos)");
                DateTime inicio = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la hora de fin (horas:minutos)");
                DateTime fin = DateTime.Parse(Console.ReadLine());

                clases[i] = new Gimnasio(nombre, inicio, fin);
            }

            TimeSpan mayorDuracion = clases[0].CalculadorTiempo();
            string nombreMayor = clases[0].NombreClase;

            for (int i = 1; i < clases.Length; i++)
            {
                TimeSpan duracion = clases[i].CalculadorTiempo();

                if (duracion > mayorDuracion)
                {
                    mayorDuracion = duracion;
                    nombreMayor = clases[i].NombreClase;
                }
            }

            Console.WriteLine();
            Console.WriteLine("La clase con mayor duracion es: " + nombreMayor);
            Console.WriteLine("Duracion: " + mayorDuracion);

            DateTime masTemprana = clases[0].HoraInicio;
            string nombreTemprano = clases[0].NombreClase;

            for (int i = 1; i < clases.Length; i++)
            {
                if (clases[i].HoraInicio < masTemprana)
                {
                    masTemprana = clases[i].HoraInicio;
                    nombreTemprano = clases[i].NombreClase;
                }
            }

            Console.WriteLine();
            Console.WriteLine("La clase mas temprana es: " + nombreTemprano);
            Console.WriteLine("Hora de inicio: " + masTemprana);

            Console.ReadKey();
        }
    }
}
