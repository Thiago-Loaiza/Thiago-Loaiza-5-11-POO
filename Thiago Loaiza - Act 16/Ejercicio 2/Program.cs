using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    /*
        2. Plantear una clase Producto y otra clase Inventario.
        La clase Producto debe tener como atributos privados el nombre, precio y
        stock. Definir propiedades para acceder a estos atributos, asegurando que el
        stock no pueda ser negativo y el precio sea mayor a cero.
        La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
        método para mostrar todos los productos ordenados de menor a mayor en
        base al precio, además, mostrar el producto más caro y más barato del
        inventario.
     */
    public class Producto
    {
        protected string nombre;
        protected int precio;
        protected int stock;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                    precio = value;
            }
        }

        public int Stock
        {
            get { return stock; }
            set
            {
                if (value >= 0)
                    stock = value;
            }
        }

        public Producto(string nombre, int precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }
    }

    public class Inventario : Producto
    {
        private Producto produc1;
        private Producto produc2;
        private Producto produc3;

        public Inventario(string nombre, int precio, int stock)
            : base(nombre, precio, stock)
        {
            produc1 = new Producto("Queso", 6000, 22);
            produc2 = new Producto("Mani", 2000, 600);
            produc3 = new Producto("Banana", 4000, 500);
        }

        public void DeMenorAMayor_Y_ElMasCaroYMasBarato()
        {
            Producto[] productos = { produc1, produc2, produc3 };

            int mayor = productos[0].Precio;
            int menor = productos[0].Precio;

            string nomMayor = productos[0].Nombre;
            string nomMenor = productos[0].Nombre;

            Producto aux;

            for (int i = 0; i < productos.Length - 1; i++)
            {
                for (int j = i + 1; j < productos.Length; j++)
                {
                    if (productos[i].Precio > productos[j].Precio)
                    {
                        aux = productos[i];
                        productos[i] = productos[j];
                        productos[j] = aux;
                    }
                }
            }

            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i].Precio > mayor)
                {
                    mayor = productos[i].Precio;
                    nomMayor = productos[i].Nombre;
                }

                if (productos[i].Precio < menor)
                {
                    menor = productos[i].Precio;
                    nomMenor = productos[i].Nombre;
                }
            }

            Console.WriteLine("Productos ordenados de menor a mayor:");

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine(productos[i].Nombre + " - $" + productos[i].Precio);
            }

            Console.WriteLine();
            Console.WriteLine("Producto mas caro: " + nomMayor + " - $" + mayor);
            Console.WriteLine("Producto mas barato: " + nomMenor + " - $" + menor);
        }

        static void Main(string[] args)
        {
            Inventario i = new Inventario("Inventario", 1, 0);

            i.DeMenorAMayor_Y_ElMasCaroYMasBarato();

            Console.ReadKey();
        }
    }
}