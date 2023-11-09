using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp35
{
    internal class Propio : Inmueble
    {
        string codigo;
        string nombre;
        double valorInicial;
        int mesesDeVida;
        int mesesRestantes;
        List <Concepto> conceptos;

        public Propio(string codigo, string nombre, string fecha, double valorInicial, int mesesDeVida, int mesesRestantes) : base(codigo, nombre, fecha)
        {    
            this.codigo = codigo;
            this.nombre = nombre; 
            this.valorInicial = valorInicial;
            this.mesesDeVida = mesesDeVida;
            this.mesesRestantes = mesesRestantes;
            this.conceptos = new List<Concepto>();
        }

        public override double GetAlquiler()
        {
            return 0;
        }

        public override double GetAmortizacion()
        {
            return valorInicial/mesesDeVida;
        }

        public override List<Concepto> GetConcepto()
        {
            List<Concepto> conceptosAplicables = new List<Concepto>();

            foreach (Concepto concepto in conceptos)
            {
                if (concepto.AplicaApropios(this))
                {
                    conceptosAplicables.Add(concepto);
                }
            }

            return conceptosAplicables;
        }



        public override string ToString()
        {
            string conceptosStr = "";
            double totalPorConcepto = 0;

            foreach (Concepto concepto in conceptos)
            {
                conceptosStr += concepto.ToString() + "\n";
                totalPorConcepto += concepto.GetImporte();
            }

            return $"Código: {codigo}\nNombre: {nombre}\nConceptos:\n{conceptosStr}\nTotal por Concepto: {totalPorConcepto}";
        }


        public void AgregarConcepto(Concepto concepto)
        {
            conceptos.Add(concepto);
        }

        public override double GetGastosAdicionales()
        {
            double gastos = 0;
            foreach (Concepto concepto in conceptos)
            {
                if (concepto.AplicaApropios(this))
                {
                    gastos += concepto.GetImporte();
                }
            }

            return gastos;
        }

       
    }
}