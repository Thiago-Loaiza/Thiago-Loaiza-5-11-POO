using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /*
     1. El Sistema de Peaje.
        Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
        La clase Vehiculo debe tener los siguientes atributos privados:

        Patente (de tipo string).
        Tipo (puede ser "Auto", "Camion" o "Moto").
        Tarifa (un valor decimal que representa el costo de su pase).

        El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.

        La clase CabinaPeaje debe tener como atributos privados:
        El número o identificador de la cabina.

        Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
        Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. Además, implementar los siguientes métodos dentro de CabinaPeaje:
            Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
            Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
            Un método que muestre la patente del vehículo que pagó la tarifa más cara.

    */

    internal class Vehiculo
    {
        private string patente;
        private string tipo;
        private float tarifa;

        public Vehiculo()
        {
            Console.WriteLine("Carga de datos del vehiculo");

            Console.WriteLine("Ingrese el tipo (Auto, Camion o Moto)");
            tipo = Console.ReadLine();

            Console.WriteLine("Ingrese la patente");
            patente = Console.ReadLine();

            Console.WriteLine("Ingrese la tarifa");
            tarifa = float.Parse(Console.ReadLine());
        }

        public string RetornarPatente()
        {
            return patente;
        }

        public string RetornarTipo()
        {
            return tipo;
        }

        public float RetornarTarifa()
        {
            return tarifa;
        }
    }

    internal class CabinaPeaje
    {
        private int id;
        private Vehiculo[] vehiculos;

        public CabinaPeaje()
        {
            Console.WriteLine("Ingrese el ID de la cabina");
            id = int.Parse(Console.ReadLine());

            vehiculos = new Vehiculo[3];

            for (int i = 0; i < vehiculos.Length; i++)
            {
                vehiculos[i] = new Vehiculo();
            }
        }

        public void Impresion()
        {
            Console.WriteLine("Cabina: " + id);

            for (int i = 0; i < vehiculos.Length; i++)
            {
                Console.WriteLine("Vehiculo " + (i + 1));
                Console.WriteLine("Tipo: " + vehiculos[i].RetornarTipo());
                Console.WriteLine("Patente: " + vehiculos[i].RetornarPatente());
                Console.WriteLine("");
            }
        }

        public void RecaudacionTotal()
        {
            float total = 0;

            for (int i = 0; i < vehiculos.Length; i++)
            {
                total = total + vehiculos[i].RetornarTarifa();
            }

            Console.WriteLine("La recaudacion total es: " + total);
        }

        public void TarifaMayor()
        {
            float mayor = vehiculos[0].RetornarTarifa();
            string patente = vehiculos[0].RetornarPatente();

            for (int i = 1; i < vehiculos.Length; i++)
            {
                if (vehiculos[i].RetornarTarifa() > mayor)
                {
                    mayor = vehiculos[i].RetornarTarifa();
                    patente = vehiculos[i].RetornarPatente();
                }
            }

            Console.WriteLine("El vehiculo con mayor tarifa es: " + patente);
            Console.WriteLine("Tarifa: " + mayor);
        }

        static void Main(string[] args)
        {
            CabinaPeaje cp = new CabinaPeaje();

            cp.Impresion();
            cp.RecaudacionTotal();
            cp.TarifaMayor();

            Console.ReadKey();
        }
    }
}
