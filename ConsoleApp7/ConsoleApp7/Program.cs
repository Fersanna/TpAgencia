using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int promedio;


            {
                Console.WriteLine("ingrese el primer numero ");
                if (!Int32.TryParse(Console.ReadLine(), out numero1))

                    numero1 = -1;

                if (numero1 <= 0 || numero1 >= 10)

                {
                    Console.WriteLine("Debe ingresar un numero entre 0 y 10");


                }
                else
                
                    Console.WriteLine("ingrese otro numero");
                    if (!Int32.TryParse(Console.ReadLine(), out numero2)) ;

                    numero2 = -1;
                


                    if (numero2 <= 10 || numero2 >= 10)
                    
                        Console.WriteLine("Debe ingresar un numero entre 0 y 10");


                Console.ReadLine();

            }
            }     
               

        }




    }
}
