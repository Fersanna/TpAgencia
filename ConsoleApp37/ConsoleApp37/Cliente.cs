using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp37
{
    public class Cliente
    {
        private int numeroDocumento;
        private string nombre;
       
        private string telefono;

        public Cliente(int numeroDocumento, string nombre, string telefono)
        {
            this.nombre = nombre;
            this.numeroDocumento = numeroDocumento;
            this.telefono = telefono;
        }

        public override bool Equals(object obj)
        {
            return obj is Cliente cliente &&
                   numeroDocumento == cliente.numeroDocumento;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(numeroDocumento);
        }

        internal int GetNumeroDNI()
        {
            return numeroDocumento;
        }

        public override string ToString()
        {
            return ($"Nombre: {nombre} Numero de docuemnto: {numeroDocumento}Telefono: {telefono}  ").ToString();
        }
    }
}
