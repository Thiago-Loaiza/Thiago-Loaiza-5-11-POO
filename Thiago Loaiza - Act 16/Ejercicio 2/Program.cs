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
        private string nombre;
        private int precio;
        private int stock;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int Precio
        {
            set { precio = value; }
            get { return precio; }
        }
        public int Stock
        {
            set { stock = value; }
            get { return stock; }
        }
        public void VerificacionStock()
        {
            if (Stock < 0)
            {
                Console.WriteLine("El stock del producto " + Nombre + " no debe ser menor a 0 o negativo");
                return;
            }
        }
    }
    internal class Inventario
    {
        Producto produc1 = new Producto();
        Producto produc2 = new Producto();
        Producto produc3 = new Producto();
        public void Seteo()
        {
            Console.WriteLine("PRODUCTO 1");

            Console.Write("Nombre: ");
            produc1.Nombre = Console.ReadLine();

            Console.Write("Precio: ");
            produc1.Precio = int.Parse(Console.ReadLine());

            Console.Write("Stock: ");
            produc1.Stock = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("PRODUCTO 2");

            Console.Write("Nombre: ");
            produc2.Nombre = Console.ReadLine();

            Console.Write("Precio: ");
            produc2.Precio = int.Parse(Console.ReadLine());

            Console.Write("Stock: ");
            produc2.Stock = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("PRODUCTO 3");

            Console.Write("Nombre: ");
            produc3.Nombre = Console.ReadLine();

            Console.Write("Precio: ");
            produc3.Precio = int.Parse(Console.ReadLine());

            Console.Write("Stock: ");
            produc3.Stock = int.Parse(Console.ReadLine());

            produc1.VerificacionStock();
            produc2.VerificacionStock();
            produc3.VerificacionStock();
        }

        public void DeMenorAMayor_Y_ElMasCaroYMasBarato()
        {
            Producto[] productos = { produc1, produc2, produc3 };
            int mayor = productos[0].Precio;
            int menor = productos[0].Precio;
            string nom1 = productos[0].Nombre;
            string nom2 = productos[0].Nombre;
            var aux = productos[0];

            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i].Precio > mayor)
                {
                    mayor = productos[i].Precio;
                    nom1 = productos[i].Nombre;
                }
                if (productos[i].Precio < menor)
                {
                    menor = productos[i].Precio;
                    nom2 = productos[i].Nombre;
                }

                for (int j = 0; j < productos.Length - 1; j++)
                {
                    if (productos[i].Precio < productos[j].Precio)
                    {
                        aux = productos[i];
                        productos[i] = productos[j];
                        productos[j] = aux;
                    }
                }
            }

            Console.WriteLine("Productos de menor a mayor(base precio)");
            Console.WriteLine("");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(productos[i].Nombre + " - ");
            }
            Console.WriteLine();
            Console.WriteLine("El producto mas caro de todo el inventario es : " + nom1 + " con una cantidad de $" + mayor);
            Console.WriteLine("El producto mas barata de todo el inventario es : " + nom2 + " con una cantidad de $" + menor);
        }


        static void Main(string[] args)
        {
            Inventario i = new Inventario();

            i.Seteo();
            i.DeMenorAMayor_Y_ElMasCaroYMasBarato();
            Console.ReadKey();
        }
    }
}