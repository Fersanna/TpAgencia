using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp34
{
    class OrdenDeCompra : Orden
    {
        private double precio;

        public OrdenDeCompra(string fecha, string especie, int cantidadLimite, double precioLimite, double precio) : base(fecha, especie, cantidadLimite, precioLimite)
        {
            this.precio = precio;
            
        }

        public override List<String> DespuesDeValidar(Operacion operacion)
        {
            List<String> retorno=new List<String>();

           if (!(operacion is Cancelacion && operacion is Compra))
            {
                retorno.Add("La operacion debe puede ser compra o cancelacion");
            }
           else if (operacion is Compra compra && compra.GetPrecio() > GetPrecioLimite())
            {
                retorno.Add("El importe no puede exceder el limite establecido");
            }

           return retorno;
        }

    }
}
