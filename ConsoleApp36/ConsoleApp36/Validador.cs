using System;
using System.Collections.Generic;

namespace ConsoleApp36
{
    internal class Validador
    {
        internal string pedirStringEnColeccion(string mensaeje, List<string> opciones)
        {
            string opcionElegida;

            do
            {
                Console.WriteLine(mensaeje);

                opcionElegida = Console.ReadLine().ToUpper();

                if (!opciones.Contains(opcionElegida))
                {
                    Console.WriteLine("Debe elegir una opcion del menu");
                }

            } while (!opciones.Contains(opcionElegida));


            return opcionElegida;
        }

        internal string PedirStringNoVacio(string mensaje)
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
            return (retorno.ToUpper());
        }


        public int PedirInteger(string mensaje, int minimo, int maximo)
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

    }
}