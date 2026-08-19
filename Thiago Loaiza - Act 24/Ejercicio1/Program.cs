using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    /*
     7-
    Un restaurante automatizado procesa la comanda de una mesa para controlar la
    preparación y el cobro de los platos pedidos.
         Crear la clase Plato que contenga como atributos privados: nombrePlato
        (string) y precio (double). Definir sus propiedades correspondientes y un
        constructor que reciba nom y pre.
         Crear la clase GestionComandas que administre una lista de objetos List.
         Métodos en GestionComandas:
            o AgregarPlato():Solicitar por teclado los datos de un plato y
            agregarlo a la lista utilizando .Add().
            o MostrarComanda(): Listar todos los platos agregados hasta el
            momento junto a la cantidad total de ítems pedidos utilizando la
            propiedad .Count.
            o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
            total a cobrar sumando los precios de la lista.
            o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
            se encuentra en la lista, removerlo mediante .Remove() para
            actualizar la comanda.
     */
    internal class GestionComandas
    {
        List<Plato> GestionDeComandas = new List<Plato>();

        public void AgregarPlato()
        {
            string nombre;
            double precio = 0;

            Console.WriteLine("Ingrese el nombre del plato: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del plato: ");
            precio = double.Parse(Console.ReadLine());

            Plato plato = new Plato(nombre, precio);

            GestionDeComandas.Add(plato);
        }

        public void MostrarComanda()
        {
            int cantidad = GestionDeComandas.Count;

            Console.WriteLine(" - Lista de platos en la orden -");

            foreach (var P in GestionDeComandas)
            {
                Console.WriteLine("Plato: " + P.NombrePlato +
                                  " Precio: $" + P.Precio);
            }

            Console.WriteLine("Hay un total de: " + cantidad);
        }

        public void CalcularTotalMesa()
        {
            Console.WriteLine("El monto total de todos los platos cargados en la comanda:");

            double total = 0;

            foreach (var P in GestionDeComandas)
            {
                total += P.Precio;
            }

            Console.WriteLine("Unos: $" + total);
        }

        public void CancelarPlato()
        {
            string nombre;

            Console.WriteLine("Ingrese el nombre del plato a eliminar: ");
            nombre = Console.ReadLine();

            for (int i = 0; i < GestionDeComandas.Count; i++)
            {
                if (nombre == GestionDeComandas[i].NombrePlato)
                {
                    Plato plato = GestionDeComandas[i];

                    GestionDeComandas.Remove(plato);

                    Console.WriteLine("Se ha removido con exito el plato: " + nombre);

                    return;
                }
            }

            Console.WriteLine("No se encontro el plato.");
        }


        static void Main(string[] args)
        {
            GestionComandas gestion = new GestionComandas();

            gestion.AgregarPlato();
            gestion.AgregarPlato();

            gestion.MostrarComanda();

            gestion.CalcularTotalMesa();

            gestion.CancelarPlato();

            gestion.MostrarComanda();

            Console.ReadKey();
        }
    }
}
