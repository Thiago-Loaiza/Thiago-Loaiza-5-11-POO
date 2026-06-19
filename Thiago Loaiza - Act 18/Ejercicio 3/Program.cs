using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    /*
    Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
    AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
    realice su asignación.
    Luego, definir dos clases derivadas de la clase base:
        ● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
        soportada en atmósferas).
        ● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
    Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
    tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
    clase SondaExploradora mediante el uso explícito de la palabra clave base.
    En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
    parámetros unificados por consola.
    */

    class SondaExploradora
    {
        protected string modelo;
        protected int autonomiaminutos;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Autonomiaminutos
        {
            get { return autonomiaminutos; }
            set { autonomiaminutos = value; }
        }

        public SondaExploradora(string modelo, int autonomiaminutos)
        {
            Modelo = modelo;
            Autonomiaminutos = autonomiaminutos;
        }
    }

    class SondaSubmarina : SondaExploradora
    {
        private int presionmaxima;

        public int PresionMaxima
        {
            get { return presionmaxima; }
            set { presionmaxima = value; }
        }

        public SondaSubmarina(string modelo,
                              int autonomiaminutos,
                              int presionmaxima)
            : base(modelo, autonomiaminutos)
        {
            PresionMaxima = presionmaxima;
        }

        public void Mostrar()
        {
            Console.WriteLine("=== SONDA SUBMARINA ===");
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Autonomia: " + Autonomiaminutos);
            Console.WriteLine("Presion maxima: " + PresionMaxima);
        }
    }

    class RoverTerrestre : SondaExploradora
    {
        private int cantidadruedas;

        public int CantidadRuedas
        {
            get { return cantidadruedas; }
            set { cantidadruedas = value; }
        }

        public RoverTerrestre(string modelo,
                              int autonomiaminutos,
                              int cantidadruedas)
            : base(modelo, autonomiaminutos)
        {
            CantidadRuedas = cantidadruedas;
        }

        public void Mostrar()
        {
            Console.WriteLine("=== ROVER TERRESTRE ===");
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Autonomia: " + Autonomiaminutos);
            Console.WriteLine("Cantidad de ruedas: " + CantidadRuedas);
        }
    }

    class Testeo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SONDA SUBMARINA");

            Console.Write("Modelo: ");
            string modeloSub = Console.ReadLine();

            Console.Write("Autonomia: ");
            int autSub = int.Parse(Console.ReadLine());

            Console.Write("Presion maxima: ");
            int presion = int.Parse(Console.ReadLine());

            SondaSubmarina s1 =
                new SondaSubmarina(modeloSub, autSub, presion);

            Console.WriteLine();

            Console.WriteLine("ROVER TERRESTRE");

            Console.Write("Modelo: ");
            string modeloRover = Console.ReadLine();

            Console.Write("Autonomia: ");
            int autRover = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de ruedas: ");
            int ruedas = int.Parse(Console.ReadLine());

            RoverTerrestre r1 =
                new RoverTerrestre(modeloRover, autRover, ruedas);

            Console.WriteLine();
            s1.Mostrar();

            Console.WriteLine();

            r1.Mostrar();

            Console.ReadKey();
        }
    }
}