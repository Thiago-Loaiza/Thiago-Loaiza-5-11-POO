using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /*
     1. Plantear una clase parcial ReservaHotel.
        En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
        TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
        noches sea mayor a 0. Estos valores son cargados desde la consola.
        En el segundo archivo, agregar un método que calcule el total a pagar según la
        habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
        noche).
        Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            ReservaHotel[] reservas;
            reservas = new ReservaHotel[3];
            int Mayor = 0;
            string nomMayor = "";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Reserva numero : " + (i + 1));
                reservas[i] = new ReservaHotel();
                if (reservas[i].TotalPagar() > Mayor)
                {
                    Mayor = reservas[i].TotalPagar();
                    nomMayor = reservas[i].NombreCliente;
                }
            }
            Console.WriteLine("==================");
            Console.WriteLine("El cliente que mas paga es: " + nomMayor + "Con un cantidad de: " + Mayor);
        }
    }
}
