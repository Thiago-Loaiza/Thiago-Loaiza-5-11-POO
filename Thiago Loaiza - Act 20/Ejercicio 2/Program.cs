using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    /*
     Actividad 2: Administración de entregas logísticas
        Problema:
        Una empresa de envíos desea registrar sus entregas mediante colaboración de
        clases.
        Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
        Despachador que contenga una lista de paquetes y un método para registrar nuevos
        paquetes.
        Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
         Todos los paquetes registrados.
         Cuántos superan los 10 kg de peso.
         Cuántos tienen destino nacional (por ejemplo, “Argentina”).
     */
    internal class Despachador
    {
        List<Paquete> ListaPaquetes = new List<Paquete>();

        public void Registrar()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("=========================================");
                Paquete paq = new Paquete();
                Console.WriteLine("Ingrese el codigo del paquete");
                paq.Codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el peso(Kg) del paquete");
                paq.Peso = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el destino del paquete");
                paq.Destino = Console.ReadLine();

                ListaPaquetes.Add(paq);
                Console.WriteLine("Paquete añadido perfectamente a la lista");
            }
        }

        static void Main(string[] args)
        {
            Despachador d = new Despachador();

            d.Registrar();

            int contpesados = 0;
            int contnacionales = 0;
            foreach (Paquete p in d.ListaPaquetes)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("El codigo del paquete es #" + p.Codigo + " Con destino a : " + p.Destino);
                Console.WriteLine("Contiene un peso(Kg) de : " + p.Peso);

                if (p.Peso > 10)
                {
                    contpesados++;
                }

                if (p.Destino == "Argentina" || p.Destino == "argentina")
                {
                    contnacionales++;
                }
            }
            Console.WriteLine("Hay un total de: " + contpesados + " paquetes pesado en esta lista");
            Console.WriteLine("Hay un total de: " + contnacionales + " paquetes nacionales en esta lista");

        }
    }
}
