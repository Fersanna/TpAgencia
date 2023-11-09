using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
    internal class AppPorfolio
    {
        private Validador validador;
        private List<Orden> ordenes;
        private List<String> especies;

        public AppPorfolio()
        {
            especies = new List<String>();
            ordenes = new List<Orden>();
            validador = new Validador();
            especies.Add("MSFT");
            especies.Add("AAPL");
            especies.Add("KO");
            especies.Add("MCD");
        }


        internal void Ejecutar()
        {
            string opcion = "";

            opcion = "";

            do
            {
                opcion = validador.pedirStringNoVacio("Ingrese opcion 1-Mostar\n2-Pendientes\n3-Ingresar Orden");
                if (opcion == "1")
                {
                    mostrarPortfolio();
                }
                else if (opcion == "2")
                {
                    mostrarPendientes();
                }
                else if (opcion == "3")
                {
                    ingresarOrden();
                }
            } while (opcion != "4");
        }

        public List<String> GetEspecies()
        {
            List<String> retorno = new List<String>();

            foreach (String especie in especies)
            {
                retorno.Add(especie.ToString());
            }

            return retorno;
        }

        private void ingresarOrden()
        {
            ordenes.Add(CargarOrden(especies));
        }

        private Orden CargarOrden(List<string> especies)
        {
            Orden retorno = null;
            string tipo = "";
            string especie;
            double precioLimite = 0;
            string fecha;
            int cantidad;
            double precio;

            do
            {
                
                tipo = validador.pedirStringNoVacio("Ingrese el tipo de operacion V para venta o C para compra");

                if (tipo != "V" && tipo != "C")
                {
                    Console.WriteLine("Ddebe ingresar V o C");
                }

            } while (tipo != "V" && tipo != "C");

            do
            {
                especie = validador.pedirStringNoVacio("Ingrese la especie\n" + GetEspecies());

                if (!especies.Contains(especie))
                {
                    Console.WriteLine("Debe elegir una especie valida");
                }

            } while (!especies.Contains(especie));

            precioLimite = validador.pedirDouble("Ingrese el valor a negociar", 0, 1000);
            fecha = DateTime.Now.ToString();
            cantidad= validador.pedirInteger("Ingrese cantidad a negociar",0,1000);
            precio = validador.pedirDouble("ingrese el precio", 0, 999999);

            if (tipo =="V")
            {
                retorno = new OrdenDeVenta(fecha, especie, cantidad, precioLimite,precio);  
            }
            else if (tipo == "C")
            {
                retorno = new OrdenDeCompra(DateTime.Now.ToString(), especie, cantidad, precioLimite,precio);


            }

            return retorno;
    }

    private void mostrarPendientes()
    {
            ordenes.FindAll(orden => orden.EstaPendiente())
            .ForEach(Console.WriteLine);
    }

    private void mostrarPortfolio()
    {
        throw new NotImplementedException();
    }
}

internal class Validador
{
    public double pedirDouble(string mensaje, double minimo, double maximo)
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

    internal string pedirStringNoVacio(string mensaje)
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

    public int pedirInteger(string mensaje, int minimo, int maximo)
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