using System;

namespace Ejercicio_Array
{
    class Program
    {
        static void Main(string[] args)


        {
            string opcionMenu = "";
            const int fila = 3;
            string[] nombre = new string[fila]; 
            string [] direccion = new string [fila];
            string [] telefono = new string [fila];
            const string opcionAlta = "A";
            const string opcionCons = "C";
            const string opcionSal = "S";
            int posicion = 0;
            string nombreIngresar = "";
            string direccionIngresar = "";
            string nombreBuscar = "";
            string telefonoIngresar = "";

            do
            {
                    Console.WriteLine("Elegir opcion\n A - Alta Cliente\n B- Consula Cliente\n C- Salir   ");
                    opcionMenu = Console.ReadLine().ToUpper();

                    if (opcionMenu == "")
                    {
                        Console.WriteLine("Debe ingresar un valor");
                    }

                } while (opcionMenu == "");
            do
            {
                if (opcionMenu != "A" && opcionMenu != "B" && opcionMenu != "C")
                {
                    Console.WriteLine("Por favor ingresar un dato valido");
                    opcionMenu = Console.ReadLine().ToUpper();



                }
            } while (opcionMenu != "A" && opcionMenu != "B" && opcionMenu != "C");

            Console.WriteLine(opcionMenu);

            switch (opcionMenu)
            {
                case opcionAlta:

                    if (fila <= posicion)
                    {
                        Console.WriteLine("No existe mas espacio para cargar nombres");
                    }
                    else
                    {
                        do
                        {
                            {
                                Console.WriteLine("Nombre:");
                                nombreIngresar = Console.ReadLine();
                            }
                            if (nombreIngresar == "")
                            {
                                Console.WriteLine("ingrese un dato");
                            }

                        } while (nombreIngresar == "");


                        nombre[posicion] = nombreIngresar;



                        do
                        {
                            {
                                Console.WriteLine("Direccion:");
                                nombreIngresar = Console.ReadLine();
                            }
                            if (direccionIngresar == "")
                            {
                                Console.WriteLine("ingrese un dato");
                            }

                        } while (direccionIngresar == "");



                        direccion[posicion] = direccionIngresar;

                        posicion = posicion + 1;



                    }
                    break;

                case opcionCons:
                    {
                        do
                        {
                            Console.WriteLine("Ingrese nombre a buscar");
                            if (nombreBuscar == "")
                            {
                                Console.WriteLine("Por favor ingrese un dato");
                            }

                        } while (nombreBuscar == "");

                        
                            posicion = -1;

                            do
                            {
                                posicion = posicion + 1;
                            } while
                          (nombre[posicion] != nombreBuscar && nombre[posicion] != null && posicion < fila);

                            if (nombre[posicion] == nombreBuscar)
                            {
                                Console.WriteLine("el nombre es " + nombre[posicion]);
                                Console.WriteLine("La direccion es " + direccion[posicion]);

                            }

                        } 
                    break;

                case opcionSal:
                    {

                    }break;
            }

            Console.ReadKey();
        }
    }
}
