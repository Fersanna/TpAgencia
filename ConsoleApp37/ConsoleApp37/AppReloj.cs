using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp37
{
    class AppReloj
    {
        Validador validador;
        List<Pedido> pedidos;
        List<Cliente> clientes;

        public AppReloj()
        {
            validador = new Validador();
            pedidos = new List<Pedido>();
            clientes = new List<Cliente>();

            cargaInicial();
        }

        public void ejecutar()
        {
            List<String> opcionMenu = new List<String>() { "1", "2", "3", "4", "5" };
            string opcionElegida = "";

            do
            {
                opcionElegida = validador.SeleccionarOpcionColeccion("Ingrese:\n1-Cargar Cliente\n2-Ingresar nueva reparación\n3-Comunicar precio presupuestado\n4-Entrega\n5-Salir", opcionMenu);

                if (opcionElegida == ("1"))
                {
                    ingresarCliente();
                }
                else if (opcionElegida == ("2"))
                {   //cambiar el estado a reparar
                    IngresarReparacion();
                }
                else if (opcionElegida == ("3"))
                {
                    ConultarPrecioPresupuesto();
                }
                else if (opcionElegida == ("4"))
                {
                    entregarReparacion();
                }
            } while (opcionElegida != ("5")); 
        }

        private void ConultarPrecioPresupuesto()
        {
            int numeroAcomparar = validador.PedirInteger("ingrese numero pedido a consultar", 1, 10000);
            Pedido pedidoAConsultar = pedidos.Find(pedidos => pedidos.GetNumeroPedido() == numeroAcomparar);

            Console.WriteLine($"El pedido por usted consultado esta presupuestado en {pedidoAConsultar.GetPrecio()}");
        }

        private void entregarReparacion()

        {//validar que el cliente exista, con el correspondiente DNI

            string opcion = "";
            int numeroDNI = validador.PedirInteger("Ingrese DNI a buscar", 0, 10000);
           if (!ClienteExiste(numeroDNI))
            {
                Console.WriteLine("El cliente no existe");
            }
            //Bucar pedidos para entregar con ese DNI.
            else
            {
                List<Pedido> pedidosParaEntregar = BuscarPedidosParaEntregar(numeroDNI);

                if (pedidosParaEntregar.Count == 0)
                {
                    Console.WriteLine("No hay pedidos para entregar para el cliente con DNI {0}.", numeroDNI);
                }
                else
                {
                    Console.WriteLine("Pedidos para entregar del cliente con DNI {0}:", numeroDNI);
                    foreach (Pedido pedido in pedidosParaEntregar)
                    {
                        Console.WriteLine(pedido.ToString());
                    }
                    Console.WriteLine("Que pedido entrega? ");
                    
                    //Cuando necesito imprimir en una coleccion debo hacer el Foreach y luego no olvidar el ToString();

                        foreach (Pedido pedido in pedidosParaEntregar)
                    {
                          Console.WriteLine(pedido.ToString());
                    }

                    int numeroAEntregar = validador.PedirInteger("Ingrese numero de Pedido a Entregar", 0, 100);
                   
                    //Aca uso el Find ya que necesito solo un Objeto, devuelve el primero encontrado

                    Pedido AEntregar = pedidosParaEntregar.Find(pedido => pedido.GetNumeroPedido() == numeroAEntregar && pedido.GetEstado()=="R");

                    opcion= validador.pedirSoN("Confirma entrega?" + AEntregar.ToString());


                    if (opcion=="S")
                    {
                        AEntregar.MarcarEntregado();
                    }

                    else
                        Console.WriteLine("El pedido " + AEntregar.ToString() + " no está para avisar entrega");


                }


            }




            //buscar el numero de pedido y trabajar con eso, corroborar que este en estado de entrega, mediante el numero de DNI OBTENER EL NUMERO DE PEDIDO. A arreglar o S solucionado. marcar como entregado.
        }

        private List<Pedido> BuscarPedidosParaEntregar(int numeroDNI)
        {
            {
                //aca estoy buscando en 2 listas, clientes y pedidos busco que coincidan

                List<Pedido> pedidosParaEntregar = pedidos.FindAll(pedido => pedido.GetNumeroDNI() == numeroDNI && pedido.GetEstado() == "R");
                return pedidosParaEntregar;
            }
        }
        public bool ClienteExiste(int numero)
        {
            Cliente Abuscar=new Cliente(numero, "","");
            return clientes.Contains(Abuscar);
        }

        private void IngresarReparacion()
        {
            int numeroPedidoMaximo = 0;
            int numeroDNI = 0;
            string problema = "";
            string solucion = "";
            double precio= 0;


            foreach (Pedido pedido in pedidos)
            {
                if (pedido.GetNumeroPedido() > numeroPedidoMaximo)
                {
                    numeroPedidoMaximo = pedido.GetNumeroPedido();
                }
            }
            int numeroReparacion = numeroPedidoMaximo;

            numeroDNI = validador.PedirInteger("Ingrese DNI", 0, 100);
            problema = validador.PedirStringNoVacio("Ingrese el problema a reparar");
            solucion = "";
            precio = validador.PedirDouble("Ingrese precio arreglo",0,10000);

            pedidos.Add(new Pedido(numeroPedidoMaximo,numeroDNI, problema,solucion,0,"R"));

        }

        private void obtenerPedidosParaEntrega()
        {
            throw new NotImplementedException();
        }

        

        private void cargaInicial()
        {
            clientes.Add(new Cliente(11111111, "Atila el huno", "1111-1111"));
            clientes.Add(new Cliente(35212132, "Cosme Fulanito", "3232-2323"));
            pedidos.Add(new Pedido(1, 11111111, "Sin pila", "Nueva pila", 300, "R"));
            pedidos.Add(new Pedido(2, 11111111, "Sin pila", "Nueva pila", 300, "A"));
            pedidos.Add(new Pedido(3, 35212132, "Sin pila", "Nueva pila", 300, "R"));
            pedidos.Add(new Pedido(4, 35212132, "Se rompio todo", "Armar a nuevo", 300, "R"));


        }

        private void ingresarCliente()
        {
            int numeroAcomparar = 0;
            string nombre = "";
            string telefono = "";

            numeroAcomparar = validador.PedirInteger("ingrese numero de documento", 1, 99999999);

            Cliente clienteExiste = clientes.Find(cliente => cliente.GetNumeroDNI() == numeroAcomparar);

            if (clienteExiste != null)
            {
                Console.WriteLine("El cliente ya existe, ,no puedo ser cargado otra vez");
            }

            else
            {
                nombre = validador.PedirStringNoVacio("Ingrese Nombre:");
                telefono = validador.PedirStringNoVacio("Ingrese Telefono:");



                //Lo instancio y lo agrego a la coleccion.
                Cliente nuevoCliente = new Cliente(numeroAcomparar, nombre, telefono);
                clientes.Add(nuevoCliente);

                Console.WriteLine($"El cliente {nuevoCliente} se agregó exitosamente.");
            }

        }



    }
}

