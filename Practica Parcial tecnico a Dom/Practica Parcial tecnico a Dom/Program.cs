using System;

namespace Practica_Parcial_tecnico_a_Dom
{
    class Program
    {
        public const string EstPend = "P";
        public const string EstVisi = "V";
        public const long NumMin = 1;
        public const long NumMax = 999999;
        public const int cantidad = 100;

        static void Main(string[] args)
        {


            long[] numeros = new long[cantidad];
            string[] domicilio = new string[cantidad];  
            string[] nombreClient=new string[cantidad];
            string[] sintoma=new string[cantidad];
            string[] causaSolucion=new string[cantidad];
            string[] estado = new string[cantidad];
            string opcion = "";
            int pendientes = 0;

            //2.	Luego NO presentará un menú, sino que llamará directamente al método CompletarVisita de la clase ListaVisitas.
            // omo sAllí la aplicación armará una lista con las visitas pendientes(ce ve en la próxima imagen). Si no hubiera ninguna mostrará el mensaje “No hay visitas pendientes”. Si las hubiera mostrará la lista mientras solicita el número de visita a registrar

            //3.Una vez que el técnico ingresa el número de visita deseada, la aplicación buscará la visita por su número.
            // 4.Si no existen visitas con ese número, la aplicación informarála situación al usuario y salteará los pasos siguientes hasta el número 9, donde se consulta al usuario si quiere continuar en la aplicación.
            // 5.Si existe una visita con ese número, pero la misma no está pendiente, la aplicación informará la situación al usuario y salteará los pasos siguientes hastael número 9, donde se consulta al usuario si quiere continuar en la aplicación.
            //6.Satisfechas estas validaciones, la aplicación solicitará confirmación para proceder o no a completar la visita seleccionada(“S” o “N”):
            //7 Si responde afirmativamente, la aplicación solicitará la causa y solución, registrará este dato en la visita junto con el cambio de estado, y mostrará el mensaje “Completó satisfactoriamente la visita” y salteará los pasos siguientes hasta el número 9, donde se consulta al usuario si quiere continuar en la aplicación.
            //8.Si responde negativamente, la aplicación mostrará el mensaje “Eligió NO completar esta visita”, y continuará con el paso siguiente.
            //9.(NO DESARROLLAR)Finalmente se consultará al usuario si desea continuar(“S” o “N”). Si desea continuar, la aplicación vuelve al punto 2.Si desea no continuar, la aplicación guardará las visitas pendientes las visitas pendientes del archivo “visitas_pend.csv”, las visitas completadas en el archivo “visitas_visi.csv” y se cerrará.

            cargaInicial(numeros, domicilio, nombreClient, sintoma, causaSolucion, estado);
            
            do
            {
                string listaVisitasPendientes = listarVisitasPendientes(numeros, domicilio, nombreClient, sintoma, estado);
                long visitaARegistrar;
             
                if (listaVisitasPendientes == "")
                {
                    Console.WriteLine("No hay visitas pendientes");
                }else
                {
                    visitaARegistrar = PeridYvalidarlong("ingrese numero de visita", 0, 9999);

                    int indice = buscarLongEnArreglo(numeros, visitaARegistrar);

                    if (indice == -1)
                    {
                        Console.WriteLine("No existen visitas con el numero ingresado"); 
                    } else
                    {
                        if (estado[indice] != EstPend)
                        {
                            Console.WriteLine("La visita no esta pendiente");
                        }
                        else
                        {
                            string confirmacion = PedirSoN("Desea completar la visita ? (S / N)");

                            if (confirmacion=="S")
                            {
                                causaSolucion[indice] = pedirStringNoVacio("indique la causa");
                                estado[indice] = EstVisi;
                            }
                            else
                            {
                                Console.WriteLine("Eligió NO completar esta visita");
                            }
                        }
                    }

                }

            } while (opcion == "S");

        }

        private static string pedirStringNoVacio(string mensaje)
        {
            string retorno = "";

            do
            {
                Console.WriteLine(mensaje);

                if (mensaje == "")
                {
                    Console.WriteLine("debe ingresar un valor");
                }

            } while (mensaje == "");

            return retorno;
        }

        private static string PedirSoN (string mensaje)
        {
            string retorno = "";

            do
            {
                retorno = pedirStringNoVacio("Ingrese S para continua N para terminar");

                if (retorno != "N" && retorno != "S")
                {
                    Console.WriteLine("Debe ingresar S o N");

                }
            } while (retorno != "N" && retorno != "S");

            return retorno;



        }

        private static int buscarLongEnArreglo(long[] numeros, long visitaARegistrar)
        {
            int retorno = -1;

            for (int fila = 0; fila < numeros.GetUpperBound(0) && retorno!=-1; fila++)
            {
                if (numeros[fila] == visitaARegistrar)
                {
                    retorno = fila;
                }
            }

            return retorno;
        } 

        private static long PeridYvalidarlong(string mensaje, int minimo, int maximo)
        {
            long retorno;

            do
            {
                Console.WriteLine(mensaje);

                if (!long.TryParse(Console.ReadLine(), out retorno))
                {
                    Console.WriteLine("Debe ingresar un valor numerico");

                }
                else if (retorno < minimo || retorno > maximo)
                {

                    Console.WriteLine("el numero debe estar entre" + minimo + " y " + maximo);
                }
            }

            while (retorno < minimo || retorno > maximo);
            
            return retorno;
        }

        private static string listarVisitasPendientes(long[] numeros, string[] domicilio, string[] nombreClient, string[] sintoma, string[] estado)
        {
            string retorno = "";

            for (int fila = 0; fila < estado.GetLowerBound(0); fila++)
            {
                if (estado[fila] == EstPend)
                {
                    retorno = retorno + numeros[fila] + domicilio[fila] + nombreClient[fila] + sintoma[fila];
                } 

              

            }
            return retorno;
        }

        private static void buscarVisitasPendientes(string[] estado, long[] numeros)
        {
            int retorno = -1;

            for (int fila = 0; fila < estado.GetUpperBound(0) && retorno !=-1; fila++)
            {
                if (estado[fila] == EstPend)
                {
                    retorno= fila;
                }

                retorno = fila;
            }
        }

        private static string armarListasVisitas(long[] numeros, string[] estado, string[] sintoma, string [] domicilio)
        {
            string retorno = "";

            for (int fila = 0; fila < estado.GetUpperBound(0); fila++)
            {
                if (estado[fila] == EstPend)
                {
                    retorno = retorno + numeros[fila] + domicilio[fila] + sintoma[fila] + estado[fila];  
                }

                
            }

            return retorno;
        }

        private static void cargaInicial(long[] numeros, string[] domicilio, string[] nombreClient, string[] sintoma, string[] causaSolucion, string[] estado)
        {
            numeros[0] = 401;
            domicilio[0] = "Helguera 4770";
            nombreClient[0] = "Juan Topo";
            sintoma[0] = "No enfria nada";
            causaSolucion[0] = "motor";
            estado[0] = EstPend;
            numeros[1] = 402;
            domicilio[1] = "Cortina 1840";
            nombreClient[1] = "Juan Manco";
            sintoma[1] = "No enfria nada";
            causaSolucion[1] = "bobina";
            estado[1] = EstPend;
        }
    }
}

