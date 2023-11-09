using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
    abstract internal class Orden
    {
        private string fecha;
        private string especie;
        private int cantidadLimite;
        private double precioLimite;

        private List<Operacion> operaciones;

        public Orden(string fecha, string especie, int cantidadLimite, double precioLimite)
        {
            this.fecha = fecha;
            this.especie = especie;
            this.cantidadLimite = cantidadLimite;
            this.precioLimite = precioLimite;
            this.operaciones = new List<Operacion>();
        }

        public int CantidadOperada()
        {
            int cantidadOperada = 0;

            foreach (Operacion c in operaciones)
            {
                cantidadOperada = c.GetCantiadOperada() + cantidadOperada;
            }

            return cantidadOperada;
        }

        public bool EstaPendiente()
        {
            return CantidadPendiente() != 0;
        }

        public int CantidadPendiente()
        {
            int cantidadPendiente = 0;

            foreach (Operacion c in operaciones)
            {
                cantidadPendiente = c.GetCantiadOperada() - cantidadLimite;
            }

            return cantidadPendiente;
        }

        public List<String> ValidacionClaseBase()
        {
            List<String> errores = new List<String>();

            foreach (Operacion c in operaciones)
            {
                if (CantidadPendiente() < c.GetCantiadOperada())
                {
                    errores.Add("La operacion excede lo pendiente");
                }
            }

            return errores;
        }

       public double GetPrecioLimite()
        {
            return precioLimite;
        }

        public List<String> IntentarAgregarOperacion(Operacion operacion)
        {
            List<String> retorno = ValidacionClaseBase();
            retorno.AddRange(DespuesDeValidar(operacion));

            if (retorno.Count==0)
            {
                operaciones.Add(operacion);
            }

            return retorno;


        }

        abstract public List<String> DespuesDeValidar(Operacion operacion);

        public override string ToString()
        {
            return $"Fecha: {fecha} + Especie: {especie} +  Cantidad :{cantidadLimite} + Precio: {precioLimite}";
        }
    }
}