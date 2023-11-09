using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp23
{
   abstract class ComprobanteEmitido : Comprobante 
    {
        

        public ComprobanteEmitido( string fecha, string signo, double importe, string letra, string cae, int numero, string puntoDeVenta) : base(fecha, signo, importe)
        {
            Letra = letra;
            Cae= cae;
            Numero= numero;
            PuntoDeVenta= puntoDeVenta;
            


        }



        public override string ToString()
        {
            return $"Letra : {Letra} - Numero : {Numero} -  Punto de Venta : {PuntoDeVenta} Cae :{Cae} Signo : {Signo} Importe : {Importe}";
        }

        public string Letra { get; set; }
        public string PuntoDeVenta { get; set; }
        public int Numero { get; set; }
        public string Cae { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ComprobanteEmitido emitido &&
                   Fecha == emitido.Fecha &&
                   Signo == emitido.Signo &&
                   Importe == emitido.Importe &&
                   Letra == emitido.Letra &&
                   PuntoDeVenta == emitido.PuntoDeVenta &&
                   Numero == emitido.Numero &&
                   Cae == emitido.Cae;
        }
    }
}
