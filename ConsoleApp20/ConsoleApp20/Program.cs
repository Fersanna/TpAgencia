using System;

namespace ConsoleApp20
{
    class Program

    {
        const int cantidadOrdenes = 100;
        const int cantidadItems = 5;
        const int cantidadArticulos = 0;

        static void Main(string[] args)
        {
            string[] articuloNombre = new string[] { "Lapiz", "Marcador", "Otros" };
            string[] articuloCodigo = new string[] { "Lap", "Mar", "Ot" };

            string[] cabeceraFecha = new string[cantidadOrdenes];
            int[] cabeceraNumero = new int[cantidadOrdenes];
            string[] cabeceraProveedor = new string[cantidadOrdenes];


            string[,] itemCodigo = new string[cantidadOrdenes, cantidadItems];
            int[,] itemCantidad = new int[cantidadOrdenes, cantidadItems];
            double[,] itemPrecio = new double[cantidadOrdenes, cantidadItems];
            double[,] itemSubtotal = new double[cantidadOrdenes, cantidadItems];

            string opcionElegida = "";

          

            do
            {
                opcionElegida = pedirStringNoVacio(" 1-Agregar\n 2-Buscar");
                if (opcionElegida == "1")
                {
                    ingresarOrdenDeCompra(articuloCodigo, articuloNombre, cabeceraFecha, cabeceraNumero,


                                cabeceraProveedor, itemCodigo, itemCantidad, itemPrecio, itemSubtotal);
                }
                else if (opcionElegida == "2")
                {

                }
                else if (opcionElegida == "3")
                {

                }
            } while (opcionElegida != "4");

        }

        private static void ingresarOrdenDeCompra(string[] articuloCodigo, string[] articuloNombre, string[] cabeceraFecha, int[] cabeceraNumero, string[] cabeceraProveedor, string[,] itemCodigo, int[,] itemCantidad, double[,] itemPrecio, double[,] itemSubtotal)
        {
            int filaVacia = buscarFilaVacia(cabeceraNumero, null);
            int cabeceraNumeroAAgregar;
            string proveedorAAgregar = "";
            int filaOrdenDeCompra = 0;

            if (filaVacia == -1)
            {
                Console.WriteLine("No hay lugar para mas odenes de compras");
            }
            else
            {
                do
                {
                    cabeceraNumeroAAgregar = pedirInteger("Ingrese numero de orden de compra", 0, 100);
                    filaOrdenDeCompra = buscarEnInteger(cabeceraNumero, cabeceraNumeroAAgregar);

                    if (filaOrdenDeCompra != -1)
                    {
                        Console.WriteLine("Esa orden de compra ya fue ingresada");
                    }
                } while (filaOrdenDeCompra != -1);


                proveedorAAgregar = pedirStringNoVacio("ingrese nombre de proveedor");
                cabeceraNumero[filaVacia] = filaOrdenDeCompra;
                cabeceraFecha[filaVacia] = DateTime.Now.ToString();
                cabeceraProveedor[filaVacia] = proveedorAAgregar;

                ingresarItemsDeOrden(filaVacia, articuloCodigo, articuloNombre, itemCodigo, itemPrecio, itemCantidad, itemSubtotal);

            }

        }

        private static void ingresarItemsDeOrden(int filaVacia, string[] articuloCodigo, string[] articuloNombre, string[,] itemCodigo, double[,] itemPrecio, int[,] itemCantidad, double[,] itemSubtotal)
        {
            int contador = 0;
            string confirmar = "";
            do
            {
                cargarItemsDeOrden(filaVacia, contador, articuloCodigo, articuloNombre, itemCodigo, itemPrecio, itemCantidad, itemSubtotal);
                confirmar = pedirSoN("Ingrese S para continuar o N para terminar");

            } while (contador < articuloCodigo.GetUpperBound(0) && confirmar == "S");


        }

        private static void cargarItemsDeOrden(int filaVacia, int contador, string[] articuloCodigo, string[] articuloNombre, string[,] itemCodigo, double[,] itemPrecio, int[,] itemCantidad, double[,] itemSubtotal)
        {
            int filaItem = 0;
            string articuloAAgregar = "";

            do
            {
                articuloAAgregar = pedirStringNoVacio("Ingrese Codigo Articulo\n" + listadoDeArticulos(articuloNombre, articuloCodigo));
                filaItem = buscarEnString(articuloCodigo, articuloAAgregar);

                if (filaItem == -1)
                {
                    Console.WriteLine("El articulo no existe");
                }
            } while (filaItem == -1);

            double precioAIngresar = pedirDouble("ingrese el precio", 0, 1000000);
            int cantidadAIngresar = pedirInteger("ingrese cantidad", 0, 1000);

            itemCodigo[filaVacia, contador] = articuloAAgregar;
            itemCantidad[filaVacia, contador] = cantidadAIngresar;
            itemPrecio[filaVacia, contador] = precioAIngresar;
            itemSubtotal[filaVacia, contador] = cantidadAIngresar * precioAIngresar;



        }

        private static string listadoDeArticulos(string[] articuloNombre, string[] articuloCodigo)
        {
            string retorno = "";

            for (int i = 0; i < articuloCodigo.GetUpperBound(0); i++)
            {
                if (articuloCodigo[i] != null)
                {
                    retorno = retorno + "Nombres\t" + articuloNombre[i] + "Codigos\t" + articuloCodigo[i] + "\n";
                }
            }

            return retorno;
        }

        private static double pedirDouble(string mensaje, int min, int max)
        {
            double retorno;

            do
            {
                Console.WriteLine(mensaje);
                if (!double.TryParse(Console.ReadLine(), out retorno))
                {
                    Console.WriteLine("debe ingresar un numero");
                }
                else if (retorno > max || retorno < min)
                {
                    Console.WriteLine("Debe ingresar un numero dentro del rando de " + min + "y" + max);

                }
            } while (retorno > max || retorno < min);




            return retorno;
        }

        private static int buscarEnString(string[] articuloCodigo, string articuloAAgregar)
        {
            int retorno = -1;

            for (int i = 0; i < articuloCodigo.GetUpperBound(0); i++)
            {
                if (articuloCodigo[i] != null && articuloCodigo[i] == articuloAAgregar)
                {
                    retorno = i;
                }
            }
            return retorno;
        }


        private static string pedirSoN(string mensaje)
        {
            string respuesta;
            do
            {
                Console.WriteLine(mensaje);
                respuesta = Console.ReadLine().ToUpper();
                if (respuesta != "S" && respuesta != "N")
                {
                    Console.WriteLine("Respuesta inválida. Por favor, ingrese 'S' o 'N'");
                }
            } while (respuesta != "S" && respuesta != "N");
            return respuesta;
        }

        private static string pedirStringNoVacio(string mensaje)
        {
            string retorno = "";
            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine();

                if (retorno == "")
                {
                    Console.WriteLine("ingrese algun valor");
                }
            } while (retorno == "");

            return retorno;
        }

        private static int buscarEnInteger(int[] cabeceraNumero, int cabeceraNumeroAAgregar)
        {
            int retorno = -1;

            for (int i = 0; i < cabeceraNumero.GetUpperBound(0); i++)
            {
                if (cabeceraNumero[i] == cabeceraNumeroAAgregar)
                {
                    retorno= i;
                }
            }

            return retorno;
        }

        private static int pedirInteger(string mansaje, int min, int max)
        {
            int retorno;

            do
            {
                Console.WriteLine(mansaje);
                if (!Int32.TryParse(Console.ReadLine(), out retorno))
                {
                    Console.WriteLine("debe ingresar un numero");
                }
                else if (retorno > max || retorno < min)
                {
                    Console.WriteLine("Debe ingresar un numero dentro del rando de " + min + "y" + max);

                }
            } while (retorno > max || retorno < min);

            return retorno;
        }

        private static int buscarFilaVacia(int[] cabeceraNumero, object p)
        {
            int retorno = -1;

            for (int i = 0; i < cabeceraNumero.GetUpperBound(0); i++)
            {
                if (cabeceraNumero[i]== 0 && retorno ==-1)
                {
                    retorno = i;
                }
            }
            return retorno;
        }
    }
}
