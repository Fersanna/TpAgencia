using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp23
{
     abstract class Comprobante
    {

        public string Fecha { get; set; }
        public string Signo { get; set; }
        public double Importe { get; set; }

        public Comprobante(string fecha, string signo, double importe)
        {

            Fecha = fecha;
            Signo = signo;
            Importe = importe;

        }

        public override string ToString()
        {
            return $"Comprobante - Fecha: {Fecha} - Signo: {Signo} - Importe {Importe}";
        }

        public double getImporte()
        {
            return (Signo == "D") ? Importe : -Importe;
        }
    }
}
