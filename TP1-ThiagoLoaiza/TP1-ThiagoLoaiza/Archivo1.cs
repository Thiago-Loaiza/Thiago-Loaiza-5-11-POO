using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP1_ThiagoLoaiza
{
    partial class Configuracion
    {
        private int cantidadfilas;
        private int cantidadcolumnas;
        private int velocidadcopos;

        public int CantidadFilas
        {
            set { cantidadfilas = value; }
            get { return cantidadfilas; }
        }

        public int CantidadColumnas
        {
            set { cantidadcolumnas = value; }
            get{ return cantidadcolumnas; }
        }

        public int VelocidadCopos
        {
            set { velocidadcopos = value; }
            get { return velocidadcopos; }
        }

        public Configuracion()
        {
            cantidadfilas = 30;
            cantidadcolumnas = 7;
            velocidadcopos = 1;
            Console.WriteLine("Costructor Configuracion - Datos por defecto");
            Thread.Sleep(1000);
            Console.Clear();
        }

        public Configuracion(int cantidadfilas, int cantidadcolumnas, int velocidadcopos)
        {
            this.cantidadfilas = cantidadfilas;
            this.cantidadcolumnas = cantidadcolumnas;
            this.velocidadcopos = velocidadcopos;
        }

        public int ReturnarColumnas()
        {
            return cantidadcolumnas;
        }
        public int ReturnarFilas()
        {
            return cantidadfilas;
        }
    }
}
