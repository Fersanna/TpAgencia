using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp34
{
    class OrdenDeVenta : Orden
    {
        private double precio;

        public OrdenDeVenta(string fecha, string especie, int cantidadLimite, double precioLimite, double precio) : base(fecha, especie, cantidadLimite, precioLimite)
        {
            this.precio = precio;
        }

        public override List<string> DespuesDeValidar(Operacion operacion)
        {
            List<String> retorno = new List<String>();

            if (!(operacion is Cancelacion && operacion is Venta))
            {
                retorno.Add("No se admite operaciones de compra");
            } else if (!(operacion is Venta venta && venta.getPrecio() < GetPrecioLimite())){
                retorno.Add("la operacion esta por debajo de lo pautado");
            }

            return retorno;

        }
    }
}
