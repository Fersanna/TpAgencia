using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp39
{
    internal class Cancelacion : Operacion
    {
        public Cancelacion(string fecha, string especie, int cantidadOperada, double precio) : base(fecha, especie, cantidadOperada, precio)
        {
        }

        public override double GetSubtotal()
        {
            return 0;
        }

        public override int signo()
        {
            return 0;
        }
    }
}
