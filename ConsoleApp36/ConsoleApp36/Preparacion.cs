using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp36
{
    class Preparacion : Evento
    {
        int nunmeroOrden;


        public Preparacion(string fecha, int numero) : base(fecha)
        {
            this.nunmeroOrden = numero;
        }

        public override bool PuedeAgregarEvento(Evento evento)
        {
            throw new NotImplementedException();
        }
    }
}
