using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp36
{
    class FinMantenimiento : Evento
    {


        public FinMantenimiento(string fecha) : base(fecha)
        {
        }

        public override bool PuedeAgregarEvento(Evento evento)
        {
            throw new NotImplementedException();
        }
    }
}
