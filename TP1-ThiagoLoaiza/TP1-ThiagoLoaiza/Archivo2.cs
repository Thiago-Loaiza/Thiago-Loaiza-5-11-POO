using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP1_ThiagoLoaiza
{
    //new Random().Next();
    partial class CopoDeNieve : Configuracion
    {
        public string Modelo = "*";
        public int posicionX;
        public int posicionY;
        public int limite;
        public void Spawneo()
        {
            limite = CantidadFilas;
            int posicionXAnterior = 0;
            int RetrasoSpawn = 1000;
            bool PosicionOcupada = true;
            while (true)
            {
                Thread.Sleep(RetrasoSpawn / VelocidadCopos);
                posicionX = new Random().Next(0, CantidadColumnas);
                posicionY = new Random().Next(0, CantidadFilas);

                while (PosicionOcupada)
                {
                    if (posicionX == posicionXAnterior)
                    {
                        posicionX = new Random().Next(0, CantidadColumnas);
                    }
                    else
                    {
                        Console.SetCursorPosition(posicionX, 0);
                        Console.Write(Modelo);
                        PosicionOcupada = false;
                    }
                    posicionXAnterior = posicionX;
                }
                PosicionOcupada = true;
            }
        }
        public void Caida()
        {
        }
    }
}
