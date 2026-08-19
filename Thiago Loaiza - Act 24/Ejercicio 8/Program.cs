using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    /*
     8-
        Una farmacia controla el nivel de stock de sus medicamentos para evitar el
        desabastecimiento de insumos esenciales.
             Crear la clase Medicamento que contenga los atributos privados: nombre
            (string) y stock (int). Definir sus propiedades correspondientes. Su
            constructor debe recibir nom y stk.
             Crear la clase ControlFarmacia que administre una lista de objetos List.
             Métodos en ControlFarmacia:
                o Un constructor que cargue por teclado una lista inicial de 4
                medicamentos ingresando sus nombres y stock.
                o ListarStock(): Mostrar la lista de medicamentos en pantalla.

                o RemoverAgotados(): Recorrer la lista y remover por completo de
                la colección a todos aquellos medicamentos cuyo stock sea igual a 0.
                o MostrarMedicamentosDisponibles(): Imprimir la lista
                actualizada y la cantidad de productos disponibles en el inventario
                utilizando la propiedad .Count.
     */
    internal class ControlFarmacia
    {
        List<Medicamento> ListaMedicamentos = new List<Medicamento>();

        public ControlFarmacia()
        {
            string nombre;
            int stock;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el nombre del medicamento: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el stock del medicamento: ");
                stock = int.Parse(Console.ReadLine());

                Medicamento medicamento = new Medicamento(nombre, stock);

                ListaMedicamentos.Add(medicamento);
            }
        }

        public void ListarStock()
        {
            Console.WriteLine(" - Lista de medicamentos -");

            foreach (var M in ListaMedicamentos)
            {
                Console.WriteLine("Medicamento: " + M.Nombre +
                                  " Stock: " + M.Stock);
            }
        }

        public void RemoverAgotados()
        {
            for (int i = ListaMedicamentos.Count - 1; i >= 0; i--)
            {
                if (ListaMedicamentos[i].Stock == 0)
                {
                    ListaMedicamentos.RemoveAt(i);
                }
            }

            Console.WriteLine("Se han removido los medicamentos agotados.");
        }

        public void MostrarMedicamentosDisponibles()
        {
            Console.WriteLine(" - Medicamentos disponibles -");

            foreach (var M in ListaMedicamentos)
            {
                Console.WriteLine("Medicamento: " + M.Nombre +
                                  " Stock: " + M.Stock);
            }

            Console.WriteLine("Cantidad de productos disponibles: " +
                              ListaMedicamentos.Count);
        }


        static void Main(string[] args)
        {
            ControlFarmacia farmacia = new ControlFarmacia();

            farmacia.ListarStock();

            farmacia.RemoverAgotados();

            farmacia.MostrarMedicamentosDisponibles();

            Console.ReadKey();
        }
    }
}