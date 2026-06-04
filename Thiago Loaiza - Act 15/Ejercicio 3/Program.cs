using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /*
     3. Geolocalización de Reservas Naturales
        Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
        especies protegidas en cuadrículas de territorio.

        ● Confeccionar la clase ReservaNatural que tenga como atributos privados el
        NombreReserva y una matriz llamada avistamientos de 3x3 (que representa un
        mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
        cantidad de animales avistados en cada sector). El constructor de la clase debe
        cargar por teclado el nombre y rellenar el mapa de avistamientos.
        ● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
        objetos de la clase ReservaNatural.

        La clase CentroEcologico debe implementar los siguientes métodos:
        1. Un constructor que solicite la carga secuencial de las 3 reservas.
        2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
        registró en toda su superficie (la suma de toda su matriz rectangular).
        3. Un método que determine e informe cuál fue la coordenada o sector específico ([fila,
        columna]) que registró la mayor concentración de avistamientos de toda la red de
        reservas, indicando a qué reserva pertenece.
     */
    internal class ReservaNatural
    {
        private string NombreReserva;
        private int[,] avistamientos;

        public ReservaNatural()
        {
            avistamientos = new int[3, 3];

            Console.WriteLine("Ingrese el nombre de la reserva");
            NombreReserva = Console.ReadLine();

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.WriteLine("Ingrese cantidad de avistamientos");

                    avistamientos[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public string ReturnarNombre()
        {
            return NombreReserva;
        }

        public int ReturnarDato(int f, int c)
        {
            return avistamientos[f, c];
        }
    }

    internal class CentroEcologico
    {
        private ReservaNatural[] reservas;

        public CentroEcologico()
        {
            reservas = new ReservaNatural[3];

            for (int i = 0; i < 3; i++)
            {
                reservas[i] = new ReservaNatural();
            }
        }

        public void TotalAvistamientos()
        {
            for (int g = 0; g < 3; g++)
            {
                int total = 0;

                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        total += reservas[g].ReturnarDato(f, c);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Reserva: " + reservas[g].ReturnarNombre());
                Console.WriteLine("Total de avistamientos: " + total);
            }
        }

        public void MayorAvistamiento()
        {
            int mayor = reservas[0].ReturnarDato(0, 0);

            string reserva = reservas[0].ReturnarNombre();

            int fila = 0;
            int columna = 0;

            for (int g = 0; g < 3; g++)
            {
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (reservas[g].ReturnarDato(f, c) > mayor)
                        {
                            mayor = reservas[g].ReturnarDato(f, c);
                            reserva = reservas[g].ReturnarNombre();
                            fila = f;
                            columna = c;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Mayor avistamiento:");
            Console.WriteLine("Reserva: " + reserva);
            Console.WriteLine("Coordenada: [" + fila + "," + columna + "]");
            Console.WriteLine("Cantidad: " + mayor);
        }

        static void Main(string[] args)
        {
            CentroEcologico ce = new CentroEcologico();
            ce.TotalAvistamientos();
            ce.MayorAvistamiento();
            Console.ReadKey();
        }
    }
}