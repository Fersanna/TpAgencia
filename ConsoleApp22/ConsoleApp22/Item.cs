using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22
{
    class Item
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }

        public Item (string codigo, string descripcion, int cantidad)
        {
            Codigo= codigo;
            Descripcion= descripcion;
            Cantidad= cantidad;
        }
    }
}
