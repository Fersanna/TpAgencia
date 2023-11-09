using System;
using System.Collections.Generic;

namespace ConsoleApp38
{
    internal class AppCintas
    {
        Validador validador;
        List<Producto> productos;
        List<Maquina> maquinas;
        List<Orden> ordenes;

        public  AppCintas() {
        
            validador=new Validador(); 
            productos=new List<Producto>();
            maquinas=new List<Maquina>();
            ordenes= new List<Orden>(); 

            productos.Add(new Producto("1","zapatillas",1000, 1000));
            productos.Add(new Producto("2", "Zapatos", 5000, 600));
            productos.Add(new Producto("3", "Medias", 9000, 1080));
            maquinas.Add(new Telar("telar 1", "Telar", 2000, 1000));

        }

        internal void Ejecutar()
        {
            string opcion = "";
            do
            {
                opcion = validador.PedirStringNoVacio("Ingrese opcion:\nA-Listar Productos\nB-Listar Maquina\nC-Crear Orden de Fabricacion");
                if (opcion == "A")
                {
                    ListarProductos();
                }
                else if (opcion == "B")
                {
                    ListarMaquinas();
                }
                else if (opcion == "C")
                {
                    CrearOrdenDeFabricacion();
                }
                else if (opcion == "C")
                {
                    ListarOrdenesSinAsignar();
                }
            } while (opcion != "4");

        }

        private void ListarOrdenesSinAsignar()
        {
            throw new NotImplementedException();
        }

        private void CrearOrdenDeFabricacion()
        {
            string codigoAbuscar = "";
            Orden ordenAAgregar = null;
            int numeroDeOrden = 0;

           foreach (Producto producto in productos)
            {
                Console.WriteLine(producto);
            }
            do
            {
                codigoAbuscar = validador.PedirStringNoVacio("Ingrese codigo de producto");

                if (!ProductoExiste(codigoAbuscar))
                {
                    Console.WriteLine("Ese produto no existe");
                }
            } while (!ProductoExiste(codigoAbuscar));



            numeroDeOrden = GetNumeroDeOrden();

            Producto productoSeleccionado = ObtenerProductoPorCodigo(codigoAbuscar);


            List<string> procesosProducto = productoSeleccionado.GetProcesosSecuenciales();

            ordenAAgregar = new Orden(numeroDeOrden, productoSeleccionado, 0, new List<string>(), procesosProducto, null, 0);
            ordenes.Add(ordenAAgregar);

            Console.WriteLine("Orden de fabricación creada exitosamente.");

            Console.WriteLine("Procesos a ejecutar:");
            foreach (string proceso in procesosProducto)
            {
                Console.WriteLine(proceso);
            }


        }

        private Producto ObtenerProductoPorCodigo(string codigo)
        {
            foreach (Producto producto in productos)
            {
                if (producto.GetCodigo() == codigo)
                {
                    return producto;
                }
            }
            return null;
        }

        private int GetNumeroDeOrden()
        {
            int MayorNumero = 0;

            foreach(Orden orden in ordenes)
            {
                if (orden.GetNumeroDeOrden() > MayorNumero)
                {
                    MayorNumero= orden.GetNumeroDeOrden();
                }
                 
            }
            return MayorNumero + 1;

        }

        private bool ProductoExiste(string codigoAbuscar)
        {
            foreach (Producto producto in productos)
            {
                if (producto.GetCodigo() == codigoAbuscar)
                {
                    return true;
                }
            }
            return false;
        }
            private void ListarMaquinas()
        {
            foreach(Maquina maquina in maquinas)
            {  
                
                    Console.WriteLine(maquina);

                
            }
        }

        private void ListarProductos()
        {
            foreach(Producto producto in productos)
            {
                Console.WriteLine(producto);
            }
        }
    }
}