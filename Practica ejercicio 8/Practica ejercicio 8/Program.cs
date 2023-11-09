using System;

namespace Practica_ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {

            int ImporteFactura;
            string seguir = "";
            int promedio;
            int maximo = 0;
            int minimo = 0;
            int ImporteMaximo = 0;
            int contador = 0;
            int TotalFacturas = 0;

            do
            {

                do
                {
                    Console.WriteLine(" Por favor ingrese el importe de la factura");

                    if (!Int32.TryParse(Console.ReadLine(), out ImporteFactura))


                        ImporteFactura = -1;

                    {
                        if (ImporteFactura < 0)
                        {
                            Console.WriteLine("Ingrese un valor correcto por favor,");
                            Console.ReadLine();
                        }
                    }

                } while (ImporteFactura < 0);

                  
              TotalFacturas = TotalFacturas +ImporteFactura;
               contador = contador + 1;

                maximo = ImporteFactura;

                if (ImporteMaximo > maximo)
                {
                    maximo = ImporteMaximo;
                }
                

                Console.WriteLine("Desea ingresar OTRO numero? S/N");
                seguir = Console.ReadLine().ToUpper();
                if (!seguir.Equals("S"))

                {
                    Console.WriteLine("Usted a concluido  con la carga ");
                    Console.ReadKey();

                } 
            } while (seguir.Equals("S"));

            Console.ReadLine();

            Console.WriteLine("el total de las facturas ingresadas: " + TotalFacturas);
            Console.WriteLine("el promedio de las facturas ingresadas es igual a: " + (TotalFacturas / contador));
            Console.WriteLine("El importe maximo ingresado fue:" + (maximo));
            Console.WriteLine("La cantidad de registros ingresados fueron: " + (contador));



            Console.ReadKey();

















            //} while (seguir=="S" && ImporteFactura <0);

   
        }
    }
}
