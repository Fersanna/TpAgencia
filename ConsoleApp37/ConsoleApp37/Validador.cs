using System;
using System.Collections.Generic;

namespace ConsoleApp37
{
    public class Validador
    {

        public double PedirDouble(string mensaje, double minimo, double maximo)
        {
            double retorno = minimo - 1;
            do
            {
                Console.WriteLine(mensaje);
                if (!Double.TryParse(Console.ReadLine(), out retorno))
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

        public string PedirStringNoVacio(string mensaje)
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

        public string SeleccionarOpcionColeccion(string mensaje, List<String> menu)
        {
            string opcion = "";
            do
            {
                Console.WriteLine(mensaje);

                opcion = Console.ReadLine();

                if (!(menu.Contains(opcion)))
                {

                    Console.WriteLine("La opcion no valida");
                }

            } while (!(menu.Contains(opcion)));


            return opcion;

        }

        public string pedirSoN(string mensaje)
        {
            string retorno = "";
            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine().ToUpper();
                if (retorno != "S" && retorno != "N")
                {
                    Console.WriteLine("El string debe ser S o N");
                }
            } while (retorno != "S" && retorno != "N");
            return (retorno);
        }
    }


}