using System;
using System.Collections.Generic;

namespace ConsoleApp36
{
    internal class AppMaquinas
    {
        private Validador validador;
        private List<Maquina> maquinas;
        public AppMaquinas()
        {
            this.validador = new Validador();
            maquinas = new List<Maquina>();

            maquinas.Add(new Maquina("MA1", "MAQUINA 1", "D"));
            maquinas.Add(new Maquina("MA2", "MAQUINA 2", "ND"));

        }

        internal void Ejecutar()
        {
            string opcion = "";
            List<String> opciones = new List<String>() { "A", "B", "C", "D" };

            do
            {
                opcion = validador.pedirStringEnColeccion("Ingrese A para nueva maquina, B para listar, C para agregar evento y D para salir", opciones);
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
            //Se muestran todas las maquinas para luego pedir el codigo con la que se va a trabajar.
            string codigoAbuscar = "";
            string estadoMaquina = "";
            List<String> opcionesEventos = new List<string>() {"1","2","3","4","5" };
            string opcion = "";

            foreach (Maquina maquina in maquinas)
            {
                Console.WriteLine(maquina.ToString());
            }

            codigoAbuscar = validador.PedirStringNoVacio("Ingrese el codigo maquina a para agregar evento");

            Maquina maquinaAmodificar = maquinas.Find(maquina => maquina.GetCodigo() == codigoAbuscar);

            if (maquinaAmodificar == null)
            {
                Console.WriteLine("No se encontró una máquina con el código especificado.");
            }
            else
            {
                // Continuar con la lógica para agregar un evento a la máquina.
                estadoMaquina = maquinaAmodificar.GetEstado();

                Console.WriteLine($"El estado de la maquina es : { estadoMaquina}");
            }
                                  
            Console.WriteLine("Seleccione un evento para agregar:");
            Console.WriteLine("1. Inicio de Trabajo");
            Console.WriteLine("2. Final de Trabajo");
            Console.WriteLine("3. Preparacion");
            Console.WriteLine("4. Parada por Mantenimiento");
            Console.WriteLine("5. Fin de Mantenimiento");

            opcion = validador.pedirStringEnColeccion("Ingrese Evento a Agregar", opcionesEventos);

            if (opcion == "2")
            {
                Evento eventoAAgregar = new Final("", "", 0);

                if (!maquinaAmodificar.SePuedeAgregar(eventoAAgregar))
                {
                    Console.WriteLine("Ese evento no puede ser agregado");
                }

                else
                {string fecha=DateTime.Now.ToString();
                    string nuemro = validador.PedirStringNoVacio("Ingrese numero");
                    int cantidades = validador.PedirInteger("ingrese cantidad", 0, 100);

                    eventoAAgregar = new Final(fecha, nuemro, cantidades);
                }
            }



        }


        private void listarMaquinasDisponibles()
        {
            List<Maquina> maquinasDisponibles = maquinas.FindAll(maquina => maquina.EstaDisponible());
         
            if (maquinasDisponibles.Count == 0)
            {
                Console.WriteLine("No hay maquinas disponibles.");
            }
            else
            {
                Console.WriteLine("Maquinas disponibles:");
                foreach (Maquina maquina in maquinasDisponibles)
                {
                    Console.WriteLine(maquina.ToString());
                }
            }
        }

        private void ingresarMaquina()
        {
            //para elegir sectores convenia hacer una lista de string con 3 opciones y aramr el menu.
            string codigoAAgregar = "";
            string nombreAAgregar = "";
            string estado = "D";
            List<String> opciones;//aca ponia A, B Y C EN VEZ DE USAR EL GetSector (Una tontera)
            string sectorElegido;

            Maquina AAgregar = null;

            do
            {
                codigoAAgregar = validador.PedirStringNoVacio("Ingrese codigo de Maquina");
                nombreAAgregar = validador.PedirStringNoVacio("Ingrese nombre de la Maquina");

                AAgregar = new Maquina(codigoAAgregar, nombreAAgregar, estado);

                if (maquinas.Contains(AAgregar))
                {
                    Console.WriteLine("Esa maquina ya fue agregada");
                }

            } while (maquinas.Contains(AAgregar));


            opciones= new List<string> { "A", "B", "C"};//necesito un String con los sectores, para poder elegir cual

            string sectoresString = AAgregar.StringDeSectores();
            Console.WriteLine("Sectores disponibles:\n " + sectoresString);


            sectorElegido = validador.pedirStringEnColeccion("Ingrese sector", opciones);

            AAgregar.SetSector(sectorElegido);

            maquinas.Add(AAgregar);
        }


    }
}