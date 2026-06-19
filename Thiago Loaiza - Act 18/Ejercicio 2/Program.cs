using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
        /*
    Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
    La clase CriaturaMarina debe tener como atributos privados: Especie (string),
    ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
    propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:

        ● La profundidad óptima sea estrictamente mayor a cero (0).
        ● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
        asignar un valor por defecto de 35, que representa la salinidad promedio del océano).

    La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
    de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
    criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
    a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
    nivel de salinidad para sobrevivir.
     */

    class CriaturaMarina
    {
        private string especie;
        private int profundidadoptima;
        private int nivelsalinidad;

        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public int ProfundidadOptima
        {
            get { return profundidadoptima; }
            set { profundidadoptima = value; }
        }

        public int NivelSalinidad
        {
            get { return nivelsalinidad; }
            set { nivelsalinidad = value; }
        }

        public void VerificadorValores()
        {
            while (ProfundidadOptima <= 0)
            {
                Console.WriteLine("La profundidad debe ser mayor a 0.");
                Console.WriteLine("Ingrese nuevamente la profundidad:");
                ProfundidadOptima = int.Parse(Console.ReadLine());
            }

            if (NivelSalinidad < 1 || NivelSalinidad > 100)
            {
                Console.WriteLine("Nivel de salinidad fuera de rango. Se asignó 35.");
                NivelSalinidad = 35;
            }
        }
    }

    class HabitatAcuatico
    {
        private CriaturaMarina[] criaturas;

        public void Carga()
        {
            criaturas = new CriaturaMarina[3];

            for (int i = 0; i < criaturas.Length; i++)
            {
                criaturas[i] = new CriaturaMarina();

                Console.WriteLine("CRIATURA " + (i + 1));

                Console.Write("Especie: ");
                criaturas[i].Especie = Console.ReadLine();

                Console.Write("Profundidad óptima: ");
                criaturas[i].ProfundidadOptima = int.Parse(Console.ReadLine());

                Console.Write("Nivel de salinidad: ");
                criaturas[i].NivelSalinidad = int.Parse(Console.ReadLine());

                criaturas[i].VerificadorValores();

                Console.WriteLine();
            }
        }

        public void OrdenamientoYImpresion()
        {
            int mayorsal = criaturas[0].NivelSalinidad;
            string nom1 = criaturas[0].Especie;

            for (int i = 0; i < criaturas.Length; i++)
            {
                if (criaturas[i].NivelSalinidad > mayorsal)
                {
                    mayorsal = criaturas[i].NivelSalinidad;
                    nom1 = criaturas[i].Especie;
                }
            }

            for (int i = 0; i < criaturas.Length - 1; i++)
            {
                for (int j = 0; j < criaturas.Length - 1 - i; j++)
                {
                    if (criaturas[j].ProfundidadOptima > criaturas[j + 1].ProfundidadOptima)
                    {
                        var aux = criaturas[j];
                        criaturas[j] = criaturas[j + 1];
                        criaturas[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("CRIATURAS ORDENADAS POR PROFUNDIDAD");

            for (int i = 0; i < criaturas.Length; i++)
            {
                Console.WriteLine(
                    criaturas[i].Especie +
                    " - Profundidad: " +
                    criaturas[i].ProfundidadOptima +
                    " m"
                );
            }

            Console.WriteLine();
            Console.WriteLine("Mayor nivel de salinidad:");
            Console.WriteLine(nom1 + " - " + mayorsal);
        }

        static void Main(string[] args)
        {
            HabitatAcuatico ha = new HabitatAcuatico();

            ha.Carga();
            ha.OrdenamientoYImpresion();

            Console.ReadKey();
        }
    }
}