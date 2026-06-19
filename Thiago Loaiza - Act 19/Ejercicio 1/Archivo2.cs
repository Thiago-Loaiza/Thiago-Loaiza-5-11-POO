using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    partial class ReservaHotel
    {
        public int TotalPagar()
        {
            int total = 0;
            if (TipoHabitacion == "Simple")
            {
                total = CantidadNoches * 5000;

            }
            if (TipoHabitacion == "Double")
            {
                total = CantidadNoches * 8000;

            }
            if (TipoHabitacion == "Suite")
            {
                total = CantidadNoches * 12000;
            }
            return total;
        }
    }
}
