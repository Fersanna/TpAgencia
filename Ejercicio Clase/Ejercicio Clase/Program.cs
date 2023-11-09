using System;

namespace Ejercicio_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            const int columnaCodigoProducto = 0;
            const int columnaNombreProducto = 1;
            const int columnaCodigoCliente = 0;
            const int columnaNombreCliente = 1;
            const int cantidadLineasFactura = 1000;

            string[,] clientes = new string[100, 2];
            string[,] productos = new string[10, 2];
            double[,] analisis = new double[100, 10];

            int[] lineaFacturaNumeroFactura = new int[cantidadLineasFactura];
            string[] lineaFacturaCodigoArticulo = new string[cantidadLineasFactura];
            string[] lineaFacturaCodigoCliente = new string[cantidadLineasFactura];
            int[] lineaFacturaCantidad = new int[cantidadLineasFactura];
            double[] lineaFacturaPrecio = new double[cantidadLineasFactura];
            double[] lineaFacturaImporte = new double[cantidadLineasFactura];
            int[] numeroFacturas = new int[100];

            productos[0, columnaCodigoProducto] = "MZ";
            productos[0, columnaNombreProducto] = "MANZANA";
            productos[1, columnaCodigoProducto] = "NJ";
            productos[1, columnaNombreProducto] = "NARANJA";

            clientes[0, columnaCodigoCliente] = "36";
            clientes[0, columnaNombreCliente] = "JOSE L. SANCHEZ";
            clientes[1, columnaCodigoCliente] = "888";
            clientes[1, columnaNombreCliente] = "JUAN TOPO";
            clientes[2, columnaCodigoCliente] = "111";
            clientes[2, columnaNombreCliente] = "ATILA EL HUNO";
            string listadoClientes = "Codigo\tNombre\n";
            string listadoProductos = "Codigo\tNombre\n";

            int numeroFacturaAingresar = 0;

            string opcionMenu = "";

            for (int fila = 0; fila < clientes.GetUpperBound(0); fila++)
            {
                if (clientes[fila, columnaCodigoCliente] != null)
                {
                    listadoClientes = listadoClientes + clientes[fila, columnaCodigoCliente] + "\t" + clientes[fila, columnaNombreCliente] + "\n";
                } 
            }

            for (int fila = 0; fila < productos.GetUpperBound(0); fila++)
            {
                if (productos[fila, columnaNombreProducto] != null)
                {
                    listadoProductos = listadoProductos + productos[fila, columnaCodigoProducto] + "\t" + productos[fila, columnaNombreProducto] + "\n";
                }
            }

            do
            {
                opcionMenu = PedirStringNoVacio("Ingrese 1 para ingresar venta, 2 para ver por cliente, 3 para analisis, 4 para salir");




                if (opcionMenu == "1")

                {
                    string codigoClienteAIngresar = "";
                    int numeroFacturaIngresar = 0;
                    int cantidadIngresar = 0;
                    double precioIngresar = 0;
                    bool existeCliente = false;

                    //validar que el cliente ingresado exista

                    codigoClienteAIngresar = ValiarIngresoCliente(columnaCodigoCliente, clientes, listadoClientes, ref existeCliente);

                    string codigoProductoAIngresar = "";
                    bool existeProducto = false;

                    // valida que el producto exista
                    codigoProductoAIngresar = ValiarIngresoCliente(columnaCodigoProducto, productos, listadoProductos, ref existeProducto);





                }
                else if (opcionMenu == "2")
                {


                }


            } while (opcionMenu != "4");
        }

        //validar que el cliente ingresado exista

        private static string ValiarIngresoCliente(int columnaCodigoCliente, string[,] clientes, string listadoClientes, ref bool existeCliente)
        {
            string codigoClienteAIngresar;
            do
            {
                codigoClienteAIngresar = PedirStringNoVacio("Ingreses una opcion de este listado" + listadoClientes);

                for (int filaCliente = 0; filaCliente < clientes.GetUpperBound(0); filaCliente++)
                {
                    if (clientes[filaCliente, columnaCodigoCliente] == codigoClienteAIngresar)
                    {
                        existeCliente = true;

                    }

                }

            } while (!existeCliente);
            return codigoClienteAIngresar;
        }

        //garantiza que se ingrese un String no vacio, no deja seguir a menos que se ingrese algun dato de cadena

        private static string PedirStringNoVacio(string mensaje)
        {
            string retorno = "";
            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine().ToUpper();
                if (retorno == "")
                {
                    Console.WriteLine("Debe ingresar algun valor");
                }

            } while (retorno == "");

            return (retorno);
        }

        //Solicita un numero en un rango determinado, asegura que sea un entero dentro de un rango y devuelve un numero.

        public static int PedirYvalidarIntEnRango(string mensaje, int minimo, int maximo)
        {
            int retorno = 0;

            do
            {
                Console.WriteLine(mensaje + " en el rango de " + minimo + " y " + maximo);

                if (!Int32.TryParse(Console.ReadLine(), out retorno))
                {
                    Console.WriteLine("Debe ingresar un numero");
                }

                else if (retorno > maximo || retorno < minimo)
                {
                    Console.WriteLine("Debe ingresar un numero en el rango solicitado");
                }
            } while (retorno > maximo || retorno < minimo);

            return (retorno);

        }

        //Este metodo aun no funciona
        public static int PedirControlDeDuplicidad(int numeroFacturaAingresar, int[] numeroFacturas)
        {
            bool facturaExiste = false;
            do
            {
                for (int fila = 0; fila < numeroFacturas.GetUpperBound(0); fila++)
                {
                    if (numeroFacturas[fila] != 0 && numeroFacturas[fila] == numeroFacturaAingresar)
                    {
                        facturaExiste = true;

                        Console.WriteLine("Ese numero de factura existe");
                    }
                }


            } while (facturaExiste);


            return (numeroFacturaAingresar);


        }
        public static string buscarEnArreglo(string mensaje, string[] opciones)
        {
            string retorno = "";
            bool existeEnarreglo=false;
            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine();

                for (int fila = 0; fila < opciones.GetUpperBound(0); fila++)
                {
                    if (opciones[fila] == retorno && opciones[fila] != null)
                    {
                        existeEnarreglo = true;
                    }
                }
                  
                if (!existeEnarreglo)
                {
                    Console.Write("el valor no existe papu");
                }

            }while (!existeEnarreglo);

            return (retorno);
        }


        public static string [] mapeo(int filaAborrar, string [,] elementos)
        {
            string [] retorno = new string[elementos.GetUpperBound(0) +1 ];

            for (int fila = 0; fila < elementos.GetUpperBound(0); fila++)
            {
                retorno[fila] = elementos[fila, filaAborrar];
            }
            return retorno;
        }

        //algoritmo de mapeo 

        public string [] reduccion (int columnaAextraer, string [,] elementos)
        {
            string[] retorno = new string[elementos.GetUpperBound(0) + 1];

            for (int fila = 0; fila < elementos.GetLowerBound(0); fila++)
            {
                retorno[fila] = elementos[fila, columnaAextraer];
            }
            return retorno;
        }
     
        //algoritmo de reduccion matriz de 2 dimensiones

        public string algoritmoReduccion (int columna, int columanB, string [,] elementos)
        {
            string retorno = "";

            for (int i = 0; i < elementos.GetUpperBound(0); i++)

                if (elementos[i, columna] != null )
            {
                retorno = retorno + elementos[i, columna] + elementos[i, columanB];
            }

            return retorno;
        }




    }
}
