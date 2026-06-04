using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    /*
     4. Línea de Ensamblaje Robótico
        En una planta de fabricación automatizada, cada robot industrial realiza tareas de
        ensamblaje complejas divididas en operaciones secundarias de duración variable.

        ● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
        1. ModeloRobot.
        2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
        fila representa una de las 4 fases principales del proceso (Estructura,
        Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
        completar las distintas subtareas de esa fase (por ejemplo, en la fase de
        Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
        1).
        3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
        cada una de las 4 fases de fabricación cuántas sub-tareas requirió realizar

        (definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
        una de ellas.

        ● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
        RobotEnsamblador. Implementar en PlantaIndustrial:
        1. Un constructor que cargue la información de los 3 robots instalados en la
        planta.
        2. Un método que muestre un reporte detallado con los tiempos de operación
        de cada robot fase por fase.
        3. Un método que calcule el promedio general de tiempo por tarea de cada
        robot y declare al Robot más Eficiente (aquel que registre el promedio de
        tiempo por operación más bajo de la planta).
     */
    internal class RobotEnsamblador
    {
        private string ModeloRobot;
        private float[][] tiemposOperacion;

        public RobotEnsamblador()
        {
            tiemposOperacion = new float[4][];

            Console.WriteLine("Ingrese modelo del robot");
            ModeloRobot = Console.ReadLine();

            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine("Ingrese cantidad de subtareas de la fase " + (f + 1));

                int cantidad = int.Parse(Console.ReadLine());

                tiemposOperacion[f] = new float[cantidad];
            }

            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < tiemposOperacion[f].Length; c++)
                {
                    Console.WriteLine("Ingrese tiempo de la subtarea");

                    tiemposOperacion[f][c] = float.Parse(Console.ReadLine());
                }
            }
        }

        public string ReturnarModelo()
        {
            return ModeloRobot;
        }

        public float ReturnarTiempo(int f, int c)
        {
            return tiemposOperacion[f][c];
        }

        public int ReturnarCantidadSubtareas(int f)
        {
            return tiemposOperacion[f].Length;
        }
    }

    internal class PlantaIndustrial
    {
        private RobotEnsamblador[] robots;

        public PlantaIndustrial()
        {
            robots = new RobotEnsamblador[3];

            for (int i = 0; i < 3; i++)
            {
                robots[i] = new RobotEnsamblador();
            }
        }

        public void ReporteTiempos()
        {
            for (int g = 0; g < 3; g++)
            {
                Console.WriteLine();
                Console.WriteLine("Robot: " + robots[g].ReturnarModelo());

                for (int f = 0; f < 4; f++)
                {
                    Console.Write("Fase " + (f + 1) + ": ");

                    for (int c = 0; c < robots[g].ReturnarCantidadSubtareas(f); c++)
                    {
                        Console.Write(robots[g].ReturnarTiempo(f, c) + " - ");
                    }

                    Console.WriteLine();
                }
            }
        }

        public void RobotMasEficiente()
        {
            float mejorPromedio = 0;
            string robot = "";

            for (int g = 0; g < 3; g++)
            {
                float suma = 0;
                int cantidad = 0;

                for (int f = 0; f < 4; f++)
                {
                    for (int c = 0; c < robots[g].ReturnarCantidadSubtareas(f); c++)
                    {
                        suma += robots[g].ReturnarTiempo(f, c);
                        cantidad++;
                    }
                }

                float promedio = suma / cantidad;

                if (g == 0 || promedio < mejorPromedio)
                {
                    mejorPromedio = promedio;
                    robot = robots[g].ReturnarModelo();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Robot mas eficiente: " + robot);
            Console.WriteLine("Promedio: " + mejorPromedio);
        }

        static void Main(string[] args)
        {
            PlantaIndustrial pi = new PlantaIndustrial();

            pi.ReporteTiempos();
            pi.RobotMasEficiente();

            Console.ReadKey();
        }
    }
}