using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcionMenu = "";
            string[] nombreCliente = new string[100];
            string[] direccionCliente = new string[100];
            string[] telefonoCliente = new string[100];
                                 

            do

            {
                opcionMenu = ingresarStringNoVacio("Selecione una Opcion\n A-Cargar Cliente:\n B- Consultar Cliente:\n C- Salir ingresar :S o C para Continuar: " ).ToUpper();

                if (opcionMenu == "A")
                {
                     IngresarNombreCliente(nombreCliente, direccionCliente, telefonoCliente);
                     
                }else if (opcionMenu == "B")
                {
                    string nombreAbuscar= ingresarStringNoVacio("ingrese nombre cliente a buscar: ");

                    int filaCliente = buscarCliente(nombreCliente,nombreAbuscar);

                    if (filaCliente==-1)
                    {
                                              
                       Console.WriteLine(" No existe el dato buscado");
                    }
               
                else

                    {
                        Console.WriteLine("El nombre del cliente  es: " + nombreCliente[filaCliente]);
                        Console.WriteLine("La direccion:  " + direccionCliente[filaCliente]);
                        Console.WriteLine("Telefono:  " + nombreCliente[filaCliente]);
                }

                }   


            } while (opcionMenu != "S");

        }
        
         public static int buscarCliente(string[] nombreCliente, string nombreAbuscar)
       
        {
            int retorno = -1;

            for (int fila = 0; fila < nombreCliente.GetUpperBound(0); fila++) 
            {
                if (nombreCliente[fila] != null)
                {
                    if (nombreCliente[fila].Equals(nombreAbuscar) && retorno == -1)
                      
                        retorno = fila;
                }
               

            } return (retorno);

        }

        // Para ingresar el nombre primero debeo buscar lugar en el arreglo donde lo voy a guardar, de ahi se desprende otro metodo que busca lugar para guardar y arroja el numero de la fila donde
        // lo va a guardar o -1 

        private static void IngresarNombreCliente(string[] nombreCliente, string[] direccionCliente, string [] telefonoCliente)
        {
            int fila = buscarFilaVacia(nombreCliente);

            if (fila == -1)
            {
                Console.WriteLine("no hay lugar para realizar la carga solicitada");
            }
            else
            {
                nombreCliente[fila] = ingresarStringNoVacio("Por favor ingrese su nombre:");
                direccionCliente[fila] = ingresarStringNoVacio("Por favor ingrese su direccion");
                telefonoCliente[fila] = ingresarStringNoVacio("Por favor ingrese su telefono");
                
            }
        }
                private static int buscarFilaVacia(string[] nombreCliente)
        {
            int retorno= -1;
            
            for (int fila = 0; fila < nombreCliente.GetUpperBound(0); fila++)
            {
                if(fila==0 && retorno == -1)
                {
                    retorno = fila; 
                }
            }return (retorno);
        }

        private static string ingresarStringNoVacio(string mesaje)
        {
            string retorno = "";
            do
            {
                Console.WriteLine(mesaje);
                retorno = Console.ReadLine();
            
                if (retorno == "")
                {
                    Console.WriteLine("Por favor ingrese algun dato no vacio");
                }
             } while (retorno == "");
            return (retorno);
        } 



        }
    }
