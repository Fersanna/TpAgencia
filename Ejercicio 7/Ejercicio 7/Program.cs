using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // debo multiplicar por 10 todos los numero que den por resultado un numero menor a 100. por ende, son 1,2,3,4,5,6
            //el 10 lo resuelvo con una constante
            // el 100 es una condicion, debe ser menor a 100. Parte del if
            //y del uno al diez, un contador (puede ir buscando en un arreglo o con una variable.

            const int multilplo = 10;
            int[] resultado = new int[100];

            for (int contador = 0; contador < 100; contador++)

            {
                resultado[contador] = contador;

                if (multilplo * resultado[contador] < 100)
                    do
                    {
                        { 
                        Console.WriteLine(" los multiplos son " + resultado[contador]);

                    }

                } while (resultado[contador] > 100);

                Console.ReadLine();
                



               


            }
        }
    }
}
