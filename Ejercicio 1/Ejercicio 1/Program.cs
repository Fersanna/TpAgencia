using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombresAlumnos= new string[100];
            int[] notaAlumno = new int[100];
            string seguir = "";
            string Alumno = "";

            do
            {
              Alumno= pedirStringnoVacio("Por favor ingrese el nombre del alumno:");


            } while (seguir == "S");

        }

        private static string pedirStringnoVacio(string mensaje)
        {
            int  retorno = "";


        }
    }
}
