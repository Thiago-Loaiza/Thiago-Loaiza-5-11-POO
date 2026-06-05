using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /*
       3. Crear una clase base Vehículo que contenga atributos marca y
        velocidadMaxima.
        Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
        una debe tener un constructor que reciba los valores de los atributos base
        mediante la palabra clave base, y un atributo propio (cantidadPuertas en
        Auto, cilindrada en Moto).
        Crear un objeto de cada clase y mostrar todos sus datos por consola.
     */
    public class Vehiculo
    {
        protected string marca;
        protected int velocidadMaxima;
        protected string[] Base;
        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }

        public int VelocidadMaxima
        {
            set { velocidadMaxima = value; }
            get { return velocidadMaxima; }
        }
    }

    public class Auto : Vehiculo
    {
        private int cantidadPuertas;
        public int CantidadPuertas
        {
            set { cantidadPuertas = value; }
            get { return cantidadPuertas; }
        }
        public Auto()
        {
            Base = new string[2];
            Base[0] = "45RE51";
            Base[1] = "1000";
        }
    }

    public class Moto : Vehiculo
    {
        private int cilindrada;

        public int Cilindrada
        {
            set { cilindrada = value; }
            get { return cilindrada; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
