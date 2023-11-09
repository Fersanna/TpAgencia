using System;
using System.Collections.Generic;
using System.Text;

namespace Alta_personal
{
    class Postulantes

    {
       

        public Postulantes(string nombre, int edad, int legajo)
        {
            Nombre = nombre;
            Edad = edad;
            Legajo = legajo;
        }
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public int Legajo { get; set; }  
        

        
    }
}
