using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp38
{
    class Trenzadora : Maquina
    {
        private int metrosProdcuto;
        private int anchoMaximo;

        public Trenzadora(string codigo, string nombre, int metros, int anchoMaximo) : base(codigo, nombre)
        {
            this.metrosProdcuto = metros;
            this.anchoMaximo = anchoMaximo;
        }

        public override int MinutosParaFabricar(Orden orden)
        {
            throw new NotImplementedException();
        }

        public override bool PuedeFabricar(Orden orden)
        {
            throw new NotImplementedException();
        }

        // Resto del código de la clase Telar
    }

}
