using System;
using System.Collections.Generic;

namespace ConsoleApp36
{
    internal abstract class Evento
    {
        string fecha;
        

        protected Evento(string fecha)
        {
            
            this.fecha = fecha;
        }

        abstract public bool PuedeAgregarEvento(Evento evento);
    }
}