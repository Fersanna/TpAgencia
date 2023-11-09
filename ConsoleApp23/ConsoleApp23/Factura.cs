using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp23
{
    class Factura : ComprobanteEmitido
    {
        public Factura(string fecha, double importe, string letra, string cae, int numero, string puntoDeVenta) : base(fecha, "D", importe, letra, cae, numero, puntoDeVenta)
        {

        }


    }

    
}
