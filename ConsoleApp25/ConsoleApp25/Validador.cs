using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25
{
    class Validador
    {
        internal Cancion PedirCancion(String mensaje)

        {
            Console.WriteLine(mensaje);
            Cancion retorno = new Cancion(PedirStringNoVacio("Ingrese el nombre de la cancion"), PedirStringNoVacio("Nombre del artista"), pedirInteger("Ingrese el anio de la cancion", 0, 100));

            return retorno;
        }

        private int pedirInteger(string mensaje, int minimo, int maximo)
        {
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
            return (retorno);
        }

        public  string PedirStringNoVacio(string mensaje)
        {
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
            return (retorno);
        }
    }
}
