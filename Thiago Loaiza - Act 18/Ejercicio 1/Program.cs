using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /*
    1.
    Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
    CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
    generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
    generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
    imprimir estos datos básicos.
    Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
    un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
    en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).

    Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
    En el programa principal (Main):

        ● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
        ● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
        puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
        muestra de información.
     */
    class DispositivoEnergia
    {
        protected string codigoIdentificador;
        protected double generacionKwh;

        public string CodigoIdentificador
        {
            set { codigoIdentificador = value; }
            get { return codigoIdentificador; }
        }

        public double GeneracionKwh
        {
            set { generacionKwh = value; }
            get { return generacionKwh; }
        }

        public void VerificadorGen()
        {
            if (GeneracionKwh < 0)
            {
                Console.WriteLine("Se ingreso una generacion en Kwh negativo, restablecido su valor a 0");
                GeneracionKwh = 0;
            }
        }

        public void Impresion()
        {
            Console.WriteLine("=== DATOS DEL DISPOSITIVO ===");
            Console.WriteLine("El codigo identificador del dispositivo es: " + codigoIdentificador);
            Console.WriteLine("La generacion en Kwh es: " + generacionKwh);
        }
    }
    class PanelSolar : DispositivoEnergia
    {
        private double areametros;

        public double AreaMetros
        {
            set { areametros = value; }
            get { return areametros; }
        }

        public void VerificadorMet()
        {
            if (AreaMetros < 0)
            {
                Console.WriteLine("Se ingreso una area en metros negativo, restablecido su valor a 0");
                AreaMetros = 0;
            }
        }

        public void ImpresionTodo()
        {
            Console.WriteLine("=== DATOS DEL PANEL SOLAR ===");
            Console.WriteLine("La area en metros del panel solar es: " + AreaMetros); ;
            Console.WriteLine("El codigo identificador del dispositivo es: " + codigoIdentificador);
            Console.WriteLine("La generacion en Kwh es: " + generacionKwh);
        }

        static void Main(string[] args)
        {
            DispositivoEnergia dispositivo1 = new DispositivoEnergia();
            Console.WriteLine("Ingrese el codigo del dispositivo");
            dispositivo1.CodigoIdentificador = Console.ReadLine();
            Console.WriteLine("Ingrese su Generacion Kwh del disposito");
            dispositivo1.GeneracionKwh = double.Parse(Console.ReadLine());
            dispositivo1.VerificadorGen();
            dispositivo1.Impresion();

            Console.WriteLine("");
            PanelSolar solar = new PanelSolar();
            Console.WriteLine("Ingrese el codigo del panel solar");
            solar.CodigoIdentificador = Console.ReadLine();
            Console.WriteLine("Ingrese la generacion en Kwh del panel");
            solar.GeneracionKwh = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la area en metros de panel solar");
            solar.AreaMetros = double.Parse(Console.ReadLine());
            solar.VerificadorGen();
            solar.VerificadorMet();
            solar.ImpresionTodo();
            Console.ReadKey();
        }
    }
}
