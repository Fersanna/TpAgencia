using System;
using System.Collections.Generic;

namespace ConsoleApp38
{
    internal class Orden
    {
        private int numero;
        Producto producto;
        private int cantidadDeMetros;
        List<String> procesosEjecutados;
        List<String> porcesosAEjecutar;
        private Maquina maquinaAsignada;
        public int minutosAsignados;

        public Orden(int numero, Producto producto, int cantidadDeMetros, List<string> procesosEjecutados, List<string> porcesosAEjecutar, Maquina maquinaAsignada, int minutosAsignados)
        {
            this.numero = numero;
            this.producto = producto;
            this.cantidadDeMetros = cantidadDeMetros;
            this.procesosEjecutados = procesosEjecutados;
            this.porcesosAEjecutar = porcesosAEjecutar;
            this.maquinaAsignada = maquinaAsignada;
            this.minutosAsignados = minutosAsignados;
        }

        internal int GetMinutosAsignados()
        {
            return minutosAsignados;
        }

        public int GetNumeroDeOrden()
        {
            return numero;
        }


    }
}