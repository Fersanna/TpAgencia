using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombrePostulante = new string[50];
            string[] direccionPostulante = new string[50];
            string[] puestoPretendido = new string[50];
            string opcion = "";
            string confirmaSalir = "";

            do
            {

                opcion = pedirStringNoVacio("Debe ingresar una opcion\n"+ 
                    "1. Ingresar postulante\n" +
                    "2. Buscar postulante\n"+
                     "3 Desea Salir:");

                if (opcion == "1")
                {
                    IngresoPostulante( nombrePostulante, direccionPostulante, puestoPretendido) ;
                                          
                                        
                }
                else if (opcion == "2")
                {
                    buscarPostulante( nombrePostulante,  direccionPostulante, puestoPretendido);
                }
                else if (opcion == "3")

                {
                    confirmaSalir = pedirSoN("Ingrese S para salir y N para quedarse"); 
                }
                else
                {
                    Console.WriteLine("Debe ingresar alguna de las opciones");

                }
                
            } while (!(opcion =="3") && confirmaSalir != "S"); 

        }

        private static void buscarPostulante(string[] nombrePostulante, string[] direccionPostulante, string[] puestoPretendido) //Metodo 4
        {
            string nombreAbuscar = pedirStringNoVacio("Ingrese nombre postulante a buscar");
            int filaPostulante = buscarStringenArreglo(nombrePostulante, nombreAbuscar);
            if (filaPostulante==-1)
            {
                Console.WriteLine(" El postulante no existe");

            }
            else
            {
                Console.WriteLine("nombre completo" + nombrePostulante[filaPostulante]);
                Console.WriteLine("direccion " + direccionPostulante[filaPostulante]);
                Console.WriteLine("Puesto pretendido " + puestoPretendido[filaPostulante]);

            }
        }

        private static int buscarStringenArreglo(string[] nombrePostulante, string nombreAbuscar) //Metodo 5 (terminarlo) y armar Metodo 6
        {
            
        }

        private static void IngresoPostulante( string[] nombrePostulante,  string[] direccionPostulante, string[] puestoPretendido)  //Metodo 2
        {
            int fila= obtenerPrimerFilaVacia (nombrePostulante);

            if (fila == -1)

            {
                Console.WriteLine("No hay filas vacias, no se puede ingresar postulante");
            }

            else
            {
                nombrePostulante[fila] = pedirStringNoVacio("Ingrese el nombre del postulante"); 
                direccionPostulante[fila] = pedirStringNoVacio("Ingrese Direccion");
                puestoPretendido[fila] = pedirStringNoVacio("Ingresar puesto pretendido");
            }
            
        }

        private static int obtenerPrimerFilaVacia(string[] nombrePostulante) //Metodo 3
        {
            int retorno = -1;
            for (int fila = 0; fila >= nombrePostulante.GetUpperBound(0); fila++) 
            {
                if (nombrePostulante[fila] == null && retorno == -1) //si la fila aun esta vacia y retorno aun es -1
                {
                    fila = retorno; //aca le indico que la fila va a valer -1
                
                }
            }return (retorno); // si no encontro vacia aca devuelve el numero (Devuelve -1 o una fila valida)
        }
               
                                   
        
        private static string pedirStringNoVacio(string mensaje)// para validar que se ingrese algun  dato - Metodo 1-
        {
            string retorno = "";
            do
            {
                {
                    Console.WriteLine(mensaje);
                        }
                retorno = Console.ReadLine();

                if (retorno == "")
                {
                    Console.WriteLine("Debe ingresar un valor no vacio");
                        }

            } while (retorno == "");

            return (retorno);
        }
      
    }
}
