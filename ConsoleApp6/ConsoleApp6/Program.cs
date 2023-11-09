using System;


namespace Clase 3  
    

    class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        int importeFactura;
        int total = 0;
        string seguir = "";

        do
        {

            //Pedir y validar importeFactura
            do
            {
                //Mostrar mensaje al usuario solicitando dato
                Console.WriteLine("Ingrese un numero mayor a 0");
                //Si el dato no es un numero
                if (!Int32.TryParse(Console.ReadLine(), out importeFactura))
                {
                    //Fuerzo el valor para que este fuera de rangos validos
                    importeFactura = -1;
                    //Imprimir el mensaje de numero no valido
                    Console.WriteLine("No ingreso un dato numerico valido");
                }
                //Si el dato es numerico
                else
                {
                    //Si el dato no cumple la condicion
                    if (importeFactura <= 0)
                    {
                        //Mostrar mensaje de numero que no cumple la condicion
                        Console.WriteLine("El numero debe ser positivo. O sea mayor a 0");
                    }
                }
                //Si no cumple la condicion, repetir
            } while (importeFactura <= 0);

            total = total + importeFactura;
            contador = contador + 1;

            do
            {
                Console.WriteLine("Desea continuar? (S/N)");
                seguir = Console.ReadLine().ToUpper();
                if (!seguir.Equals("S") && !seguir.Equals("N"))
                {
                    Console.WriteLine("Debe ingresar S o N");
                }
            } while (!seguir.Equals("S") && !seguir.Equals("N"));

        } while (seguir.Equals("S"));

        Console.WriteLine("Importe=" + total);
        Console.WriteLine("Promedio=" + total / contador);
        Console.ReadLine();
    } } }
















             


 

