using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    /*
     2. Catálogo de Películas (Encapsulación, Validación y Composición)
        Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
        La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
        (un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
        asegurando mediante validaciones lógicas que:
         La duración en minutos sea estrictamente mayor a cero (0).
         La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
        un valor por defecto de 1).
        La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
        la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
        películas ordenadas de mayor a menor en base a su duración. Además, el método debe
        informar el título de la película con mejor calificación y cuál es la película más corta del
        catálogo.
     */
    public class Pelicula
    {
        private string titulo;
        private int duracionminutos;
        private int calificacion;

        public string Titulo
        {
            set { titulo = value; }
            get { return titulo; }
        }

        public int DuracionMinutos
        {
            set { duracionminutos = value;}
            get { return duracionminutos; }
        }

        public int Calificacion
        {
            set
            {
                calificacion = value;
            }
            get { return calificacion; }
        }

        public void Verificador()
        {
            if (DuracionMinutos < 0)
            {
                Console.WriteLine("La pelicula llamada " + Titulo + " Tiene que tener asignada una duracion mayor a 0");
            }

            if (Calificacion <= 0 || Calificacion > 5)
            {
                Calificacion = 1;
                Console.WriteLine("ALERTA ==== Calificacion asignada se salio del limite, restablecido a 1");
            }
        }
    }
    internal class Catalogo
    {
        private Pelicula[] peliculas;

        public void Seteo()
        {
            peliculas = new Pelicula[3];
            for (int i = 0; i < peliculas.Length; i++)
            {
                peliculas[i] = new Pelicula();
                Console.WriteLine("Pelicula numero : " + (i+1));
                Console.WriteLine("");
                Console.WriteLine("Ingresa el titulo de la pelicula");
                peliculas[i].Titulo = Console.ReadLine();
                Console.WriteLine("Ingresa la duracion en minutos de la pelicula");
                peliculas[i].DuracionMinutos = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la calificacion (1-5) de la pelicula");
                peliculas[i].Calificacion = int.Parse(Console.ReadLine());
                peliculas[i].Verificador();
            }
        }

        public void MostrarPeliculasMayoraMenorYAdiciones()
        {

            int menordur = peliculas[0].DuracionMinutos;
            int mejorcal = peliculas[0].Calificacion;
            string nom1 = peliculas[0].Titulo;
            string nom2 = peliculas[0].Titulo;
            for (int i = 0; i < peliculas.Length; i++)
            {
                if (peliculas[i].DuracionMinutos < menordur)
                {
                    menordur = peliculas[i].DuracionMinutos;
                    nom1 = peliculas[i].Titulo;
                }

                if (peliculas[i].Calificacion > mejorcal)
                {
                    mejorcal = peliculas[i].Calificacion;
                    nom2 = peliculas[i].Titulo;
                }
                for (int j = 0; j < peliculas.Length - 1; j++)
                {
                    if (peliculas[i].DuracionMinutos > peliculas[j].DuracionMinutos)
                    {
                        var aux = peliculas[i];
                        peliculas[i] = peliculas[j];
                        peliculas[j] = aux;
                    }
                }
            }

            Console.WriteLine("La peliculas ordenardas segun su duracion(Mayor a menor) : ");
            for (int i = 0;i < peliculas.Length; i++)
            {
                Console.Write(peliculas[i].Titulo);
                Console.Write(" - ");
                Console.Write(peliculas[i].DuracionMinutos);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("La pelicula con menor duracion es : " + nom1 + " con una duracion de : " + menordur);
            Console.WriteLine("La pelicula con mejor calificacion es : " + nom2 + " con una calificacion de : " + mejorcal);
        }

        static void Main(string[] args)
        {
            Catalogo c = new Catalogo();

            c.Seteo();
            c.MostrarPeliculasMayoraMenorYAdiciones();
            Console.ReadKey();
        }
    }
}
