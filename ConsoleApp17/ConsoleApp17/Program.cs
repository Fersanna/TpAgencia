using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeroFactura = new int[100000];
            double[] importeFactura = new double[100000];

            int numeroFacturaAIngresar = 0;
            double importeFacturaAIngresar = 0;
            bool facturaAIngresarExiste = false;

            int filaMaximo = -1;
            int filaMinimo = -1;
            double total = 0;
            double promedio = 0;
            int contador = 0;

            string seguir = "";
            int filaActual = 0;

            do
            {
                if (filaActual <= numeroFactura.GetUpperBound(0))
                {
                    do
                    {
                        do
                        {
                            Console.WriteLine("Ingrese numero de factura");
                            if (!Int32.TryParse(Console.ReadLine(), out numeroFacturaAIngresar))
                            {
                                Console.WriteLine("Debe ingresar un numero");
                            }
                            else if (numeroFacturaAIngresar <= 0)
                            {
                                Console.WriteLine("El numero de factura debe ser mayor a 0");
                            }
                        } while (numeroFacturaAIngresar <= 0);

                        facturaAIngresarExiste = false;

                        for (int fila = 0; fila <= numeroFactura.GetUpperBound(0) && !facturaAIngresarExiste; fila++)
                        {
                            if (numeroFacturaAIngresar == numeroFactura[fila])
                            {
                                facturaAIngresarExiste = true;
                            }
                        }
                        if (facturaAIngresarExiste)
                        {
                            Console.WriteLine("Ya existe la factura a ingresar");
                        }
                    } while (facturaAIngresarExiste);


                    do
                    {
                        Console.WriteLine("Ingrese importe de factura");
                        if (!Double.TryParse(Console.ReadLine(), out importeFacturaAIngresar))
                        {
                            Console.WriteLine("Debe ingresar un numero");
                        }
                        else if (importeFacturaAIngresar <= 0)
                        {
                            Console.WriteLine("El importe debe ser mayor a 0");
                        }
                    } while (importeFacturaAIngresar <= 0);

                    if (filaActual != numeroFactura.GetUpperBound(0))
                    {
                        do
                        {
                            Console.WriteLine("Desea continuar? S o N");
                            seguir = Console.ReadLine().ToUpper();
                            if (seguir != "S" && seguir != "N")
                            {
                                Console.WriteLine("Debe ingresar S o N");
                            }
                        } while (seguir != "S" && seguir != "N");
                    }
                    else
                    {
                        Console.WriteLine("No hay mas lugar para cargar facturas");
                        seguir = "N";
                    }
                    numeroFactura[filaActual] = numeroFacturaAIngresar;
                    importeFactura[filaActual] = importeFacturaAIngresar;
                    filaActual += filaActual ;
                }
                else
                {
                    Console.WriteLine("No hay mas lugar para cargar facturas");
                    seguir = "N";
                }
            } while (seguir == "S");







            //Obtener el total de importe de facturas. Transformamos N numeros en 1 numero. Reducir un arreglo

            for (int fila = 0; fila <= importeFactura.GetUpperBound(0); fila++)
            {
                total = total + importeFactura[fila];
            }

            //Para hacer una operacion condicional dependiendo de la fila, hacemos un bucle y adentro metemos
            for (int fila = 0; fila <= importeFactura.GetUpperBound(0); fila++)
            {
                if (importeFactura[fila] != 0)
                {
                    contador += contador ;
                }
            }



            //Voy a buscar la fila que tenga el valor maximo. A partir de un arreglo devuelvo un nunero de fila que cumple una condicion determinada
            //Esto conceptualmente es una busqueda

            double maximoActual = 0;
            for (int fila = 0; fila <= importeFactura.GetUpperBound(0); fila++)
            {
                if (importeFactura[fila] > maximoActual)
                {
                    filaMaximo = fila;
                    maximoActual = importeFactura[fila];
                }
            }

            double minimoActual = maximoActual;
            for (int fila = 0; fila <= importeFactura.GetUpperBound(0); fila++)
            {
                if (importeFactura[fila] < minimoActual && importeFactura[fila] != 0)
                {
                    filaMinimo = fila;
                    minimoActual = importeFactura[fila];
                }
            }

            promedio = total / contador;

            Console.WriteLine("El total es: " + total);
            Console.WriteLine("La cantidad de facturas es: " + contador);
            Console.WriteLine("El promedio es: " + promedio);
            Console.WriteLine("La factura mas alta es " + numeroFactura[filaMaximo] + "   Importe: " + importeFactura[filaMaximo]);
            Console.WriteLine("La factura mas baja es " + numeroFactura[filaMinimo] + "   IImporte: " + importeFactura[filaMinimo]);
   ​        }
    }
}














