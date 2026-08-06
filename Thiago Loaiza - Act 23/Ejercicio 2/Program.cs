using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    /*
     2-
        Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
        drones de entrega en vuelo de regreso a la base.
         Crear la clase Dron que contenga los atributos privados: codigo (string) y
        nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
        Su constructor debe recibir cod y bat.
         Crear la clase CentroControl que administre una lista de objetos
        List&lt;Dron&gt;.
         Métodos en CentroControl:

        1. Un constructor que cargue por teclado una lista inicial de 4 drones
        ingresando sus códigos y baterías.
        2. ListarFlota(): Mostrar la lista de drones en pantalla.
        3. RemoverDronesBajos(): Recorrer la lista y remover por
        completo de la flota a todos aquellos drones cuyo nivel de batería
        sea menor o igual al 15% (ya que requieren mantenimiento
        automático urgente).
        4. MostrarDronesRestantes(): Imprimir la flota actualizada y la
        cantidad de drones operativos utilizando la propiedad .Count.
     */
    internal class CentrodeControl
    {
        List<Dron> controles = new List<Dron>();
        public CentrodeControl()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Datos del dron numero : " + (1 + i));
                string cod;
                Console.WriteLine("Ingrese el codigo");
                cod = Console.ReadLine();
                int bat = 0;
                Console.WriteLine("Ingrese la bateria (1 - 100)");
                bat = int.Parse(Console.ReadLine());
                while (bat < 0 && bat >= 100)
                {
                    Console.WriteLine("Reingrese el valor de la bateria (1 - 100)");
                    bat = int.Parse(Console.ReadLine());
                }
                Dron dron = new Dron(cod, bat);
                controles.Add(dron);
            }
        }

        public void ListarFlota()
        {
            Console.WriteLine("Lista de todos los drones");
            Console.WriteLine();
            foreach (Dron d in controles)
            {
                Console.WriteLine("Dron del codigo : " + d.Codigo + " | Su nivel de bateria es : " + d.NiveldeBateria);
            }
        }

        public void RemoverDronesBajos()
        {
            foreach (Dron j in controles)
            {
                if (j.NiveldeBateria < 15)
                {
                    controles.Remove(j);
                }
            }
        }

        public void MostrarDronesRestantes()
        {
            Console.WriteLine("Lista de todos los drones despues del descarte");
            Console.WriteLine();
            foreach (Dron d in controles)
            {
                Console.WriteLine("Dron del codigo : " + d.Codigo + " | Su nivel de bateria es : " + d.NiveldeBateria);
            }
        }
        static void Main(string[] args)
        {
            CentrodeControl cc = new CentrodeControl();

            cc.ListarFlota();
            cc.RemoverDronesBajos();
            cc.MostrarDronesRestantes();
            Console.ReadKey();
        }
    }
}
