namespace ConsoleApp36
{
     class InicioTrabajo : Evento
    {
        string numeroOrden;
        int cantidadesPlanificadas;

      public InicioTrabajo(string fecha, string numero, int cantidad) : base(fecha)
        {
            this .numeroOrden = numero; 
            this.cantidadesPlanificadas= cantidad;  
        }

        public override bool PuedeAgregarEvento(Evento evento)
        {
            throw new System.NotImplementedException();
        }
    }
}