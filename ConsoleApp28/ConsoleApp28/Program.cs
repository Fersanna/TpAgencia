using System;
using System.Collections.Generic;

namespace ConsoleApp28
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
        private List<String> especies;
        private List<Orden> ordenes;
        private Validador validador;

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

        internal void ejecutar()
        {
            string opcion = "";

            do
            {
                opcion = validador.pedirStringNoVacio("Ingrese opcion 1-Mostrar Porfolio\n2-Mostrar Pendintes\n3-Ingresar Orden\n 4-Salir");
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
            List<Orden> pendientes = ordenes.FindAll(ordenesEncontradas => ordenesEncontradas.EstaPendiente());

            foreach (Orden orden in pendientes)
            {
                Console.WriteLine(orden);
            }
        }

        // continuar por aca

        private void mostrarPortfolio()
        {
            foreach(String especie in especies)
            {
                int cantidadPendiente = 0;
                double subTotal=0;

                foreach (Orden orden in ordenes)
                {
                    cantidadPendiente += orden.CantidadPendiente() * orden.Signo();
                    subTotal += orden.ImporteOperado() * orden.Signo();
                }
                
                Console.WriteLine($"{especie}\t\t {subTotal}\t\t{cantidadPendiente}");

            }

        }

       
        }

    }

    internal class Validador
    {
         public Orden IngresarOrden(List<String> nombreCualquieraDeEspPendientes) {
          
          Orden retorno=null;
          string tipo = "";
          string fecha = DateTime.Now.ToString();
          string especie = "";
          int cantidad= 0;
          double precio= 0;

        do
        {
            tipo = pedirStringNoVacio("Ingrese C para compra o V para venta");

            if (tipo != "V" && tipo != "C")
            {
                Console.WriteLine("Ingrese C o V");
            }

        } while (tipo != "V" && tipo != "C");

        do
        { 
            especie =pedirStringNoVacio("Ingrese la especie");
             if (!nombreCualquieraDeEspPendientes.Contains(especie)){

                Console.WriteLine("Debe elegir una especie existente");
            }
        } while (!nombreCualquieraDeEspPendientes.Contains(especie));

        cantidad = pedirInteger("Ingrese cantidad", 1, 9999);
        precio = pedirDouble("Ingrese precio limite", 1, 9999);

        if (tipo=="C")
        {
            retorno = new OrdenDeCompra(fecha, especie, cantidad, precio);
        }
        if (tipo == "V")
        {
            retorno = new OrdenDeVenta(fecha, especie, cantidad, precio);
        }

        return retorno;
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

        private List<Operacion> operacionesEnOrdenes;

        public Orden(string fecha, string especie, int cantidadLimite, double precioLimite)
        {

            this.fecha = fecha;
            this.especie = especie;
            this.cantidadLimite = cantidadLimite;
            this.precioLimite = precioLimite;
            
        }

    public double ImporteOperado()
    {
        double retorno = 0;

        foreach (Operacion operacion in operacionesEnOrdenes)
        {
            retorno = retorno + operacion.GetImporteOperado();
        }
        return retorno;
    }

        protected double GetPrecioLimite()
        {
            return precioLimite;
        }

        public bool EstaPendiente()
        {

            return CantidadPendiente() != 0;
        }

        public int CantidadPendiente()
        {
            int operacionesPendientes = cantidadLimite;

            operacionesPendientes = CantidadOperada() - operacionesPendientes;


            return operacionesPendientes;
        }

        public int CantidadOperada()
        {
            int cantidad = 0;

            foreach (Operacion operacion in operacionesEnOrdenes)
            {
                if (!(operacion is Cancelacion))
                {
                    cantidad = cantidad + operacion.GetCantidadOperada();


                }
            }

            return cantidad;
        }

    public override string ToString()
    {
        return $"Fecha: {fecha}, Especie: {especie}, Cantidad Limite: {cantidadLimite}, Precio Limite: {precioLimite}";
    }


    public List<String> ControlClaseBase(Operacion pirulo)
        {
            List<String> retorno = new List<String>();

            if (pirulo.GetCantidadOperada() > CantidadPendiente())
            {
                retorno.Add("La operacion no puede superar a las ordenes pendientes");
            }

            return retorno;           
        }

 

        public List<String> IntentarAgregar(Operacion operacion)
        {
            List<String> retorno = ControlClaseBase(operacion);
            retorno.AddRange(ControPosterior(operacion));

            if (retorno.Count == 0)
            {
             operacionesEnOrdenes.Add(operacion);   
            }

            return retorno;
        }


        abstract public List<String> ControPosterior(Operacion operacion);

        abstract internal int Signo();

        

    }

    class OrdenDeCompra : Orden
    {
        private double precio;

        public OrdenDeCompra(string fecha, string especie, int cantidadLimite, double precioLimite) : base(fecha, especie, cantidadLimite, precioLimite)
        {
            
        }

        public double GetPrecio()
        {
            return precio;
        }

        public override List<String> ControPosterior(Operacion operacion)
        {
            List<String> retorno = new List<String>();

            if (!(operacion is Compra ) && (operacion is Cancelacion)) {

                retorno.Add("La operacion debe ser de compra");
            } 

            if (operacion is Compra compra && compra.GetPrecio() >this.GetPrecioLimite())
            {
                retorno.Add("El precio no puede ser superario al limite");
            }

            return retorno;
          
        }

        internal override int Signo()
        {
            return 1;
        }
    }


    class OrdenDeVenta : Orden
    {


        public OrdenDeVenta(string fecha, string especie, int cantidadLimite, double precioLimite) : base(fecha, especie, cantidadLimite, precioLimite)
        {
        }

        public override List<string> ControPosterior(Operacion operacion)
        {
            List<String> retorno = new List<String>();

            if (!(operacion is Venta && operacion is Cancelacion))
            {
                retorno.Add("La operacion debe ser de venta");
            }
            if (operacion is Venta venta && this.GetPrecioLimite() < venta.GetPrecio())
            {
                retorno.Add("La operacion debe estar por enciam del precio establecido");
            }

            return retorno;
        }

        internal override int Signo()
        {
            return -1;
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
            return cantidadOperada;
        }

        abstract protected int Signo();

        abstract public double GetImporteOperado();
    }

    class Compra : Operacion
    {

        private double precio;

        public Compra(string fecha, string especie, int cantidadOperada, double precio) : base(fecha, especie, cantidadOperada)
        {
            this.precio = precio;
        }


        public double GetPrecio()
        {
            return precio;
        }

        public override double GetImporteOperado()
        {
            return precio * GetCantidadOperada();
        }

        protected override int Signo()
        {
            return 1;
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

    protected override int Signo()
        {
            return 1;
        }
    }

    internal class Venta : Operacion
    {
        private double precio;

        public Venta(string fecha, string especie, int cantidadOperada, double precio) : base(fecha, especie, cantidadOperada)
        {
            this.precio = precio;
        }

        public double GetPrecio()
        {
            return precio;
        }

        public override double GetImporteOperado()
        {
            return precio*GetCantidadOperada();
        }

        protected override int Signo()
        {
            return -1;
        }
    }






