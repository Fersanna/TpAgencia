using System;
using System.Collections.Generic;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            AppPortfolio app = new AppPortfolio();
            app.ejecutar();

        }
    }

    internal class AppPortfolio
    {

        Validador validador;
        List<Orden> ordenes;
        List<String> especies;

          public AppPortfolio()
        {
            validador=new Validador();
            ordenes=new List<Orden>();
            especies= new List<String>();
            especies.Add("MSFT");
            especies.Add("AAPL");
            especies.Add("KO");
            especies.Add("MCD");
        }

        internal void ejecutar()
        {
            string opcion = "";
            do
            {
                opcion = validador.pedirStringNoVacio("Ingrese opcion");
                if (opcion == "1")
                {
                    mostrarPortfolio();
                }
                else if (opcion == "2")
                {
                    mostrarPendientes();
                }
                else if (opcion == "3")
                {
                    ingresarOrden();
                }
            } while (opcion != "4");

        }

        private void mostrarPortfolio()
        {
            foreach (String especie in especies)
            {
               
              
                    foreach(Orden orden in ordenes)
                    {
                    int cantidad = 0;
                    double importe= 0;

                    importe = importe + orden.ImporteOperado();
                    cantidad = cantidad + orden.GetCantidadOperada();

                    }
                
            }

            Console.WriteLine(ordenes);
        }
    }

    internal class Validador
    {


        private double pedirDouble(string mensaje, double minimo, double maximo)
        {
            double retorno = minimo - 1;
            do
            {
                Console.WriteLine(mensaje);
                if (!Double.TryParse(Console.ReadLine(), out retorno))
                {
                    Console.WriteLine("Debe ingresar un numero");
                }
                else
                {
                    if (retorno < minimo && retorno > maximo)
                    {
                        Console.WriteLine("Fuera de rango");
                    }
                }
            } while (retorno < minimo && retorno > maximo);
            return (retorno);
        }

        internal string pedirStringNoVacio(string mensaje)
        {
            string retorno = "";
            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine();
                if (retorno == "")
                {
                    Console.WriteLine("Debe ingresar un dato");
                }
            } while (retorno == "");
            return (retorno.ToUpper());
        }

        private int pedirInteger(string mensaje, int minimo, int maximo)
        {
            int retorno = minimo - 1;
            do
            {
                Console.WriteLine(mensaje);
                if (!Int32.TryParse(Console.ReadLine(), out retorno))
                {
                    Console.WriteLine("Debe ingresar un numero");
                }
                else
                {
                    if (retorno < minimo && retorno > maximo)
                    {
                        Console.WriteLine("Fuera de rango");
                    }
                }
            } while (retorno < minimo && retorno > maximo);
            return (retorno);
        }
    }
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

        public int CantidadPendiente()
        {
            int pendintes = cantidadLimite;

            foreach (Operacion esto in operaciones)
            {
                pendintes = esto.GetCantidadOperada() - pendintes;
            }

            return pendintes;

        }

        public int GetCantidadOperada()
        {
            int cantidad;

            foreach(Operacion c in operaciones)
            {
                cantidad += c.GetCantidadOperada(); 
            } 
            return cantidad;
        }   

        public double ImporteOperado()
        {
            double importe = 0;

            foreach (Operacion op in operaciones)
            {
                importe += op.GetCantidadOperada() * op.GetPrecio();
            }

            return importe;
        }

        public bool EstaPendinte()
        {
            return CantidadPendiente() != 0;
        }



        public abstract List<String> DespuesDeValidarClaseBase(Operacion operacion);

        public List<String> ValidirClase(Operacion operacion)
        {
            List<String> error = new List<String>();

            if (operacion.GetCantidadOperada() > cantidadLimite)
            {
                error.Add("La operacion no puede ser agregar por exceder cantidad limite de la orde");
            }

            return error;
        }


        public List<Orden> IntentarAgregarOperacion(Operacion operacion)
        {
            List<Orden> Aagregar = new List<Orden>();

            List<String> retorno = ValidirClase(operacion);

            retorno.AddRange(DespuesDeValidarClaseBase(operacion));

            if (retorno.Count == 0)
            {
                Aagregar.Add(this);
            }

            return Aagregar;
        }

    }

    abstract class Operacion
    {

        private string fecha;
        private string especie;
        private int cantidadOperada;


        protected Operacion(string fecha, string especie, int cantidadOperada)
        {
            this.fecha = fecha;
            this.especie = especie;
            this.cantidadOperada = cantidadOperada;

        }

        public int GetCantidadOperada()
        {

            return this.cantidadOperada;
        }

        public abstract double GetPrecio();
        /*
         *
         Metodo que devuelve 0 si no hay problemas y 1 si el error es que la cantidad operada es mayor a la pendiente
         */


        class OrdenDeCompra : Orden
        {


            public OrdenDeCompra(string fecha, string especie, int cantidadLimite, double precioLimite) : base(fecha, especie, cantidadLimite, precioLimite)
            {
            }

            public override List<String> DespuesDeValidarClaseBase(Operacion operacion)
            {
                List<String> retorno = new List<String>();

                if (!(operacion is Compra && operacion is Cancelacion))
                {
                    retorno.Add("Solo se admiten compras o cancelaciones");
                }
                if (operacion is Compra compra && compra.GetPrecio() > this.precioLimite)
                {
                    retorno.Add("El precion no puede ser superior al limite");
                }

                return retorno;
            }
            class OrdenDeVenta : Orden
            {
                public OrdenDeVenta(string fecha, string especie, int cantidadLimite, double precioLimite) : base(fecha, especie, cantidadLimite, precioLimite)
                {
                }

                public override List<string> DespuesDeValidarClaseBase(Operacion operacion)
                {
                    List<String> errores = new List<String>();

                    if (!(operacion is Venta && operacion is Cancelacion))
                    {
                        errores.Add("No se admite otra operacion que no sea Venta o Cancelacion");
                    }

                    if (operacion is Venta venta && venta.GetPrecio() < precioLimite)
                    {
                        errores.Add("El importe no puede ser inferior");
                    }

                    return errores;
                }
            }

            internal class Venta : Operacion
            {
                private double precio;

                public Venta(string fecha, string especie, int cantidadOperada, double precio) : base(fecha, especie, cantidadOperada)
                {
                    this.precio = precio;
                }


                public int GetcantidadOperada()
                {
                    return cantidadOperada;
                }



                public override double GetPrecio()
                {
                    return precio;
                }
            }

            internal class Cancelacion : Operacion
            {
                public Cancelacion(string fecha, string especie, int cantidadOperada) : base(fecha, especie, cantidadOperada)
                {
                }

                public override double GetPrecio()
                {
                    return 0;
                }
            }


            class Compra : Operacion
            {

                private double precio;

                public Compra(string fecha, string especie, int cantidadOperada, double precio) : base(fecha, especie, cantidadOperada)
                {
                    this.precio = precio;
                }
                public int GetcantidadOperada()
                {
                    return cantidadOperada;
                }

                public override double GetPrecio()
                {
                    return precio;
                }
            }


        }
    }
}