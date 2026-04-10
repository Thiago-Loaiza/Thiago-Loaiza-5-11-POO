using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class PuntacionesVideojuego
    {
        /*
         3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
            un videojuego. El programa debe:
             Mostrar la puntuación más alta y la más baja.
             Calcular el promedio de puntuación.
             Contar cuántas veces superó los 500 puntos.
         */
        private int[] Vec;
        public void CargarPuntajes()
        {
            Vec = new int[6];
            Console.WriteLine("Ingrese los 6 puntajes del videojuego");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingrese el puntaje");
                string linea;
                linea = Console.ReadLine();
                Vec[i] = int.Parse(linea);
            }
        }

        public void MayYMenor()
        {
            int mayor = 0;
            int menor = Vec[0];


            for (int i = 0; i < 6; i++)
            {
                if (Vec[i] > mayor)
                {
                    mayor = Vec[i];
                }

                if (Vec[i] < menor)
                {
                    menor = Vec[i];
                }
            }
            Console.WriteLine("El puntaje mayor es : " + mayor);
            Console.WriteLine("El puntaje menor es : " + menor);
        }

        public void Promedio()
        {
            float suma;
            suma = 0;
            for (int i = 0; i < 6; i++)
            {
                suma = suma + Vec[i];
            }
            float promedio = suma / 6;
            Console.WriteLine("El promedio de todos los puntajes es : " + promedio);
        }

        public void Sup500()
        {
            int cont = 0;
            for (int i = 0; i < 6; i++)
            {
                if (Vec[i] > 500)
                {
                    cont++;
                }
            }
            Console.WriteLine("Los puntajes mayores a 500 son : " + cont);
        }

        static void Main(string[] args)
        {
            PuntacionesVideojuego pv = new PuntacionesVideojuego();
            pv.CargarPuntajes();
            pv.MayYMenor();
            pv.Promedio();
            pv.Sup500();
            Console.ReadKey();
        }
    }
}
