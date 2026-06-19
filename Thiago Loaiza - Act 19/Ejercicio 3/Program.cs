using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /*
     3. Armar una clase parcial JuegoArcade.
        En el primer archivo, definir las propiedades NombreJuego, PuntajeMaximo, y
        NivelDificultad (de 1 a 5). Valores cargados desde consola
        En el segundo archivo, implementar un método que indique si un puntaje ingresado
        supera el récord o no.
        Desde Main, simular 4 partidas, mostrar qué jugador rompió el récord de su juego.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            JuegoArcade juego = new JuegoArcade();

            juego.IngresarPuntaje();
            juego.IngresarPuntaje();
            juego.IngresarPuntaje();
            juego.IngresarPuntaje();

            int Record = juego.ReturnarRecord();
            string JugadorRecord = juego.ReturnarCampeon();
            Console.WriteLine("");
            Console.WriteLine("El jugador que batios el record de: " + Record + " Puntos es: " + JugadorRecord);
            Console.ReadKey();
        }
    }
}
