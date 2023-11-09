using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Algoritmo de flujo principal del programa
            NotaDeRecepcion[] notas = new NotaDeRecepcion[100];
            Articulo[] articulos = new Articulo[50];
            
            string opcion = "";

            // blucle principal del programa

            cargaInicialDeArticulos(articulos);
            
            do
            {
                opcion = pedirStringNoVacio("Ingrese una opcion:\n1. Ingresar nota\n2. Consultar nota\n3. Salir");
                if (opcion == "1")
                {
                    ingresarNota(notas, articulos);
                }
                else if (opcion == "2")
                {
                    consultarNota(notas);
                }
            } while (opcion != "3");

        }

        private static void consultarNota(NotaDeRecepcion[] notas)
        {
            throw new NotImplementedException();
        }

        // SEGUIR POR ACA TODO

        private static void ingresarNota(NotaDeRecepcion[] notas, Articulo[] articulos)
        {
           int filaVacia = buscarFilaVacia(notas);
            if (filaVacia==-1)
            {
                Console.WriteLine('No hay mas lugar');
            }
            else

            {
                NotaDeRecepcion notaAAgregar = pedirYValidarDatosDeNota(notas);
                notaAAgregar.items = pedirYvalidarItems(articulos); //Porque no me deja validar Items y si Articulos? 
            }
            
        }

        private static Item[] pedirYvalidarItems(Articulo[] articulos)
        {
            //completar bloque // ESTE BLOQUE ES DONDE SE ME COMPLICA
            Item[] items = new Item[5];
            int filaArticulo = 0;
            string codigoAAgregar = "";

            do
            {
                filaArticulo = -1;
                codigoAAgregar = pedirStringNoVacio("Ingrese codigo de articulo:\n" + armarListadoDeArticulos(articulos))


        } while (filaArticulo != -1);

            //carga de datos en el objeto.
        }

            private static NotaDeRecepcion pedirYValidarDatosDeNota(NotaDeRecepcion[] notas)
        {
            NotaDeRecepcion notaAAgregar = new NotaDeRecepcion();
            notaAAgregar.numero = obtenerNumeroDeNota(notas); // 3 pasos buscar, buscar nota mas alta, validar que este dentro del rango, sumar uno al ultimo enco. 
            notaAAgregar.fecha = DateTime.Now.ToString();
            notaAAgregar.origen= pedirStringNoVacio("Ingrese origen");
            notaAAgregar.nombreReceptor= pedirStringNoVacio("Ingrese nombre del receptor");
            return notaAAgregar;
        }


        // toma el numero de nota maximo cargado y se le suma otro, si no hay se guarda en la variable el solicitado al usuario validando rangos.

        private static int obtenerNumeroDeNota(NotaDeRecepcion[] notas)
        {
            int numeroDeNotas = ObetenerMaximoNumeroNota(notas);

            if (numeroDeNotas==-1)
            {
                numeroDeNotas = pedirIntegerEnRango("Ingrese un numero entre 1 y 99999", 1, 99999);
            }
            else 
            numeroDeNotas += numeroDeNotas;

            return numeroDeNotas;
        }

         
        // ESTA UN POCO DIFERENTE AL APUNTE (CHECK)

        private static int pedirIntegerEnRango(string v1, int minimo, int maximo) 
        {
            int retorno;
            bool pudeConvertir;

            Console.WriteLine(v1);
            
            pudeConvertir = Int32.TryParse(Console.ReadLine(), out retorno);
            if (pudeConvertir)
            {
                do
                {
                    if (retorno > maximo || retorno < minimo)
                    {
                        Console.WriteLine("Debe ingresar un numero dentro del rango indicado");
                        Console.ReadLine();

                    }

                } while (retorno > maximo || retorno < minimo);


            }
            else
                do
                {
                    {
                        Console.WriteLine("Por favor ingrese un dato valido");
                        Console.ReadLine();

                    }
                } while (!pudeConvertir);
           
            return retorno;
        }

        // BUSCA EL NUMERO DE NOTA MAS ALTO EN EL ARREGLO

        private static int ObetenerMaximoNumeroNota(NotaDeRecepcion[] notas) 
        {
            int maximoNumeroNota = -1;

            for (int i = 0; i < notas.GetUpperBound(0); i++)

                if (notas[i].numero!=0)
            {
                if (notas[i].numero >maximoNumeroNota  )
                {
                    maximoNumeroNota = notas[i].numero;
                }
            }
            return (maximoNumeroNota);
        }
        
        // BUSCA LUGAR PARA AGREGAR EL OBJETO

        private static int buscarFilaVacia(NotaDeRecepcion[] notas)
        {
            int retorno = -1;

            for (int i = 0; i < notas.GetUpperBound(0); i++)
            {
                if (notas[i] == null && retorno == -1)
                    retorno = i;
            }

            return (retorno);
        } 

        private static void cargaInicialDeArticulos(Articulo[] articulos)
        {
            articulos [0] = new Articulo();
            articulos[0].codigo = "SIL001";
            articulos[0].nombre = "silla uno";

            articulos[1].codigo = "mesa002";
            articulos[1].nombre = "mesa dos";
         
            articulos[1] = new Articulo();
            articulos[1].codigo = "SIL003";
            articulos[1].nombre = "Silla tress";

        }

        //IMPIDE QUE SE DEJE SIN CARGAR UN TEXTO

        private static string pedirStringNoVacio(string mensaje)
        {

            string retorno = "";

            do
            {
                Console.WriteLine(mensaje);
                Console.ReadLine();
                if (retorno == "")
                {
                    Console.WriteLine("Por favor ingresar un dato no vacio");
                }

            } while (retorno == "");

            return (retorno);
        }
    }
}
