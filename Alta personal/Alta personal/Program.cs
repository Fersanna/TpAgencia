using System;

namespace Alta_personal
{
    class Program
    {
        private const string Mensaje = "Ingrese Nombre del postulante";

        static void Main(string[] args)
        {
            string opcion;
            string nombrePostulandeAingresar;
            int edadPostulandeAingresar = 0;
            string legajoPostulandeAingresar = "";
            Postulantes[] postulante = new Postulantes[50];
 


            do
            {
                opcion = IngresarStringNoVacio("Por favor, Ingrese una Opcion\n A- Ingresar Personal\n B-Buscar Personal\n C- Salir").ToUpper();
                if (opcion == "A")
                {
                    IngresarNuevoPostulante(postulante);
                   

                }

                if (opcion == "B")
                {

                };

                
            } while (opcion != "C");
        }

        private static void IngresarNuevoPostulante(Postulantes[] postulante)
        {
            
            int filaVacia = BuscarFilaVaciaEnArreglo(postulante);
            postulante[filaVacia] = new Postulantes(IngresarStringNoVacio(Mensaje), IntegerEnRango("Por favor ingrese la edad"), ControlDuplicidad(postulante));
            
        }

        // quede aca, me toma el metodo Legajo y pincha (legajo esta private y no puedo usar las props autoimplementadas)
        private static int ControlDuplicidad(Postulantes [] postulante) 
        {

           int legajoAbuscar = IntegerEnRango("Por favor ingrese numero de legajo");

            for (int i = 0; i < postulante.GetUpperBound(0); i++)
            {
                if (postulante[i] != null)
                do
                {
                    if (postulante[i].Legajo == legajoAbuscar)
                    {
                        Console.WriteLine("El legajo ya esta cargado, por favor ingrese otro");
                    }
                } while ( postulante[i].Legajo == legajoAbuscar);


            }

            return legajoAbuscar;
        }

        private static int IntegerEnRango(string mensajeInt)
        {
            int retorno;

            do
            {
                Console.WriteLine(mensajeInt);
                if (!Int32.TryParse(Console.ReadLine(), out retorno))
                {
                    Console.WriteLine("debe ingresar un numero");
                }
                else if (retorno <= 0)
                {
                    Console.WriteLine("El numero debe ser mayor a cero");
                }

            } while (retorno <= 0);



            return retorno;

        }

        private static int BuscarFilaVaciaEnArreglo(Postulantes[] postulante)
        {
            int retorno = -1;

            for (int fila = 0; fila < postulante.GetUpperBound(0); fila++)
            {
                if(postulante [fila] == null && retorno==-1)
                {
                   retorno= fila;
                }
            }
        return retorno;
        }


        private static string IngresarStringNoVacio(string mensaje)
        {
            string ingreso;
            
            do
            {
                Console.WriteLine(mensaje);
                ingreso= Console.ReadLine().ToUpper();
                if (ingreso == "")
                {
                    Console.WriteLine("Debe ingresar algo");
                }

            } while (mensaje == "");

            return ingreso;
           
        }
    }
}
