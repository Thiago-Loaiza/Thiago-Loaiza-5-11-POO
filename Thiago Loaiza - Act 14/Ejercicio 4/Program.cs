using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    /*
     4. Inventario de Sucursales 
            Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual. El constructor de la clase debe cargar estos atributos por teclado.
            Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo. El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
            Implementar en la clase Sucursal los siguientes métodos:
                Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).
                Un método que busque y muestre el nombre del artículo más caro del local.
                Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).

     */
    internal class Articulo
    {
        private string NombreArticulo;
        private int Precio;
        private int StockActual;

        public Articulo()
        {
            Console.WriteLine("Ingrese los datos del articulo");
            Console.WriteLine(" --- ");
            Console.WriteLine("Ingrese el nombre del articulo");
            NombreArticulo = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del articulo");
            string linea = Console.ReadLine();
            Precio = int.Parse(linea);
            Console.WriteLine("Ingrese el stock actual del articulo");
            linea = Console.ReadLine();
            StockActual = int.Parse(linea);
        }
        public string ReturnarNombre()
        {
            return NombreArticulo;
        }
        public int ReturnarPrecio()
        {
            return Precio;
        }
        public int ReturnarStockActual()
        {
            return StockActual;
        }
    }

    internal class Sucursal
    {
        private string NombreSucursal;
        private Articulo[] articulos;
        public Sucursal() {
            Console.WriteLine("Ingrese el nombre de la sucursal");
            NombreSucursal = Console.ReadLine();

            articulos = new Articulo[3];

            for (int i = 0; i < articulos.Length; i++)
            {
                articulos[i] = new Articulo();
            }
        }

        public void ListaInventario()
        {
            int totalArt = 0;
            for (int i = 0; i < articulos.Length; i++)
            {
                totalArt = totalArt + (articulos[i].ReturnarPrecio() * articulos[i].ReturnarStockActual());
                Console.WriteLine("El articulo : " + articulos[i].ReturnarNombre() + " tiene un valor de inventario total de : " + totalArt);
                totalArt = 0;
            }
        }

        public void ArticuloMasCaro()
        {
            int mayor = articulos[0].ReturnarPrecio();
            string art = articulos[0].ReturnarNombre();
            for (int i = 0; i < articulos.Length; i++)
            {
                if (articulos[i].ReturnarPrecio() > mayor)
                {
                    mayor = articulos[i].ReturnarPrecio();
                    art = articulos[i].ReturnarNombre();
                }
            }
            Console.WriteLine("El articulo mas caro del local es : " + art + "con un precio de : " + mayor);
        }

        public void ReposicionUrgente()
        {
            for (int i = 0; i < articulos.Length; i++)
            {
                if (articulos[i].ReturnarStockActual() <= 5)
                {
                    Console.WriteLine("ALERTA el articulo : " + articulos[i].ReturnarNombre() + " necesita reposicion urgente");
                }
            }
        }

        static void Main(string[] args)
        {
            Sucursal s = new Sucursal();

            s.ListaInventario();
            s.ArticuloMasCaro();
            s.ReposicionUrgente();
            Console.ReadKey();
        }
    }
}
