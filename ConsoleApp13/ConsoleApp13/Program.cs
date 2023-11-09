using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alumnosListado = new string[100];
            int[] notas = new int[100];
            string seguir = "";

            do
            {
                seguir = pedirStringNoVacio("Ingrese\n A - para cargar datos\n B - para mostrar aprobados").ToUpper();

                if (seguir == "A")
                {
                    ingresarDatoEnArreglo(alumnosListado, notas);
                    ingresarNotaEnArreglo(notas);

                }

                else if (seguir == "B")
                {
                    mostrarAprobados(alumnosListado, notas);
                }
                else 
                        {

                }
                        
            } while (seguir == "S");

        }

        private static void ingresarNotaEnArreglo(int[] notas)
        {
            int filaVacia = BuscarFilaVacia(notas);
        }

        private static void mostrarAprobados(string[] alumnosListado, int[] notas)
        {
            throw new NotImplementedException();
        }

        private static void ingresarDatoEnArreglo(string[] alumnosListado, int[] notas)
        {
            int filaVacia = BuscarFilaVacia(alumnosListado);
            if (filaVacia == -1)
            {
                Console.WriteLine("No hay lugar para la carga"); 
            }
            else
            {
                alumnosListado[filaVacia] = pedirStringNoVacio("ingrese el nombre");
             }
        }

        public static int pedirIntEnRango(string mensaje, int maximo, int minimo)
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
                        Console.WriteLine("el numero debe estar dentro del rango especificado");
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar un valor numerico");
                        numero = minimo - 1;
                    }
                } 
              
            } while (numero < minimo || numero > maximo);

            return (numero);
        } 
                          
         private static int BuscarFilaVacia(string[] alumnosListado)
        {
            int retorno = -1;

            for (int fila = 0; fila < alumnosListado.GetUpperBound(0); fila++)

                    if (alumnosListado[fila]==null && retorno == -1)
                {
                    retorno = fila;
                }

                    return (retorno);
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
                    Console.WriteLine("Por favor debe ingresar algun dato no vacio");
                }
            } while (retorno == "");
            return (retorno);
        }
    }
}
