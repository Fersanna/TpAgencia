using System;

namespace EJERCICIO_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int ladoA;
            int ladoB;
            int ladoC;
            bool pudoConvertir;

            do {
                Console.WriteLine("Por favor ingresar el Lado A");

                pudoConvertir = Int32.TryParse(Console.ReadLine(), out ladoA);
            } while (pudoConvertir == false);

            do {
                Console.WriteLine("Por favor ingresar el Lado B");

                pudoConvertir = Int32.TryParse(Console.ReadLine(), out ladoB);
            } while (pudoConvertir == false);

            do
            {
                Console.WriteLine("Por favor ingresar el Lado C");

                pudoConvertir = Int32.TryParse(Console.ReadLine(), out ladoC);
            } while (pudoConvertir == false);




            if ((ladoA != ladoB) && (ladoB != ladoC) && (ladoA !=ladoC)) {

                Console.WriteLine("El triangulo es escaleno ");
            } else if ((ladoA == ladoB) || (ladoB == ladoC) || (ladoA ==ladoC))
            {
                Console.WriteLine("El triangulo es Isoseles");

            } else { Console.WriteLine("El triangulo es equilatero"); }

            Console.ReadKey();

        }
    }
}
