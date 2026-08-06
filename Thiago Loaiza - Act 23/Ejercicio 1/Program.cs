using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /*
        En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
        llegada.
             Crear la clase Documento que contenga como atributos privados:
            nombreArchivo (string) y cantidadPaginas (int). Definir sus
            propiedades de solo lectura y un constructor que reciba los parámetros nom
            y pag.
             Crear la clase ServidorImpresion que administre una lista dinámica de
            documentos (List&lt;Documento&gt;).
             Métodos en ServidorImpresion:
            1. AgregarDocumento(): Solicitar por teclado los datos de un
            documento y agregarlo al final de la lista utilizando .Add().
            2. ImprimirSiguiente(): Si la lista no está vacía, simular la
            impresión del primer documento de la lista (mostrar sus datos en
            consola) y removerlo de la colección mediante .RemoveAt(0). Si está
            vacía, advertir que no hay trabajos pendientes.
            3. MostrarColaPendiente(): Listar todos los documentos que
            están esperando ser impresos y la cantidad total de páginas
            acumuladas en la cola de espera utilizando .Count.
     */
    internal class ServidorImpresion
    {
        List<Documento> ListaDinamica = new List<Documento>();

        public void AgregarDocumneto()
        {
            int cantidad = 0;
            Console.WriteLine("Ingrese la cantidad de documentos que agregara");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Archivo numero : " + (i+1) );
                Console.WriteLine("Ingrese el nombre del archivo");
                string nom = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de paginas");
                int pags = int.Parse(Console.ReadLine());

                Documento Doc = new Documento(nom, pags);
                ListaDinamica.Add(Doc);
            }
        }

        public void ImprimirSiguiente()
        {
            Console.WriteLine();
            if (ListaDinamica.Count == 0){
                Console.WriteLine("La lista esta vacia...");
            }
            else
            {
                Documento obj = ListaDinamica[0];
                Console.WriteLine("=== Imprimiendo --> Documento : " + obj.NombreArchivo);
                Console.WriteLine("Cantidad de paginas : " + obj.CantidaPaginas);
                ListaDinamica.RemoveAt(0);
                Console.WriteLine();
            }
        }

        public void MostrarColaPendiente()
        {
            Console.WriteLine(" | Cola de impresion | ");
            Console.WriteLine();
            foreach (Documento b in ListaDinamica)
            {
                Console.WriteLine("Documento : " + b.NombreArchivo + " | Cantidad de paginas : " + b.CantidaPaginas);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ServidorImpresion si = new ServidorImpresion();

            for (int i = 0; i < 3; i++)
            {
                si.AgregarDocumneto();
                si.ImprimirSiguiente();
                si.MostrarColaPendiente();
                Console.ReadKey();
            }
        }
    }
}
