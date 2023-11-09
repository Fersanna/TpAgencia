using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp36
{
    class Final : Evento
    {
        string numeroOrden;
        int cantidadesProcesadas;
        
        List<String> eventosPosibles;

        public Final(string fecha, string numero, int cantidades) : base(fecha)
        {
            this.numeroOrden = numero;
            this.cantidadesProcesadas= cantidades;
           
        }


        public override bool PuedeAgregarEvento(Evento evento)
        {
            return(evento is Parada || evento is InicioTrabajo || evento is Preparacion);
        }
    }
}
