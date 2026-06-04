using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /*
     1. Monitoreo Clínico de Pacientes
        En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo
        cardíaco de los pacientes.
        ● Plantear una clase llamada Paciente que tenga como atributos privados:
            1. Nombre (de tipo string).
            2. Una matriz llamada ritmoCardiaco de tamaño 3x4 (representando los
            registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos
            clave de cada día: mañana, mediodía, tarde y noche).
            3. El constructor de Paciente debe pedir su nombre y solicitar la carga por
            teclado de las 12 lecturas cardíacas.

        ● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3
        objetos de la clase Paciente. Su constructor debe inicializar el vector y solicitar la
        carga de los 3 pacientes. Implementar los siguientes métodos dentro de
        SalaMonitoreo:
            1. Un método que imprima la grilla de lecturas cardíacas completa de cada
            paciente organizada por día y momento.
            2. Un método que calcule e imprima el promedio de pulsaciones de cada
            paciente a lo largo de todo su monitoreo.
            3. Un método que verifique si algún paciente registró un evento de taquicardia
            severa (cualquier lectura individual que sea estrictamente mayor a 120
            pulsaciones), mostrando por consola su nombre y la lectura detectada.
     */
    internal class Paciente
    {
        private string Nombre;
        private int[,] ritmoCardiaco;

        public Paciente()
        {
            ritmoCardiaco = new int[3, 4];
            Console.WriteLine("Ingresa el nombre del paciente :");
            Nombre = Console.ReadLine();
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    string[] dias = { "mañana", "mediodia", "tarde", "noche" };

                    Console.WriteLine("Ingrese el valor de la lectura del dia numero " + (f + 1) + " en el momento del dia " + (dias[c]) + " ( " + (c + 1) + " / 4 )");
                    string linea = Console.ReadLine();
                    ritmoCardiaco[f, c] = int.Parse(linea);
                }
                Console.WriteLine("Siguiente dia");
            }
        }

        public string ReturnarNombre()
        {
            return Nombre;
        }

        public int ReturnarMat(int f, int c)
        {
            return ritmoCardiaco[f, c];
        }
    }

    internal class SalaMonitoreo
    {
        private Paciente[] pacientes;

        public SalaMonitoreo()
        {

            pacientes = new Paciente[3];

            for (int f = 0; f < 3; f++)
            {
                pacientes[f] = new Paciente();
            }

        }

        public void ImpresionTodo()
        {
            Console.WriteLine("Granilla de pulsasiones de los pacientes");
            for (int g = 0; g < 3; g++)
            {
                Console.WriteLine("Pulsasiones del paciente : " + pacientes[g].ReturnarNombre());
                for (int f = 0; f < 3; f++)
                {
                    Console.WriteLine("Pulsasiones del dia numero : " + (f+1));
                    for (int c = 0; c < 4; c++)
                    {
                        string[] dias = { "mañana", "mediodia", "tarde", "noche" };
                        Console.Write("Momento : " + dias[c] + "  " + pacientes[g].ReturnarMat(f, c) + " || ");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
        }

        public void ImprimirPromedio()
        {
            Console.WriteLine();
            int total = 0;
            float promedio;
            for (int g = 0; g < 3; g++)
            {
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        total = total + pacientes[g].ReturnarMat(f, c);
                    }
                }
                promedio = (total / 12);
                Console.WriteLine("El promedio de las pulsaciones del paciente : " + pacientes[g].ReturnarNombre() + " Es de : " + promedio);
                promedio = 0;
                total = 0;
            }
        }

        public void VerificacionMortal()
        {
            string paciente = null;
            for (int g = 0; g < 3; g++)
            {
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        if (pacientes[g].ReturnarMat(f, c) > 120)
                        {
                            paciente = pacientes[g].ReturnarNombre();
                        }
                    }
                }
                if (paciente != null)
                {
                    Console.WriteLine("");
                    Console.WriteLine("ALERTA El paciente : " + paciente + " tiene una de sus pulsasiones por mayor a 120, necesita revision");
                }
                paciente = null;
            }
        }
        static void Main(string[] args)
        {
            SalaMonitoreo sm = new SalaMonitoreo();

            sm.ImpresionTodo();
            sm.ImprimirPromedio();
            sm.VerificacionMortal();
            Console.ReadKey();
        }
    }
}
