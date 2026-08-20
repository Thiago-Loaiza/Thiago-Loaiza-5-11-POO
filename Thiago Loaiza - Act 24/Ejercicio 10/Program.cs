using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    /*
     10-
    Un estacionamiento medido administra el ingreso y la salida de los vehículos que
    utilizan su playa por orden de llegada.
         Crear la clase Ticket que contenga como atributos privados: patente
        (string) y horasEstadia (int). Definir sus propiedades de solo lectura y un
        constructor que reciba pat y hs.
         Crear la clase GestionEstacionamiento que administre una lista
        dinámica de tickets (List).
         Métodos en GestionEstacionamiento:
            o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y
            agregarlo al final de la lista utilizando .Add().
            o ProcesarSalida(): Si la lista no está vacía, simular la salida del
            primer vehículo de la lista (mostrar sus datos en consola) y
            removerlo de la colección mediante .RemoveAt(0). Si está vacía,
            advertir que no hay vehículos esperando salida.
            o MostrarVehiculosEstacionados(): Listar todos los vehículos
            alojados en la playa y la cantidad total de unidades presentes
            utilizando la propiedad .Count.
     */
    internal class GestionEstacionamiento
    {
        List<Ticket> ListaTickets = new List<Ticket>();  

        public void RegistrarIngreso()
        {
            string patente = "";
            int horas;
            Console.WriteLine("Ingresa los datos del ticket");
            Console.WriteLine("Ingresa la patente: ");
            patente = Console.ReadLine();
            Console.WriteLine("Ingresa las horas de estadia");
            horas = int.Parse(Console.ReadLine());

            Ticket ticket = new Ticket(patente,horas);

            ListaTickets.Add(ticket);
        }

        public void ProcesarSalida()
        {
            if(ListaTickets.Count > 0)
            {
                Console.WriteLine("Un auto esta saliendo...");
                Console.WriteLine("El auto con patente : " + ListaTickets[0].Patente + " con su Hs de estadia : " + ListaTickets[0].HorasSentandia + " se esta retirando");
                ListaTickets.RemoveAt(0);
                Console.WriteLine("El auto salio con exito");
            }
            else
            {
                Console.WriteLine("No hay autos actualmente");
            }
        }

        public void MostrarVehiculosEstacionados()
        {
            Console.WriteLine("Lista de autos");
            foreach (var t in ListaTickets)
            {
                Console.WriteLine("Auto - Patente: " + t.Patente + " - Horas de estadia: " + t.HorasSentandia);
            }
            Console.WriteLine("Hay un total de: " + ListaTickets.Count + " Autos");
        }

        static void Main(string[] args)
        {
            GestionEstacionamiento ge = new GestionEstacionamiento();

            ge.RegistrarIngreso();
            ge.RegistrarIngreso();
            ge.ProcesarSalida();
            ge.MostrarVehiculosEstacionados();
            Console.ReadKey();
        }
    }
}
