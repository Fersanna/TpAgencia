using System;

namespace Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] facturas = new int[100];
            string seguir = "";
            int fila = 0;
            int ImporteFactura = 0;
            int maximo = 0;
            int minimo = 0;
            int promedio = 0;
            int cantidadDeFacturas = 0;
            int ImporteTotal = 0;
            do
            {
                do
                {
                    Console.WriteLine("Ingrese importe de la factura: ");
                    if (!Int32.TryParse(Console.ReadLine(), out ImporteFactura))
                    {
                        ImporteFactura = -1;

                        Console.WriteLine("Debe ingresar un numero");

                        if (ImporteFactura <= 0) ;

                        Console.WriteLine("Debe ingrear un numero mayor a 0");

                    }


                } while (ImporteFactura <= 0);
                facturas[fila] = ImporteFactura;
                fila = fila + 1;
                do
                {
                    Console.WriteLine("Ingrese seguir S o N");
                    seguir = Console.ReadLine().ToUpper();
                    if (!seguir.Equals("S") && !seguir.Equals("N")) ;
                    {
                        Console.WriteLine("Debe ingresar S o N");

                    }
                } while (!seguir.Equals("N") && !seguir.Equals("S"));

            } while (seguir == "S" && fila < facturas.GetUpperBound(0));


            for (int contador = 0; contador < fila; contador++)
            {
                ImporteTotal = ImporteTotal + facturas[contador];
            }

            //Recorrer todos los elementos secuencialmente, aplicar un filtro y acumular un valor
            for (int contador = 0; contador <= facturas.GetUpperBound(0); contador++)

            { if (facturas[contador] != 0)

                    cantidadDeFacturas = cantidadDeFacturas + 1;
            }
                //Recorrer todos los elementos secuencialmente y encontrar un valor especifico
               
            for (int contador = 0; contador <= facturas.GetUpperBound(0); contador++)
            {
                if (facturas [contador] > maximo)
                {
                    maximo = facturas[contador];


                }
                promedio = ImporteTotal / fila;
            }

                Console.WriteLine("Maximo = " + maximo);
                Console.WriteLine("promedio = " + promedio);
                Console.WriteLine("total = " + ImporteTotal);
                Console.ReadLine(); 


            


            

        }
    }
}
