using System.Collections.Generic;

namespace ConsoleApp35
{
    internal class Tercero : Inmueble
    {
        private string codigo;
        private string nombre;
        private object nombreProp;
        private double feeMensual;
        private int mesesTotales;
        private int mesesRestantes;

        private List<Concepto> conceptos;

        public Tercero(string codigo, string nombre, string fecha, object nombreProp, double feeMensual, int mesesTotales, int mesesRestantes) : base(codigo, nombre, fecha)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.nombreProp = nombreProp;
            this.feeMensual = feeMensual;
            this.mesesTotales = mesesTotales;
            this.mesesRestantes = mesesRestantes;
            this.conceptos = new List<Concepto>();
        }

        public override double GetAlquiler()
        {
            return feeMensual;
        }

        public override double GetAmortizacion()
        {
            return 0;
        }

        public override double GetGastosAdicionales()
        {

            {
                double gastosAdicionales = 0;
                foreach (Concepto concepto in conceptos)
                {
                    if (concepto.AplicaATerceros(this))
                    {
                        gastosAdicionales += concepto.GetImporte();
                    }
                }
                return gastosAdicionales;
            }


        }


        public override List<Concepto> GetConcepto()
        {
            List<Concepto> conceptosAplicables = new List<Concepto>();

            foreach (Concepto concepto in conceptos)
            {
                if (concepto.AplicaATerceros(this))
                {
                    conceptosAplicables.Add(concepto);
                }
            }

            return conceptosAplicables;
        }
        public override string ToString()
        {
            string conceptosStr = "";
            foreach (Concepto concepto in conceptos)
            {
                conceptosStr += concepto.ToString() + "\n";
            }

            return $"Código: {codigo}\nNombre: {nombre}\nConceptos:\n{conceptosStr}";
        }

    }
}