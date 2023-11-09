using System;

namespace Practica_Arrelgos_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int [10];
            String[] nombreAlumnos = new string[10];
            string nombreIngresado = "";
            int notaIngresada = -1;
            string seguir = "";

            do
            {
                do
                {
                    Console.WriteLine("Nombre Alumno:");
                    nombreIngresado = Console.ReadLine();
                    if (nombreIngresado == "")
                    {
                        Console.WriteLine("No me dejes vacio");
                    }

                } while (nombreIngresado == "");


                for (int i = 0; i < nombreAlumnos.GetUpperBound(0); i++)

                    if (nombreAlumnos[i] == null)

                        nombreAlumnos[i] = nombreIngresado;


                do
                {
                    Console.WriteLine("Nota:");
                    if (!Int32.TryParse(Console.ReadLine(), out notaIngresada))
                    {
                        Console.WriteLine("Ingrese un numero");
                    }
                    else
                         if (notaIngresada > 10 || notaIngresada <= 0)

                    {
                        Console.WriteLine("Ingrese una nota en el rango valido");
                    }

                } while (notaIngresada == -1 || (notaIngresada > 10 || notaIngresada <= 0));



                for (int i = 0; i < notas.GetUpperBound(0); i++)

                  

                    if (notas[i] == 0)
                   
                        notas[i] = notaIngresada;

                                               
               
                        Console.WriteLine("Desesa seguir? S(si) oN (no)");
                        seguir = Console.ReadLine().ToUpper();



                    


             
               
                
            } while (seguir == "S");

           

            foreach (int i in notas)
            {
                Console.WriteLine(i + "");
            }

            Console.ReadKey();


        }


    }
    
}
