using System;



namespace Practica_Guia1_Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            String opcionMenu = "";
            int numero = 0;
            bool pudeConvertir;

            do
            {

                Console.WriteLine("Ingrese opcion:\n1. Definir valor"
                 + "\n2.Visualizar valor actual"
                 + "\n3. Realizar una operacion"
                 + "\n4.Salir");

                opcionMenu = Console.ReadLine();



                switch (opcionMenu)
                {
                    case "1":

                        do
                        {
                            do
                            {
                                Console.WriteLine("Ingrese un valor mayor a 0");
                                pudeConvertir = Int32.TryParse(Console.ReadLine(), out numero);
                                if (!pudeConvertir)
                                {
                                    Console.WriteLine("Por favor ingrese un numero");
                                }
                            } while (!pudeConvertir);

                            if (numero < 0)
                                Console.WriteLine("El numero debe ser mayor a cero");

                        } while (numero < 0);
                        break;
                    case "2":

                        Console.WriteLine("el valor actual de la variable es:  " + numero);

                        break;

                    case "3":

                        string opcion3 = "";
                        do
                        {

                            Console.WriteLine("Que operacion desea realizar?\n S- Suma \n R-Resta\n V-Volver al bucle principal ");
                            opcion3 = Console.ReadLine().ToUpper();

                            switch (opcion3)
                            {
                                case "S":
                                    {
                                        numero += 1;

                                        Console.WriteLine("el resultado de la operacion es " + numero);
                                        Console.ReadKey();

                                    }
                                    break;

                                case "R":
                                    {
                                        numero -= 1;

                                        Console.WriteLine("el resultado de la operacion es " + numero);
                                        Console.ReadKey();

                                    }
                                    break;

                                case "V":

                                    break;
                            }

                        } while (opcion3 != "V");
                        break;

                };
            } while (opcionMenu != "4");
        }
    }
}






