using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            AppPortfolio app = new AppPortfolio();
            app.ejecutar();
        }
    }

    class AppPortfolio
    {
        private List<String> especies;
        private List<Orden> ordenes;
        private Validador validador;

        //Constructor que instancia, no se recomienda hacer en metodos aparte.
        public AppPortfolio()
        {
            especies = new List<String>();
            ordenes = new List<Orden>();
            validador = new Validador();
            especies.Add("MSFT");
            especies.Add("AAPL");
            especies.Add("KO");
            especies.Add("MCD");
        }
        public void ejecutar()
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

        private void ingresarOrden()
        {
            ordenes.Add(validador.IngresarOrden(especies));
        }

        private void mostrarPendientes()
        {
            ordenes
                .FindAll(pepe => pepe.EstaPendiente())
                .ForEach(Console.WriteLine);

            //foreach (Orden orden in ordenes)
            //{
            //    if (orden.EstaPendiente())
            //    {
            //        Console.WriteLine(orden);
            //    }
            //}
            
        }

        private void mostrarPortfolio()
        {
            especies.ForEach(MostrarDetalleDeEspecie);

            //foreach (String especie in especies)
            //{
            //    MostrarDetalleDeEspecie(especie);
            //}
        }

        private void MostrarDetalleDeEspecie(string especie)
        {
            int cantidad = 0;
            double subtotal = 0;

            foreach (Orden orden in ordenes)
            {
                if (orden.EsdeEspecie(especie))
                {
                    cantidad = cantidad + orden.CantidadOperada() * orden.signo();
                    subtotal = subtotal + orden.ImporteOperado() * orden.signo();
                }

                Console.WriteLine(especie + "\t" + cantidad + "\t" + subtotal);
            }
        }
    }

    internal class Validador
    {

        public Orden IngresarOrden(List<String> especiesParametro)
        {
            Orden retorno=null;
            string tipo = "";
            string especie = "";
            int cantidad = 0;
            double precioLimite = 0;
            do
            {
                tipo = pedirStringNoVacio("Ingrese C para compra o V para venta");
                if (tipo != "C" && tipo != "V")
                {
                    Console.WriteLine("Debe ingresar C o V");
                }
            } while (tipo != "C" && tipo != "V");

            do
            {
                especie = pedirStringNoVacio("Ingrese especie");
                if (!especiesParametro.Contains(especie))
                {
                    Console.WriteLine("Especie invalida");
                }
            } while (!especiesParametro.Contains(especie));
            cantidad = pedirInteger("Ingrese cantidad", 1, 9999);
            precioLimite = pedirDouble("Ingrese precio limite", 1, 9999);
            if (tipo == "C")
            {
                retorno = new OrdenDeCompra(DateTime.Now.ToString(), especie, cantidad, precioLimite);
            }
            else if (tipo == "V")
            {
                retorno = new OrdenDeVenta(DateTime.Now.ToString(), especie, cantidad, precioLimite);
            }
            else
            {
                throw new InvalidDataException("No se puede instanciar la orden acorde a los dato");
            }


            return retorno;
        }

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

        public double GetPrecioLimite()
        {
            return precioLimite;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int CantidadPendiente()
        {
            int pendiente = cantidadLimite;

            pendiente = pendiente - CantidadOperada();

            return pendiente;
        }

        public int CantidadOperada()
        {
            int cantidadOperada = 0;

            foreach (Operacion item in operaciones)
            {
                cantidadOperada = cantidadOperada + item.GetCantidadOperada();
            }

            return cantidadOperada;
        }

        public double ImporteOperado()
        {
            double operada = 0;

            foreach (Operacion operacion in operaciones)
            {
                operada = operada + operacion.GetImporteOperado();
            }
            return operada;
        }

        public bool EstaPendiente()
        {
            return CantidadPendiente() != 0;
        }

        public List<String> PuedeAgregarOperacion(Operacion operacion)
        {
            List<String> result = new List<String>();

            if (cantidadLimite > operacion.GetCantidadOperada())
            {
                result.Add("La cantidad de la operacion supera a la cantidad limite");
            }

            return result;

        }

        public bool EsdeEspecie(string especie)
        {
            return (this.especie == especie);
        }

        public List<String> intentarAgregarOperacion(Operacion operacion)
        {
            List<String> retorno = PuedeAgregarOperacion(operacion);
            retorno.AddRange(despuesDeValidarClaseBase(operacion));
            if (retorno.Count == 0)
            {
                operaciones.Add(operacion);
            }
            return (retorno);
        }

        protected abstract List<String> despuesDeValidarClaseBase(Operacion operacion);

        public abstract int signo();

    }


    class OrdenDeCompra : Orden
    {
        public OrdenDeCompra(string fecha, string especie, int cantidadLimite, double precioLimite) : base(fecha, especie, cantidadLimite, precioLimite)
        {
        }

        public override int signo()
        {
            return 1;
        }

        protected override List<String> despuesDeValidarClaseBase(Operacion operacion)
        {
            List<String> result = new List<String>();

            if (!(operacion is Compra) && !(operacion is Cancelacion))
            {

                result.Add("La operacion es de tipo venta y solo se admiten compra o cancelacion");
            }
            if (operacion is Compra pirulo && pirulo.GetPrecio() > this.GetPrecioLimite())
            {
                result.Add("El precio esta fuera de rangos validos");
            }

            return result;
        }

    }

    class OrdenDeVenta : Orden
    {
        private double precio;

        public OrdenDeVenta(string fecha, string especie, int cantidadLimite, double precioLimite) : base(fecha, especie, cantidadLimite, precioLimite)
        {

        }

        public double GetPrecio()
        {
            return precio;
        }

        public override int signo()
        {
            return -1;
        }

        protected override List<string> despuesDeValidarClaseBase(Operacion operacion)
        {
            List<String> result = new List<String>();

            if (!(operacion is Venta) && !(operacion is Cancelacion))
            {
                result.Add("La operacion es de compra");
            }
            if (operacion is Venta pirulo && pirulo.GetPrecio() < this.GetPrecioLimite())
            {
                result.Add("El precio esta por debajo");
            }

            return result;
        }


    }

    abstract class Operacion
    {
        private string fecha;
        private string especie;
        private int cantidadOperada;


        public Operacion(string fecha, string especie, int cantidadOperada)
        {


            this.fecha = fecha;
            this.especie = especie;
            this.cantidadOperada = cantidadOperada;

        }

        public int GetCantidadOperada()
        {
            return cantidadOperada;
        }

        public abstract double GetImporteOperado();

    }

    class Compra : Operacion
    {
        private double precio;

        public Compra(string fecha, string especie, int cantidadOperada, double precio) : base(fecha, especie, cantidadOperada)
        {
            this.precio = precio;
        }

        public override double GetImporteOperado()
        {
            return (precio * GetCantidadOperada());
        }

        public double GetPrecio()
        {
            return precio;
        }
    }

    internal class Venta : Operacion
    {
        private double precio;

        public Venta(string fecha, string especie, int cantidadOperada) : base(fecha, especie, cantidadOperada)
        {
        }

        public override double GetImporteOperado()
        {
            return (precio * GetCantidadOperada());
        }

        public double GetPrecio()
        {

            return precio;
        }
    }

    internal class Cancelacion : Operacion
    {
        public Cancelacion(string fecha, string especie, int cantidadOperada) : base(fecha, especie, cantidadOperada)
        {
        }

        public override double GetImporteOperado()
        {
            return 0;
        }
    }
}
