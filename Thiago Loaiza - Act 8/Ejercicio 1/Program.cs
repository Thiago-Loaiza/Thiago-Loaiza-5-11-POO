using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /*
     1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
        del vector.
     */
    internal class CreadordeVectores
    {
        private int[] Vec;
        private int n;

        public void Cargar()
        {
            string linea;
            Console.WriteLine("Ingrese el numero de posiciones que tendra el Vector");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            Vec = new int[n];

            Console.WriteLine("Ahora ingrese los valores de cada vector");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese el valor del vector");
                linea = Console.ReadLine();
                Vec[i] = int.Parse(linea);
            }
        }

        public void ImprimirMenor()
        {
            int menor = Vec[0];
            int contador = 0;


            for (int i = 0; i < n; i++)
            {
                if (Vec[i] < menor)
                {
                    menor = Vec[i];
                }
            }


            for (int i = 0; i < n; i++)
            {
                if (Vec[i] == menor)
                {
                    contador++;
                }
            }

            Console.WriteLine("El menor es: " + menor);

            if (contador > 1)
            {
                Console.WriteLine("El menor se repite");
            }
            else
            {
                Console.WriteLine("El menor no se repite");
            }
        }

        static void Main(string[] args)
        {
            CreadordeVectores cv = new CreadordeVectores();

            cv.Cargar();
            cv.ImprimirMenor();

            Console.ReadKey();
        }
    }
}
