namespace ConsoleApp34
{
    abstract class Operacion
    {

        private string fecha;
        private string especie;
        private int cantidadOperada;

        protected Operacion(string fecha, string especie, int cantidadOperada)
        {
            this.fecha = fecha;
            this.especie = especie;
            this.cantidadOperada = cantidadOperada;
        }

        public int GetCantiadOperada()
        {
            return cantidadOperada;
        }
    }
}