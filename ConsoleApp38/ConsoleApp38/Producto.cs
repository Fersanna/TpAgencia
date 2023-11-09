using System;
using System.Collections.Generic;

namespace ConsoleApp38
{
    internal class Producto
    {
        private string codigo;
        private string nombre;
        private int largoEnCentimetros;
        private int anchoEnMilimetros;
        List<String> procesosSecuenciales;

        public Producto(string codigo, string nombre, int largoEnCentimetros, int anchoEnMilimetros)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.largoEnCentimetros = largoEnCentimetros;
            this.anchoEnMilimetros = anchoEnMilimetros;
            this.procesosSecuenciales = new List<string>() { "Telar-", "Trenzado-"};
        }

        internal int GetAnchoEnMilimetros()
        {
            return anchoEnMilimetros;
        }

        public string ListadoDeProcesos()
        {
            string retorno = "";
            foreach (String procesos in procesosSecuenciales)
            {
                retorno += procesos;
            }
            return retorno;
        }
        

        public override string ToString()
        {
            return $"Codigo de Producto: {codigo} Nombre: {nombre} Centimetros de largo: {largoEnCentimetros} Ancho {anchoEnMilimetros} Procesos: {ListadoDeProcesos()}";
        }

        public override bool Equals(object obj)
        {
            return obj is Producto producto &&
                   codigo == producto.codigo &&
                   anchoEnMilimetros == producto.anchoEnMilimetros;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(codigo);
        }

        internal string GetCodigo()
        {
            return codigo;
        }

        internal List<string> GetProcesosSecuenciales()
        {
            return procesosSecuenciales;
        }
    }
}