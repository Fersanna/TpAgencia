using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    internal class PersonasFormModel
    {
        public List<Persona> Personas = new List<Persona>()
        {
           new Persona { Nombre ="Maria", Apellido = "Perez", Telefono = "2855555", Documento =45556111 },
           new Persona { Nombre ="Mario", Apellido = "Sanna", Telefono = "2855555", Documento =45556111 },
           new Persona { Nombre ="Juan", Apellido = "Paz",    Telefono = "2855555", Documento =45556111 },
           new Persona { Nombre ="Alberto", Apellido = "Perez",Telefono = "2855555", Documento =45556111 },


        };

        internal String Borrar(Persona personaAborrar)
        {
            if (personaAborrar.Nombre == "Maria")
            {
                return "No se puede borrar a esta persona";
            }
            Personas.Remove(personaAborrar);

            return null;
        }

        internal string Modificar(Persona nuevosDatos, Persona personaSeleccionada)
        {
            personaSeleccionada.Documento = nuevosDatos.Documento;
            personaSeleccionada.Nombre = nuevosDatos.Nombre;
            personaSeleccionada.Apellido= nuevosDatos.Apellido;
            personaSeleccionada.Telefono= nuevosDatos.Telefono;

            return null;
        }
    }
}
