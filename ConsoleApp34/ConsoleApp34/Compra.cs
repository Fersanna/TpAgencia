using System;

namespace ConsoleApp34
{
    class Compra : Operacion
    {
        private double precio;

        public Compra(string fecha, string especie, int cantidadOperada, double precio) : base(fecha, especie, cantidadOperada)
        {
            this.precio = precio;
        }

        internal double GetPrecio()
        {
           return precio;
        }
    }
}