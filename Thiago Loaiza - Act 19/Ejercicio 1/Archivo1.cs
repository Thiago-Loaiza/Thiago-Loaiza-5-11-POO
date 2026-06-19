using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    partial class ReservaHotel
    {
        private string nombrecliente;
        private int cantidadnoches;
        private string tipohabitacion;

        public string NombreCliente
        {
            set {  nombrecliente = value; }
            get { return nombrecliente; }
        }

        public int CantidadNoches
        {
            set {  cantidadnoches = value; }
            get { return cantidadnoches; }
        }

        public string TipoHabitacion
        {
            set {  tipohabitacion = value; }
            get { return tipohabitacion; }
        }

        public ReservaHotel()
        {
            Console.WriteLine("Ingrese los datos del cliente");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el nombre del cliente");
            NombreCliente = Console.ReadLine();
            Console.WriteLine("Ingrese su cantidad de noches");
            CantidadNoches = int.Parse(Console.ReadLine());
            while (CantidadNoches <= 0)
            {
                Console.WriteLine("La cantidad de noches debe ser mayor a 0");
                CantidadNoches = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese el tipo de habitacion(Simple, Double o Suite)");
            TipoHabitacion = Console.ReadLine();
            while (TipoHabitacion != "Simple" && TipoHabitacion != "Double" && TipoHabitacion != "Suite")
            {
                Console.WriteLine("El tipo de habitacion tiene que ser como las disponibles");
                TipoHabitacion = Console.ReadLine();
            }
        }
    }
}


