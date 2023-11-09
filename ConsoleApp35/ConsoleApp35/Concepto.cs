using System;
using System.Collections.Generic;

namespace ConsoleApp35
{
    internal class Concepto
    {
        private string nombre;
        private string codigo;
        private int mesesRestantesEjecucion;
        private double importe;
        private string tipoDeInmueble;

        public Concepto(string nombre, string codigo, int mesesRestantesEjecucion, double importe, string tipoDeInmueble)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.mesesRestantesEjecucion = mesesRestantesEjecucion;
            this.importe = importe;
            this.tipoDeInmueble= tipoDeInmueble;
        }

        public bool AplicaApropios(Inmueble inmueble)
        {
            return tipoDeInmueble=="P";
        }

        public bool AplicaATerceros(Inmueble inmueble)
        {
            return tipoDeInmueble == "T";
        }

        public string GetCodigo()
        {
            return codigo;
        }

        public double GetImporte()
        {   
            return importe;
        }

        internal string GetNombre()

        {
            return nombre;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre} + Codigo: {codigo} + Tipo: {tipoDeInmueble} ";
        }

        

    }
}