using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    partial class Instituto
    {
        protected string nombrezona;
        protected int totalvisitas;

        public string NombreZona
        {
            get { return nombrezona; }
            set { nombrezona = value; }
        }

        public int TotalVisitas
        {
            get { return totalvisitas; }
            set { totalvisitas = value; }
        }

        public Instituto(string nom, int total)
        {
            nombrezona = nom;
            totalvisitas = total;
        }
    }
}