using System;
using System.Collections.Generic;

namespace ConsoleApp39
{
    abstract class Orden
    {

        private string fecha;
        private string especie;
        private int cantidadLimite;
        protected double precioLimite;

        private List<Operacion> operaciones;

        protected Orden(string fecha, string especie, int cantidadLimite, double precioLimite)
        {
            this.fecha = fecha;
            this.especie = especie;
            this.cantidadLimite = cantidadLimite;
            this.precioLimite = precioLimite;
            this.operaciones = new List<Operacion>();
        }

        public bool EstaAgotada()
        {
            return CantidadOperada() == cantidadLimite;
        }

        public int CantidadPendiente()
        {
            int cantidad = 0;
            int cantidadL = cantidadLimite;

            foreach (Operacion operacion in operaciones)
            {
                cantidad += operacion.GetCantidadOperada() - cantidadLimite;
            }
            return cantidad;
        }



        public String GetEspecie()
        {
            return especie;
        }

        internal int CantidadOperada()
        {
            int operada = 0;

            foreach (Operacion operacion in operaciones)
            {
                if (!(operacion is Cancelacion))
                {
                    operada = operada + operacion.GetCantidadOperada();
                }
            }
            return operada;

        }
        internal double GetPrecioOperado()
        {
            return precioLimite * cantidadLimite;
        }

        internal bool EstaPendiente()
        {
            return !EstaAgotada();
        }

        internal int GetCantidadOperada()
        {
            int cantidad = 0;

            foreach (Operacion operacion in operaciones)
            {
                cantidad += operacion.GetCantidadOperada();
            }
            return cantidad;
        }

        public override string ToString()
        {
            return $"Fecha: {fecha} Especie: {especie} Cantidad {cantidadLimite} Precio {precioLimite}";
        }



        private List<String> PuedeAgregarOperacion(Operacion operacion)
        {
            List<String> retorno = new List<String>();
            if (operacion.GetCantidadOperada() > CantidadPendiente())
            {
                retorno.Add("La cantidad de la operacion supera a la cantidad limite");
            }
            return (retorno);

        }

        public List<String> intentarAgregarOperacion(Operacion operacion)
        {
            List<String> retorno = PuedeAgregarOperacion(operacion);
            retorno.AddRange(DespuesDeValidarClaseBase(operacion));
            if (retorno.Count == 0)
            {
                operaciones.Add(operacion);
            }
            return (retorno);
        }

       public void AgregarOrden(Operacion nueva)
        { 

            foreach(Operacion operacion in operaciones)
            {
                if (operacion.GetCantidadOperada()>cantidadLimite)
                {
                    Console.WriteLine("La operacion excede lo previsto");

                }else
                {
                    operaciones.Add(operacion);
                }

            }
            
        }

       public abstract List<String> DespuesDeValidarClaseBase(Operacion operacion);


    }
}
