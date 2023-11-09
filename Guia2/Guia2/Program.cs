using System;

namespace Guia2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int filas = 3;
            const string opcionAlta = "A";
            const string opcionCons = "C";
            const string opcionSal = "S";
            string opcionMenu = "";

            string nombreIngresar = "";
            string direccionIngresar = "";
            string telefonoIngresar = "";
            string[] nombres = new string[filas];
            string[] direcciones = new string[filas];
            string[] telefonos = new string[filas];
            string nombreBuscar = "";
            int posicion = 0;

            do
            {
                Console.WriteLine("Ingrese una opción:\n"
                        + opcionAlta + "-Alta Clientes\n"
                        + opcionCons + "-Consulta Clientes\n"
                        + opcionSal + "-Salir");

                opcionMenu = Console.ReadLine();

                if (opcionMenu == " ")
                {
                    Console.WriteLine("Debe ingresar una opcion valida");

                }

            } while (opcionMenu == "");

            switch (opcionMenu)
            {
                case opcionAlta:

                    if (filas > posicion)
                    {
                        Console.WriteLine("No hay mas espacio");

                    }
                    else

                    {
                        do
                        {
                            Console.WriteLine("ingrese nombre cliente: ");
                            nombreIngresar = Console.ReadLine();

                            if (nombreIngresar == "") ;
                            {
                                Console.WriteLine("debe ingresar un valor");
                            }

                        } while (nombreIngresar == "");

                        do
                        {
                            Console.WriteLine("ingrese direccion:");
                            direccionIngresar = Console.ReadLine();

                            if (direccionIngresar == "")
                            {
                                Console.WriteLine("debe ingrear un valor");
                            }

                        } while (direccionIngresar == "");

                        do
                        {
                            Console.WriteLine("ingrese el telefono");
                            telefonoIngresar = Console.ReadLine();

                            if (telefonoIngresar == "")
                            {
                                Console.WriteLine("debe ingresar un valor");

                            }
                        } while (telefonoIngresar == "");




                        nombres[posicion] = nombreIngresar;
                        direcciones[posicion] = direccionIngresar;
                        telefonos[posicion] = telefonoIngresar;
                        posicion = posicion + 1;
                    }
                    break;

                case opcionCons:

                    do
                    {


                        {
                            Console.WriteLine("Ingrese nombre cilenta a consultar: ");
                            nombreBuscar = Console.ReadLine();

                            if (nombreBuscar == "")
                                Console.WriteLine("Debe ingresar un nombre");

                            else
                            {
                                for (int contador = 0; contador < nombres.GetUpperBound(0); contador++) ;

                                if (nombres[contador] != null)



                                    nombreBuscar = nombres[contador]





                              }
                        }
                    } while (nombreBuscar == ""); 
            }


        }





    }
}

