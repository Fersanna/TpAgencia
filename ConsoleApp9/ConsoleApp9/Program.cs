using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] especies = { "A", "B", "C" };
            int[] compras = new int[100];
            string opcionElegida = "";

            opcionElegida = pedirStringNoVacio("Por favor ingrese una opcion");
            Console.ReadLine(
                );

        }








        public static string pedirStringNoVacio(string mensaje)
        {
            string mensajes;
           
            do
            {
                

                Console.WriteLine("mensaje");
                mensajes = Console.ReadLine();
                if (mensajes == "")

                {
                    Console.WriteLine("Por favor ingrese algo");
                }
                else
                {
                    Console.WriteLine("Ingrese un dato valido");
                }

            } while (mensajes == "");
            return (mensajes);
            } 

    }
}
