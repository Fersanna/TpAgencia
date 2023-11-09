namespace TPagenciadeviajes
{
    internal class VuelosModel
    {
        private const int V = 2022 - 11;
        public List<Vuelos> vuelosDiponibles = new List<Vuelos>()
        {
             new Vuelos {Asiento ="15",Origen ="Paris", Destino ="Dubai", Clase ="Business", Pasajeros ="Adulto", FechaSalida =new DateTime(2023, 01, 01),FechaLlegada = new DateTime(2023, 11, 18), Precio= "100", Codigo ="AA11"},
            new Vuelos {Asiento ="18",Origen ="Paris", Destino ="Tokio", Clase ="First", Pasajeros ="Adulto", FechaSalida = new DateTime(2023, 01, 01),FechaLlegada =new DateTime(2023, 02, 01), Precio= "100", Codigo ="AA11"},
              new Vuelos {Asiento ="19",Origen ="Roma", Destino ="Roma", Clase ="Economy", Pasajeros ="Infante", FechaSalida = new DateTime(2023, 01, 10), FechaLlegada =new DateTime(2023, 01, 15), Precio= "100", Codigo ="AA11"},
            new Vuelos {Asiento ="30",Origen ="Buenos Aires", Destino ="Madrid", Clase ="Business", Pasajeros ="Menor", FechaSalida = new DateTime(2023, 02, 10),FechaLlegada =new DateTime(2023, 03,10), Precio= "115", Codigo ="AA11"},
              new Vuelos {Asiento ="33",Origen ="Buenos Aires", Destino ="Madrid", Clase ="Business", Pasajeros ="Menor", FechaSalida = new DateTime(2023, 11, 09),FechaLlegada =new DateTime(2023, 11,09), Precio= "500", Codigo ="AA25"},
        };
    }
}