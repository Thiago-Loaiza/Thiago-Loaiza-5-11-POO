using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    /*
      5-
         Un taller mecánico automatizado administra la recepción y egreso de automóviles
         que se encuentran en el sector de reparaciones.
          Crear la clase Vehiculo que contenga como atributos privados: patente
         (string) y costoReparacion (double). Definir sus propiedades
         correspondientes y un constructor que reciba pat y costo.
          Crear la clase GestionTaller que administre una lista de objetos List.
          Métodos en GestionTaller:
         o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
         reparación de un vehículo para agregarlo a la lista mediante .Add().
         o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
         recorriendo la lista, informar si el vehículo está en el taller y mostrar
         su costo asociado.
         o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
         vehículo en la lista y, si existe, removerlo de la colección mediante
         .Remove() confirmando la entrega del automóvil.

         o CalcularRecaudacionPendiente(): Listar los vehículos
         actualmente en reparación, la cantidad total de unidades alojadas en
         el taller mediante la propiedad .Count y la suma total acumulada por
         cobrar.
     */

    internal class GestionTaller
    {
        List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        public void IngresarVehiculo()
        {
            Console.WriteLine("Ingrese la cantidad de vehiculos");

            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Vehiculo numero " + (i + 1));

                Console.WriteLine("Ingrese la patente");
                string pat = Console.ReadLine();

                Console.WriteLine("Ingrese el costo de reparacion");
                double costo = double.Parse(Console.ReadLine());

                Vehiculo obj = new Vehiculo(pat, costo);

                listaVehiculos.Add(obj);
            }
        }

        public void BuscarVehiculo()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese la patente a buscar");

            string patente = Console.ReadLine();

            bool encontrado = false;

            foreach (Vehiculo v in listaVehiculos)
            {
                if (v.Patente == patente)
                {
                    Console.WriteLine("Vehiculo encontrado.");
                    Console.WriteLine("Costo de reparacion: $" + v.CostoReparacion);

                    encontrado = true;
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("Vehiculo no encontrado.");
            }
        }

        public void EntregarVehiculo()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese la patente del vehiculo");

            string patente = Console.ReadLine();

            bool eliminado = false;

            for (int i = 0; i < listaVehiculos.Count; i++)
            {
                if (listaVehiculos[i].Patente == patente)
                {
                    listaVehiculos.RemoveAt(i);

                    Console.WriteLine("Vehiculo entregado.");

                    eliminado = true;

                    break;
                }
            }

            if (eliminado == false)
            {
                Console.WriteLine("No existe un vehiculo con esa patente.");
            }
        }

        public void CalcularRecaudacionPendiente()
        {
            double total = 0;

            Console.WriteLine();
            Console.WriteLine("=== VEHICULOS EN REPARACION ===");
            Console.WriteLine();

            foreach (Vehiculo v in listaVehiculos)
            {
                Console.WriteLine("Patente: " + v.Patente +
                    " | Costo: $" + v.CostoReparacion);

                total += v.CostoReparacion;
            }

            Console.WriteLine();
            Console.WriteLine("Cantidad de vehiculos: " + listaVehiculos.Count);
            Console.WriteLine("Recaudacion pendiente: $" + total);
        }

        static void Main(string[] args)
        {
            GestionTaller gt = new GestionTaller();

            gt.IngresarVehiculo();

            Console.WriteLine();
            gt.BuscarVehiculo();

            Console.WriteLine();
            gt.EntregarVehiculo();

            Console.WriteLine();
            gt.CalcularRecaudacionPendiente();

            Console.ReadKey();
        }
    }
}