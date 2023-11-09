namespace ConsoleApp38
{
    abstract class Maquina
    {
        private string codigo;
        private string nombre;

        protected Maquina(string codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        public override bool Equals(object obj)
        {
            return obj is Maquina maquina && 
                maquina.codigo == codigo;
        }

        public override string ToString()
        {
            return $"Codigo Maquina: {codigo}  Nombre Maquina: {nombre}";
        }

        public abstract bool PuedeFabricar(Orden orden);
        public abstract int MinutosParaFabricar(Orden orden);


    }
}