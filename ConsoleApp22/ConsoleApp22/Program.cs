using System;

namespace ConsoleApp22
{
    class Program
    {

       

        static void Main(string[] args)
        {
            NotaDeRecepcion[] notaDeRecepcions = new NotaDeRecepcion[100];
            Item[] items = new Item[5];
            Articulo[] articulos = new Articulo[50];

            string opcion = "";
            cargaInicialDeArticulos(articulos);

            do
            {
                opcion = pedirYvalidarString("ingrese\n A-Carga de Nota\n B-Consultar Nota\n C-Salir");

                if (opcion == "A")
                {
                    ingresarNota(notaDeRecepcions, articulos);

                } else if (opcion == "B")
                {
                     consultarNota(notaDeRecepcions);
                }

            } while (opcion != "C");

        }

        private static void consultarNota(NotaDeRecepcion[] notaDeRecepcions)
        {
            throw new NotImplementedException();
        }

        private static void ingresarNota(NotaDeRecepcion[] notaDeRecepcions, Articulo[] articulos)
        {
            int filaVacia = buscarFilaVacia(notaDeRecepcions);
            string confirmar = "";

            if (filaVacia == -1)
            {
                Console.WriteLine("No hay lugar para cargar mas notas");
            } else  {
                
                NotaDeRecepcion notaAAgregar = pedirYvalidarNota (notaDeRecepcions, articulos);
                notaDeRecepcions[filaVacia] = notaAAgregar;
                confirmar=pedirYvalidarString("Confirma esta nota\n " + stringDeNota(notaDeRecepcions)+"\ningresar S para confirmar").ToUpper();

                if (confirmar == "S")
                {
                    notaDeRecepcions[filaVacia] = notaAAgregar;
                }
            }

        }

        private static string stringDeNota(NotaDeRecepcion[] notaDeRecepcions)
        {
            string retorno = "";

            for (int i = 0; i < notaDeRecepcions.GetUpperBound(0); i++)
            {
                if (notaDeRecepcions[i] != null)
                {
                    retorno = retorno + notaDeRecepcions[i].Fecha + "\n" +notaDeRecepcions[i].NumeroOrden + "\n" +notaDeRecepcions[i].NombreReceptor + "\n" +notaDeRecepcions[i].Origen;
                }
            }

            return retorno;
        }

        private static NotaDeRecepcion pedirYvalidarNota(NotaDeRecepcion[] notaDeRecepcions, Articulo[] articulos)
        {
            string nombreReceptor = "";
            int numeroOrden = 0;
            string fecha = "";
            string origen = "";
            Item[] items = new Item[5];

                       

            NotaDeRecepcion notaAAgregar = new NotaDeRecepcion(nombreReceptor, numeroOrden, fecha, origen, items);

            notaAAgregar.NombreReceptor = pedirYvalidarString("ingrese el nombre del receptor");
            notaAAgregar.NumeroOrden = obtenerNumeroDeOrden(notaDeRecepcions);
            notaAAgregar.Fecha=DateTime.Now.ToString();
            notaAAgregar.Origen = pedirYvalidarString("ingresar origen de la mercaderia");
           

            return notaAAgregar;
        }

        private static void cargaInicialDeArticulos(Articulo[] articulos)
        {
            articulos[0] = new Articulo("SILL001", "SILLA");
            articulos[1] = new Articulo("MES001", "MESA");
        }

        private static string pedirYvalidarString(string mensaje)
        {
            string retorno = "";

            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine().ToUpper();

                if (retorno == "")
                {
                    Console.WriteLine("Debe ingresar algo");
                }

            }while (retorno == "");

            return retorno;
            
        }

        private static int buscarFilaVacia (NotaDeRecepcion [] notaDeRecepcions)
        {
            int retorno = -1;

            for (int i = 0; i < notaDeRecepcions.GetUpperBound(0) && retorno==-1; i++)
            {
                if (notaDeRecepcions[i] == null)
                {
                    retorno = i;
                }
            }
            return retorno;
        }

        private static int  obtenerNumeroDeOrden (NotaDeRecepcion[] notaDeRecepcions)
        {

            int numeroNotaAAgregar = obtenerMaximoDeOrden(notaDeRecepcions);
            
                       
            if (numeroNotaAAgregar == -1)
            {
                numeroNotaAAgregar = pedirIntegerEnRango("ingresar numero de nota", 0, 100);
            }else
            {
                numeroNotaAAgregar = numeroNotaAAgregar + 1;
            }
                                  

            return numeroNotaAAgregar;
        }

        private static int pedirIntegerEnRango(string mensaje, int min, int max)
        {
            int retorno = -1;

            do
            {
                Console.WriteLine(mensaje);

                if (!Int32.TryParse(Console.ReadLine(), out retorno))
                {
                    Console.WriteLine("Debe ingresar un numero");
                }
                else if (retorno > max || retorno < min)
                {
                    Console.WriteLine("El numero a ingresar debe estar dentro del rando de" + min + "y" + max);
                }
            } while (retorno > max || retorno < min);

            return retorno;
        }

        private static int obtenerMaximoDeOrden(NotaDeRecepcion[] notaDeRecepcions)
        {
            int retorno = -1;

            for (int i = 0; i < notaDeRecepcions.GetUpperBound(0); i++)
            {
                if (notaDeRecepcions != null && notaDeRecepcions[i] != null && notaDeRecepcions[i].NumeroOrden > retorno)
                {
                    retorno = notaDeRecepcions[i].NumeroOrden;
                }
            }


            return retorno;
        }
    }
}