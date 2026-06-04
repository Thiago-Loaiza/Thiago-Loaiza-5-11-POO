using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    /*
        2. Logística de Puerto Espacial
        Una estación de acoplamiento registra el peso de los contenedores transportados en las
        bodegas de carga de las naves espaciales que llegan al puerto.

        ● Crear la clase NaveEspacial que contenga únicamente el atributo privado
        NombreNave y su constructor para cargarlo.
        ● Crear la clase colaboradora PuertoControl que contenga:
        ○ Un vector de 3 objetos de la clase NaveEspacial.
        ○ Una matriz irregular de tipo double llamado pesoContenedores, donde
        cada fila representa a una nave, el tamaño de la fila es la cantidad de
        bodegas que posee esa nave, y los valores almacenados son los pesos (en
        toneladas) de los contenedores que transporta cada bodega.

        En PuertoControl, definir los siguientes métodos:

        1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
        cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
        irregular) y cargue el peso del contenedor asignado a cada bodega.
        2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
        espacial.
        3. Un método que identifique e informe qué nave transporta el contenedor individual
        más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
        irregular).
        4. Un método que indique el nombre de la nave que transporta menor peso acumulado
        total (la suma de todos sus contenedores).
     */
    internal class NaveEspacial
    {
        private string NombreNave;
        public NaveEspacial()
        {
            Console.WriteLine("Ingrese el nombre de la nave");
            NombreNave = Console.ReadLine();
        }
        public string ReturnarNombre()
        {
            return NombreNave;
        }
    }

    internal class PuertoControl
    {
        private NaveEspacial[] naves;
        private double[][] pesoContenedores;
        public PuertoControl()
        {
            naves = new NaveEspacial[3];
            pesoContenedores = new double[3][];

            for (int i = 0; i < 3; i++)
            {
                naves[i] = new NaveEspacial();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese cantidad de bodegas de la nave " + naves[i].ReturnarNombre());
                int cantidad = int.Parse(Console.ReadLine());
                pesoContenedores[i] = new double[cantidad];
            }

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < pesoContenedores[f].Length; c++)
                {
                    Console.WriteLine("Ingrese peso del contenedor " + (c + 1));

                    pesoContenedores[f][c] = double.Parse(Console.ReadLine());
                }
            }
        }

        public void MuestraCarga()
        {
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine();
                Console.WriteLine("Nave: " + naves[f].ReturnarNombre());
                for (int c = 0; c < pesoContenedores[f].Length; c++)
                {
                    Console.Write(pesoContenedores[f][c] + " - ");
                }
                Console.WriteLine();
            }
        }

        public void ContenedorMasPesado()
        {
            double mayor = pesoContenedores[0][0];
            string nave = naves[0].ReturnarNombre();
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < pesoContenedores[f].Length; c++)
                {
                    if (pesoContenedores[f][c] > mayor)
                    {
                        mayor = pesoContenedores[f][c];
                        nave = naves[f].ReturnarNombre();
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("La nave con el contenedor mas pesado es: " + nave);
            Console.WriteLine("Peso: " + mayor);
        }

        public void MenorCargaTotal()
        {
            double menor = 0;
            string naveMenor = "";

            for (int f = 0; f < 3; f++)
            {
                double suma = 0;
                for (int c = 0; c < pesoContenedores[f].Length; c++)
                {
                    suma += pesoContenedores[f][c];
                }

                if (f == 0 || suma < menor)
                {
                    menor = suma;
                    naveMenor = naves[f].ReturnarNombre();
                }
            }

            Console.WriteLine();
            Console.WriteLine("La nave con menor peso acumulado es: " + naveMenor);
            Console.WriteLine("Peso total: " + menor);
        }

        static void Main(string[] args)
        {
            PuertoControl pc = new PuertoControl();
            pc.MuestraCarga();
            pc.ContenedorMasPesado();
            pc.MenorCargaTotal();
            Console.ReadKey();
        }
    }
}