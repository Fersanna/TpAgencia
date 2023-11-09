using System;
using System.Collections.Generic;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            AppMaquinas app = new AppMaquinas();
            app.Ejecutar();

        }
    }
    internal class AppMaquinas
    {
        private Validador validador;
        private List<Maquina> maquinas;
        public AppMaquinas()
       


        {
            this.validador = new Validador();
            maquinas = new List<Maquina>();


            Maquina maquina1 = new Maquina("001", "Máquina 1", "Urdido", "Disponible", new List<Evento>(), new List<String>(), "Ninguno");
            maquinas.Add(maquina1);

            Maquina maquina2 = new Maquina("002", "Máquina 2", "Tejeduria", "En mantenimiento", new List<Evento>(), new List<string>(), "Inicio de trabajo");
            maquinas.Add(maquina2);



        }
        internal void Ejecutar()
        {
            string opcion = "";
            List<String> opciones = new List<String>() { "A", "B", "C", "D" };
            do
            {
                opcion = validador.PedirStringEnColeccion("Ingrese A para nueva maquina, B para listar, C para agregar evento y D para salir", opciones);
                if (opcion == "A")
                {
                    ingresarMaquina();
                }
                else if (opcion == "B")
                {
                    listarMaquinasDisponibles();
                }
                else if (opcion == "C")
                {
                    agregarEventoAMaquina();
                }
            } while (opcion != "D");
        }
        private void agregarEventoAMaquina()
        {

            string codigoAbuscar = "";
            List<String> codigosAComparar = new List<String>();
            List<Maquina> maquinasAmodificar = new List<Maquina>();

            codigosAComparar = ImprimeYComparaCodigos(codigosAComparar);

            codigoAbuscar = validador.PedirStringEnColeccion("Ingrese codigo de maquina en la que desea agregar el evento", codigosAComparar);

            Maquina maquinaSeleccionada = maquinas.Find(maquina => maquina.GetCodigo() == codigoAbuscar);

            Console.WriteLine($"la maquina seleccionanda es la siguiente:\n {maquinaSeleccionada}");



        }

        private List<string> ImprimeYComparaCodigos(List<string> codigosAComparar)
        {
            Console.WriteLine("Listado de Máquinas:");
            foreach (Maquina maquina in maquinas)
            {
                Console.WriteLine(maquina.ToString());
                codigosAComparar = maquina.StringCodigoDeMaquinas(maquinas);

            }

            return codigosAComparar;
        }

        private void listarMaquinasDisponibles()
        { //DESARROLLAR

            List<Maquina> MaquinaDiponible = maquinas.FindAll(maquinas => maquinas.EstaDisponible());
            Evento eventoDisponible;

             if (maquinas.Count == 0)
            {
                Console.WriteLine("No hay máquinas disponibles.");
            } 
            else
            {
                Console.WriteLine("Máquinas disponibles:");
                 MaquinaDiponible.ForEach(Console.WriteLine);

                
                
                
               //continuar aca, me falta el momento de agregar un evento en la maquina, en realidad de reemplazarlo

            }
        }
        private void ingresarMaquina()
        { //YA DESARROLLADO
            maquinas.Add(validador.CargarMaquina());
        }


    }

    internal class Maquina
    {
        private string codigo;
        private string nombre;
        private string sector;
        private string estado;
        private List<Evento> eventos;
        private List<string> eventosPosibles;
        private string ultimoEvento;


        public Maquina(string codigo, string nombre, string sector, string estado, List<Evento> eventos, List<String> eventosPosibles, string ultimoEvento)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.sector = sector;
            this.estado = estado;
            this.eventos = new List<Evento>();
            this.ultimoEvento = ultimoEvento;

            eventos.Add(new InicioDeTrabajo(DateTime.Now,"5", 500, "Disponible"));

        }

        public override bool Equals(object obj)
        {
            return obj is Maquina maquina &&
                   codigo == maquina.codigo;
        }

       public void AgregarEvento(Evento evento)
        {
            Evento evantoAagregar = null;

            if (evento is InicioDeTrabajo)
            {
                evento
            }
            eventos.Add(evento);
        }

        public bool EstaDisponible()
        {
            bool EstaDiposnible = true;


            foreach (Evento evento in eventos)
            {
                if (evento is InicioDeTrabajo || evento is EnPreparacion || evento is ParadaMantenimientoEvento)
                {
                    EstaDiposnible = false;
                }
                break;
            }

            return EstaDiposnible;
        }


            


        public override string ToString()
        {
            return $"Código Máquina: {codigo}, Nombre: {nombre}, Sector: {sector} Estado: {estado} Ultimo Evento: {ultimoEvento}";
        }

        public List<String> StringCodigoDeMaquinas(List<Maquina> maquinas)
        {
            List<String> codigos = new List<string>();


            foreach (Maquina maquina in maquinas)
            {
                codigos.Add(maquina.codigo);
            }


            return codigos;
        }

        internal string GetCodigo()
        {
            return codigo;
        }


        public List<string> GetEventosPosibles(Evento evento)
        {
            eventosPosibles = new List<string>();

            if (evento is FinalTrabajoEvento || evento is FinMantenimientoEvento)
            {
                eventosPosibles.Add("A - Inicio de trabajo");
                eventosPosibles.Add("B - Preparacion");
                eventosPosibles.Add("C - Parada");

            }
            else
            {
                eventosPosibles.Add("D - Final de Trabajo");
                eventosPosibles.Add("E - Inicio de Trabajo");
                eventosPosibles.Add("F - Fin de Mantenimiento");
            }


            return eventosPosibles;
        }

        

    }

    internal abstract class Evento
    {

        public DateTime fechaDeInicio;

        public Evento(DateTime fechaDeInicio)
        {

            this.fechaDeInicio = fechaDeInicio;

        }

        abstract public List <String> GetEventosDiponible();

        
    }

    internal class InicioDeTrabajo : Evento
    {
        private string nuemroDeOrden;
        private int cantidadesPlanificadas;
        private string esatdo;

        public InicioDeTrabajo(DateTime fechaDeInicio, string numeroDeOrden, int cantidadesPlanificadas, string estado) : base(fechaDeInicio)
        {
            this.nuemroDeOrden = numeroDeOrden;
            this.cantidadesPlanificadas = cantidadesPlanificadas;
            
        }

        public override List<String> GetEventosDiponible()
        {
            List<String> eventosDiponibles;

            eventosDiponibles =new List<String>() { "Fin de Mantenimiento" };

            Console.WriteLine("Seleccione un evento de la lista:");
            foreach (string evento in eventosDiponibles)
            {
                Console.WriteLine(evento);
            }


            return eventosDiponibles;  
        }

        public bool ProximoEventoEsValido(Evento evento)
        {
            return evento is FinalTrabajoEvento 
        }
       
    }

    internal class FinalTrabajoEvento : Evento
    {
        private int cantidadesProcesadas;
        private string nuemroDeOrden;


        public FinalTrabajoEvento(DateTime fechaDeInicio, string numeroDeOrden, int cantidadesProcesadas) : base(fechaDeInicio)
        {
            this.cantidadesProcesadas = cantidadesProcesadas;
            this.nuemroDeOrden = numeroDeOrden;
        }
        public override List<String> GetEventosDiponible()
        {
            List<String> eventosDiponibles;

            eventosDiponibles = new List<String>() { "INICIO", "PREPARACION", " PARADA" };

            Console.WriteLine("Seleccione un evento de la lista:");
            foreach (string evento in eventosDiponibles)
            {
                Console.WriteLine(evento);
            }


            return eventosDiponibles;
        }
    }

    internal class EnPreparacion : Evento
    {

        private string nuemroDeOrden;


        public EnPreparacion(DateTime fechaDeInicio, string numeroDeOrden) : base(fechaDeInicio)
        {

            this.nuemroDeOrden = numeroDeOrden;
        }

        public override List<String> GetEventosDiponible()
        {
            List<String> eventosDiponibles;

            eventosDiponibles = new List<String>() { "INICIO" };

            Console.WriteLine("Seleccione un evento de la lista:");
            foreach (string evento in eventosDiponibles)
            {
                Console.WriteLine(evento);
            }


            return eventosDiponibles;
        }

    }

    internal class ParadaMantenimientoEvento : Evento
    {
        private string motivoParada;

        public ParadaMantenimientoEvento(DateTime fechaHoraInicio, string motivoParada)
           : base(fechaHoraInicio)
        {
            this.motivoParada = motivoParada;
        }

        public override List<String> GetEventosDiponible()
        {
            List<String> eventosDiponibles;

            eventosDiponibles = new List<String>() { "FIN MANTENIMIENTO" };

            Console.WriteLine("Seleccione un evento de la lista:");
            foreach (string evento in eventosDiponibles)
            {
                Console.WriteLine(evento);
            }


            return eventosDiponibles;
        }


    }

    internal class FinMantenimientoEvento : Evento
    {
        public FinMantenimientoEvento(DateTime fechaHoraInicio)
            : base(fechaHoraInicio)
        {
        }

        public override List<String> GetEventosDiponible()
        {
            List<String> eventosDiponibles;

            eventosDiponibles = new List<String>() { "INICIO", "PREPARACION","PARADA" };

            Console.WriteLine("Seleccione un evento de la lista:");
            foreach (string evento in eventosDiponibles)
            {
                Console.WriteLine(evento);
            }


            return eventosDiponibles;
        }

    }

    internal class Validador
    {
        internal string PedirStringEnColeccion(string mensaje, List<string> opciones)
        {

            string opcionElegida;

            do
            {
                Console.WriteLine(mensaje);

                opcionElegida = Console.ReadLine().ToUpper();


                if (!opciones.Contains(opcionElegida.ToUpper()))
                {
                    Console.WriteLine("Debe elegir una opcion valida");
                }

            } while (!opciones.Contains(opcionElegida.ToUpper()));

            return opcionElegida;
        }
        internal string PedirStringNoVacio(string mensaje)
        { //YA DESARROLLADO
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
        internal int PedirInt(string mensaje, int minimo, int maximo)
        { //YA DESARROLLADO
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

            return retorno;
        }

         internal Maquina CargarMaquina()
        {
            Maquina nuevaMaquina = null;
            List<Evento> eventos = new List<Evento>();
            List<String> opcionesSector = new List<String>() { "A", "B","C" };
            
            

            string codigo = PedirStringNoVacio("Ingrese el código de la máquina:");
            string nombre = PedirStringNoVacio("Ingrese el nombre de la máquina:");
            string sector = PedirStringEnColeccion("Ingrese el sector de la máquina:\nA-Sector Urdido\nB-Sector Tejeduria\nC-Sector Terminacion", opcionesSector);
            string estado = "";//No lo ingresa el usuario, hay que realizar una logica y se determina de acuerdo al ultimo evento.

          
            


            nuevaMaquina = new Maquina(codigo, nombre, sector, estado, new List<Evento>(), new List<string>(), "Ninguno");

            Console.WriteLine("La maquina se agrego exitosamente");
          
            return nuevaMaquina;
        }
    
    
       
    
    }


}
