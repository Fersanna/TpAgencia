using System;

namespace Facturacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NumeroFacturas = new int[40];
            int[] ImporteFacturas = new int[40];
            int facturasAcargar;
            int numeroFacturasAcargar = 0;
            string opcion = "";
            int filaActual = 0;
            int total = 0;
            int promedio = 0;
            int contador = 0;
            int maximo=0;
            int minimo = 0;
            bool facturaExiste;
            int filaMaximo = -1;
            int filaMinimo = 0;



            do
            {
                if (filaActual <= NumeroFacturas.GetLowerBound(0))
                    do
                    {
                        do
                        {
                            Console.WriteLine("Ingrese numero de factura");
                            if (!Int32.TryParse(Console.ReadLine(), out numeroFacturasAcargar))
                            {
                                Console.WriteLine("Ingrese un numero");
                            }
                            else if (numeroFacturasAcargar <= 0)
                            {
                                Console.WriteLine("Debe ingresar un numero mayor a cero");
                            }

                        } while (numeroFacturasAcargar <= 0);

                        facturaExiste = false;

                        for (int fila = 0; fila <= NumeroFacturas.GetUpperBound(0) && !facturaExiste; fila++)

                            if (numeroFacturasAcargar == NumeroFacturas[fila])
                            {
                                facturaExiste = true;
                            }

                        if (facturaExiste)
                        {
                            Console.WriteLine("Ese numero de factura ya esta cargado");
                        }

                    } while (facturaExiste);

                do
                {
                    Console.WriteLine("Ingrese importe");
                    if (!Int32.TryParse(Console.ReadLine(), out facturasAcargar))
                    {
                        Console.WriteLine("Debe ingrear un import");
                    }
                    else if (facturasAcargar <= 0)
                    {
                        Console.WriteLine("El importe debe ser mayor a 0");
                    }

                } while (facturasAcargar <= 0);


              //  Controla que no pase colocando cualquier letra diferente a S y a N
                do
                {
                    Console.WriteLine("Desea ingresar otro comprobante");
                    opcion = Console.ReadLine().ToUpper();
                    if (opcion != "S" && opcion != "N")
                    {
                        Console.WriteLine("Ingrese  un dato valido");
                    }
                } while (opcion != "S" && opcion != "N");


                NumeroFacturas[filaActual] = numeroFacturasAcargar;
                ImporteFacturas[filaActual] = facturasAcargar;

                filaActual += filaActual ;

                for (int i = 0; i < ImporteFacturas.GetUpperBound(0); i++)
                {
                    total += ImporteFacturas[i];
                }

                Console.WriteLine("la suma total de las facturas cargadas - " + total);

                for (int i = 0; i < ImporteFacturas.GetUpperBound(0); i++)
                {
                    if (ImporteFacturas[i] != 0)
                    {
                        contador = contador +1;
                    }
                }

                promedio = total / contador;

                for (int i = 0; i < ImporteFacturas.GetUpperBound(0); i++)
                {
                    if (ImporteFacturas[i] > maximo)
                    {
                        filaMaximo = i;
                        maximo = ImporteFacturas[i];
                    }
                }

                minimo = maximo;

                for (int i = 0; i < ImporteFacturas.GetUpperBound(0); i++)
                {
                    if (ImporteFacturas[i] < minimo && ImporteFacturas[i]!=0)
                    {
                        filaMinimo = i;
                        minimo = ImporteFacturas[i];
                    }
                }


                Console.WriteLine("la suma total de las facturas cargadas - " + total);
                Console.WriteLine("El promedio de las facturas cargadas es  - " + promedio);
                Console.WriteLine("El mayor importes es - " + ImporteFacturas[filaMaximo] + " y esta en la factura" + NumeroFacturas[filaMaximo]);
                Console.WriteLine("El menor importes es - " + ImporteFacturas[filaMinimo] + " y esta en la factura" + NumeroFacturas[filaMinimo]);


            } while (opcion == "S");
        }
    }
}


