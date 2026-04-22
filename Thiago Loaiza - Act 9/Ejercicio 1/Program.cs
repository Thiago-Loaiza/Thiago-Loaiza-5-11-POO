using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /*  
        Todas las actividades deben contar con un método para cargar los datos, y no
        predefinirlos.
    */

    /*
     1. Se desea desarrollar un programa que permita registrar los nombres y las
        calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
        nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
        estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
        máxima o mínima.
     */
    internal class Program
    {
        static string[] nombres;
        static int[] notas;

        static void Cargar()
        {
            nombres = new string[6];
            notas = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();
                Console.Write("Nota: ");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }

        static void MayorYMenor()
        {
            int contMayor = 0;
            int contMenor = 0;
            int mayor = notas[0];
            int menor = notas[0];

            for (int i = 1; i < 6; i++)
            {
                if (notas[i] > mayor) mayor = notas[i];
                if (notas[i] < menor) menor = notas[i];
            }

            Console.WriteLine("Mayor nota:");
            for (int i = 0; i < 6; i++)
            {
                if (notas[i] == mayor)
                {
                    contMayor++;
                    Console.WriteLine(nombres[i] + " - " + notas[i]);
                }
                if (contMayor > 1)
                {
                    Console.WriteLine("Hay notas maximas repetidas ");
                }

            }


            Console.WriteLine("Menor nota:");
            for (int i = 0; i < 6; i++)
            {
                if (notas[i] == menor)
                {
                    Console.WriteLine(nombres[i] + " - " + notas[i]);
                    contMenor++;
                }
            }

            if (contMenor > 1)
            {
                Console.WriteLine("Hay notas minimas repetidas");
            }

        }

        static void Main(string[] args)
        {
            Cargar();
            MayorYMenor();
            Console.ReadKey();
        }
    }
}
