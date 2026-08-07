using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    /*
     4-
        Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
        vinculados a una red hogareña.
         Crear la clase DispositivoInteligente que contenga como atributos
        privados: nombreDispositivo (string) y consumoWatts (double). Definir
        sus propiedades y un constructor que reciba nom y watts.
         Crear la clase colaboradora PanelDomotico que administre un objeto
        List&lt;DispositivoInteligente&gt;.
         Métodos en PanelDomotico:
        1. Un constructor que permita al usuario cargar dinámicamente
        dispositivos por teclado. El sistema preguntará después de cada
        carga si se desea agregar otro dispositivo.
        2. MostrarDispositivos(): Listar todos los dispositivos
        configurados junto a sus consumos.
        3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
        Watts totales que consume la casa sumando los valores de la lista.
        4. DesconectarDispositivo(): Solicitar al usuario el nombre de
        un dispositivo y, si existe en la lista, removerlo de forma dinámica
        para simular su apagado remoto.
     */
    internal class PanelDomotico
    {
        List<DispositivoInteligente> dispositivos = new List<DispositivoInteligente>();

        public PanelDomotico()
        {
            string opcion = "S";

            while (opcion == "S")
            {
                Console.WriteLine("Ingrese el nombre del dispositivo");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el consumo en Watts");
                double watts = double.Parse(Console.ReadLine());

                DispositivoInteligente obj = new DispositivoInteligente(nombre, watts);

                dispositivos.Add(obj);

                Console.WriteLine("Desea agregar otro dispositivo? (S/N)");
                opcion = Console.ReadLine().ToUpper();
            }
        }

        public void MostrarDispositivos()
        {
            Console.WriteLine();
            Console.WriteLine("=== DISPOSITIVOS ===");

            foreach (DispositivoInteligente d in dispositivos)
            {
                Console.WriteLine("Dispositivo: " + d.NombreDispositivo +
                                  " | Consumo: " + d.ConsumoWatts + " Watts");
            }
        }

        public void CalcularConsumoTotal()
        {
            double total = 0;

            foreach (DispositivoInteligente d in dispositivos)
            {
                total += d.ConsumoWatts;
            }

            Console.WriteLine();
            Console.WriteLine("Consumo total de la casa: " + total + " Watts");
        }

        public void DesconectarDispositivo()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese el nombre del dispositivo a desconectar");
            string nombre = Console.ReadLine();

            bool eliminado = false;

            for (int i = 0; i < dispositivos.Count; i++)
            {
                if (dispositivos[i].NombreDispositivo == nombre)
                {
                    dispositivos.RemoveAt(i);
                    eliminado = true;
                    Console.WriteLine("Dispositivo desconectado.");
                    break;
                }
            }

            if (eliminado == false)
            {
                Console.WriteLine("No se encontro el dispositivo.");
            }
        }

        static void Main(string[] args)
        {
            PanelDomotico pd = new PanelDomotico();

            pd.MostrarDispositivos();
            pd.CalcularConsumoTotal();
            pd.DesconectarDispositivo();
            pd.MostrarDispositivos();

            Console.ReadKey();
        }
    }
}
