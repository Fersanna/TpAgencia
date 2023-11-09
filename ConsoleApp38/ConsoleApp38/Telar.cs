using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp38
{
    class Telar : Maquina
    {
        private int metrosProducto;
        private int anchoMaximo;

        public Telar(string codigo, string nombre, int metrosAtejer, int anchoMaximo) : base(codigo, nombre)
        {
            this.metrosProducto = metrosAtejer;
            this.anchoMaximo = anchoMaximo;
        }

        public override int MinutosParaFabricar(Orden orden)
        {
            int minutos = 0;

            if (orden.GetMinutosAsignados() > 1440)
            {
                minutos = -1;
            }
            else
            {
                minutos = orden.GetMinutosAsignados();
            }

            return minutos;
        }

        public override bool PuedeFabricar(Orden orden)
        {
            return (MinutosParaFabricar(orden)!=-1);
        }

        public bool PuedeTomarProducto(Producto producto)
        {
            return producto.GetAnchoEnMilimetros() == anchoMaximo;
        }

        public override string ToString()
        {
            return base.ToString()  + $"Metros: {metrosProducto} Ancho Maximo: {anchoMaximo}";
        }
    }
}
