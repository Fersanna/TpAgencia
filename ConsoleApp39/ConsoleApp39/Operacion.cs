using System;

namespace ConsoleApp39
{
    abstract class Operacion
    {

        private string fecha;
        private string especie;
        private int cantidadOperada;
        private double precio;

        protected Operacion(string fecha, string especie, int cantidadOperada, double precio)
        {
            this.fecha = fecha;
            this.especie = especie;
            this.cantidadOperada = cantidadOperada;
        }

        public int GetCantidadOperada()
        {
            return cantidadOperada;
        }

        internal double GetPrecioOperado()
        {
            return precio;
        }

       abstract public double GetSubtotal();

        abstract public int signo();
      

    }
}