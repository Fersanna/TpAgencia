using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            bool edadNumerica; 

            Console.WriteLine(" Ingrese su edad:");
             edadNumerica = Int32.TryParse(Console.ReadLine(), out edad) ;
            
            if (edadNumerica)
                            {    Console.WriteLine("su edad es " + edad);
                if (edad > 0 && edad  < 140);
                
                else
                { Console.WriteLine("la edad debe ser menor a 140"); }

            }   
            else
            {
                Console.WriteLine("ingrese un dato correcto"); 
            }

            Console.ReadLine(); 
            } 
        }
    
    }

