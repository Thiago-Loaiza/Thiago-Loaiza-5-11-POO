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
                Console.WriteLine("Ingresa el nombre de la clase");
                string NombreClase = Console.ReadLine();
                Console.WriteLine("Ingresa la fecha de inicio de la clase");
                DateTime HoraInicio = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la fecha de finalizacion de la clase");
                DateTime HoraFin = DateTime.Parse(Console.ReadLine());

                clases[i] = new Gimnasio(NombreClase,HoraInicio,HoraFin); 
            }
                TimeSpan mayorDur = clases[0].CalculadorTiempo();
            string nom1 = clases[0].NombreClase;

            for (int i = 0; i < clases.Length; i++)
            {
                if (clases[i].CalculadorTiempo() > mayorDur){
                    mayorDur = clases[i].CalculadorTiempo();
                    nom1 = clases[i].NombreClase;
                }
            }
            Console.WriteLine("La clase con mayor duracion de: " + mayorDur + " es la clase: " +  nom1);

            DateTime masTemprana = clases[0].HoraInicio;
            string nom2 = clases[0].NombreClase;

            for (int i = 0; i < clases.Length; i++)
            {
                if (clases[i].HoraInicio > masTemprana)
                {
                    masTemprana = clases[i].HoraInicio;
                    nom2 = clases[i].NombreClase;
                }
            }

            Console.WriteLine("La clase mas temprana es: " + nom2 + " con una hora de inicio de: " + masTemprana);
        }
    }
}
