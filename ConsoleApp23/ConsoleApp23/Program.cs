using System;
using System.Collections.Generic;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Comprobante> listaDeComprobantes = new List<Comprobante>();

           
            listaDeComprobantes.Add(new NotaDeCredito(DateTime.Now.ToString(), 90, "A", "1", 1, "CCC"));
            listaDeComprobantes.Add(new Factura (DateTime.Now.ToString(), 200, "A", "1", 1, "CCC"));

            string continuarCarga = "";

            do
            {
                Comprobante aIngresar = null;

                do
                {
                    aIngresar = pedirComprobante();

                    if (listaDeComprobantes.Contains(aIngresar))
                    {
                        Console.WriteLine("el comprobante ya existe");
                    }
                   
                } while (listaDeComprobantes.Contains(aIngresar));

                listaDeComprobantes.Add(aIngresar);

                continuarCarga= pedirStringNovacio("Ingrese S o N");

            } while (continuarCarga=="S");

            double saldoFinal = 0;
           foreach(Comprobante item in listaDeComprobantes)
            {
                
               saldoFinal =saldoFinal+ item.getImporte();
                Console.WriteLine(item); 
            }
           
            Console.WriteLine("El sado final es :" + saldoFinal);

            Console.ReadKey();
        }

        private static Comprobante pedirComprobante()
        {
            Comprobante retorno = null;

            string opcion = "";

            do
            {
                opcion = pedirStringNovacio("Ingrese A para factura o B para nota de Credito");

                if (opcion != "A" && opcion != "B")
                {
                    Console.WriteLine("Ingrese una opcion valida");
                }
            } while (opcion != "A" && opcion != "B");

            if (opcion == "A")
            {
                retorno = pedirFactura();
            }

            if (opcion == "B")

                retorno = pedirNota();

            return retorno;
        }

        private static Comprobante pedirNota()
        {
            Comprobante retorno = null;

            string fecha; double importe; string letra; string cae; int numero; string puntoDeVenta;
          
            fecha = DateTime.Now.ToString();
            letra = pedirStringNovacio("ingrese letra del comprobante");
            cae = pedirStringNovacio("Ingrese cae");
            importe = pedirDouble("ingrese el importe", 0, 100);
            numero = pedirIntegerEnRango("ingrese el numero", 0, 100);
            puntoDeVenta = pedirStringNovacio("Ingrese el punto de vente");

            retorno = new NotaDeCredito(fecha, importe, letra, cae,numero,puntoDeVenta);

            return retorno;
        }

        private static Comprobante pedirFactura()
        {
            Factura retorno = null;

            string fecha; double importe; string letra; string cae; int numero; string puntoDeVenta;

            fecha = DateTime.Now.ToString();
            letra = pedirStringNovacio("ingrese letra del comprobante");
            cae = pedirStringNovacio("Ingrese cae");
            importe = pedirDouble("ingrese el importe",0,100);
            numero = pedirIntegerEnRango("ingrese el numero", 0, 100);
            puntoDeVenta = pedirStringNovacio("Ingrese el punto de vente");

            retorno = new Factura(fecha, importe, letra, cae, numero, puntoDeVenta);


            return retorno;
        }

        private static int pedirIntegerEnRango(string mensaje, int minimo , int maximo)
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

        private static string pedirStringNovacio(string mensaje)
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

         static double pedirDouble(string mensaje, int minimo, int maximo)
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
    }
}
