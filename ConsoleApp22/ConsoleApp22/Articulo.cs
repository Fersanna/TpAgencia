using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22
{

    public class Articulo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }


        public Articulo(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }
    }
}
