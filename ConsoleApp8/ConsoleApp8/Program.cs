using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)

        {
            bool EsNumerico = true;
            int Importeadevolver;
            string[] seguir = new string { "S", "N" };
            string consulta;
            string seguirCargando;
            string NoCargarMas;
           


            do
            {

                Console.WriteLine(" Pasame un numero!");

                EsNumerico = int.TryParse(Console.ReadLine(), out Importeadevolver);

                if (!EsNumerico)

                {
                    Importeadevolver = -1;
                    Console.WriteLine("debe ingresar un dato numerico");
                }

                else
                {
                    if (Importeadevolver < 0)
                    {
                        Console.WriteLine("El numero debe ser mayor a 0");
                    }
                }
            } while (Importeadevolver < 0);

            Console.WriteLine("Quiere ingresar otro numero\n para seguir S\n para parar N\n");
            seguir =Console.ReadLine();
            

            switch (seguir)
            { 

            case("S");

                    if (seguir = S)
                    {
                        Console.WriteLine("Ingrese otro numero");
                            }



        }  }
    }
}
