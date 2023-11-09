using System;
using System.Collections.Generic;

namespace ConsoleApp36
{
    internal class Maquina
    {
        string codigo;
        string nombre;
        string sector;
        string estado;
        List<Evento> eventos;
        Validador validador;

        public Maquina(string codigo, string nombre, string estado)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.estado = estado;
            this.sector = sector;
            eventos = new List<Evento>();
            validador = new Validador();

            eventos.Add(new InicioTrabajo("11/01/22", "11", 5));
        }

        public override bool Equals(object obj)
        {
            return obj is Maquina maquina &&
                   codigo == maquina.codigo;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(codigo, nombre);
        }

        public List<String> GetSector()
        {
            List<string> sector = new List<String>() { "Urdido", "Tejeduria", "Terminacion" };

            return sector;
        }

        public override string ToString()
        {
            return $"Codigo: {codigo} - Nombre: {nombre} - estado: {estado}";
        }

        public void SetSector(string sectornuevo)
        {
            sector = sectornuevo;
        }

        public string StringDeSectores()
        {
            List<string> sector = new List<String>() { "A-Urdido\n", "B-Tejeduria\n", "C-Terminacion\n" };
            string sectores = "";

            foreach (string s in sector)
            {
                sectores += s;
            }

            return sectores;

        }

        public bool EstaDisponible()
        {
            return estado == "D";
        }

        internal string GetCodigo()
        {
            return codigo;
        }

        public string GetEstado()
        {
            string estado = "";

            if (EstaDisponible())
            {
                estado = "Disponible";

            }
            else
            {
                estado = "No Disponible";
            }

            return estado.ToString();
        }
        //intendo hacer la logica para agregar eventos a la maquina


       public bool SePuedeAgregar(Evento evento)
        {
            return (EstaDisponible() && evento is InicioTrabajo && evento is Preparacion);
        }

        public List<String> PuedeAgregarOperacion(Evento evento)
        {
            List<String> retorno = new List<String>();

            if (!(EstaDisponible() && evento is InicioTrabajo && evento is Preparacion))
            {
                retorno.Add("La evento debe ser Inicio de trabajo o preparacion");
            }
            else
                retorno.Add("");

            return retorno;
        }


        public void AgregarEvento(Evento nuevoEvento)
        {
            if (EstaDisponible() && SePuedeAgregar(nuevoEvento))
            {
                eventos.Add(nuevoEvento);
                Console.WriteLine("Evento agregado correctamente.");
            }
            else
            {
                Console.WriteLine("No se pudo agregar el evento a la máquina.");
            }
        }


    }
}