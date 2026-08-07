using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /*
     3-
        Un centro de conservación marina registra de forma dinámica las especies de
        mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
         Crear la clase MonitoreoCostero que contenga como atributo privado
        una lista de cadenas de texto List&lt;string&gt; especiesDetectadas.
         Métodos en MonitoreoCostero:
        1. CargarAvistamientos(): Solicitar por teclado nombres de
        especies marinas avistadas (ej: &quot;Ballena Franca&quot;, &quot;Lobo Marino&quot;,
        &quot;Delfín&quot;) y agregarlos a la lista utilizando .Add(). La carga finaliza
        cuando el usuario ingresa la palabra &quot;FIN&quot;.
        2. MostrarReporteOrdenado(): Imprimir la lista de avistamientos
        organizada alfabéticamente de la A a la Z utilizando el método
        .Sort().
        3. MostrarReporteInvertido(): Imprimir la lista organizada de la
        Z a la A combinando .Sort() con el método .Reverse().
        4. BuscarEspecie(): Pedir al operador que ingrese el nombre de un
        animal y, utilizando los métodos de búsqueda de listas, informar si la
        especie fue divisada en la costa durante el día.
    */

    internal class Program
    {
        MonitoreoCostero monitoreo = new MonitoreoCostero();

        public void CargarAvistamientos()
        {
            Console.WriteLine("=== CARGA DE AVISTAMIENTOS ===");
            Console.WriteLine();

            string especie;

            Console.WriteLine("Ingrese una especie ('FIN' para terminar)");
            especie = Console.ReadLine();

            while (especie != "FIN")
            {
                monitoreo.especiesDetectadas.Add(especie);

                Console.WriteLine("Ingrese otra especie ('FIN' para terminar)");
                especie = Console.ReadLine();
            }
        }

        public void MostrarReporteOrdenado()
        {
            Console.WriteLine();
            Console.WriteLine("=== REPORTE A - Z ===");
            Console.WriteLine();

            monitoreo.especiesDetectadas.Sort();

            foreach (string esp in monitoreo.especiesDetectadas)
            {
                Console.WriteLine(esp);
            }
        }

        public void MostrarReporteInvertido()
        {
            Console.WriteLine();
            Console.WriteLine("=== REPORTE Z - A ===");
            Console.WriteLine();

            monitoreo.especiesDetectadas.Sort();
            monitoreo.especiesDetectadas.Reverse();

            foreach (string esp in monitoreo.especiesDetectadas)
            {
                Console.WriteLine(esp);
            }
        }

        public void BuscarEspecie()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese la especie que desea buscar");
            string buscar = Console.ReadLine();

            bool encontrado = false;

            foreach (string esp in monitoreo.especiesDetectadas)
            {
                if (esp == buscar)
                {
                    encontrado = true;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("La especie fue encontrada.");
            }
            else
            {
                Console.WriteLine("La especie NO fue encontrada.");
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            p.CargarAvistamientos();
            Console.WriteLine();
            p.MostrarReporteOrdenado();
            Console.WriteLine();
            p.MostrarReporteInvertido();
            Console.WriteLine();
            p.BuscarEspecie();

            Console.ReadKey();
        }
    }
}