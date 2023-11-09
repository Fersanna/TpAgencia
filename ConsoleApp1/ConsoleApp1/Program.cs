using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;

            Console.WriteLine("introduce la medida del radio");
            double radio = double.Parse(Console.ReadLine());

            double area = Math.Pow(radio, 2)*PI;

            Console.WriteLine(area);

            Console.Read(); 


        
        }
            


        }     



    }


