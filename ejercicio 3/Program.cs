using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            bool tipoDeDatoNumerico;
           int  promedio;

            do {
                Console.WriteLine("Por favor, ingrese un numero entre 0 y 10");

                tipoDeDatoNumerico = Int32.TryParse((Console.ReadLine()), out numero1);

                if (tipoDeDatoNumerico == true && (numero1 > 0 && numero1 <= 10) )
                { 
                    Console.WriteLine("Usted ingreso el primer numero," + numero1);
                }
                else Console.WriteLine("Debe ingresar un valor en rango");
            }
            while (numero1 < 0 || numero1 >10);


            do
            {
                Console.WriteLine("Por favor, ingrese un SEGUNDO numero entre 0 y 10");

                tipoDeDatoNumerico = Int32.TryParse((Console.ReadLine()), out numero2);

                if (tipoDeDatoNumerico == true && ( numero2 > 0 && numero2 <= 10))
                {
                    Console.WriteLine("Usted ingreso el primer numero," + numero2);
                }
                else Console.WriteLine("Debe ingresar un valor en rango");
            }
            while (numero2 < 0 || numero2 > 10);

            promedio = (numero1 + numero2) / 2;

            

            Console.WriteLine("el promedio de los 2 numero es " + promedio);

            Console.ReadKey();

        }

    }
}
