using System;

namespace Practica_guia_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] especies = { "AAPL", "MSFT", "ALPH" };
            compra[] compras = new compra[100];
            string opcionElegida = "";

            do
            {
                opcionElegida = pedirStringNoVacio("Ingresar una Opcion:\n A Ingresar compra\n B estadistica\n C Salir"  ).ToUpper();
                if (opcionElegida.Equals("A"))
                {
                    ingresarNuevaCompra(compras);

                }
                else if (opcionElegida.Equals("B")) ;


            } while (opcionElegida != "S");

        }

        private static void ingresarNuevaCompra(compra[] compras)
        {
            int filaVacia = buscarEnArrrgloCompras(compras, null);
        }

        private static int buscarEnArrrgloCompras(compra[] compras, compra p)
        {
            int retorno = -1;

            for (int fila = 0; fila < compras.GetLowerBound(0); fila++)
            {
                if (compras[fila] != null && p != null)
                {
                    if (compras[fila].Equals(p) && retorno == -1)
                    {
                        retorno =fila;
                    }

                }                    
            }
           
        }

        private static string pedirStringNoVacio( string mensaje)
        {
            string retorno = "";
            do
            {
                Console.WriteLine(mensaje);
                retorno =Console.ReadLine();
                if (retorno.Equals(""))
                {
                    Console.WriteLine("Debe ingresar un valor");
                }
            } while (retorno.Equals(""));
            return (retorno);
          }
    
        }
    } 
