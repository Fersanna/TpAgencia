using System;
using System.Collections.Generic;

namespace ConsoleApp35
{
    abstract class Inmueble
    {
        private string codigo;
        private string nombre;
        private string fecha;

        List<Concepto> conceptos;

        public Inmueble(string codigo, string nombre, string fecha)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.fecha = fecha;
            this.conceptos=new List<Concepto>();    
        }

        public override bool Equals(object obj)
        {
            return obj is Inmueble inmueble &&
                   codigo == inmueble.codigo &&
                   nombre == inmueble.nombre;
                  
        }
        public override string ToString()
        {
            string conceptosStr = "";
            foreach (Concepto concepto in conceptos)
            {
                conceptosStr += GetGastosAdicionales().ToString() + "\n";
            }

            return $"Código: {codigo}\nNombre: {nombre}\nConceptos:\n{conceptosStr}";
        }

     


        public abstract double GetAmortizacion();
        public abstract double GetAlquiler();
        public abstract double GetGastosAdicionales();

        internal string GetCodigo()
        {
            return codigo;
        }

        abstract public List<Concepto> GetConcepto();
     

    }
}