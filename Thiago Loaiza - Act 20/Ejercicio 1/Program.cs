using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /*
     Actividad 1: Sistema de control de vuelos
        Problema:
        Una aerolínea administra los vuelos programados mediante un sistema orientado a
        objetos.
        Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
        destino y duración en horas. Luego definir una clase derivada VueloInternacional que
        herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
        Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
        desde consola y luego:
         Mostrar los vuelos registrados y el país de destino.
         Informar cuál es el vuelo con mayor duración.
         Mostrar el orden de ejecución de los constructores.
     */
    internal class Program
    {
        List<VueloInternacional> listavuelo = new List<VueloInternacional>();
        public void Seteo()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("===============");
                Console.WriteLine("Ingresa el numero del vuelo");
                int numerovuelo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el destino del vuelo");
                string destino = Console.ReadLine();
                Console.WriteLine("Ingresa la duracion en horas del vuelo");
                int durhoras = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el pais destino");
                string pais = Console.ReadLine();

                VueloInternacional NuevoVuelo = new VueloInternacional(numerovuelo, destino, durhoras, pais);

                listavuelo.Add(NuevoVuelo);
                Console.WriteLine("Vuelo añadido de forma exitosa");
            }
        }

        public void Impresion()
        {
            foreach (VueloInternacional v in listavuelo)
            {
                Console.WriteLine("===============");
                Console.WriteLine("Vuelo numero : #" + v.NumeroVuelo + " Con destino a : " + v.Destino);
                Console.WriteLine("Duracion estimada de: " + v.DuracionHoras);
                Console.WriteLine("El pais a destino de este vuelo es: " + v.PaisDestino);
            }
        }

        public void MayorDur()
        {
            int num = 000000;
            int mayor = 0;
            foreach (VueloInternacional v in listavuelo)
            {
                if (v.DuracionHoras > mayor)
                {
                    mayor = v.DuracionHoras;
                    num = v.NumeroVuelo;
                }
            }
            Console.WriteLine("El vuelo con mayor duracion es el numero : #" + num + " Con una duracion en horas de: " + mayor);
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            p.Seteo();
            p.Impresion();
            p.MayorDur();
            Console.ReadKey();
        }
    }
}

