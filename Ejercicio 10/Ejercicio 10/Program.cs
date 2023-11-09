using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {

            string registro;
            int nota;
            bool NopudeConvertir;
            String continuar = "";
            int notaMaxima = -1;
            int notaMinima = 11;
            string registroNotaMaxima = "";
            string registroNotaMinima = "";


            do
            {

                Console.WriteLine("ingrese su registro");
                registro = Console.ReadLine();
                Console.WriteLine("ustede ingreso el registro  " + registro);
                do
                {
                    Console.WriteLine("Nota");
                    NopudeConvertir = !Int32.TryParse(Console.ReadLine(), out nota);



                    if ((nota < 0 || nota > 10) || NopudeConvertir)
                    {

                        Console.WriteLine("Ingrese un dato valido");
                    }

                } while ((nota < 0 || nota > 10) || NopudeConvertir);

                if (nota >= 7)
                {
                    Console.WriteLine("Promocionado");

                }
                if (nota < 7 && nota >= 4)
                {
                    Console.WriteLine("Regularizado");
                }
                if (nota < 4)
                {
                    Console.WriteLine("Reprobado");

                }

                if (nota > notaMaxima)
                {
                    notaMaxima = nota;
                    registroNotaMaxima = registro;


                }

                if (notaMinima < nota)
                {
                    notaMinima = nota;
                    registroNotaMinima = registro;

                }

                do
                {
                    Console.WriteLine("desea continuar? S o N");
                    continuar = Console.ReadLine().ToUpper();

                } while (continuar == " ");

                if (continuar == "N")
                {
                    Console.WriteLine("la nota maxima es " + notaMaxima + "del registro " + registroNotaMaxima);
                    Console.WriteLine("la nota minima es " + notaMinima + "del registro " + registroNotaMinima );

                }

            } while (continuar == "S");















            Console.ReadKey();
        }
    }
}
