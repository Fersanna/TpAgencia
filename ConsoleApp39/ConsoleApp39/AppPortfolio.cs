using System;
using System.Collections.Generic;

namespace ConsoleApp39
{
    internal class AppPortfolio
    {
        private List<String> especies;
        private List<Orden> ordenes;
        private Validador validador;


        //Constructor App porfolio

        public AppPortfolio()
        {
            especies = new List<String>();
            ordenes = new List<Orden>();
            validador = new Validador();
            especies.Add("MSFT");
            especies.Add("AAPL");
            especies.Add("KO");
            especies.Add("MCD");
        }

        public void ejecutar()
        {
            string opcion = "";
            do
            {
                opcion = validador.PedirStringNoVacio("Ingrese opcion\n1-Mostrar Porfolio\n2-Mostar Pendintes\n3-Ingresar Orden");
                if (opcion == "1")
                {
                    MostrarPortfolio();
                }
                else if (opcion == "2")
                {
                    MostrarPendientes();
                }
                else if (opcion == "3")
                {
                    IngresarOrden();
                }
            } while (opcion != "4");
        }

        private void IngresarOrden()
        {
            ordenes.Add(IngresarOrden(especies));
        }

        private Orden IngresarOrden(List<string> especies)
        {
            string fecha = DateTime.Now.ToString();
            string especieAbuscar = "";
            Orden ordenAAgregar = null;
            double precio = 0;
            int cantidad = 0;
            string tipo = "";

            do
            {
                especieAbuscar = validador.PedirStringNoVacio("Ingrese la especie a operar: " + ListaDeEspecies());
                if (!(especies.Contains(especieAbuscar)))
                {
                    Console.WriteLine("Debe ingresar una especie existente");
                }
            } while (!(especies.Contains(especieAbuscar)));

            precio = validador.PedirDouble("Por favor ingrese valor a operar", 0, 99999);
            cantidad = validador.PedirInteger("Ingrese cantidad a operar", 0, 100);

            do
            {
                tipo = validador.PedirStringNoVacio("Ingrese V para Orden de Venta y C para Orden de Compra");
                if (tipo != "V" && tipo != "C")
                {
                    Console.WriteLine("Debe ingresar V o C");
                }

            } while (tipo != "V" && tipo != "C");

            if (tipo == "V")
            {
                ordenAAgregar = new OrdenDeVenta(fecha, especieAbuscar, cantidad, precio);
            }
            if (tipo == "C")
            {
                ordenAAgregar = new OrdenDeCompra(fecha, especieAbuscar, cantidad, precio);
            }

            return ordenAAgregar;
        }

        public string ListaDeEspecies()
        {
            string Listado = "";
            foreach (string c in especies)
            {
                Listado += c.ToString() + ", ";
            }
            return Listado;

        }

        private void MostrarPendientes()
        {
           List <Orden> ordenesPendintes=ordenes.FindAll(ordenes=>ordenes.EstaPendiente());
          
            foreach(Orden orden in ordenesPendintes)
            {
                Console.WriteLine(orden.ToString());
            }

          ;
        }

        private void MostrarPortfolio()
        {
            foreach (string especie in especies)
            {
                int cantidad = 0;
                double precio = 0;

                foreach (Orden orden in ordenes)
                {
                    if (orden.GetEspecie().ToString() == especie)
                    {
                        cantidad += orden.GetCantidadOperada();
                        precio += orden.GetPrecioOperado();
                    }
                }

                Console.WriteLine($"{especie}\t{cantidad}\t{precio}");
            }
        }



    }
}
