using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    partial class JuegoArcade
    {
        private string nombrejuego;
        private int puntajemaximo;
        private int niveldificultad;

        public string NombreJuego
        {
            set { nombrejuego = value; }
            get { return nombrejuego; }
        }

        public int PuntajeMaximo
        {
            set {  puntajemaximo = value; }
            get { return puntajemaximo; }
        }

        public int NivelDificultad
        {
            set {niveldificultad = value;}
            get {return niveldificultad;}
        }

        public JuegoArcade()
        {
            Console.WriteLine("Informacion del juego");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el Nombre del juego");
            NombreJuego = Console.ReadLine();
            Console.WriteLine("Ingrese el Puntaje maximo obtenible");
            PuntajeMaximo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nivel de dificultad(1-5)");
            NivelDificultad = int.Parse(Console.ReadLine());
            while (NivelDificultad < 1 || NivelDificultad > 5)
            {
                Console.WriteLine("La dificultad tiene que estar en el rango 1 - 5");
                NivelDificultad = int.Parse(Console.ReadLine());
            }
        }
    }
}
