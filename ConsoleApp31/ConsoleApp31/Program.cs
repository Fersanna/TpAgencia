using System;
using System.Collections.Generic;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            AppInmubles app = new AppInmubles();
            app.Ejecutar();
        }
    }

    internal class AppInmubles
    {
        List<Inmueble> inmuebles;
        List<Concepto> conceptos;
        Validador validador;

        public AppInmubles()
        {
            this.inmuebles = new List<Inmueble>();
            this.conceptos = new List<Concepto>();
            this.validador = new Validador();
        }



        internal void Ejecutar()
        {
            // Agregar 3 inmuebles de ejemplo
            Inmueble inmueble1 = new Propio("COD1", "Inmueble 1", DateTime.Now.ToString(), 100000, 120, 120);
            Inmueble inmueble2 = new Propio("COD2", "Inmueble 2", DateTime.Now.ToString(), 150000, 180, 180);
            Inmueble inmueble3 = new DeTerceros("Legal 1", 5000, 12, 12, "COD3", "Inmueble 3", DateTime.Now.ToString());

            inmuebles.Add(inmueble1);
            inmuebles.Add(inmueble2);
            inmuebles.Add(inmueble3);

            // Agregar 3 conceptos de ejemplo
            Concepto concepto1 = new ConceptoPropio("CON1", "Gaestion de renovacion", 3, 50);
            Concepto concepto2 = new ConceptoPropio("CON2", "Limpieza y pintura",  1, 500);
            Concepto concepto3 = new ConceptoTerceros("CON3", "Control anual plomeria", 12, 800);

            conceptos.Add(concepto1);
            conceptos.Add(concepto2);
            conceptos.Add(concepto3);


            String opcion = "";

            do
            {
                opcion = validador.PedirStringNoVacio("Ingrese opcion de menu:\nA- Nuevo Inmueble\nB- Nuevo concepto\nC-Mostrar Listado para presupuesto\nD-Salir");
                if (opcion == "A")
                {
                    IngresarInmueble();
                }
                else if (opcion == "B")
                {
                    IngresarConcepto();
                }
                else if (opcion == "C")
                {
                    ListadoParaPresupuesto();
                }


            } while (opcion != "D");

        }

        private void ListadoParaPresupuesto()
        {
            Console.WriteLine("Presupuesto:");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Código de Edificio | Nombre de Edificio | Amortización | Alquileres | Gastos Adicionales ");
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            foreach (Inmueble inmueble in inmuebles)
            {
                string codigoEdificio = inmueble.GetCodigoDisponible();
                string nombreEdificio = inmueble.GetNombre();

                double amortizacion = inmueble.GetAmortizacion();
                double alquileres = inmueble.GetAlquiler();
                double gastosAdicionales = 0;

                foreach (Concepto concepto in conceptos)
                {
                    if (inmueble is Propio && concepto is ConceptoPropio)
                    {
                        gastosAdicionales += concepto.CalcularGasto();
                    }
                    else if (inmueble is DeTerceros && concepto is ConceptoTerceros)
                    {
                        gastosAdicionales += concepto.CalcularGasto();
                    }
                }

                Console.WriteLine(codigoEdificio + "\t\t\t | " + nombreEdificio + " \t| " + amortizacion + "\t | " + alquileres + " | " + gastosAdicionales);
                Console.WriteLine("------------------------------------------------------------------");
            }
        }


        private void IngresarConcepto()
        {
            conceptos.Add(validador.CargarConcepto(conceptos));
        }

        private void IngresarInmueble()
        {
            inmuebles.Add(validador.CargarInmueble(inmuebles));

        }

    }

    internal class Validador
    {
        internal Inmueble CargarInmueble(List<Inmueble> inmuebles)
        {

            Inmueble nuevoInmueble = null;
            string tipo = "";
            string codigoAComparar;
            string nombre;
            string fecha;
            bool inmuebleExiste = false;

            do
            {
                tipo = PedirStringNoVacio("A- Si desea cargar un inmueble propio\nB- Cargar inmueble no propio");

                if (tipo != "A" && tipo != "B")
                {
                    Console.WriteLine("Debe ingresar A o B");
                }
            } while (tipo != "A" && tipo != "B");

            codigoAComparar = PedirStringNoVacio("Ingrese código de inmueble");
            nombre = PedirStringNoVacio("Ingrese el nombre del edificio");
            fecha = DateTime.Now.ToString();

            //validar que el inmueble que intento agregar no exista para poder cargarlo

            if (inmuebles != null)
            {
                inmuebleExiste = inmuebles.Exists(i => i != null && i.GetCodigoDisponible() == codigoAComparar);
            }


            if (inmuebleExiste == inmuebles.Exists(i => i.GetCodigoDisponible() == codigoAComparar))

                if (inmuebleExiste)
                {
                    Console.WriteLine("El inmueble ya existe en la lista.");
                }
                else

               if (tipo == "A")
                {
                    double valorInicial = PedirDouble("Ingrese el valor inicial del inmueble: ", 0, 1000);
                    int mesesVidaUtil = PedirInteger("Ingrese los meses de vida útil del inmueble: ", 0, 10000);
                    int mesesRestantes = PedirInteger("Ingrese los meses restantes del inmueble: ", 0, mesesVidaUtil);

                    Propio propio = new Propio(codigoAComparar, nombre, fecha, valorInicial, mesesVidaUtil, mesesRestantes);
                    inmuebles.Add(propio);
                }
                else if (tipo == "B")
                {
                    string nombreLegal = PedirStringNoVacio("Ingrese el nombre legal del inmueble de terceros: ");
                    double feeMensual = PedirDouble("Ingrese el fee mensual del inmueble de terceros: ", 0, double.MaxValue);
                    int mesesTotalesAlq = PedirInteger("Ingrese los meses totales de alquiler del inmueble de terceros: ", 0, int.MaxValue);
                    int mesesRestantes = PedirInteger("Ingrese los meses restantes del inmueble de terceros: ", 0, int.MaxValue);

                    DeTerceros tercero = new DeTerceros(nombreLegal, feeMensual, mesesTotalesAlq, mesesRestantes, codigoAComparar, nombre, fecha);

                }

            return nuevoInmueble;
        }

        internal string PedirStringNoVacio(string mensaje)
        {
            string retorno = "";

            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine();

                if (retorno == "")
                {
                    Console.WriteLine("Por favor ingresar alguna opción válida");
                }
            } while (retorno == "");

            return retorno.ToUpper();
        }

        internal double PedirDouble(string mensaje, double minimo, double maximo)
        {
            double retorno = 0;

            do
            {
                Console.WriteLine(mensaje);

                if (!Double.TryParse(Console.ReadLine(), out retorno))
                {
                    Console.WriteLine("Debe ingresar un valor numérico");
                }
                else if (retorno < minimo || retorno > maximo)
                {
                    Console.WriteLine("El número a ingresar debe estar entre " + minimo + " y " + maximo);
                }
            } while (retorno < minimo || retorno > maximo);

            return retorno;
        }

        internal int PedirInteger(string mensaje, int minimo, int maximo)
        {
            int retorno = 0;

            do
            {
                Console.WriteLine(mensaje);

                if (!Int32.TryParse(Console.ReadLine(), out retorno))
                {
                    Console.WriteLine("Debe ingresar un valor numérico");
                }
                else if (retorno < minimo || retorno > maximo)
                {
                    Console.WriteLine("El número a ingresar debe estar entre " + minimo + " y " + maximo);
                }
            } while (retorno < minimo || retorno > maximo);

            return retorno;
        }

        internal Concepto CargarConcepto(List<Concepto> conceptos)
        {

            Concepto nuevoConcepto = null;
            string codigoAIngresar = "";
            bool conceptoExiste = false;
            string nombre = "";
            string tipo = "";
            bool aplicaApropios = false;
            bool aplicaAterceros = false;
            int mesesRestantes = 0;
            double importe = 0;

            codigoAIngresar = PedirStringNoVacio("ingrese el codigo para el concepto que desea ingresar");


            conceptoExiste = conceptos.Exists(i => i.GetCodigoConcepto() == codigoAIngresar);

            if (conceptoExiste)
            {
                Console.WriteLine("El concepto existe");
            }

            else
            {
                nombre = PedirStringNoVacio("Ingrese nombre del concepto");
            }

            do
            {
                tipo = PedirStringNoVacio("Ingrese P para inmuebles propios o T para inmuebles de terceros");

                if (tipo != "P" && tipo != "T")
                {
                    Console.WriteLine("Debe ingresar P o T");
                }
            } while (tipo != "P" && tipo != "T");

            if (tipo == "P")
            {
                aplicaApropios = true;

                mesesRestantes = PedirInteger("ingrese meses restantes para el concepto", 0, 12);

                importe = PedirDouble("ingrese el importe a imputar", 0, 99999);

                nuevoConcepto =new ConceptoPropio(codigoAIngresar, nombre, mesesRestantes, importe);


            }

            else if (tipo == "T")
            {
                aplicaAterceros = true;

                mesesRestantes = PedirInteger("ingrese meses restantes para el concepto", 0, 12);

                importe = PedirDouble("ingrese el importe a imputar", 0, 99999);

                nuevoConcepto = new ConceptoTerceros(codigoAIngresar, nombre,  mesesRestantes, importe);
            }


            return nuevoConcepto;
        }
    }


    internal abstract class Concepto
    {
        private string codgido;
        private string nombre;
        private int mesesRestantes;
       

        public Concepto(string codgido, string nombre, int mesesRestantes)
        {
            this.codgido = codgido;
            this.nombre = nombre;
            this.mesesRestantes = mesesRestantes;
            
        }

        internal string GetCodigoConcepto()
        {
            return codgido;
        }

        public abstract double CalcularGasto();


    }

    internal abstract class Inmueble
    {
        private string codigo;
        private string nombre;
        private string fechaAlta;

        public Inmueble(string codigo, string nombre, string fecha)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.fechaAlta = fecha;
        }

        public override bool Equals(object obj)
        {
            return obj is Inmueble inmueble &&
                   codigo == inmueble.codigo &&
                   nombre == inmueble.nombre;

        }

        public string GetCodigoDisponible()
        {
            return codigo;
        }

        public string GetNombre()
        {
            return nombre;
        }

        abstract public double GetAmortizacion();

        abstract public double GetAlquiler();
    }

    internal class Propio : Inmueble
    {
        private double valorInicial;
        private double mesesVidaUtil;
        private int mesesRestantes;


        public Propio(string codigo, string nombre, string fecha, double valorInicial, double mesesVidaUtil, int mesesRestantes) : base(codigo, nombre, fecha)
        {
            this.valorInicial = valorInicial;
            this.mesesVidaUtil = mesesVidaUtil;
            this.mesesRestantes = mesesRestantes;
        }

        public override double GetAlquiler()
        {
            return 0;
        }

        public override double GetAmortizacion()
        {
            return (valorInicial / mesesVidaUtil);
        }

    }

    internal class DeTerceros : Inmueble
    {
        private string nombreLegal;
        private double feeMensual;
        private int mesesTotalesAlq;
        private int mesesRestantes;

        public DeTerceros(string nombreLegal, double feeMensual, int mesesTotalesAlq, int mesesRestantes, string codigo, string nombre, string fecha) : base(codigo, nombre, fecha)
        {
            this.nombreLegal = nombreLegal;
            this.feeMensual = feeMensual;
            this.mesesTotalesAlq = mesesTotalesAlq;
            this.mesesRestantes = mesesRestantes;
        }

        public override double GetAlquiler()
        {
            return feeMensual;
        }

        public override double GetAmortizacion()
        {
            return 0;
        }
    }

    internal class ConceptoPropio : Concepto
    
    {
        private double importe;

      public ConceptoPropio(string codgido, string nombre, int mesesRestantes, double importe) : base(codgido, nombre, mesesRestantes)
        {
            this.importe= importe;
        }

        public double GetImporte()
        {
            return importe;
        }

        public override double CalcularGasto()
        {
            return GetImporte();
        }
    }



    internal class ConceptoTerceros : Concepto

    {
        private double importe;

        public ConceptoTerceros (string codgido, string nombre, int mesesRestantes, double importe) : base(codgido, nombre, mesesRestantes)
        {
            this.importe = importe;
        }

        public double GetImporte()
        {
            return importe;
        }

        public override double CalcularGasto()
        {
            return GetImporte();
        }
    }

}
