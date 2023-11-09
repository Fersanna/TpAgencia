namespace ConsoleApp34
{
    class Venta : Operacion
    {
        private double precio;

        protected Venta(string fecha, string especie, int cantidadOperada, double precio) : base (fecha, especie, cantidadOperada)
        {
            this.precio = precio;
        }

        public double getPrecio()
        { return precio; 
        }
    }
}