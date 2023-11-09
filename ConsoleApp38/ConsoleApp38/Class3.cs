using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp38
{
    class Cortadora : Maquina
    {
        private int cantidadDeProductos;
        private int largoMinimo;

        public Cortadora(string codigo, string nombre, int cantidadDeProductos, int largoMinimo) : base (codigo,nombre)
        {
            this.cantidadDeProductos = cantidadDeProductos;
            this.largoMinimo = largoMinimo;
        }

        public override int MinutosParaFabricar(Orden orden)
        {
            throw new NotImplementedException();
        }

        public override bool PuedeFabricar(Orden orden)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
