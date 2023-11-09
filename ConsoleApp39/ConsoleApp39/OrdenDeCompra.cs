using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp39
{
    class OrdenDeCompra : Orden
    {
        private int precioDeLaOrden;

        public OrdenDeCompra(string fecha, string especie, int cantidadLimite, double precioLimite) : base(fecha, especie, cantidadLimite, precioLimite)
        {
        }

        public override List<string> DespuesDeValidarClaseBase(Operacion operacion)
        {
            throw new NotImplementedException();
        }

        public int GetPrecioOrden()
        {
            return precioDeLaOrden;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
