using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25
{
    class Cancion
    {
        private string nombre;
        private string artista;
        private int anio;

        public Cancion(string nombre, string artista, int anio)
        {
            this.nombre = nombre;
            this.artista = artista;
            this.anio = anio;
        }

        public override bool Equals(object obj)
        {
            return obj is Cancion cancion &&
                   nombre == cancion.nombre;
                 
        }

        public override string ToString()
        {
            return $" nombre : {nombre}\t\t\t artista : {artista}\t\t anio : {anio}";
        }

        
    }
}
