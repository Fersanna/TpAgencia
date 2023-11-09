using System;
using System.Collections.Generic;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            AppCanciones app = new AppCanciones();
            app.Ejecutar();
        }
    }

    class AppCanciones
    {
        private List<Cancion> disponibles;
        private List<Cancion> reproduccion;
        private Validador validador;


        public AppCanciones()
        {
            disponibles = new List<Cancion>();
            reproduccion = new List<Cancion>();
            validador = new Validador();



            disponibles.Add(new Cancion("November rain", "Guns", 1990));
            disponibles.Add(new Cancion("Africa", "Toto", 1980));
            disponibles.Add(new Cancion("Jump", "Van Halen", 1991));
        }

        public void Ejecutar()
        {
            string opcion = "";
            do
            {
                opcion = validador.PedirStringNoVacio("1 - Agrega Cancion\n2 - Reproducir proxima cancion\n3 - Salir");


                if (opcion == "1")
                {
                    AgregarCancionAlaListadeReproduccion();
                }
                if (opcion == "2")
                {
                    reproducirProximaCancion();
                }


            } while (opcion != "3");
        }



        //ingresar cancion, listar canciones

        private void reproducirProximaCancion()
        {
            //Si no hay cancion, mensaje de que no hay
            //Muestra proxima cancion
            //Saca la cancion de la lista de repro y la manda a la lista de disponibles
            if (reproduccion.Count == 0)
            {
                Console.WriteLine("No hay nada en la lista de reproduccion");
            }
            else
            {
                Cancion aRemover = reproduccion[0];
                reproduccion.RemoveAt(0);
                Console.WriteLine("Reproduciendo " + aRemover);
                disponibles.Add(aRemover);
            }
        }

        private void AgregarCancionAlaListadeReproduccion()
        {
            
            Cancion aBuscar = null;
            string listadoDisponibles = ConvertirColeccionAString(disponibles);
            //Pedir cancion al usuario
            do
            {
                aBuscar = validador.PedirCancion("Ingrese el nombre de la cancion\n" + listadoDisponibles);

                if (!disponibles.Contains(aBuscar))
                {
                    Console.WriteLine("La cancion no esta disponible");
                }

            } while (!disponibles.Contains(aBuscar));

            if (disponibles.Contains(aBuscar))
            {
                disponibles.Remove(aBuscar);
                disponibles.Add(aBuscar);
                Console.WriteLine("se a agregado" + aBuscar + "a la lista de reproduccion");
            }



        }

        private string ConvertirColeccionAString(List<Cancion> canciones)
        {
            string retorno = "";

            foreach (Cancion cancion in canciones)
            {
                retorno = retorno + cancion.ToString();
            }

            return retorno;
        }

       
          

    }

}
