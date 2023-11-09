using System;
using System.Collections.Generic;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Orden
    {
        private string fecha;
        private string especie;
        private int cantidadLimite;
        private double precioLimite;

        private List<Operacion> opereciones;

        protected Orden(string fecha, string especie, int cantidadLimite, double precioLimite)

        {

        this.fecha=fecha;
        this.especie = especie;
        this.cantidadLimite= cantidadLimite;
        this.precioLimite = precioLimite;
    
        }

        public override string ToString()
        {
            return base.ToString(); 
        }

        public int CantidadPendiente()
        {
            int pendientes = cantidadLimite;

            foreach(Operacion operacion in opereciones)
            {
                pendientes = pendientes - operacion.GetCantidadOperada();
            }
            return pendientes;
        }

        protected double GetPrecioLimite()
        {
            return precioLimite;
        }

        public bool EstaPendiente()
        {
            return CantidadPendiente() != 0;
        }

        private List<String> PuedeAgregarOperacion (Operacion operacion)
        {
            List<String> retorno= new List<String>();

            if (operacion.GetCantidadOperada() > cantidadLimite)
            {
                retorno.Add("La cantidad de la operacion supera a la cantidad limite");
            }

            return retorno;
        }
    }

    class Operacion
    {
        private string fecha;
        private string especie;
        private int cantidadOperada;
                
        protected Operacion (string fecha, string especie, int cantidadOperada)
        {
            this.fecha = fecha;
            this.especie=especie;
            this.cantidadOperada= cantidadOperada;      

        }

        public int GetCantidadOperada()
        {
            return cantidadOperada;
        }
    }

    class Compra : Operacion
    {
        private double precio;

        public Compra(double precio, string fecha, string especie, int cantidadOperada) : base (fecha, especie, cantidadOperada)
        {
            this.precio = precio;
        }

        public double GetPrecio() { 
        return precio;
        }

    }


    internal class Cancelacion : Operacion
    {
        public Cancelacion(string fecha, string especie, int cantidadOperada) : base(fecha, especie, cantidadOperada)
        {
        }
    }

    class OrdenDeCompra : Orden
    {
        public OrdenDeCompra(string fecha, string especie, int cantidadLimite, double precioLimite) : base (fecha, especie,cantidadLimite, precioLimite)
        {

        }
        

        protected  List<String> DespuesDeValidarClaseBase (Operacion operacion)
        {
            List <String> resultadoEvaluacion = new List<String>();

            if (!(operacion is Cancelacion) && !(operacion is Compra))
            {
                resultadoEvaluacion.Add("La operacion es de tipo venta y solo se admiten compra o cancelacion");

            }
            if (operacion is Compra compra && compra.GetPrecio() > this.GetPrecioLimite())
            {
                resultadoEvaluacion.Add("El precio esta fuera de rangos validos");
            }

                          

            return resultadoEvaluacion;
        }
    }
}
