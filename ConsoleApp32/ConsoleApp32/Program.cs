using System;
using System.Collections.Generic;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            AppMecacho app = new AppMecacho();
            app.ejecutar();
        }
    }

    class AppMecacho
    {
        private Validador validador;
        private List<Auto> autos;
        private List<Servicio> servicios;
        

        public AppMecacho()
        {
            validador = new Validador();
            autos = new List<Auto>();
            servicios = new List<Servicio>();
        }

        public void ejecutar()
        {
            cargaInicial();

            List<String> opcioneMenu = new List<String>() { "1", "2", "3", "4" };

            string opcionElegida = "";

            do
            {
                opcionElegida = validador.pedirOpcionDeMenu("1 - Registrar auto\n2 - Ingresar servicios" + "\n3 - Reporte de servicios" + "\n4 - Salir" + "\n", opcioneMenu);
                if (opcionElegida.Equals("1"))
                {
                    registrarAuto();
                }
                else if (opcionElegida.Equals("2"))
                {
                    ingresarServicios();
                }
                else if (opcionElegida.Equals("3"))
                {
                    reporteServicios();
                }
            } while (!opcionElegida.Equals("4"));




        }

        private void cargaInicial()
        {
            autos.Add(new Auto("pjs192", "toyota", "1999", "Jose Perez", "1555-1111"));
            autos.Add(new Auto("AAA111", "VW", "2022", "Juan Topo", "2222-2222"));
            autos.Add(new Auto("UNO111", "VW", "2021", "Atila el Huno", "1111-1111"));


        }

        private void reporteServicios()
        {
            throw new NotImplementedException();
        }

        private void ingresarServicios()
        {
            servicios.Add(CargarServicio());
        }

        private Servicio CargarServicio()
        {
            string patenteAcomparar = "";
            List<String> patentes = new List<String>();
            int numeroDeFactura= 0;
            string fecha;

            patenteAcomparar = validador.pedirString("Ingrese patente a cargar servicio");

            foreach (Auto auto in autos) {

                patentes.Add(auto.GetPatente());
            }

            if (!patentes.Contains(patenteAcomparar))
            {
                Console.WriteLine("Esta patente no esta cargada");
            }


            do
            {
                numeroDeFactura = validador.pedirInteger("ingrese numero de factura", 0, 1000);

                foreach (Servicio servicio in servicios)
                {
                    if (servicio.NumeroFacturaExiste(numeroDeFactura))

                        Console.WriteLine("Ingrese otro numero de factura");
                }

            }while (numeroDeFactura == 0);


            fecha = DateTime.Now.ToString();

            Servicio nuevoServicio=new Servicio(numeroDeFactura, patenteAcomparar, fecha);

            return nuevoServicio;
        }

        private void registrarAuto()
        {
            autos.Add(CargaDeAuto());
        }

        private Auto CargaDeAuto()
        {
            
            string patenteAbuscar;
            string marca;
            string anio;
            string nombre;
            string telefono;

            patenteAbuscar = validador.pedirString("Ingrese patente de auto a cargar");
             
            List<String> patentes= new List<String>();

            foreach (Auto auto in autos)
            {
                patentes.Add(auto.GetPatente());
            }

            if (patentes.Contains(patenteAbuscar)) {

                Console.WriteLine("Esa patente ya fue cargada");
                return null;
            }

            marca = validador.pedirString("Ingrese marca del auto");
            anio = validador.pedirString("Ingrese el año");
            nombre = validador.pedirString("Nombre");
            telefono = validador.pedirString("Telefono");

            Auto autoNuevo = new Auto(patenteAbuscar, marca, anio, nombre, telefono);
         
            return autoNuevo;

        }
    }

    internal class Servicio
    {
        private int numeroDeFactura;
        private string patenteAutoAtendido;
        private string fecha;
        List<trabajo> trabajos;

        public Servicio(int numeroDeFactura, string patenteAutoAtendido, string fecha)
        {
            this.numeroDeFactura = numeroDeFactura;
            this.patenteAutoAtendido = patenteAutoAtendido;
            this.fecha = fecha;
            trabajos = new List<trabajo>();
        }

         public bool NumeroFacturaExiste(int numeroAcomprarar)
        {
            return (numeroDeFactura == numeroAcomprarar);
        }
        
    }

    internal class trabajo
    {
        string descripcion;
        double importe;

        public trabajo(string descripcion, double importe)
        {
            this.descripcion = descripcion;
            this.importe = importe;
        }
    }

    internal class Auto
    {
        private string patente;
        private string marca;
        private string anio;
        private string nombreDuenio;
        private string telefono;

        public Auto(string patente, string marca, string anio, string nombreDuenio, string telefono)
        {
            this.patente = patente;
            this.marca = marca;
            this.anio = anio;
            this.nombreDuenio = nombreDuenio;
            this.telefono = telefono;
        }

        internal string GetPatente()
        {
            return patente;
        }
    }

    internal class Validador
    {
        public string pedirOpcionDeMenu(string mensaje, List<String> opciones)
     
        {
            string opcion = "";
             bool opcionValida = false;

            while (!opcionValida);

            Console.WriteLine(mensaje);
            
            opcion=Console.ReadLine();

            if (!opciones.Contains(opcion)){

                Console.WriteLine("Debe ingresar una ocpion valida");

            }else
            {
                opcionValida=true;
            }

            return opcion;
        }
        public string pedirString(string mensaje)
        {
            string retorno = "";
            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine();
                if (retorno == "")
                {
                    Console.WriteLine("El string no puede estar vacio");
                }
            } while (retorno == "");
            return (retorno);
        }

        public int pedirInteger(string mensaje, int minimo, int maximo)
        {
            int numero = minimo - 1;
            bool pudeConvertir;

            do
            {
                Console.WriteLine(mensaje);
                pudeConvertir = Int32.TryParse(Console.ReadLine(), out numero);
                if (pudeConvertir)
                {
                    if (numero < minimo || numero > maximo)
                    {
                        Console.WriteLine(mensaje);
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un valor numerico");
                    numero = minimo - 1;
                }
            } while (numero < minimo || numero > maximo);

            return numero;
        }

        public double pedirDouble(string mensaje, double minimo, int maximo)
        {
            double retorno = 0;
            do
            {
                Console.WriteLine(mensaje);
                if (Double.TryParse(Console.ReadLine(), out retorno))
                {
                    if (retorno < minimo && retorno > maximo)
                    {
                        Console.WriteLine("El valor debe estar entre " + minimo + " y " + maximo);
                    }
                }
                else
                {
                    retorno = minimo - 1;
                }
            } while (retorno < minimo && retorno > maximo);
            return (retorno);
        }

        public string pedirSoN(string mensaje)
        {
            string retorno = "";
            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine().ToUpper();
                if (retorno != "S" && retorno != "N")
                {
                    Console.WriteLine("El string debe ser S o N");
                }
            } while (retorno != "S" && retorno != "N");
            return (retorno);
        }
    }
}

