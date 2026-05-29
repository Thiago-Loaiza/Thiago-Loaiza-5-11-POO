using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    /*
     2. Control de Vuelos

        Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
        Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero. Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
        Agregar los siguientes métodos en la clase Vuelo:

            Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
            Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
            Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI.
    */

    internal class Pasajero
    {
        private string nombre;
        private int dni;
        private float equipajeKilos;

        public Pasajero()
        {
            Console.WriteLine("Carga de datos del pasajero");

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el DNI");
            dni = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el peso del equipaje");
            equipajeKilos = float.Parse(Console.ReadLine());
        }

        public string RetornarNombre()
        {
            return nombre;
        }

        public int RetornarDNI()
        {
            return dni;
        }

        public float RetornarEquipaje()
        {
            return equipajeKilos;
        }
    }

    internal class Vuelo
    {
        private Pasajero[] pasajeros;

        public Vuelo()
        {
            pasajeros = new Pasajero[4];

            for (int i = 0; i < pasajeros.Length; i++)
            {
                pasajeros[i] = new Pasajero();
            }
        }

        public void Listado()
        {
            for (int i = 0; i < pasajeros.Length; i++)
            {
                Console.WriteLine("Nombre: " + pasajeros[i].RetornarNombre());
                Console.WriteLine("DNI: " + pasajeros[i].RetornarDNI());
                Console.WriteLine("Equipaje: " + pasajeros[i].RetornarEquipaje());
                Console.WriteLine("");
            }
        }

        public void PesoTotal()
        {
            float total = 0;

            for (int i = 0; i < pasajeros.Length; i++)
            {
                total = total + pasajeros[i].RetornarEquipaje();
            }

            Console.WriteLine("El peso total del equipaje es: " + total);
        }

        public void ExcesoEquipaje()
        {
            Console.WriteLine("Pasajeros con exceso de equipaje:");

            for (int i = 0; i < pasajeros.Length; i++)
            {
                if (pasajeros[i].RetornarEquipaje() > 23)
                {
                    Console.WriteLine(" --- ");
                    Console.WriteLine(pasajeros[i].RetornarNombre());
                    Console.WriteLine(pasajeros[i].RetornarDNI());
                }
            }
        }

        static void Main(string[] args)
        {
            Vuelo v = new Vuelo();

            v.Listado();
            v.PesoTotal();
            v.ExcesoEquipaje();

            Console.ReadKey();
        }
    }
}
