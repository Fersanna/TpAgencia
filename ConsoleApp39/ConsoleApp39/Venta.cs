using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp39
{
    internal class Venta : Operacion
    {
        private double precio;

        public Venta(string fecha, string especie, int cantidadOperada, double precio) : base(fecha, especie, cantidadOperada, precio)
        {
            this.precio = precio;
        }

        public override double GetSubtotal()
        {
            {
                return precio * GetCantidadOperada();
            }
        }

        public override int signo()
        {
            return 1;
        }

        internal int GetPrecio()
        {
            throw new NotImplementedException();
        }
    }
}
