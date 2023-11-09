using System;

class Program
{
    static void Main(string[] args)
    {
        int maxAlumnos = 100;
        int cantidadAlumnos = 0;
        int[] registro = new int[maxAlumnos];
        string[] nombre = new string[maxAlumnos];
        float[] notaPrimerParcial = new float[maxAlumnos];

        int opcion;
        do
        {
            Console.WriteLine("1. Ingresar un alumno");
            Console.WriteLine("2. Ingresar nota de un alumno");
            Console.WriteLine("3. Listar alumnos desaprobados");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese la opción deseada: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (cantidadAlumnos < maxAlumnos)
                    {
                        Console.Write("Ingrese el registro del alumno: ");
                        int reg = int.Parse(Console.ReadLine());
                        if (BuscarAlumno(registro, cantidadAlumnos, reg) == -1)
                        {
                            Console.Write("Ingrese el nombre del alumno: ");
                            string nom = Console.ReadLine();
                            registro[cantidadAlumnos] = reg;
                            nombre[cantidadAlumnos] = nom;
                            cantidadAlumnos++;
                            Console.WriteLine("Alumno agregado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("El registro ingresado ya existe.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se pueden agregar más alumnos.");
                    }
                    break;
                case 2:
                    Console.Write("Ingrese el registro del alumno: ");
                    int regBusqueda = int.Parse(Console.ReadLine());
                    int indice = BuscarAlumno(registro, cantidadAlumnos, regBusqueda);
                    if (indice == -1)
                    {
                        Console.WriteLine("No se encontró el alumno con el registro ingresado.");
                    }
                    else
                    {
                        Console.Write($"Ingrese la nueva nota de {nombre[indice]}: ");
                        float nuevaNota = float.Parse(Console.ReadLine());
                        notaPrimerParcial[indice] = nuevaNota;
                        Console.WriteLine("Nota actualizada con éxito.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Alumnos desaprobados:");
                    for (int i = 0; i < cantidadAlumnos; i++)
                    {
                        if (notaPrimerParcial[i] < 4)
                        {
                            Console.WriteLine($"{nombre[i]} - Nota: {notaPrimerParcial[i]}");
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Adiós.");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
            Console.WriteLine();
        } while (opcion != 4);
    }

    static int BuscarAlumno(int[] registro, int cantidadAlumnos, int regBusqueda)
    {
        for (int i = 0; i < cantidadAlumnos; i++)
        {
            if (registro[i] == regBusqueda)
            {
                return i;
            }
        }
        return -1;
    }
}
