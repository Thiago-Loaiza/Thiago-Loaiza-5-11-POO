using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    /*
     Actividad 5: Gestión de Carreras Deportivas
        Consigna:
        Crear un sistema para gestionar carreras deportivas. Cada carrera tiene un código,
        una hora de inicio y una hora de fin. Cada carrera puede registrar varios corredores.
        Se pide:
        1. Crear una clase Carrera con:
        o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
        definidos.
        o Dos constructores (uno por defecto y otro con parámetros).
        o Método para calcular la duración de la carrera usando TimeSpan.
        2. Crear una clase Corredor con:
        o Atributos: nombre, número de dorsal y tiempo total.
        o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
        horas y minutos).

        3. Mostrar en consola (usando Console.SetCursorPosition()):
        o La carrera con mayor duración.
        o El corredor más rápido.
        4. Utilizar this en los constructores o métodos donde corresponda.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Carrera[] carreras = new Carrera[2];

            for (int i = 0; i < carreras.Length; i++)
            {
                Console.WriteLine("Carrera " + (i + 1));

                Console.Write("Codigo: ");
                string codigo = Console.ReadLine();

                Console.Write("Hora de inicio (horas:minutos): ");
                DateTime inicio = DateTime.Parse(Console.ReadLine());

                Console.Write("Hora de fin (horas:minutos): ");
                DateTime fin = DateTime.Parse(Console.ReadLine());

                carreras[i] = new Carrera(codigo, inicio, fin);

                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Corredor " + (j + 1));

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Dorsal: ");
                    int dorsal = int.Parse(Console.ReadLine());

                    Corredor c = new Corredor(nombre, dorsal);

                    Console.WriteLine("1 - Minutos");
                    Console.WriteLine("2 - Horas y minutos");

                    int op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        Console.Write("Minutos: ");
                        int minutos = int.Parse(Console.ReadLine());

                        c.RegistrarTiempo(minutos);
                    }
                    else
                    {
                        Console.Write("Horas: ");
                        int horas = int.Parse(Console.ReadLine());

                        Console.Write("Minutos: ");
                        int minutos = int.Parse(Console.ReadLine());

                        c.RegistrarTiempo(horas, minutos);
                    }

                    carreras[i].Corredores.Add(c);
                }

                Console.WriteLine();
            }

            Carrera mayor = carreras[0];

            for (int i = 1; i < carreras.Length; i++)
            {
                if (carreras[i].CalcularDuracion() > mayor.CalcularDuracion())
                {
                    mayor = carreras[i];
                }
            }

            Corredor rapido = carreras[0].Corredores[0];

            for (int i = 0; i < carreras.Length; i++)
            {
                for (int j = 0; j < carreras[i].Corredores.Count; j++)
                {
                    if (carreras[i].Corredores[j].TiempoTotal < rapido.TiempoTotal)
                    {
                        rapido = carreras[i].Corredores[j];
                    }
                }
            }

            Console.Clear();

            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Carrera con mayor duracion: " + mayor.Codigo);

            Console.SetCursorPosition(0, 4);
            Console.WriteLine("Duracion: " + mayor.CalcularDuracion());

            Console.SetCursorPosition(0, 7);
            Console.WriteLine("Corredor mas rapido: " + rapido.Nombre);

            Console.SetCursorPosition(0, 9);
            Console.WriteLine("Tiempo: " + rapido.TiempoTotal + " minutos");

            Console.SetCursorPosition(0, 12);
            Console.ReadKey();
        }
    }
}
