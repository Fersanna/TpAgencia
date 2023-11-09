using System;

namespace Practica_guia_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombreEmpleado = new string[100];
            string[] direccionEmpleado = new string[100];
            string[] telefonoEmpleado = new string[100];
            string opcionMenu = "";
            string seguir = "";

            do
            {
                    

                opcionMenu = pedirStringnovacio("Elija una opcion\n" +
                    "A- Cargar un Empleado\n" +
                    "B- Buscar un Empleado\n" +
                    "C- Desea Salir ingrese S o N ");

                if (opcionMenu == "A")
                {
                    altaEmpleado(nombreEmpleado, direccionEmpleado, telefonoEmpleado);

                }
                else if (opcionMenu == "B")

                {
                    buscarEmpleado(nombreEmpleado);

                }
                else if (opcionMenu == "C")

                    seguir = pedirStringnovacio("Por favor ingrese S o N");   

                    if (seguir == "N")
                    {
                        Console.WriteLine("Usted a optado por salir");
                    }
                
                                
            } while (seguir == "S");

         

        }

        private static void buscarEmpleado(string[] nombreEmpleado)
        {
            throw new NotImplementedException();
        }

        private static void altaEmpleado(string[] nombreEmpleado, string[] direccionEmpleado, string[] telefonoEmpleado)
        {
           
            int fila = buscarFilaVacia(nombreEmpleado);

            if (fila == -1)

            {
                Console.WriteLine("No hay lugar para cargar");
            }

            else
            {
                nombreEmpleado[fila] = pedirStringnovacio("Por favor ingre el nombre del empleado");
                direccionEmpleado[fila] = pedirStringnovacio("Por favor ingrese la direccion");
                telefonoEmpleado[fila] = pedirStringnovacio("Por favor ingresa el telefon");
            }

        }

        private static int buscarFilaVacia(string[] nombreEmpleado)
        {
            int retorno = -1;

            for (int fila = 0; fila <= nombreEmpleado.GetLowerBound(0); fila++)

                if (nombreEmpleado[fila] == null  && retorno == -1)
             
                {
                    fila = retorno;
                
                }return (retorno);
            


        }

        private static string pedirStringnovacio(string mensaje)
        {
           
            
            string retrono = "";

            do
            {
                Console.WriteLine(mensaje);
                retrono = Console.ReadLine().ToUpper();

                if (retrono == "")
                {
                    Console.WriteLine("por favor ingrese algun dato no vacio");
                }
              
            } while (retrono == "");

            return (retrono);


        }
    }
}
