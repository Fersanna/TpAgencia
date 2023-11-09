using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alumnosCurso = new string[100];
            int[] notasAlumnos = new int[100];
            string opcionMenu = "";

            do
            {
                opcionMenu = PedirStringNoVacio("Por favor ingrese\n A - Cargar Alumno y sus notas\n B - Consultar Aprobados\n C - Salir").ToUpper();

            
                if (opcionMenu == "A")
                {
                    cargarAlumnosCurso(alumnosCurso, notasAlumnos);

                }
                else if (opcionMenu == "B")
                {
                    mostrarAlumnosAprobados(alumnosCurso, notasAlumnos);
                }
                else
                {
                    Console.WriteLine("Ingrese una opcion valida");
                }
            } while (opcionMenu != "C");
        }

        private static void mostrarAlumnosAprobados(string[] alumnosCurso, int[] notasAlumnos)
        {
            Console.WriteLine("Los alumanos aprobados son: ");


            for (int fila = 0; fila < notasAlumnos.GetUpperBound(0); fila++)

            if (notasAlumnos[fila] >= 6)
                {

                    Console.WriteLine(alumnosCurso[fila]);
                    Console.WriteLine(notasAlumnos[fila]);
                }
                    
        }

        private static void cargarAlumnosCurso(string[] alumnosCurso, int[] notasAlumnos)
        {
            int fila = BuscarFilaVacia(alumnosCurso);
         
            if (fila == -1)
            {
                Console.WriteLine("no hay mas lugar para cargar alumnos");

            } else 
                         
            {
                alumnosCurso[fila] = PedirStringNoVacio("Por favor ingrese el nombre del alumno");
               notasAlumnos[fila] = PedirIntEnRango("por favor ingrese una nota", 0, 10);
                
            }

        }

        private static int PedirIntEnRango(string mensaje, int minimo, int maximo)
        {
            int retorno = 0;

            do
            {
                Console.WriteLine(mensaje);
                if (!Int32.TryParse(Console.ReadLine(), out retorno))
                {
                    retorno = minimo - 1;
                    Console.WriteLine("Ingrese un numero por favor");
                }
                if (retorno < minimo || retorno > maximo)
                {
                    Console.WriteLine("El numero debe estar entre " + minimo + " y " + maximo);
                }
            } while (retorno < minimo || retorno > maximo);

            return (retorno);

            //int numeroRecibido;
            //bool pudeConvertir;
            //do
            //{
            //    Console.WriteLine("ingrese un numero entre" + minimo + "y" + maximo);
            //    pudeConvertir = Int32.TryParse(Console.ReadLine(), out numeroRecibido);

            //    if (pudeConvertir)
            //    {
            //        if (numeroRecibido < minimo || numeroRecibido > maximo)
            //        {
            //            Console.WriteLine("debe estar dentro del rango determinado");

            //        } 
            //    }
            //    else
            //    {
            //        Console.WriteLine("debe ser un dato numerico");
            //        numeroRecibido = minimo - 1;
            //    }
            //} while (numeroRecibido < minimo || numeroRecibido > maximo);
            //return (numeroRecibido);
        }

        private static int BuscarFilaVacia(string[] alumnosCurso)
        {
            int retorno = -1;

            for (int fila = 0; fila <= alumnosCurso.GetUpperBound(0); fila++)

                if (alumnosCurso[fila] == null && retorno == -1)
                {
                    retorno = fila;
                }
            return (retorno);
            
        }

        public static string PedirStringNoVacio(string mensaje)
        {
            string retorno="";

            do
            {
                {
                    Console.WriteLine(mensaje);
                    retorno = Console.ReadLine();
                }
                if (retorno == "")
                {
                    Console.WriteLine("por favor ingrese un dato no vacio");
            } 
            } while (retorno == "");
            return (retorno);



        }
    }
}
