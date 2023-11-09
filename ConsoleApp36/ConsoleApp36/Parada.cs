using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp36
{
  class Parada : Evento
    {
        string motivo;

        public Parada (string fecha, string motivo) : base(fecha)
        {
            this.motivo = motivo;
        }

        public override bool PuedeAgregarEvento(Evento evento)
        {
            throw new NotImplementedException();
        }
    }   
 
}
