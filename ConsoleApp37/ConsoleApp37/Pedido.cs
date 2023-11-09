using System;

namespace ConsoleApp37
{
    internal class Pedido
    {
        private int numero;
        private int numeroDocumento;
        private string problema;
        private string solucion;
        private double precio;
        private string estado;

        public Pedido(int numero, int numeroDocumento, string problema, string solucion, double precio, string estado)
        {
            this.numero = numero;
            this.numeroDocumento = numeroDocumento;
            this.problema = problema;
            this.solucion = solucion;
            this.precio = precio;
            this.estado = "R";
        }

      

        internal int GetNumeroDNI()
        {
            return numeroDocumento;
        }

        internal string GetEstado()
        {
            return estado;
        }

        internal void MarcarEntregado()
        {
             estado = "E";
        }

        public override string ToString()
        {
            return $"Numero:{numero} Precio: {precio} Estado: {estado} Solucion: {solucion}";
        }

        internal int GetNumeroPedido()
        {
            return numero;
        }

       

        internal object GetPrecio()
        {
            return precio;
        }
    }
}