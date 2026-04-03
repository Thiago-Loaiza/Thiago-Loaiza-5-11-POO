using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /*
     1. Desarrollar una clase que represente un punto en el plano y tenga los
        siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
        encuentra dicho punto (concepto matemático, primer cuadrante si x e y son
        positivas, si x&lt;0 e y&gt;0 segundo cuadrante, etc.)
     */
    internal class UbicadorPunto
    {
        private int X, Y;
        private string cuadrante = "";
        public void CargarXyY()
        {
            string linea;
            Console.WriteLine("Cargar los valores X y Y");
            Console.WriteLine("Ingresa X");
            linea = Console.ReadLine();
            X = int.Parse(linea);
            Console.WriteLine("Ingresa Y");
            linea = Console.ReadLine();
            Y = int.Parse(linea);
        }

        public void EncontrarCuadrante()
        {

            if (X > 0 && Y > 0)
            {
                cuadrante = "Primer Cuadrante";
            }

            if (X < 0 && Y > 0)
            {
                cuadrante = "Segundo Cuadrante";
            }

            if (X < 0 && Y < 0)
            {
                cuadrante = "Tercer Cuadrante";
            }

            if (X > 0 && Y < 0)
            {
                cuadrante = "Cuarto Cuadrante";
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("X : " + X);
            Console.WriteLine("Y : " + Y);
            Console.WriteLine("El punto esta en el " + cuadrante);
        }

        static void Main(string[] args)
        {
            UbicadorPunto UP = new UbicadorPunto();
            UP.CargarXyY();
            UP.EncontrarCuadrante();
            UP.Imprimir();
            Console.ReadKey();
        }
    }
}
