using System;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;

           

            Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");

            do
            {
                key = Console.ReadKey();
                Console.WriteLine("Ingrese algo");

                if ((key.Modifiers & ConsoleModifiers.Control)!=0) 

                        key.


            }
                    


        }
    }
}
