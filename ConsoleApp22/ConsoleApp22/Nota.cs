using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22
{
    class NotaDeRecepcion
    {
        public NotaDeRecepcion(string nombreReceptor, int numeroOrden, string fecha, string origen, Item[] items)
        {
            NombreReceptor = nombreReceptor;
            NumeroOrden = numeroOrden;
            Fecha = fecha;
            Origen = origen;
            Items = items;
        }

        public string NombreReceptor { get; set; }
        public int NumeroOrden { get; set; }
        public string Fecha { get; set; }
        public string Origen { get; set; }
        public Item[] Items { get; set; }
    }
}
