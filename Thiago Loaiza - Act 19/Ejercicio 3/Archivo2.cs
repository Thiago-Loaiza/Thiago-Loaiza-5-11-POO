using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    partial class JuegoArcade
    {
        private string jugador;
        private string campeon;
        private int puntaje;
        private int record=10;

        public void IngresarPuntaje()
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese su nombre : ");
            jugador = Console.ReadLine();
            Console.WriteLine("Ingrese el puntaje que saco en el juego");
            puntaje = int.Parse(Console.ReadLine());
            while (puntaje > PuntajeMaximo)
            {
                Console.WriteLine("El puntaje no puede superar al maximo");
                puntaje = int.Parse(Console.ReadLine());
            }
            if (puntaje > record)
            {
                record = puntaje;
                campeon = jugador;
            }
        }

        public int ReturnarRecord()
        {
            return record;
        }

        public string ReturnarCampeon()
        {
            return campeon;
        }
    }
}
