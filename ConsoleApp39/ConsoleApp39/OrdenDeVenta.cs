using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp39
{
    class OrdenDeVenta : Orden
    {
        public OrdenDeVenta(string fecha, string especie, int cantidadLimite, double precioLimite) : base(fecha, especie, cantidadLimite, precioLimite)
        {
        }
        public override List<String> DespuesDeValidarClaseBase(Operacion operacion)
        {
            List<String> resultadoEvaluacionBase = new List<string>();
            if (!(operacion is Venta) && !(operacion is Cancelacion))
            {
                resultadoEvaluacionBase.Add("La operacion es de tipo compra y solo se admiten compra o cancelacion");
            }
            if (operacion is Venta venta && venta.GetPrecio() < precioLimite)
            {
                resultadoEvaluacionBase.Add("El precio esta fuera de rangos validos");
            }
            return (resultadoEvaluacionBase);
        }

     

    }
}
