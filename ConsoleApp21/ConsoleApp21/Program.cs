using System;

namespace ConsoleApp21
{
    class Program
    {
        public const string estIngresada = "I";
        public const string estCotizada = "C";
        public const string estTerminada = "T";
        public const string estEntregada = "E";
        public const long docMin = 1000000;
        public const long docMax = 99999999;
        public const long preMin = 0;
        public const long preMax = 99999;
        public const long numMin = 1;
        public const long numMax = 40000;




        static void Main(string[] args)
        {
            long [] docCliente = new long[numMax];
            string []problema= new string[numMax];
            string [] solucion= new string[numMax];
            long [] precio= new long[numMax];
            string[] estado= new string[numMax];

            string opcion = "";

            CargaInicial(docCliente, problema, solucion, precio, estado);

            do
            {
                do
                {

                    opcion = PedirStringNoVacio("1-Ingresar Nueva Reparación\n 2-Cotizar Reparación\n 3-Terminar Reparación\n 4-Entregar Reparación\n, 5-Salir\n");

                    if (opcion == "1")
                    {
                        int filaVacia = BuscarEspacioEnArreglo(docCliente);

                        if (filaVacia == -1)
                        {
                            Console.WriteLine("No existe espacio para una nueva carga");
                        }

                    }else
                    {
                        long numeroDeDocumentoAAgregar = PedirLongEnRango("Por favor ingrese su numero de doc", 0, 5000000);
                        string problemaAAgregar = PedirStringNoVacio("Por favor ingrese el problema:");

                        int numeroDeReparacionAAgregar = ObtenerUltimoNumeroDeReparacion() + 1;
                    }




                } while (filaVacia == -1);

            }while (opcion != "5");
            
            

        }

        private static int ObtenerUltimoNumeroDeReparacion()
        {
            throw new NotImplementedException();
        }

        private static int BuscarEspacioEnArreglo(long[] docCliente)
        {
            int retorno = -1;

            for (int i = 0; i < docCliente.GetLowerBound(0) && retorno!=-1; i++)
            {
                if (docCliente[i] == 0)
                {
                    retorno = i;
                }

            }
            return retorno;

        }

        private static long PedirLongEnRango(string mensaje, int minimo, int maximo)
        {
            long numero;
            do
            {
                Console.WriteLine(mensaje);
                if (!long.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Debe ingresar un numero");
                }
                else if (numero > maximo || numero < minimo)
                {
                    Console.WriteLine("El numero debe estar dentro de" + minimo + "y" + maximo);
                }
            }
            while (numero > maximo || numero < minimo);

            return numero;
        }

        private static string PedirStringNoVacio(string mensaje)
        {
            throw new NotImplementedException();
        }

        public static void CargaInicial(long[] docCliente, string[] problema, string[] solucion, long[] precio, string[] estado)
        {
            docCliente[0] = 22551805;
            problema[0] = "El reloc no funca para nada";
            solucion[0] = "Busca un tecnicoooo";
            precio[0] = 80000;
            estado[0] = estIngresada;
            docCliente[1] = 50000000;
            problema[1] = "El reloc no funca para nada";
            solucion[1] = "Busca un tecnicoooo";
            precio[1] = 82000;
            estado[1] = estIngresada;

            
        }
    }
}
