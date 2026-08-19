using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    /*
     9-
    Un instituto de enseñanza registra de forma dinámica a sus estudiantes para
    realizar el seguimiento académico de sus materias.
         Crear la clase Estudiante que contenga como atributos privados:
        nombreCompleto (string) y calificacion (double). Definir sus propiedades
        de solo lectura y un constructor que reciba nom y cal.
         Crear la clase GestionAcademica que administre una lista de objetos
        List.
         Métodos en GestionAcademica:
            o CargarEstudiantes(): Solicitar por teclado nombres y
            calificaciones para agregar estudiantes a la lista mediante .Add(). La
            carga finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como
            nombre.
            o ListarEstudiantes(): Mostrar en pantalla todos los alumnos
            junto a la cantidad total de inscriptos mediante la propiedad .Count.
            o FiltrarAprobados(): Recorrer la lista e imprimir en consola
            únicamente aquellos estudiantes cuya calificación sea mayor o igual
            a 6.0.
            o DarDeBaja(): Pedir al operador el nombre de un estudiante y,
            utilizando los métodos de búsqueda y remoción de listas, eliminarlo
            de la colección si se encuentra presente.
     */
    internal class GestionAcademica
    {
        List<Estudiante> ListaEstudiantes = new List<Estudiante>();

        public void CargarEstudiantes()
        {
            string nombre;
            double calificacion;

            Console.WriteLine("Ingrese el nombre del estudiante o escriba FIN para terminar: ");
            nombre = Console.ReadLine();

            while (nombre != "FIN")
            {
                Console.WriteLine("Ingrese la calificacion: ");
                calificacion = double.Parse(Console.ReadLine());

                Estudiante estudiante = new Estudiante(nombre, calificacion);

                ListaEstudiantes.Add(estudiante);

                Console.WriteLine("Ingrese el nombre del estudiante o escriba FIN para terminar: ");
                nombre = Console.ReadLine();
            }
        }

        public void ListarEstudiantes()
        {
            Console.WriteLine(" - Lista de estudiantes -");

            foreach (var E in ListaEstudiantes)
            {
                Console.WriteLine("Nombre: " + E.NombreCompleto +
                                  " Calificacion: " + E.Calificacion);
            }

            Console.WriteLine("Cantidad total de inscriptos: " +
                              ListaEstudiantes.Count);
        }

        public void FiltrarAprobados()
        {
            Console.WriteLine(" - Estudiantes aprobados -");

            foreach (var E in ListaEstudiantes)
            {
                if (E.Calificacion >= 6.0)
                {
                    Console.WriteLine("Nombre: " + E.NombreCompleto +
                                      " Calificacion: " + E.Calificacion);
                }
            }
        }

        public void DarDeBaja()
        {
            string nombre;

            Console.WriteLine("Ingrese el nombre del estudiante a dar de baja: ");
            nombre = Console.ReadLine();

            for (int i = 0; i < ListaEstudiantes.Count; i++)
            {
                if (nombre == ListaEstudiantes[i].NombreCompleto)
                {
                    Estudiante estudiante = ListaEstudiantes[i];

                    ListaEstudiantes.Remove(estudiante);

                    Console.WriteLine("Se ha dado de baja al estudiante: " + nombre);

                    return;
                }
            }

            Console.WriteLine("No se encontro al estudiante.");
        }


        static void Main(string[] args)
        {
            GestionAcademica gestion = new GestionAcademica();

            gestion.CargarEstudiantes();

            gestion.ListarEstudiantes();

            gestion.FiltrarAprobados();

            gestion.DarDeBaja();

            gestion.ListarEstudiantes();

            Console.ReadKey();
        }
    }
}