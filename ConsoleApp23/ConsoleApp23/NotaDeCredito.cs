using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp23
{
    internal class NotaDeCredito : ComprobanteEmitido
    {
        public NotaDeCredito(string fecha, double importe, string letra, string cae, int numero, string puntoDeVenta) : base(fecha, "H", importe, letra, cae, numero, puntoDeVenta)
        {
        }

    
    }
}
