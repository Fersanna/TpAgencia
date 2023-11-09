using System;

namespace Practica_Guia1_Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            String opcionMenu = "";

            while (opcionMenu != "4")
                do
                {
                    {
                        Console.WriteLine("Ingrese opcion:\n1. Definir valor"
            + "\n2.Visualizar valor actual"
            + "\n3. Realizar una operacion"
             + "\n4.Salir");

                        opcionMenu = Console.ReadLine();

                        if (opcionMenu != "3" || opcionMenu != "1" || opcionMenu != "2")
                        {
                            Console.WriteLine("debe ingresar un valor correcto");
                        }

                    }

                } while (opcionMenu != "3" || opcionMenu != "1" || opcionMenu != "2");
        }
    }
}
