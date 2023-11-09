using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp39
{
    class Compra : Operacion
    {

        private double precio;

        public Compra(string fecha, string especie, int cantidadOperada, double precio) : base(fecha, especie, cantidadOperada, precio)
        {
            this.precio = precio;
        }

        public override double GetSubtotal()
        {
            return precio * GetCantidadOperada()*-1;
        }

        public override int signo()
        {
            return -1;
        }
    }
}