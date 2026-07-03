using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    partial class ElementoPantalla
    {
        private string nombre;
        private int posX;
        private int posY;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public ElementoPantalla()
        {
            nombre = "Sin nombre";
            posX = 0;
            posY = 0;
        }

        public ElementoPantalla(string nombre, int posX, int posY)
        {
            this.nombre = nombre;
            this.posX = posX;
            this.posY = posY;
        }

        public void Mostrar()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(PosX, PosY);
            Console.Write(Nombre);
        }
    }
}
