using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /*
    3. Competencia de Atletismo
        Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.

        Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
        Definir los siguientes métodos en la clase Carrera:

        Un constructor que cargue los datos de los 3 atletas de la carrera.
            Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
            Un método que calcule e imprima el tiempo promedio de la carrera.
            Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
            Un método que muestre a los atletas que superaron el promedio.

    */

    internal class Atleta
    {
        private string nombre;
        private float tiempoSegundos;

        public Atleta()
        {
            Console.WriteLine("Ingrese el nombre del atleta");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el tiempo en segundos");
            tiempoSegundos = float.Parse(Console.ReadLine());
        }

        public string RetornarNombre()
        {
            return nombre;
        }

        public float RetornarTiempo()
        {
            return tiempoSegundos;
        }
    }

    internal class Carrera
    {
        private Atleta[] atletas;

        public Carrera()
        {
            atletas = new Atleta[3];

            for (int i = 0; i < atletas.Length; i++)
            {
                atletas[i] = new Atleta();
            }
        }

        public void MostrarAtletas()
        {
            for (int i = 0; i < atletas.Length; i++)
            {
                Console.WriteLine(" --- ");
                Console.WriteLine("Atleta: " + atletas[i].RetornarNombre());
                Console.WriteLine("Tiempo: " + atletas[i].RetornarTiempo());
            }
        }

        public void TiempoPromedio()
        {
            float suma = 0;

            for (int i = 0; i < atletas.Length; i++)
            {
                suma = suma + atletas[i].RetornarTiempo();
            }

            float promedio = suma / atletas.Length;

            Console.WriteLine("El tiempo promedio es: " + promedio);
        }

        public void Ganador()
        {
            float menor = atletas[0].RetornarTiempo();
            string nombre = atletas[0].RetornarNombre();

            for (int i = 1; i < atletas.Length; i++)
            {
                if (atletas[i].RetornarTiempo() < menor)
                {
                    menor = atletas[i].RetornarTiempo();
                    nombre = atletas[i].RetornarNombre();
                }
            }

            Console.WriteLine("El ganador es: " + nombre);
        }

        public void SuperaronPromedio()
        {
            float suma = 0;

            for (int i = 0; i < atletas.Length; i++)
            {
                suma = suma + atletas[i].RetornarTiempo();
            }

            float promedio = suma / atletas.Length;

            Console.WriteLine("Atletas que superaron el promedio:");

            for (int i = 0; i < atletas.Length; i++)
            {
                if (atletas[i].RetornarTiempo() > promedio)
                {
                    Console.WriteLine(atletas[i].RetornarNombre());
                }
            }
        }

        static void Main(string[] args)
        {
            Carrera c = new Carrera();

            c.MostrarAtletas();
            c.TiempoPromedio();
            c.Ganador();
            c.SuperaronPromedio();

            Console.ReadKey();
        }
    }
}
