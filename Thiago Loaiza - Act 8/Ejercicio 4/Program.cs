using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    /*
     4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
        habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
        ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
        nuevamente.
     */
    internal class PaisesHabitantes
    {
        private string[] paises = new string[5];
        private int[] habitantes = new int[5];

        public void Cargar()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese pais:");
                paises[i] = Console.ReadLine();

                Console.WriteLine("Ingrese cantidad de habitantes:");
                habitantes[i] = int.Parse(Console.ReadLine());
            }
        }

        public void OrdenarAlfabetico()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (paises[i].CompareTo(paises[j]) > 0)
                    {
                        string auxP = paises[i];
                        paises[i] = paises[j];
                        paises[j] = auxP;

                        int auxH = habitantes[i];
                        habitantes[i] = habitantes[j];
                        habitantes[j] = auxH;
                    }
                }
            }
        }

        public void OrdenarHabitantes()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (habitantes[i] < habitantes[j])
                    {
                        string auxP = paises[i];
                        paises[i] = paises[j];
                        paises[j] = auxP;

                        int auxH = habitantes[i];
                        habitantes[i] = habitantes[j];
                        habitantes[j] = auxH;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Listado:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(paises[i] + " - " + habitantes[i]);
            }
        }

        static void Main(string[] args)
        {
            PaisesHabitantes ph = new PaisesHabitantes();

            ph.Cargar();
            Console.WriteLine("Orden alfabetico:");
            ph.OrdenarAlfabetico();
            ph.Imprimir();
            Console.WriteLine("Orden por habitantes (mayor a menor):");
            ph.OrdenarHabitantes();
            ph.Imprimir();
            Console.ReadKey();
        }
    }
}
