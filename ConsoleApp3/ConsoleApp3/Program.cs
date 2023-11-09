using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)

            
        {
            String Nombre;
            String direccion; 
          

            Console.WriteLine("Ingrese su nombre:");
            Nombre = Console.ReadLine();

            if (Nombre == "")
            { Console.WriteLine("Por favor, Debe ingresar su nombre"); }

            do { while (Nombre! = String)};


            Console.WriteLine("Ingrese su direccion");
            direccion = Console.ReadLine();

            if (direccion == "");

            { Console.WriteLine("Debe ingresar una direccion"); }

         
            Console.WriteLine(" Su nombre es "  +   Nombre + " Y vive en " +  direccion);

           

            
           

            Console.WriteLine(" Presione una tecla para salir: ");
            Console.ReadKey();
           
        }
    }
}
