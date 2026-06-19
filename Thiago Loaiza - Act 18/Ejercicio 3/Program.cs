using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
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