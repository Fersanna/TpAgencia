using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaDeRecepcion [] notas = new NotaDeRecepcion[100];
            Articulo [] articulos = new Articulo[50];
            Item[] items = new Item[5];
            string opcion = "";

            cargaInicial(articulos);

            do
            {
                do
                {
                    opcion = pedirStringNoVacio(" 1 - Cargar nota\n 2 - Consultar notas\n 3 - Salir\n");

                    {
                        if (opcion == "1")
                        {
                            ingresarNota(notas, articulos);
                        }
                        if(opcion == "2")
                        {
                            consultarNotas(notas);
                        }
                            
                }
                } while (opcion != "0");
              
                

            } while (opcion != "0");

        }

        private static void consultarNotas(NotaDeRecepcion[] notas)
        {
            throw new NotImplementedException();
        }

        private static string pedirStringNoVacio(string mesaje)
        {
            string retorno = "";

            do
            {
                Console.WriteLine(mesaje);
                retorno = Console.ReadLine().ToUpper();
                if (retorno == "")
                {
                    Console.WriteLine("Debe ingresar algun valor");
                }
            } while (retorno == "");

            return retorno;
        }


        public static void cargaInicial(Articulo[] articulos)
        {
            articulos [0] = new Articulo();
            articulos[0].codigo = "SILLA001";
            articulos[0].nombre = "SILLA CLASICA";

            articulos[1] = new Articulo();
            articulos[1].codigo = "SILLA002";
            articulos[1].nombre = "OTRA SILLA";

            
        }

        // Para Agregar un valor en un array, hay que buscar fila vacia en el mismo y luego validar los datos a cargar, para eso se debe crear una variable que va a servir para validar los datos antes de cargarlos.

        public static void ingresarNota(NotaDeRecepcion [] notas, Articulo [] articulos)
        {
            //1 -buscar fila vacia en arreglo  2 - si no hay lugar dar ese mensaje
            //confirmar agregado 
            int filaVacia = buscarFilaVacia(notas);
            string confirmarAgregado = "";

            if (filaVacia == -1)
            {
                Console.WriteLine("No existe espacio para agregar mas notas");
            }
            else
            {
                //1 - pedir y validar nota a agregar y 2 - pedir y validar articulos a agregar 3 - 

                // Otro caso donde se crea una variable temporal para luego realizar la carga en el arreglo pasando esta variable temporal en la filaVaci.

                NotaDeRecepcion notaAAgregar = pedirYValidarNota(notas); 
                notaAAgregar.items = pedirYValidarItems(articulos);
                confirmarAgregado=pedirStringNoVacio("Desea confirmar el ingreso de " + obtenerStringDeNota(notaAAgregar) + "\n Ingrese S para confirmar").ToUpper();
                if (confirmarAgregado == "S")
                {
                    notas[filaVacia] = notaAAgregar;
                }
            }


            }


        private static string obtenerStringDeNota(NotaDeRecepcion notaAAgregar)
        {
            string retorno = "";

            retorno = retorno + notaAAgregar.numero;
            retorno = retorno + notaAAgregar.origen;
            retorno = retorno + notaAAgregar.fecha;
            retorno = retorno + notaAAgregar.nombreReceptor;

            //notaDeRecepcion tiene dentro un arreglo con items !!!! por eso para traer esos datos debo hacer un for 

            for (int fila = 0; fila < notaAAgregar.items.GetLowerBound(0); fila++)
            {
                if (notaAAgregar.items != null)
                {
                    retorno = retorno + notaAAgregar.items[fila].codigo +notaAAgregar.items[fila].descripcion +notaAAgregar.items[fila].cantidad; 
                }

                
            }
            return retorno;


        }

        // 1- buscar lugar en arreglo 2- crear variable ante para validar datos (String o integer)
        // cuando devuelve un Objeto, hay que instanciarlo dentro del metodo.
        private static Item[] pedirYValidarItems(Articulo[] articulos)
        {
            Item[] Items = new Item[5];
            string codigoAAgregar = "";
            int fila = 0;
            int filaArticulo = -1;
            do
            {
                do
                {

                    codigoAAgregar = pedirStringNoVacio("Ingrear codigo");

                    fila = buscarArticuloPorCodigo(articulos, codigoAAgregar);

                    if (filaArticulo == -1 && codigoAAgregar != "0")
                    {
                        Console.WriteLine("El codigo ingresado no es valido");
                    }


                } while (filaArticulo == -1 && codigoAAgregar != "0");

                if (codigoAAgregar != "0")
                {
                    //El profe resuelve creando en nuevoItem una variable temporal para luego agregarla al arreglo en la ultima linea haciendo nuevoItem[fila]=codigoAAgregar;

                    Item[] nuevoItem = new Item[5];
                    nuevoItem[fila].codigo = codigoAAgregar;
                    nuevoItem[fila].cantidad = pedirIntegerEnRango("Ingrese la cantidad", 0, 5);
                    nuevoItem[fila].descripcion = pedirStringNoVacio("Ingrese la descripcion");

                    fila = fila + 1;
                }
            }while (fila < Items.GetUpperBound(0) && codigoAAgregar != "0");

            return (Items);

        }

        private static int buscarArticuloPorCodigo(Articulo[] articulos, string codigoAAgregar)
        {
            int fila = -1;

            for (int i = 0; i < articulos.GetLowerBound(0); i++)
            {
                if (articulos[i] != null && articulos[i].codigo == codigoAAgregar)
                {
                    Console.WriteLine("Debe ingresar un codigo valido");


                }
                else fila = i;


            }

            return fila;
        }


        //devuelve un objeto del tipo nota de recepcion notaAAgregar.
        private static NotaDeRecepcion pedirYValidarNota(NotaDeRecepcion[] notas)
        {
            NotaDeRecepcion notaAAgregar = new NotaDeRecepcion();
            notaAAgregar.numero = obtenerNumeroDeNota(notas);
            notaAAgregar.nombreReceptor = pedirStringNoVacio("ingrese nombre del receptor");
            notaAAgregar.origen = pedirStringNoVacio("origen");
            notaAAgregar.fecha = DateTime.Now.ToString();
            return (notaAAgregar);

        }
        //aca necesitamos 3 metodos, pedir int en rango, buscar el mayor numero del arreglo y el bucle que sume +1 al ultmo numero.
        private static int obtenerNumeroDeNota(NotaDeRecepcion[] notas)
        {
            int numeroNota = buscarMayorNumeroNota(notas);

            if (numeroNota == -1)
            {
                numeroNota = pedirIntegerEnRango("Ingresar un numero en el rango de 0 a 100", 0, 100);
            }
            else
            {
                numeroNota = numeroNota + 1;
            }

            return numeroNota;
        }

        private static int buscarMayorNumeroNota(NotaDeRecepcion[] notas)
        {
            int retorno = -1;

            for (int fila = 0; fila < notas.GetLowerBound(0); fila++)
            {
                if (notas[fila] != null)
                {
                    if (notas[fila].numero > retorno)
                    {
                        retorno = notas[fila].numero;
                    }

                }
                
            }
            return retorno;
        }


            private static int pedirIntegerEnRango(string mensaje, int minimo, int maximo)
        {
            int retorno= -1;

            Console.WriteLine(mensaje);
            if (!Int32.TryParse(Console.ReadLine(), out retorno)) 

            {
                Console.WriteLine("Debe ingresar un valor numerico");
                    }

            else if (retorno > maximo || retorno < minimo)
            {
                Console.WriteLine("Debe ingrear un valor entre " + minimo + "y " + maximo);
            }while (retorno > maximo || retorno < minimo) ;

            return retorno;

        }

        public static int buscarFilaVacia (NotaDeRecepcion[] notas)
        {
            int retorno = -1;

            for (int fila = 0; fila < notas.GetUpperBound(0) && retorno == -1; fila++)
            {
                if (notas[fila] == null)
                {
                    retorno = fila;
                }

            }

            return retorno;
            }


    }

    }


