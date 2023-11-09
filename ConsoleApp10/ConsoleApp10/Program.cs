using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int ImporteFactura = 0;
            int[] NumeroFacturas = new int[100];



            ImporteFactura = ValidarINTenrango("Ingrese el importe de la factura", 0, 100);
            


        }

        private static int BuscarFactura(int numerofactura,  int [] ImporteFacturas )
        {
            bool estaEnarreglo = false;
            int importeAdevolver = -1;

            for (int i = 0; i <= ImporteFacturas.GetUpperBound(0) ;  i ++)
            {
                if (ImporteFacturas[i] == numerofactura)

                {
                    importeAdevolver = i;
                        
                        } return importeAdevolver;
                        
          }




        }



        public static int ValidarInteg(string mensaje)
        {

            int ImporteaDevolver;
            bool Esnumerico = false;

            do
            {
                Console.WriteLine(mensaje);
                Esnumerico = int.TryParse(Console.ReadLine(), out ImporteaDevolver);

                if (!Esnumerico)
                {
                    Console.WriteLine("Ingrese un valor numerico");

                }
            } while (!Esnumerico);

                                    
            return (ImporteaDevolver);
        }

        public static int ValidarINTenrango(string mensaje, int Numerodesde, int NumeroHasta)


        {
            
                int numeroaDevolver;
            do
            {

                numeroaDevolver = ValidarInteg(mensaje);
              
                if (numeroaDevolver < Numerodesde || numeroaDevolver > NumeroHasta)
                {
                    Console.WriteLine("El numero debe estar entre" + Numerodesde + " y "+ NumeroHasta);

                }
            } while (numeroaDevolver > Numerodesde || numeroaDevolver > NumeroHasta);

            return (numeroaDevolver);

         }
    }
}
